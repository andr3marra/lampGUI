using lampGUI.Telas;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lampGUI
{

    public partial class MainWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private LampClient _lampClient;
        private AppConfig _appConfig;
        private Analyzer _analyzer;
        public MainWindow(LampClient lampClient, AppConfig appConfig, Analyzer analyzer)
        {
            _appConfig = appConfig;
            _lampClient = lampClient;
            _analyzer = analyzer;
            InitializeComponent();
            openChildForm(new _0_Cores(_lampClient, _appConfig));
            pnlLeft.BringToFront();
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm?.GetType() == childForm.GetType())
            {
                return;
            }
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnCores_Click_1(object sender, EventArgs e)
        {
            openChildForm(new _0_Cores(_lampClient, _appConfig));
            pnlLeft.Location = new Point(pnlCores.Location.X, pnlCores.Location.Y-panel2.Size.Height);
            pnlLeft.BringToFront();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnCores_Enter(object sender, EventArgs e)
        {
            btnColors.BackColor = (Color.FromArgb(47, 49, 54));
        }
        private void btnCores_Leave(object sender, EventArgs e)
        {
            btnColors.BackColor = (Color.FromArgb(47, 49, 54));
        }
        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            if (_appConfig.applicationConfig.HideMinimize)
            {
                this.Hide();
            }

            else
            {
                Application.Exit();
            }


        }

        private void tgOnOff_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == ToggleButtonState.Inactive)
                _lampClient.Send(0);
            if (e.ToggleState == ToggleButtonState.Active)
                _lampClient.Send(255);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            openChildForm(new Musica(_lampClient, _appConfig, _analyzer));
            pnlLeft.Location = new Point(pnlMusica.Location.X, pnlMusica.Location.Y - panel2.Size.Height);
            pnlLeft.BringToFront();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            openChildForm(new Tela(_lampClient, _appConfig));
            pnlLeft.Location = new Point(pnlTela.Location.X, pnlTela.Location.Y - panel2.Size.Height);
            pnlLeft.BringToFront();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            openChildForm(new Configuracoes(_lampClient, _appConfig));
            pnlLeft.Location = new Point(pnlConfiguracoes.Location.X, pnlConfiguracoes.Location.Y - panel2.Size.Height);
            pnlLeft.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.BalloonTipText = "Welcome to TutorialsPanel.com!!";
            //notifyIcon1.BalloonTipTitle = "Welcome Message";
            //notifyIcon1.ShowBalloonTip(2000);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
