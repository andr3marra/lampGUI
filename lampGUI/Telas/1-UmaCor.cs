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
                items.Add(lamp.name, lamp.selected);
            }
            int countSelected = 0;
            for( int i = 0; i < PersistentData.lamps.Count; i++) {
                if (PersistentData.lamps[i].selected == true)
                    countSelected++;
            }
            if(countSelected == 1) {
                tbBrilho.Value = PersistentData.lamps.FirstOrDefault().brightness;
            }
            btnColor4x1.BackColor = PersistentData.btnColor4x1;
            btnColor4x1.Style.FocusedBackColor = PersistentData.btnColor4x1;
            btnColor4x1.Style.HoverBackColor = PersistentData.btnColor4x1;
            btnColor4x1.Style.PressedBackColor = PersistentData.btnColor4x1;
            btnColor4x2.BackColor = PersistentData.btnColor4x2;
            btnColor4x2.Style.FocusedBackColor = PersistentData.btnColor4x2;
            btnColor4x2.Style.HoverBackColor = PersistentData.btnColor4x2;
            btnColor4x2.Style.PressedBackColor = PersistentData.btnColor4x2;
            btnColor4x3.BackColor = PersistentData.btnColor4x3;
            btnColor4x3.Style.FocusedBackColor = PersistentData.btnColor4x3;
            btnColor4x3.Style.HoverBackColor = PersistentData.btnColor4x3;
            btnColor4x3.Style.PressedBackColor = PersistentData.btnColor4x3;
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

            led.PostAsync(array);
        }

        private void btnColor1x1_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor1x1.BackColor.R, btnColor1x1.BackColor.G, btnColor1x1.BackColor.B);
        }
        private void btnColor1x2_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor1x2.BackColor.R, btnColor1x2.BackColor.G, btnColor1x2.BackColor.B);
        }
        private void btnColor1x3_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor1x3.BackColor.R, btnColor1x3.BackColor.G, btnColor1x3.BackColor.B);
        }
        private void btnColor2x1_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor2x1.BackColor.R, btnColor2x1.BackColor.G, btnColor2x1.BackColor.B);
        }
        private void btnColor2x2_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor2x2.BackColor.R, btnColor2x2.BackColor.G, btnColor2x2.BackColor.B);
        }
        private void btnColor2x3_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor2x3.BackColor.R, btnColor2x3.BackColor.G, btnColor2x3.BackColor.B);
        }
        private void btnColor3x1_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor3x1.BackColor.R, btnColor3x1.BackColor.G, btnColor3x1.BackColor.B);
        }
        private void btnColor3x2_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor3x2.BackColor.R, btnColor3x2.BackColor.G, btnColor3x2.BackColor.B);
        }
        private void btnColor3x3_Click(object sender, EventArgs e) {
            cwUmaCor.Color = Color.FromArgb(btnColor3x3.BackColor.R, btnColor3x3.BackColor.G, btnColor3x3.BackColor.B);
        }
        private void btnColor4x1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                cwUmaCor.Color = Color.FromArgb(btnColor4x1.BackColor.R, btnColor4x1.BackColor.G, btnColor4x1.BackColor.B);
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.Color = btnColor4x1.BackColor;
                if (MyDialog.ShowDialog() == DialogResult.OK)
                    btnColor4x1.BackColor = MyDialog.Color;
                    btnColor4x1.Style.FocusedBackColor = MyDialog.Color;
                    btnColor4x1.Style.HoverBackColor = MyDialog.Color;
                    btnColor4x1.Style.PressedBackColor = MyDialog.Color;
                    PersistentData.btnColor4x1 = MyDialog.Color;
            }
        }
        private void btnColor4x2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                cwUmaCor.Color = Color.FromArgb(btnColor4x2.BackColor.R, btnColor4x2.BackColor.G, btnColor4x2.BackColor.B);
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.Color = btnColor4x2.BackColor;
                if (MyDialog.ShowDialog() == DialogResult.OK)
                    btnColor4x2.BackColor = MyDialog.Color;
                    btnColor4x2.Style.FocusedBackColor = MyDialog.Color;
                    btnColor4x2.Style.HoverBackColor = MyDialog.Color;
                    btnColor4x2.Style.PressedBackColor = MyDialog.Color;
                    PersistentData.btnColor4x2 = MyDialog.Color;
            }
        }
        private void btnColor4x3_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                cwUmaCor.Color = Color.FromArgb(btnColor4x3.BackColor.R, btnColor4x3.BackColor.G, btnColor4x3.BackColor.B);
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.Color = btnColor4x3.BackColor;
                if (MyDialog.ShowDialog() == DialogResult.OK) {
                    btnColor4x3.BackColor = MyDialog.Color;
                    btnColor4x3.Style.FocusedBackColor = MyDialog.Color;
                    btnColor4x3.Style.HoverBackColor = MyDialog.Color;
                    btnColor4x3.Style.PressedBackColor = MyDialog.Color;
                    PersistentData.btnColor4x3 = MyDialog.Color;
                }
            }
        }
    }
}
