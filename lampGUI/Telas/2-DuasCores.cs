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
    public partial class DuasCores : Form
    {
        Api led = new Api("192.168.15.12");
        public DuasCores()
        {
            InitializeComponent();
        }

        private void cwDuasCores1_ColorChanged(object sender, EventArgs e) {
            led.Get(rgb.doubleColor(cwDuasCores1.Color.R, cwDuasCores1.Color.G, cwDuasCores1.Color.B, cwDuasCores2.Color.R, cwDuasCores2.Color.G, cwDuasCores2.Color.B));
        }

        private void cwDuasCores2_ColorChanged(object sender, EventArgs e) {
            led.Get(rgb.doubleColor(cwDuasCores1.Color.R, cwDuasCores1.Color.G, cwDuasCores1.Color.B, cwDuasCores2.Color.R, cwDuasCores2.Color.G, cwDuasCores2.Color.B));
        }

        private void btnSolido_Click_1(object sender, EventArgs e) {
            led.Get(rgb.mode('s'));
        }

        private void btnBreath_Click(object sender, EventArgs e) {
            led.Get(rgb.mode('b', 1000));
        }

        private void btnWave_Click(object sender, EventArgs e) {
            led.Get(rgb.mode('w', 1000));
        }
    }
}
