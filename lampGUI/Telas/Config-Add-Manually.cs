using System;
using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class Config_Add_Manually : Form
    {
        private AppConfig _appConfig;

        public Config_Add_Manually(AppConfig appConfig)
        {
            _appConfig = appConfig;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnSaveClick(object sender, EventArgs e)
        {
            _appConfig.lamps.Add(new Lamp(txbName.Text, txbIp.Text));
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
