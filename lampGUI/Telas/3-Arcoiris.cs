using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lampGUI.Telas {
    public partial class _3_Arcoiris : Form {
        Api led = new Api("192.168.15.12");
        public _3_Arcoiris() {
            InitializeComponent();
        }

        private void lblBrilho_Click(object sender, EventArgs e)
        {

        }

        private void btnArcoIris_Click(object sender, EventArgs e) {
            led.Get(rgb.rainwbow());
        }

        private void tbBrilho_Scroll(object sender, EventArgs e) {
            led.Get(rgb.brightness((byte)tbBrilho.Value));
        }
    }
}
