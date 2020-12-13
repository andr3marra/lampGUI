using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace lampGUI
{
    public class AppConfig
    {
        public List<Lamp> lamps;
        public List<Color> customButtonColor;
        public ApplicationConfig applicationConfig;
        public AppConfig()
        {
            this.lamps = new List<Lamp> { };
            this.customButtonColor = new List<Color> { Color.FromArgb(245, 254, 0), Color.FromArgb(245, 254, 0), Color.FromArgb(245, 254, 0) };
            this.applicationConfig = new ApplicationConfig();
        }
        public static AppConfig Init()
        {
            var readSuccess = ReadConfig(out var instance);
            if (!readSuccess) { instance = new AppConfig(); }
            else
            {
                if (instance.lamps == null)
                {
                    instance.lamps = new List<Lamp> { };
                }
                if (instance.customButtonColor == null)
                {
                    instance.customButtonColor = new List<Color> { Color.FromArgb(245, 254, 0), Color.FromArgb(245, 254, 0), Color.FromArgb(245, 254, 0) };
                }
            }

            return instance;
        }
        public static bool ReadConfig(out AppConfig deserializedObject)
        {
            var path = "External/config.json";
            deserializedObject = null;
            try
            {
                var json = File.ReadAllText(path);
                deserializedObject = JsonConvert.DeserializeObject<AppConfig>(json);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveConfig()
        {
            var path = "External/config.json";
            var serializedObject = JsonConvert.SerializeObject(this, Formatting.Indented);
            try
            {
                File.WriteAllText(path, serializedObject);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
    public class Lamp
    {
        public String name;
        public String ip;
        public byte brightness;
        public int delay;
        public bool selected;
        public char mode;
        public Lamp(String name, String ip)
        {
            this.name = name;
            this.ip = ip;
            this.brightness = 255;
            this.delay = 200;
            this.selected = true;
            this.mode = 's';
        }
    }
    public class ApplicationConfig
    {
        public bool HideMinimize { get; set; }
        public ApplicationConfig()
        {
            this.HideMinimize = false;
        }
    }
}
