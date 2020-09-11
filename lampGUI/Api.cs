using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace lampGUI {
    public class Api {
        private WebRequest request;
        private string url;
        private string endereco;
        private WebClient client;
        private static HttpClient client1;
        public Api() {
            this.endereco = PersistentData.lamps[0].ip;     // APENAS POST
            this.url = endereco;                            // APENAS POST
            client = new WebClient();
            client.Proxy = null;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            ServicePointManager.DefaultConnectionLimit = Int32.MaxValue;
            ServicePointManager.Expect100Continue = false;
            client1 = new HttpClient();
            client1.Timeout = new TimeSpan(50);
        }
        public async void PostAsync(byte[] data) {
            string requestUri = "http://192.168.15.83/color/custom";
            string contentType = "text/plain";

            byte[] requestBodyBytes = data;
            var dataHttp = new ByteArrayContent(data);

            using (client) {
                client.Headers[HttpRequestHeader.ContentType] = contentType;

                var bla = await client1.PostAsync(requestUri, dataHttp);
            }
        }
        public string Get(string address, String data) {
            request = WebRequest.Create("http://" + address + data);
            request.Method = "GET";
            request.UseDefaultCredentials = true;
            request.Timeout = 50;
            try {
                WebResponse response = request.GetResponse();
                string responseData;

                using (Stream dataStream = response.GetResponseStream()) {
                    StreamReader reader = new StreamReader(dataStream);
                    responseData = reader.ReadToEnd();
                }
                response.Close();
                return responseData;
            }
            catch {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Verifique se as lampadas estão ligadas na tomada, e conectadas a rede sem fio. ";
                string caption = "Nenhum dispositivo pode ser encontrado!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                //if (result == System.Windows.Forms.DialogResult.Yes)
                return "notFound";
            }
        }

        public void Send(byte r, byte g, byte b) {                                     // Single Color
            foreach (var lamp in PersistentData.lamps) {
                if (lamp.selected)
                    Get(lamp.ip, "/color/single?r=" + r.ToString() + "&g=" + g.ToString() + "&b=" + b.ToString());
            }
        }
        public void Send(byte r1, byte g1, byte b1, byte r2, byte g2, byte b2) {        // Dual Color
            foreach (var lamp in PersistentData.lamps) {
                if (lamp.selected)
                    Get(lamp.ip, "/color/double?r1=" + r1.ToString() + "&g1=" + g1.ToString() + "&b1=" + b1.ToString() + "&r2=" + r2.ToString() + "&g2=" + g2.ToString() + "&b2=" + b2.ToString());
            }
        }
        public void Send(char mode) {                                                   // Mode
            if (mode == 'r') {
                foreach (var lamp in PersistentData.lamps) {
                    if (lamp.selected)
                        Get(lamp.ip, "/color/rainbow");
                }
            }
            else {
                foreach (var lamp in PersistentData.lamps) {
                    if (lamp.selected)
                        Get(lamp.ip, "/animation?mode=" + mode);
                }
            }
        }
        public void Send(byte brightness) {                                             // Brightness
            foreach (lamp lamp in PersistentData.lamps) {
                if (lamp.selected)
                    Get(lamp.ip, $"/brightness?set={brightness}");
            }
        }
        public void Send(char mode, int delay) {                                        // Change Mode and Delay
            foreach (var lamp in PersistentData.lamps) {
                if (lamp.selected)
                    Get(lamp.ip, $"/animation?mode={mode}&delay={delay}");
            }

        }
        public void CheckConnectivity() {
            List<lamp> copy = new List<lamp>(PersistentData.lamps);

            foreach (var lamp in PersistentData.lamps) {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(lamp.ip, 900);
                if (reply.Status == IPStatus.Success) {
                    int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                    var copyItem = PersistentData.lamps[index];
                    copy[index] = copyItem;
                }
                else {
                    int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                    var copyItem = PersistentData.lamps[index];
                    copyItem.selected = false;
                    copy[index] = copyItem;
                }
            }
            PersistentData.lamps = copy;
        }
        public void Status() {
            multipleRequests("/status");
        }
        public void multipleRequests(String _sendData) {
            List<lamp> copy = new List<lamp>(PersistentData.lamps);

            foreach (var lamp in PersistentData.lamps) {
                if (lamp.selected) {
                    String data = Get(lamp.ip, _sendData);
                    if (data == "notFound") {
                        int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                        var copyItem = PersistentData.lamps[index];
                        copy[index] = copyItem;
                    }
                    else {
                        int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                        var copyItem = PersistentData.lamps[index];
                        copyItem.brightness = (byte)Int16.Parse(data);
                        copy[index] = copyItem;
                    }
                }
            }
            PersistentData.lamps = copy;
        }

    }
}