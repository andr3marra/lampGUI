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
        Api led;
        public UmaCor(Api instancia)
        {
            led = instancia;
            InitializeComponent();
        }

        private void cwUmaCor_ColorChanged(object sender, EventArgs e) {
            led.Send(cwUmaCor.Color.R, cwUmaCor.Color.G, cwUmaCor.Color.B);
        }
        private void btnSolido_Click(object sender, EventArgs e) {
            led.Send('s');
        }

        private void btnPulsar_Click(object sender, EventArgs e) {
            led.Send('b', tbFrequencia.Value);
        }

        private void btnWave_Click(object sender, EventArgs e) {
            led.Send('w', tbFrequencia.Value);
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

        private void lblBrilho_Click(object sender, EventArgs e) {
        }
        private void tbBrilho_Scroll(object sender, EventArgs e) {
            led.Send((byte) tbBrilho.Value);
        }

        private void UmaCor_Load(object sender, EventArgs e) {
            tbFrequencia.Value = PersistentData.delay;
            tbBrilho.Value = PersistentData.brightness;
        }
    }
}
