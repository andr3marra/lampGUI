namespace lampGUI {
    partial class MainWindow {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection4 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlConfiguracoes = new System.Windows.Forms.Panel();
            this.btnConfig = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.btnScreen = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlMusica = new System.Windows.Forms.Panel();
            this.btnMusic = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlCores = new System.Windows.Forms.Panel();
            this.btnColors = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tgOnOff = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.bntClose = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlLateral.SuspendLayout();
            this.pnlConfiguracoes.SuspendLayout();
            this.pnlTela.SuspendLayout();
            this.pnlMusica.SuspendLayout();
            this.pnlCores.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgOnOff)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlLateral.Controls.Add(this.pnlConfiguracoes);
            this.pnlLateral.Controls.Add(this.pnlTela);
            this.pnlLateral.Controls.Add(this.pnlMusica);
            this.pnlLateral.Controls.Add(this.pnlCores);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(200, 600);
            this.pnlLateral.TabIndex = 4;
            // 
            // pnlConfiguracoes
            // 
            this.pnlConfiguracoes.Controls.Add(this.btnConfig);
            this.pnlConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguracoes.Location = new System.Drawing.Point(0, 500);
            this.pnlConfiguracoes.Name = "pnlConfiguracoes";
            this.pnlConfiguracoes.Size = new System.Drawing.Size(200, 100);
            this.pnlConfiguracoes.TabIndex = 4;
            // 
            // btnConfig
            // 
            this.btnConfig.AccessibleName = "Button";
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfig.Location = new System.Drawing.Point(0, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(200, 100);
            this.btnConfig.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnConfig.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfig.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnConfig.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnConfig.TabIndex = 8;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pnlTela
            // 
            this.pnlTela.Controls.Add(this.btnScreen);
            this.pnlTela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTela.Location = new System.Drawing.Point(0, 400);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(200, 100);
            this.pnlTela.TabIndex = 3;
            // 
            // btnScreen
            // 
            this.btnScreen.AccessibleName = "Button";
            this.btnScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScreen.Location = new System.Drawing.Point(0, 0);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(200, 100);
            this.btnScreen.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnScreen.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScreen.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnScreen.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnScreen.TabIndex = 7;
            this.btnScreen.Text = "Tela";
            this.btnScreen.UseVisualStyleBackColor = false;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            // 
            // pnlMusica
            // 
            this.pnlMusica.Controls.Add(this.btnMusic);
            this.pnlMusica.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMusica.Location = new System.Drawing.Point(0, 300);
            this.pnlMusica.Name = "pnlMusica";
            this.pnlMusica.Size = new System.Drawing.Size(200, 100);
            this.pnlMusica.TabIndex = 2;
            // 
            // btnMusic
            // 
            this.btnMusic.AccessibleName = "Button";
            this.btnMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMusic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMusic.Location = new System.Drawing.Point(0, 0);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(200, 100);
            this.btnMusic.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMusic.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMusic.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnMusic.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnMusic.TabIndex = 6;
            this.btnMusic.Text = "Música";
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // pnlCores
            // 
            this.pnlCores.Controls.Add(this.btnColors);
            this.pnlCores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCores.Location = new System.Drawing.Point(0, 200);
            this.pnlCores.Name = "pnlCores";
            this.pnlCores.Size = new System.Drawing.Size(200, 100);
            this.pnlCores.TabIndex = 1;
            this.pnlCores.Tag = "";
            // 
            // btnColors
            // 
            this.btnColors.AccessibleName = "Button";
            this.btnColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnColors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColors.Location = new System.Drawing.Point(0, 0);
            this.btnColors.Name = "btnColors";
            this.btnColors.Size = new System.Drawing.Size(200, 100);
            this.btnColors.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnColors.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColors.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnColors.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnColors.TabIndex = 5;
            this.btnColors.Text = "Cores";
            this.btnColors.UseVisualStyleBackColor = false;
            this.btnColors.Click += new System.EventHandler(this.btnCores_Click_1);
            this.btnColors.Enter += new System.EventHandler(this.btnCores_Enter);
            this.btnColors.Leave += new System.EventHandler(this.btnCores_Leave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Controls.Add(this.panel1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 200);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::lampGUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 603);
            this.panel1.TabIndex = 15;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.pnlLeft.Location = new System.Drawing.Point(0, 150);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(21, 100);
            this.pnlLeft.TabIndex = 5;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.tgOnOff);
            this.panel2.Controls.Add(this.bntClose);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 50);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Location = new System.Drawing.Point(630, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // tgOnOff
            // 
            this.tgOnOff.DisplayMode = Syncfusion.Windows.Forms.Tools.DisplayType.Image;
            this.tgOnOff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tgOnOff.ForeColor = System.Drawing.Color.Black;
            this.tgOnOff.Location = new System.Drawing.Point(643, 64);
            this.tgOnOff.MinimumSize = new System.Drawing.Size(52, 20);
            this.tgOnOff.Name = "tgOnOff";
            this.tgOnOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tgOnOff.Size = new System.Drawing.Size(52, 30);
            this.tgOnOff.Slider = sliderCollection4;
            this.tgOnOff.TabIndex = 1;
            this.tgOnOff.Text = "toggleButton1";
            this.tgOnOff.ThemeName = "Office2016Colorful";
            this.tgOnOff.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            this.tgOnOff.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016Colorful;
            this.tgOnOff.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.tgOnOff_ToggleStateChanged);
            // 
            // bntClose
            // 
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntClose.Location = new System.Drawing.Point(662, 12);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(26, 26);
            this.bntClose.TabIndex = 0;
            this.bntClose.Text = "X";
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelChildForm.Controls.Add(this.pnlLeft);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(200, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 550);
            this.panelChildForm.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ledGUI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlConfiguracoes.ResumeLayout(false);
            this.pnlTela.ResumeLayout(false);
            this.pnlMusica.ResumeLayout(false);
            this.pnlCores.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tgOnOff)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlConfiguracoes;
        private System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.Panel pnlMusica;
        private System.Windows.Forms.Panel pnlCores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntClose;
        private Syncfusion.Windows.Forms.Tools.ToggleButton tgOnOff;
        private Syncfusion.WinForms.Controls.SfButton btnColors;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnMinimize;
        private Syncfusion.WinForms.Controls.SfButton btnMusic;
        private Syncfusion.WinForms.Controls.SfButton btnConfig;
        private Syncfusion.WinForms.Controls.SfButton btnScreen;
    }
}

