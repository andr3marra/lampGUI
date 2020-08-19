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
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
/*            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                button1.BackColor = colorDialog1.Color;
            }*/
        }

        private void cwUmaCor_ColorChanged(object sender, EventArgs e) {
            
        }

        private void colorWheel2_ColorChanged(object sender, EventArgs e) {
            //
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
        private void btnCores_Click(object sender, EventArgs e) {
            openChildForm(new UmaCor());
        }

        private void btnMusica_Click(object sender, EventArgs e) {
            openChildForm(new DuasCores());
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
