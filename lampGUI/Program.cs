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
            PersistentData.Init();
            Api led = new Api();
            PersistentData.brightness = led.Status();
            PersistentData.delay = 200;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(led));
        }
    }
}