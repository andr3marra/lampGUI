using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class Tela : Form
    {
        private LampClient _lampClient;
        private AppConfig _appConfig;
        public Tela(LampClient lampClient, AppConfig appConfig)
        {
            _lampClient = lampClient;
            _appConfig = appConfig;
            InitializeComponent();
        }
    }
}
