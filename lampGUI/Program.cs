using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.Json;
using System.IO;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace lampGUI {
    public static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        
        [STAThread]
        
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Device {
            public string id { get; set; }
            public string name { get; set; }
            public string ip { get; set; }
        }

        public class Root {
            public List<Device> devices { get; set; }
        }



    }
}
