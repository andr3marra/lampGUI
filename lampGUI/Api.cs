using System;
using System.IO;
using System.Net;


namespace lampGUI {
    class Api {
        private WebRequest request;
        private readonly string url;
        private string fullUrl;
        public string endpoint;

        public Api(string url) {
            this.url = "http://" + url;
            //request = WebRequest.Create(this.url);
        }

        public void SetEndpoint(string endpoint) {
            fullUrl = url + endpoint + "?";
        }

        public string Post(byte[] data) {
            request = WebRequest.Create(this.url);
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

        public string Get(String data) {
            request = WebRequest.Create(this.url + data);
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
    }
    public static class rgb {
        public static string singleColor(byte r, byte g, byte b) {
            return "/color/single?r=" + r.ToString() +"&g="+g.ToString() + "&b="+b.ToString(); 
        }
        public static string doubleColor(byte r1, byte g1, byte b1, byte r2, byte g2, byte b2) {
            return "/color/double?r1=" + r1.ToString() + "&g1=" + g1.ToString() + "&b1=" + b1.ToString() + "&r2" + r2.ToString() + "&g2=" + g2.ToString() + "&b2=" + b2.ToString();
        }

        public static string rainwbow() {
            return "/color/rainbow";
        }

        public static string mode(char mode) {
            return "/animation?mode=" + mode ;
        }
        public static string mode(char mode, int delay) {
            return $"/animation?mode={mode}&delay={delay}";
        }
        public static string brightness( byte brightness) {
            return $"/brightness?set={brightness}";
        }

    }
}
