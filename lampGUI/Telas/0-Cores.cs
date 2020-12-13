using lampGUI.Telas;
using System;
using System.Windows.Forms;

namespace lampGUI
{
    public partial class _0_Cores : Form
    {
        LampClient _lampClient;
        AppConfig _appConfig;
        public _0_Cores(LampClient lampClient, AppConfig appConfig)
        {
            _lampClient = lampClient;
            _appConfig = appConfig;
            InitializeComponent();
            openChildForm(new UmaCor(_lampClient, _appConfig));
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildCores.Controls.Add(childForm);
            panelChildCores.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new UmaCor(_lampClient, _appConfig));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DuasCores(_lampClient, _appConfig));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new _3_Arcoiris(_lampClient, _appConfig));
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            openChildForm(new UmaCor(_lampClient, _appConfig));
        }

        private void btnGradient_Click(object sender, EventArgs e)
        {
            openChildForm(new DuasCores(_lampClient, _appConfig));
        }

        private void btnRainbow_Click(object sender, EventArgs e)
        {
            openChildForm(new _3_Arcoiris(_lampClient, _appConfig));
        }
    }

}
