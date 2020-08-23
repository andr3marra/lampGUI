using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class Musica: Form
    {
        private Analyzer analyzer;
        public Musica()
        {
            
            InitializeComponent();
            analyzer = new Analyzer(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (Btn_Enable.Text == "Enable") {
                analyzer.Enable = true;
                analyzer.DisplayEnable = true;
                Btn_Enable.Text = "Disable";
            }
            else {
                analyzer.Enable = false;
                analyzer.DisplayEnable = false;
                Btn_Enable.Text = "Enable";
            }
        }
    }
}
