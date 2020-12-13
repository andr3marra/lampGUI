using Syncfusion.DataSource.Extensions;
using System;
using System.Windows.Forms;
using System.Linq;

namespace lampGUI.Telas
{
    public partial class Musica : Form
    {
        private Analyzer _analyzer;
        private LampClient _lampClient;
        private AppConfig _appConfig;
        public Musica(LampClient lampClient, AppConfig appConfig, Analyzer analyzer)
        {
            _lampClient = lampClient;
            _appConfig = appConfig;
            _analyzer = analyzer;
            InitializeComponent();

            String[] deviceListArray = new String[_analyzer._devicelist.Count];
            _analyzer._devicelist.Values.CopyTo(deviceListArray, 0);

            comboBox1.Items.AddRange(deviceListArray);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Btn_Enable.Text == "Enable")
            {
                _analyzer.selectedIndex = _analyzer._devicelist.Where(item => item.Value == comboBox1.SelectedItem.ToString()).FirstOrDefault().Key;
                _analyzer.Enable = true;
                _analyzer.DisplayEnable = true;
                Btn_Enable.Text = "Disable";
                comboBox1.Enabled = false;
            }
            else
            {
                _analyzer.Enable = false;
                _analyzer.DisplayEnable = false;
                Btn_Enable.Text = "Enable";
                comboBox1.Enabled = true;
            }
        }
    }
}
