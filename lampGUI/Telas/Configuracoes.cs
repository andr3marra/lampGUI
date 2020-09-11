using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Forms;

namespace lampGUI.Telas {
    public partial class Configuracoes : Form {
        public Configuracoes() {
            InitializeComponent();
            lvLamps.View = View.Details;
            foreach(var lamp in PersistentData.lamps) {
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Form form = new Config_Add_Manually(lvLamps);
            form.Show();
        }
    }
}
