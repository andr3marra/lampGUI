using System;
using System.Windows.Forms;

namespace lampGUI.Telas
{
    public partial class Musica : Form
    {
        private Analyzer analyzer;
        private Api led;
        public Musica(Api instancia)
        {
            led = instancia;
            InitializeComponent();
            analyzer = new Analyzer(comboBox1, led);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Btn_Enable.Text == "Enable")
            {
                analyzer.Enable = true;
                analyzer.DisplayEnable = true;
                Btn_Enable.Text = "Disable";
            }
            else
            {
                analyzer.Enable = false;
                analyzer.DisplayEnable = false;
                Btn_Enable.Text = "Enable";
            }
        }
    }
}
