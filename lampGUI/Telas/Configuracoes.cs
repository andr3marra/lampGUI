using System;
using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class Configuracoes : Form
    {
        private LampClient _lampClient;
        private AppConfig _appConfig;
        public Configuracoes(LampClient lampClient, AppConfig appConfig)
        {
            _lampClient = lampClient;
            _appConfig = appConfig;
            InitializeComponent();
            showList();
            checkBoxHideMinimize.BoolValue = _appConfig.applicationConfig.HideMinimize;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Config_Add_Manually(_appConfig);
            form.Show();
            showList();
        }

        private void checkBoxHideMinimize_CheckStateChanged(object sender, EventArgs e)
        {
            _appConfig.applicationConfig.HideMinimize = checkBoxHideMinimize.BoolValue;
        }

        private void showList()
        {
            lvLamps.View = View.Details;
            lvLamps.Items.Clear();
            foreach (var lamp in _appConfig.lamps)
            {
                ListViewItem lvi = new ListViewItem(lamp.name);
                lvi.SubItems.Add(lamp.ip);
                //lvi.SubItems.Add("O"):lvi.SubItems.Add("X");
                //String item = lamp.available ? "" : "";
                //lvi.SubItems.Add(item);
                //lvi.SubItems[2].BackColor = lamp.available ? Color.Green : Color.Red;
                lvi.UseItemStyleForSubItems = false;
                lvLamps.Items.Add(lvi);
            }
        }
    }
}
