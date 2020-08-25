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
            lvLamps.Columns.Add("Nome");
            lvLamps.Columns.Add("IP", 150);
            foreach(var lamp in PersistentData.lamps) {
                ListViewItem lvi = new ListViewItem(lamp.name);
                lvi.SubItems.Add(lamp.ip);
                lvLamps.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
