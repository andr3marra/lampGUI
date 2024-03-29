﻿using System;
using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class _3_Arcoiris : Form
    {
        private LampClient _lampClient;
        private AppConfig _appConfig;
        public _3_Arcoiris(LampClient lampClient, AppConfig appConfig)
        {
            _lampClient = lampClient;
            _appConfig = appConfig;
            InitializeComponent();
        }

        private void lblBrilho_Click(object sender, EventArgs e)
        {

        }

        private void tbBrilho_Scroll(object sender, EventArgs e)
        {
            _lampClient.Send((byte)tbBrilho.Value);
        }

        private void pbArcoIris_Click(object sender, EventArgs e)
        {
            _lampClient.Send('r');
        }
        private void _3_Arcoiris_Load(object sender, EventArgs e)
        {
            /*            tbBrilho.Value = PersistentData.brightness;*/
        }

        private void btnSolido_Click(object sender, EventArgs e)
        {
            _lampClient.Send('r');
        }

        private void btnBreath_Click(object sender, EventArgs e)
        {
            _lampClient.Send('b', tbFrequencia.Value);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
