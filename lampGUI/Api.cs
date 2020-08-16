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
            this.url = url;
            request = WebRequest.Create(url);
        }

        public void SetEndpoint(string endpoint) {
            fullUrl = url + endpoint + "?";
        }

        public string Post(byte[] data) {

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

        public string Get() {

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
}
