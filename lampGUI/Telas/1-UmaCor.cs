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
        bool starting;
        public UmaCor(Api api)
        {
            led = api;
            InitializeComponent();
            starting = true;
            var items = chklbLamp.Items;
            foreach (var lamp in PersistentData.lamps) {
                items.Add(lamp.name, lamp.available&&lamp.selected);
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
            if (starting) {
                starting = false;
                return;
            }
            string itemText = chklbLamp.Items[e.Index].ToString();
            List<lamp> copy = new List<lamp>(PersistentData.lamps);
            if (e.NewValue == CheckState.Checked) {
                int index = PersistentData.lamps.FindIndex(lamp => lamp.name == itemText);
                var copyItem = PersistentData.lamps[index];
                copyItem.selected = true;
                copy[index] = copyItem;
            }
            else {
                int index = PersistentData.lamps.FindIndex(lamp => lamp.name == itemText);
                var copyItem = PersistentData.lamps[index];
                copyItem.selected = false;
                copy[index] = copyItem;
            }
            PersistentData.lamps = copy;
        }

        private void tbFrequencia_Scroll(object sender, EventArgs e) {

        }

        private void tbBrilho_Scroll(object sender, EventArgs e) {
            led.Send((byte) tbBrilho.Value);
            
        }

        private void button1_Click(object sender, EventArgs e) {
            byte[] array = new byte[270];
            for(int i = 0; i<array.Length; i++) {
                array[i] = 127;
            }

            led.Post(array);
        }
    }
}
