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
    public partial class _0_Cores : Form {
        public _0_Cores() {
            InitializeComponent();
            openChildForm(new UmaCor());
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm) {
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

        private void button1_Click(object sender, EventArgs e) {
            openChildForm(new UmaCor());
        }

        private void button2_Click(object sender, EventArgs e) {
            openChildForm(new DuasCores());
        }

        private void button3_Click(object sender, EventArgs e) {
            openChildForm(new _3_Arcoiris());
        }
    }

}
