using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace lampGUI
{
    public static class PersistentData
    {
        public static Color btnColor4x1 = Color.FromArgb(245, 254, 0);
        public static Color btnColor4x2 = Color.FromArgb(245, 0, 55);
        public static Color btnColor4x3 = Color.FromArgb(245, 57, 75);
        public static bool HideMinimize = false;
        public static List<lamp> lamps = new List<lamp> { };

        public static void Init()
        {
            if (File.Exists("External/config.json"))
            {
                using (StreamReader r = new StreamReader("External/config.json"))
                {
                    string json = r.ReadToEnd();
                    dynamic array = JsonConvert.DeserializeObject(json);
                    String[] ip = new String[array.Count];
                    for (int i = 0; i < array.Count; i++)
                    {
                        lamps.Add(new lamp(array[i].name.Value, array[i].ip.Value));
                    }
                }
            }
        }
    }
    public class lamp
    {
        public String name;
        public String ip;
        public byte brightness;
        public int delay;
        public bool selected;
        public char mode;
        public lamp(String name, String ip)
        {
            this.name = name;
            this.ip = ip;
            this.brightness = 255;
            this.delay = 200;
            this.selected = true;
            this.mode = 's';
        }
    }
}
