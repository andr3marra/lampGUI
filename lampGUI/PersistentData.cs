using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Un4seen.Bass.Misc;
using System.Windows.Forms;

namespace lampGUI {
    public static class PersistentData {
        public static List<lamp> lamps = new List<lamp> { };
        //public static List<lamp> temporary = new List<lamp> { };
        //public static byte brightness;
        //public static int delay;
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
        public static void UpdateStatus(Api api) {
            List<lamp> temporary = new List<lamp> { };
            foreach (lamp item in lamps) {
                int index = PersistentData.lamps.FindIndex(lamp1 => lamp1.name == item.name);
                var lampLoop = item;
                //lampLoop.brightness = api.Status();
                lampLoop.delay = 200;
                temporary.Add(item);
            }
            lamps = temporary;
        }
    }
    public struct lamp {
        public String name;
        public String ip;
        public bool available;
        public byte brightness;
        public int delay;
        public bool selected;
        public lamp(String name, String ip) {
            this.name = name;
            this.ip = ip;
            this.available = true;
            this.brightness = 0;
            this.delay = 200;
            this.selected = true;
        }
    }
}
