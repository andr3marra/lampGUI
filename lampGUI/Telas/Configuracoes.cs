using System;
using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
            lvLamps.View = View.Details;
            foreach (var lamp in PersistentData.lamps)
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
            checkBoxHideMinimize.BoolValue = PersistentData.HideMinimize;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Config_Add_Manually(lvLamps);
            form.Show();
        }

        private void checkBoxHideMinimize_CheckStateChanged(object sender, EventArgs e)
        {
            PersistentData.HideMinimize = checkBoxHideMinimize.BoolValue;
        }
    }
}
