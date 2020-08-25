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
        Api led;
        public _3_Arcoiris(Api instancia) {
            led = instancia;
            InitializeComponent();
        }

        private void lblBrilho_Click(object sender, EventArgs e)
        {

        }

        private void btnArcoIris_Click(object sender, EventArgs e) {
            led.Send('r');
        }

        private void tbBrilho_Scroll(object sender, EventArgs e) {
            led.Send((byte)tbBrilho.Value);
        }

        private void _3_Arcoiris_Load(object sender, EventArgs e) {
            tbBrilho.Value = PersistentData.brightness;
        }
    }
}
