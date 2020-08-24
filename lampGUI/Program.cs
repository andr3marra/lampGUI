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
    public class Program {
        [STAThread]

        static void Main() {
            String[] ip;
            bool[] lamps = new []{ true, false, false };
            using (StreamReader r = new StreamReader("config.json")) {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                ip = new String[array.Count];
                for ( int i = 0; i <array.Count; i++ ) {
                    ip[i] = array[i].ip;
                }
            }
            
            Api led = new Api(ip);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(led));
        }
    }
}