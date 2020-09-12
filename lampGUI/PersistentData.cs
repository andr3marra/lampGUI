using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Un4seen.Bass.Misc;
using System.Windows.Forms;
using System.Drawing;

namespace lampGUI {
    public static class PersistentData {
        public static Color btnColor4x1 = Color.FromArgb(245, 254, 0);
        public static Color btnColor4x2 = Color.FromArgb(245, 0, 55);
        public static Color btnColor4x3 = Color.FromArgb(245, 57, 75);
        public static bool HideMinimize = true;
        public static List<lamp> lamps = new List<lamp> { };

        public static void Init() {
            using (StreamReader r = new StreamReader("config.json")) {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                String[] ip = new String[array.Count];
                for (int i = 0; i < array.Count; i++) {
                    lamps.Add(new lamp(array[i].name.Value, array[i].ip.Value));
                }
            }
        }
    }
    public struct lamp {
        public String name;
        public String ip;
        public byte brightness;
        public int delay;
        public bool selected;
        public char mode;
        public lamp(String name, String ip) {
            this.name = name;
            this.ip = ip;
            this.brightness = 255;
            this.delay = 200;
            this.selected = true;
            this.mode = 's';
        }
    }
}
