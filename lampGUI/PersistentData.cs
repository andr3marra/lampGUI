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

namespace lampGUI {
    public static class PersistentData {
        public static List<lamp> lamps = new List<lamp> { };
        public static byte brightness;
        public static int delay;
        //public static byte[] brightness;
        //public static int[] delay;
        //public static bool[] lamps = new[] { true, false, false };
        public static void Init() {
            using (StreamReader r = new StreamReader("config.json")) {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                String[] ip = new String[array.Count];
                for (int i = 0; i < array.Count; i++) {
                    lamps.Add(new lamp(array[i].name.Value , array[i].ip.Value));
                }
            }
        }
    }
    public struct lamp {
        public String name;
        public String ip;
        public lamp(String name, String ip) {
            this.name = name;
            this.ip = ip;
        }
    }
}
