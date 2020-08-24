using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace lampGUI {
    public class Api {
        private WebRequest request;
        private readonly string url;
        private string[] ip;
        bool[] lamps { set; get; }
        public Api(string[] ip) {
            this.ip = ip;
            lamps = new bool[] { true, false, false};
            //request = WebRequest.Create(this.url);
            this.url = ip[0];
        }
        public string Post(byte[] data) {
            request = WebRequest.Create("http://" + this.url + "/color/custom");
            request.Method = "POST";
            request.ContentType = "application/octet-stream";
            request.ContentLength = data.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(data, 0, data.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            string responseData;
            using (dataStream = response.GetResponseStream()) {
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

            WebResponse response = request.GetResponse();
            string responseData;

            using (Stream dataStream = response.GetResponseStream()) {
                StreamReader reader = new StreamReader(dataStream);
                responseData = reader.ReadToEnd();
            }
            response.Close();
            return responseData;
        }

        public void Send(byte r, byte g, byte b) {                                     // Single Color
            for (int i = 0; i < lamps.Length; i++) {
                if (lamps[i]) {
                    Get(ip[i], "/color/single?r=" + r.ToString() + "&g=" + g.ToString() + "&b=" + b.ToString());
                }
            }

        }
        public void Send(byte r1, byte g1, byte b1, byte r2, byte g2, byte b2) {        // Dual Color
            for (int i = 0; i < lamps.Length; i++) {
                if (lamps[i]) {
                    Get(ip[i], "/color/double?r1=" + r1.ToString() + "&g1=" + g1.ToString() + "&b1=" + b1.ToString() + "&r2=" + r2.ToString() + "&g2=" + g2.ToString() + "&b2=" + b2.ToString());
                }
            }
        }
        public void Send(char mode) {                                                   // Mode
            if (mode == 'r') {
                for (int i = 0; i < lamps.Length; i++) {
                    if (lamps[i]) {
                        Get(ip[i], "/color/rainbow");
                    }
                }
            }
            else {
                for (int i = 0; i < lamps.Length; i++) {
                    if (lamps[i]) {
                        Get(ip[i], "/animation?mode=" + mode);
                    }
                }
            }
        }
        public void Send(byte brightness) {                                             // Brightness
            for (int i = 0; i < lamps.Length; i++) {
                if (lamps[i]) {
                    Get(ip[i], $"/brightness?set={brightness}");
                }
            }
        }
        public void Send(char mode, int delay) {                                        // Change Mode and Delay
            for (int i = 0; i < lamps.Length; i++) {
                if (lamps[i]) {
                    Get(ip[i], $"/animation?mode={mode}&delay={delay}");
                }
            }
        }
    }
}