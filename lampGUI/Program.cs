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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var appConfig = AppConfig.Init();
            //appConfig.lamps.Add(new Lamp("Lamp R", "192.168.15.14"));
            //.SaveConfig();
            LampClient lampClient = new LampClient(appConfig);
            lampClient.CheckConnectivity();
            lampClient.Status();
            var analyzer = new Analyzer(lampClient);

            Application.Run(new MainWindow(lampClient, appConfig, analyzer));
        }
    }
}