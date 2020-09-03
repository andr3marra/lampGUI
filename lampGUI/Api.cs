using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace lampGUI {
    public class Api {
        private WebRequest request;
        private string url;
        private string endereco;

        public Api() {
            this.endereco = PersistentData.lamps[0].ip;     // APENAS POST
            this.url = endereco;                            // APENAS POST
        }
        public void Post(byte[] data) {
            request = WebRequest.Create("http://" + this.url + "/color/custom");
            request.Method = "POST";
            request.ContentType = "text/plain";
            request.ContentLength = data.Length;
            ServicePointManager.DefaultConnectionLimit = 20;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(data, 0, data.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
/*            string responseData;
            using (dataStream = response.GetResponseStream()) {
                StreamReader reader = new StreamReader(dataStream);
                responseData = reader.ReadToEnd();
            }*/
            response.Close();
            return;
        }
        public string Get(string address) {
            request = WebRequest.Create("http://" + address);
            request.Method = "GET";
            request.UseDefaultCredentials = true;

            WebResponse response = request.GetResponse();
            string responseData;

            using (Stream dataStream = response.GetResponseStream()) {
                StreamReader reader = new StreamReader(dataStream);
                responseData = reader.ReadToEnd();
            }
            response.Close();
            return responseData;
        }
        public string Get(string address, String data) {
            request = WebRequest.Create("http://" + address + data);
            request.Method = "GET";
            request.UseDefaultCredentials = true;
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
                if (lamp.selected && lamp.available)
                    Get(lamp.ip, "/color/single?r=" + r.ToString() + "&g=" + g.ToString() + "&b=" + b.ToString());
            }
        }
        public void Send(byte r1, byte g1, byte b1, byte r2, byte g2, byte b2) {        // Dual Color
            foreach (var lamp in PersistentData.lamps) {
                if (lamp.selected && lamp.available)
                    Get(lamp.ip, "/color/double?r1=" + r1.ToString() + "&g1=" + g1.ToString() + "&b1=" + b1.ToString() + "&r2=" + r2.ToString() + "&g2=" + g2.ToString() + "&b2=" + b2.ToString());
            }
        }
        public void Send(char mode) {                                                   // Mode
            if (mode == 'r') {
                foreach (var lamp in PersistentData.lamps) {
                    if (lamp.selected && lamp.available)
                        Get(lamp.ip, "/color/rainbow");
                }
            }
            else {
                foreach (var lamp in PersistentData.lamps) {
                    if (lamp.selected && lamp.available)
                        Get(lamp.ip, "/animation?mode=" + mode);
                }
            }
        }
        public void Send(byte brightness) {                                             // Brightness
            foreach (lamp lamp in PersistentData.lamps) {
                if (lamp.selected && lamp.available)
                    Get(lamp.ip, $"/brightness?set={brightness}");
            }
        }
        public void Send(char mode, int delay) {                                        // Change Mode and Delay
            foreach (var lamp in PersistentData.lamps) {
                if (lamp.selected && lamp.available)
                    Get(lamp.ip, $"/animation?mode={mode}&delay={delay}");
            }

        }
        public void Status() {
            List<lamp> copy = new List<lamp>(PersistentData.lamps);

            foreach (var lamp in PersistentData.lamps) {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(lamp.ip, 900);
                if(reply.Status == IPStatus.Success) {
                    int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                    var copyItem = PersistentData.lamps[index];
                    copyItem.available = true;
                    copy[index] = copyItem;
                }
                else{
                    int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                    var copyItem = PersistentData.lamps[index];
                    copyItem.available = false;
                    copyItem.selected = false;
                    copy[index] = copyItem;
                }
            }
            PersistentData.lamps = copy;
        }
        public void State() {
            List<lamp> copy = new List<lamp>(PersistentData.lamps);

            foreach (var lamp in PersistentData.lamps) {
                String data;
                if (lamp.selected && lamp.available) {
                    data = Get(lamp.ip, "/status");
                    if (data == "notFound") {
                        int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                        var copyItem = PersistentData.lamps[index];
                        copyItem.available = false;
                        copy[index] = copyItem;
                    }
                    else {
                        int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == lamp.name);
                        var copyItem = PersistentData.lamps[index];
                        copyItem.available = true;
                        copyItem.brightness = (byte)Int16.Parse(data);
                        copy[index] = copyItem;
                    }
                }
            }
            PersistentData.lamps = copy;
        }
    }
}