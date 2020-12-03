using System;
using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class Config_Add_Manually : Form
    {
        private ListView lvLamps;

        public Config_Add_Manually(ListView lvLamps)
        {
            this.lvLamps = lvLamps;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnSaveClick(object sender, EventArgs e)
        {
            PersistentData.lamps.Add(new lamp(txbName.Text, txbIp.Text));
            ListViewItem lvi = new ListViewItem(txbName.Text);
            lvi.SubItems.Add(txbIp.Text);
            lvLamps.Items.Add(lvi);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
