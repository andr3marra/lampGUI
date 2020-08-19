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
        Api led = new Api("192.168.15.12");
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
/*            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                button1.BackColor = colorDialog1.Color;
            }*/
        }

        private void colorWheel1_ColorChanged(object sender, EventArgs e) {
            led.Get(rgb.singleColor(colorWheel1.Color.R, colorWheel1.Color.G, colorWheel1.Color.B));
        }

        private void colorWheel2_ColorChanged(object sender, EventArgs e) {
            led.Get(rgb.doubleColor(colorWheel1.Color.R, colorWheel1.Color.G, colorWheel1.Color.B, colorWheel2.Color.R, colorWheel2.Color.G, colorWheel2.Color.B));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
