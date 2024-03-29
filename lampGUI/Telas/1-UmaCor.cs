﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lampGUI
{
    public partial class UmaCor : Form
    {
        private LampClient _lampClient;
        private AppConfig _appConfig;
        public UmaCor(LampClient lampClient, AppConfig appConfig)
        {
            _lampClient = lampClient;
            _appConfig = appConfig;
            InitializeComponent();
            UpdateChklbLamp();
            int countSelected = 0;
            for (int i = 0; i < _appConfig.lamps.Count; i++)
            {
                if (_appConfig.lamps[i].selected == true)
                    countSelected++;
            }
            if (countSelected == 1)
            {
                tbBrilho.Value = _appConfig.lamps.FirstOrDefault().brightness;
            }
            btnColor4x1.BackColor = _appConfig.customButtonColor[0];
            btnColor4x1.Style.FocusedBackColor = _appConfig.customButtonColor[0];
            btnColor4x1.Style.HoverBackColor = _appConfig.customButtonColor[0];
            btnColor4x1.Style.PressedBackColor = _appConfig.customButtonColor[0];
            btnColor4x2.BackColor = _appConfig.customButtonColor[1];
            btnColor4x2.Style.FocusedBackColor = _appConfig.customButtonColor[1];
            btnColor4x2.Style.HoverBackColor = _appConfig.customButtonColor[1];
            btnColor4x2.Style.PressedBackColor = _appConfig.customButtonColor[1];
            btnColor4x3.BackColor = _appConfig.customButtonColor[2];
            btnColor4x3.Style.FocusedBackColor = _appConfig.customButtonColor[2];
            btnColor4x3.Style.HoverBackColor = _appConfig.customButtonColor[2];
            btnColor4x3.Style.PressedBackColor = _appConfig.customButtonColor[2];
        }

        private void cwUmaCor_ColorChanged(object sender, EventArgs e)
        {
            if (timerPreventOversending.Interval > 100)
            {
                if (!_lampClient.Send(cwUmaCor.Color.R, cwUmaCor.Color.G, cwUmaCor.Color.B))
                    UpdateChklbLamp();
                timerPreventOversending.Stop();
                timerPreventOversending.Start();
            }


        }
        private void btnSolido_Click(object sender, EventArgs e)
        {
            _lampClient.Send('s');
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            _lampClient.Send('b', tbFrequencia.Value);
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            _lampClient.Send('w', tbFrequencia.Value);
        }
        private void UmaCor_Load(object sender, EventArgs e)
        {
            timerPreventOversending.Start();
            //tbFrequencia.Value = PersistentData.delay;
            //tbBrilho.Value = PersistentData.brightness;
        }

        private void chklbLamp_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            string itemText = chklbLamp.Items[e.Index].ToString();
            List<Lamp> copy = new List<Lamp>(_appConfig.lamps);
            if (e.NewValue == CheckState.Checked)
            {
                int index = _appConfig.lamps.FindIndex(lamp => lamp.name == itemText);
                var copyItem = _appConfig.lamps[index];
                copyItem.selected = true;
                copy[index] = copyItem;
            }
            else
            {
                int index = _appConfig.lamps.FindIndex(lamp => lamp.name == itemText);
                var copyItem = _appConfig.lamps[index];
                copyItem.selected = false;
                copy[index] = copyItem;
            }
            _appConfig.lamps = copy;
        }

        private void tbFrequencia_Scroll(object sender, EventArgs e)
        {

        }

        private void tbBrilho_Scroll(object sender, EventArgs e)
        {
            _lampClient.Send((byte)tbBrilho.Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[270];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 127;
            }

            _lampClient.PostAsync(array);
        }

        private void btnColor1x1_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor1x1.BackColor.R, btnColor1x1.BackColor.G, btnColor1x1.BackColor.B);
        }
        private void btnColor1x2_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor1x2.BackColor.R, btnColor1x2.BackColor.G, btnColor1x2.BackColor.B);
        }
        private void btnColor1x3_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor1x3.BackColor.R, btnColor1x3.BackColor.G, btnColor1x3.BackColor.B);
        }
        private void btnColor2x1_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor2x1.BackColor.R, btnColor2x1.BackColor.G, btnColor2x1.BackColor.B);
        }
        private void btnColor2x2_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor2x2.BackColor.R, btnColor2x2.BackColor.G, btnColor2x2.BackColor.B);
        }
        private void btnColor2x3_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor2x3.BackColor.R, btnColor2x3.BackColor.G, btnColor2x3.BackColor.B);
        }
        private void btnColor3x1_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor3x1.BackColor.R, btnColor3x1.BackColor.G, btnColor3x1.BackColor.B);
        }
        private void btnColor3x2_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor3x2.BackColor.R, btnColor3x2.BackColor.G, btnColor3x2.BackColor.B);
        }
        private void btnColor3x3_Click(object sender, EventArgs e)
        {
            cwUmaCor.Color = Color.FromArgb(btnColor3x3.BackColor.R, btnColor3x3.BackColor.G, btnColor3x3.BackColor.B);
        }
        private void btnColor4x1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                cwUmaCor.Color = Color.FromArgb(btnColor4x1.BackColor.R, btnColor4x1.BackColor.G, btnColor4x1.BackColor.B);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.Color = btnColor4x1.BackColor;
                if (MyDialog.ShowDialog() == DialogResult.OK)
                    btnColor4x1.BackColor = MyDialog.Color;
                btnColor4x1.Style.FocusedBackColor = MyDialog.Color;
                btnColor4x1.Style.HoverBackColor = MyDialog.Color;
                btnColor4x1.Style.PressedBackColor = MyDialog.Color;
                _appConfig.customButtonColor[0] = MyDialog.Color;
            }
        }
        private void btnColor4x2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                cwUmaCor.Color = Color.FromArgb(btnColor4x2.BackColor.R, btnColor4x2.BackColor.G, btnColor4x2.BackColor.B);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.Color = btnColor4x2.BackColor;
                if (MyDialog.ShowDialog() == DialogResult.OK)
                    btnColor4x2.BackColor = MyDialog.Color;
                btnColor4x2.Style.FocusedBackColor = MyDialog.Color;
                btnColor4x2.Style.HoverBackColor = MyDialog.Color;
                btnColor4x2.Style.PressedBackColor = MyDialog.Color;
                _appConfig.customButtonColor[1] = MyDialog.Color;
            }
        }
        private void btnColor4x3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                cwUmaCor.Color = Color.FromArgb(btnColor4x3.BackColor.R, btnColor4x3.BackColor.G, btnColor4x3.BackColor.B);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.Color = btnColor4x3.BackColor;
                if (MyDialog.ShowDialog() == DialogResult.OK)
                {
                    btnColor4x3.BackColor = MyDialog.Color;
                    btnColor4x3.Style.FocusedBackColor = MyDialog.Color;
                    btnColor4x3.Style.HoverBackColor = MyDialog.Color;
                    btnColor4x3.Style.PressedBackColor = MyDialog.Color;
                    _appConfig.customButtonColor[2] = MyDialog.Color;
                }
            }
        }
        private void UpdateChklbLamp()
        {
            chklbLamp.Items.Clear();
            var items = chklbLamp.Items;
            foreach (var lamp in _appConfig.lamps)
            {
                items.Add(lamp.name, lamp.selected);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[270];
            int var_teste = 236;
            int jump = 3;
            while (true)
            {
                /*                for (int i = 0; i < 270; i++)
                                {
                                    array[i] = 0;
                                }*/
                if (var_teste >= 269)
                {
                    array[var_teste] = 0;
                    var_teste = 236;
                }
                array[var_teste] = 0;
                array[var_teste + jump] = 255;
                var_teste += jump;
                //System.Threading.Thread.Sleep(100);
                _lampClient.PostAsync(array);
            }
        }
    }
}
