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
            PersistentData.Init();
            Api led = new Api();
            //PersistentData.UpdateStatus(led);
            led.CheckConnectivity();
            led.Status();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(led));
        }
    }
}