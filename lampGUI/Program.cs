using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace lampGUI {
    public static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        
        [STAThread]
        
        static void Main() {
/*            using (StreamReader r = new StreamReader("config.json")) {
                string jsonString = r.ReadToEnd();

                Devices devices = JsonSerializer.Deserialize<Devices>(jsonString);
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public class Devices {
            public string name { get; set; }
            public string ip { get; set; }
        }
    }
}
