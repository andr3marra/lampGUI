using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using SuperSocket.ClientEngine;
using System.Threading;
using WebSocket4Net;

namespace lampGUI
{
    public class LampClient
    {
        private static HttpClient httpClient;
        private AppConfig _appConfig;
        public LampClient(AppConfig appConfig)
        {
            _appConfig = appConfig;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            ServicePointManager.DefaultConnectionLimit = Int32.MaxValue;
            ServicePointManager.Expect100Continue = false;
            httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(100000000);
        }
        public async void PostAsync(byte[] data)
        {
            string requestUri = "http://" + "192.168.15.16" + "/color/custom";
            byte[] requestBodyBytes = data;
            var dataHttp = new ByteArrayContent(data);

            var taskA = httpClient.PostAsync(requestUri, dataHttp);
            var result = taskA.Result.Content.ReadAsStringAsync().Result;
        }

        public string Get(Lamp _lamp, String data)
        {
            try
            {
                var taskA = httpClient.GetAsync("http://" + _lamp.ip + data);
                return taskA.Result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception e)
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Verifique se as lampadas estão ligadas na tomada, e conectadas a rede sem fio. ";
                string caption = "Nenhum dispositivo pode ser encontrado!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                _lamp.selected = false;
                //if (result == System.Windows.Forms.DialogResult.Yes)
                return "notFound";
            }
        }

        public bool Send(byte r, byte g, byte b)
        {                                     // Single Color
            return multipleRequests("/color/single?r=" + r.ToString() + "&g=" + g.ToString() + "&b=" + b.ToString());
        }
        public bool Send(byte r1, byte g1, byte b1, byte r2, byte g2, byte b2)
        {        // Dual Color
            return multipleRequests("/color/double?r1=" + r1.ToString() + "&g1=" + g1.ToString() + "&b1=" + b1.ToString() + "&r2=" + r2.ToString() + "&g2=" + g2.ToString() + "&b2=" + b2.ToString());
        }
        public bool Send(char mode)
        {                                                   // Mode
            if (mode == 'r')
            {
                return multipleRequests("/color/rainbow");
            }
            else
            {
                return multipleRequests("/animation?mode=" + mode);
            }
        }
        public bool Send(byte brightness)
        {                                             // Brightness
            return multipleRequests($"/brightness?set={brightness}");
        }
        public bool Send(char mode, int delay)
        {                                        // Change Mode and Delay
            return multipleRequests($"/animation?mode={mode}&delay={delay}");
        }
        public void CheckConnectivity()
        {
            List<Lamp> copy = new List<Lamp>(_appConfig.lamps);

            foreach (var lamp in _appConfig.lamps)
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(lamp.ip, 900);
                if (reply.Status == IPStatus.Success)
                {
                    int index = _appConfig.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                    var copyItem = _appConfig.lamps[index];
                    copy[index] = copyItem;
                }
                else
                {
                    int index = _appConfig.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                    var copyItem = _appConfig.lamps[index];
                    copyItem.selected = false;
                    copy[index] = copyItem;
                }
            }
            _appConfig.lamps = copy;
        }
        public void Status()
        {
            multipleRequests("/status");
        }
        public bool multipleRequests(String _sendData)
        {
            List<Lamp> copy = new List<Lamp>(_appConfig.lamps);
            bool success = true;
            for (byte i = 0; i < _appConfig.lamps.Count; i++)
            {
                var x = _appConfig.lamps[i];
                if (x.selected)
                {
                    String data = Get(x, _sendData);
                    if (data == "notFound")
                    {
                        int index = _appConfig.lamps.FindIndex(lamp1 => lamp1.name == x.name);
                        var copyItem = _appConfig.lamps[index];
                        copy[index] = copyItem;
                        success = success && false;
                    }
                    else
                    {
                        int index = _appConfig.lamps.FindIndex(lamp1 => lamp1.name == x.name);
                        var copyItem = _appConfig.lamps[index];
                        if (_sendData == "/status")
                            copyItem.brightness = (byte)Int16.Parse(data);
                        copy[index] = copyItem;
                        success = success && true;
                    }
                }
            }
            _appConfig.lamps = copy;
            return success;
        }

    }
    public class WebSocketManager
    {
        private AutoResetEvent messageReceiveEvent = new AutoResetEvent(false);
        private string lastMessageReceived;
        private WebSocket webSocket;

        public WebSocketManager(string webSocketUri)
        {
            Console.WriteLine("Initializing websocket. Uri: " + webSocketUri);
            webSocket = new WebSocket(webSocketUri);
            webSocket.Opened += new EventHandler(websocket_Opened);
            webSocket.Closed += new EventHandler(websocket_Closed);
            webSocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            webSocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(websocket_MessageReceived);

            webSocket.Open();
            while (webSocket.State == WebSocketState.Connecting) { };   // by default webSocket4Net has AutoSendPing=true, 
                                                                        // so we need to wait until connection established
            if (webSocket.State != WebSocketState.Open)
            {
                throw new Exception("Connection is not opened.");
            }
        }

        public string Send(string data)
        {
            Console.WriteLine("Client wants to send data:");
            Console.WriteLine(data);

            webSocket.Send(data);
            if (!messageReceiveEvent.WaitOne(5000))                         // waiting for the response with 5 secs timeout
                Console.WriteLine("Cannot receive the response. Timeout.");

            return lastMessageReceived;
        }
        public string Send(byte[] data)
        {
            Console.WriteLine("Client wants to send data:");
            Console.WriteLine(data);

            webSocket.Send(data, 0, data.Length);
            if (!messageReceiveEvent.WaitOne(5000))                         // waiting for the response with 5 secs timeout
                Console.WriteLine("Cannot receive the response. Timeout.");

            return lastMessageReceived;
        }

        public void Close()
        {
            Console.WriteLine("Closing websocket...");
            webSocket.Close();
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Websocket is opened.");
        }
        private void websocket_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
        }
        private void websocket_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Websocket is closed.");
        }

        private void websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine("Message received: " + e.Message);
            lastMessageReceived = e.Message;
            messageReceiveEvent.Set();
        }
    }
}