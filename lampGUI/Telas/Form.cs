using lampGUI.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lampGUI {

    public partial class Form1 : Form {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        Api led;
        public Form1(Api instancia) {
            led = instancia;
            InitializeComponent();
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm) {
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
        private void btnCores_Click_1(object sender, EventArgs e) {
            openChildForm(new _0_Cores());
            pnlLeft.Height = btnCores.Height;
            pnlLeft.Top = btnCores.Top;
            
        }
        private void btnMusica_Click(object sender, EventArgs e) {

            openChildForm(new Musica(led));
            pnlLeft.Height = btnMusica.Height;
            pnlLeft.Top = btnMusica.Top;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnConfiguracoes_Click(object sender, EventArgs e) {
            openChildForm(new Configuracoes());
            pnlLeft.Height = btnConfiguracoes.Height;
            pnlLeft.Top = btnConfiguracoes.Top;

        }
        private void btnTela_Click(object sender, EventArgs e) {
            openChildForm(new Tela());
            pnlLeft.Height = btnTela.Height;
            pnlLeft.Top = btnTela.Top;
            }

        private void btnCores_Enter(object sender, EventArgs e) {
            btnCores.BackColor = (Color.FromArgb(47, 49, 54));
        }
        private void btnCores_Leave(object sender, EventArgs e) {
            btnCores.BackColor = (Color.FromArgb(47, 49, 54));
        }
        private void btnCloseWindow_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
