using System;
using System.Windows.Forms;

namespace lampGUI
{
    public partial class DuasCores : Form
    {
        LampClient led;
        public DuasCores(LampClient instancia)
        {
            led = instancia;
            InitializeComponent();
        }

        private void cwDuasCores1_ColorChanged(object sender, EventArgs e)
        {
            led.Send(cwDuasCores1.Color.R, cwDuasCores1.Color.G, cwDuasCores1.Color.B, cwDuasCores2.Color.R, cwDuasCores2.Color.G, cwDuasCores2.Color.B);
        }

        private void cwDuasCores2_ColorChanged(object sender, EventArgs e)
        {
            led.Send(cwDuasCores1.Color.R, cwDuasCores1.Color.G, cwDuasCores1.Color.B, cwDuasCores2.Color.R, cwDuasCores2.Color.G, cwDuasCores2.Color.B);
        }

        private void btnSolido_Click_1(object sender, EventArgs e)
        {
            led.Send('s');
        }

        private void btnBreath_Click(object sender, EventArgs e)
        {
            led.Send('b', tbFrequencia.Value);
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            led.Send('w', tbFrequencia.Value);
        }

        private void tbBrilho_Scroll(object sender, EventArgs e)
        {
            led.Send((byte)tbBrilho.Value);
        }

        private void DuasCores_Load(object sender, EventArgs e)
        {
            /*            tbFrequencia.Value = PersistentData.delay;
                        tbBrilho.Value = PersistentData.brightness;*/
        }
    }
}
