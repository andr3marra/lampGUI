using System;
using System.Windows.Forms;
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace lampGUI
{
    public class Program
    {
        [STAThread]

        static void Main()
        {
            var appConfig = AppConfig.Init();
            //appConfig.lamps.Add(new Lamp("Lamp R", "192.168.15.16"));
            //appConfig.SaveConfig();
            LampClient led = new LampClient(appConfig);
            led.CheckConnectivity();
            led.Status();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(led, appConfig));
        }
    }
}