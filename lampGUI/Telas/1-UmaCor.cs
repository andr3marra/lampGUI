using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lampGUI
{
    public partial class UmaCor : Form
    {
        Api led = new Api("192.168.15.12");
        public UmaCor()
        {
            InitializeComponent();
        }

        private void cwUmaCor_ColorChanged(object sender, EventArgs e) {
            led.Get(rgb.singleColor(cwUmaCor.Color.R, cwUmaCor.Color.G, cwUmaCor.Color.B));
        }
        private void btnSolido_Click(object sender, EventArgs e) {
            led.Get(rgb.mode('s'));
        }

        private void btnPulsar_Click(object sender, EventArgs e) {
            led.Get(rgb.mode('b', 1000));
        }

        private void btnWave_Click(object sender, EventArgs e) {
            led.Get(rgb.mode('w', 1000));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBrilho_Click(object sender, EventArgs e)
        {

        }
    }
}
