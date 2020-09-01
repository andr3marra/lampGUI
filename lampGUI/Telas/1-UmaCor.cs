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
        public UmaCor(Api api)
        {
            led = api;
            InitializeComponent();
            var items = chklbLamp.Items;
            foreach (var lamp in PersistentData.lamps) {
                items.Add(lamp.name, lamp.available);
            }
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
        private void UmaCor_Load(object sender, EventArgs e) {
            //tbFrequencia.Value = PersistentData.delay;
            //tbBrilho.Value = PersistentData.brightness;
        }

        private void chklbLamp_ItemCheck(object sender, ItemCheckEventArgs e) {
/*            foreach (var item in chklbLamp.CheckedItems) {
                int index = PersistentData.lamps.FindIndex(lamp => lamp.name == item.ToString());
                var ms = PersistentData.lamps[index];
                ms.selected = false;
                PersistentData.lamps[index] = ms;
            }*/
        }

        private void chklbLamp_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void tbFrequencia_Scroll(object sender, EventArgs e) {

        }

        private void tbBrilho_Scroll(object sender, EventArgs e) {
            led.Send((byte) tbBrilho.Value);
            
        }
    }
}
