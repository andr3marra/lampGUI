namespace lampGUI {
    partial class Form1 {
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnCores = new System.Windows.Forms.Panel();
            this.btnMusica = new System.Windows.Forms.Panel();
            this.btnTela = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new System.Windows.Forms.Panel();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblMusica = new System.Windows.Forms.Label();
            this.lblTela = new System.Windows.Forms.Label();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.Cores = new System.Windows.Forms.Panel();
            this.colorWheel2 = new Cyotek.Windows.Forms.ColorWheel();
            this.btnSolido = new System.Windows.Forms.Panel();
            this.btnPulsar = new System.Windows.Forms.Panel();
            this.btnOndas = new System.Windows.Forms.Panel();
            this.btnCor1 = new System.Windows.Forms.Panel();
            this.btnCor2 = new System.Windows.Forms.Panel();
            this.btnCor3 = new System.Windows.Forms.Panel();
            this.btnCor4 = new System.Windows.Forms.Panel();
            this.btnCor8 = new System.Windows.Forms.Panel();
            this.btnCor7 = new System.Windows.Forms.Panel();
            this.btnCor6 = new System.Windows.Forms.Panel();
            this.btnCor5 = new System.Windows.Forms.Panel();
            this.lblSolido = new System.Windows.Forms.Label();
            this.lblPulsar = new System.Windows.Forms.Label();
            this.lblOndas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DuasCores = new System.Windows.Forms.Panel();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.colorWheel3 = new Cyotek.Windows.Forms.ColorWheel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlLateral.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.btnCores.SuspendLayout();
            this.btnMusica.SuspendLayout();
            this.btnTela.SuspendLayout();
            this.btnConfiguracoes.SuspendLayout();
            this.Cores.SuspendLayout();
            this.btnSolido.SuspendLayout();
            this.btnPulsar.SuspendLayout();
            this.btnOndas.SuspendLayout();
            this.DuasCores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.btnConfiguracoes);
            this.pnlLateral.Controls.Add(this.btnTela);
            this.pnlLateral.Controls.Add(this.btnMusica);
            this.pnlLateral.Controls.Add(this.btnCores);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(200, 601);
            this.pnlLateral.TabIndex = 4;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.DuasCores);
            this.pnlLogo.Controls.Add(this.panel1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 203);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnCores
            // 
            this.btnCores.Controls.Add(this.lblCores);
            this.btnCores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCores.Location = new System.Drawing.Point(0, 203);
            this.btnCores.Name = "btnCores";
            this.btnCores.Size = new System.Drawing.Size(200, 100);
            this.btnCores.TabIndex = 1;
            this.btnCores.Tag = "";
            // 
            // btnMusica
            // 
            this.btnMusica.Controls.Add(this.lblMusica);
            this.btnMusica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusica.Location = new System.Drawing.Point(0, 303);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(200, 100);
            this.btnMusica.TabIndex = 2;
            // 
            // btnTela
            // 
            this.btnTela.Controls.Add(this.lblTela);
            this.btnTela.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTela.Location = new System.Drawing.Point(0, 403);
            this.btnTela.Name = "btnTela";
            this.btnTela.Size = new System.Drawing.Size(200, 100);
            this.btnTela.TabIndex = 3;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Controls.Add(this.lblConfiguracoes);
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 503);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(200, 100);
            this.btnConfiguracoes.TabIndex = 4;
            // 
            // lblCores
            // 
            this.lblCores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(83, 46);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(34, 13);
            this.lblCores.TabIndex = 0;
            this.lblCores.Text = "Cores";
            // 
            // lblMusica
            // 
            this.lblMusica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMusica.AutoSize = true;
            this.lblMusica.Location = new System.Drawing.Point(83, 44);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(41, 13);
            this.lblMusica.TabIndex = 1;
            this.lblMusica.Text = "Música";
            // 
            // lblTela
            // 
            this.lblTela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(83, 44);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(28, 13);
            this.lblTela.TabIndex = 1;
            this.lblTela.Text = "Tela";
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblConfiguracoes.Location = new System.Drawing.Point(65, 43);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(75, 13);
            this.lblConfiguracoes.TabIndex = 1;
            this.lblConfiguracoes.Text = "Configurações";
            this.lblConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cores
            // 
            this.Cores.Controls.Add(this.btnCor8);
            this.Cores.Controls.Add(this.btnCor7);
            this.Cores.Controls.Add(this.btnCor6);
            this.Cores.Controls.Add(this.btnCor5);
            this.Cores.Controls.Add(this.btnCor4);
            this.Cores.Controls.Add(this.btnCor3);
            this.Cores.Controls.Add(this.btnCor2);
            this.Cores.Controls.Add(this.btnCor1);
            this.Cores.Controls.Add(this.btnOndas);
            this.Cores.Controls.Add(this.btnPulsar);
            this.Cores.Controls.Add(this.btnSolido);
            this.Cores.Controls.Add(this.colorWheel2);
            this.Cores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cores.Location = new System.Drawing.Point(200, 0);
            this.Cores.Name = "Cores";
            this.Cores.Size = new System.Drawing.Size(1058, 601);
            this.Cores.TabIndex = 5;
            this.Cores.Visible = false;
            // 
            // colorWheel2
            // 
            this.colorWheel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel2.Location = new System.Drawing.Point(209, 123);
            this.colorWheel2.Name = "colorWheel2";
            this.colorWheel2.Size = new System.Drawing.Size(241, 268);
            this.colorWheel2.TabIndex = 3;
            // 
            // btnSolido
            // 
            this.btnSolido.Controls.Add(this.lblSolido);
            this.btnSolido.Location = new System.Drawing.Point(92, 437);
            this.btnSolido.Name = "btnSolido";
            this.btnSolido.Size = new System.Drawing.Size(138, 38);
            this.btnSolido.TabIndex = 4;
            // 
            // btnPulsar
            // 
            this.btnPulsar.Controls.Add(this.lblPulsar);
            this.btnPulsar.Location = new System.Drawing.Point(255, 437);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(138, 38);
            this.btnPulsar.TabIndex = 5;
            // 
            // btnOndas
            // 
            this.btnOndas.Controls.Add(this.lblOndas);
            this.btnOndas.Location = new System.Drawing.Point(413, 437);
            this.btnOndas.Name = "btnOndas";
            this.btnOndas.Size = new System.Drawing.Size(138, 38);
            this.btnOndas.TabIndex = 5;
            // 
            // btnCor1
            // 
            this.btnCor1.Location = new System.Drawing.Point(749, 79);
            this.btnCor1.Name = "btnCor1";
            this.btnCor1.Size = new System.Drawing.Size(138, 38);
            this.btnCor1.TabIndex = 6;
            // 
            // btnCor2
            // 
            this.btnCor2.Location = new System.Drawing.Point(749, 123);
            this.btnCor2.Name = "btnCor2";
            this.btnCor2.Size = new System.Drawing.Size(138, 38);
            this.btnCor2.TabIndex = 7;
            // 
            // btnCor3
            // 
            this.btnCor3.Location = new System.Drawing.Point(749, 167);
            this.btnCor3.Name = "btnCor3";
            this.btnCor3.Size = new System.Drawing.Size(138, 38);
            this.btnCor3.TabIndex = 8;
            // 
            // btnCor4
            // 
            this.btnCor4.Location = new System.Drawing.Point(749, 211);
            this.btnCor4.Name = "btnCor4";
            this.btnCor4.Size = new System.Drawing.Size(138, 38);
            this.btnCor4.TabIndex = 9;
            // 
            // btnCor8
            // 
            this.btnCor8.Location = new System.Drawing.Point(884, 211);
            this.btnCor8.Name = "btnCor8";
            this.btnCor8.Size = new System.Drawing.Size(138, 38);
            this.btnCor8.TabIndex = 13;
            // 
            // btnCor7
            // 
            this.btnCor7.Location = new System.Drawing.Point(884, 167);
            this.btnCor7.Name = "btnCor7";
            this.btnCor7.Size = new System.Drawing.Size(138, 38);
            this.btnCor7.TabIndex = 12;
            // 
            // btnCor6
            // 
            this.btnCor6.Location = new System.Drawing.Point(884, 123);
            this.btnCor6.Name = "btnCor6";
            this.btnCor6.Size = new System.Drawing.Size(138, 38);
            this.btnCor6.TabIndex = 11;
            // 
            // btnCor5
            // 
            this.btnCor5.Location = new System.Drawing.Point(884, 79);
            this.btnCor5.Name = "btnCor5";
            this.btnCor5.Size = new System.Drawing.Size(138, 38);
            this.btnCor5.TabIndex = 10;
            // 
            // lblSolido
            // 
            this.lblSolido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSolido.AutoSize = true;
            this.lblSolido.Location = new System.Drawing.Point(55, 13);
            this.lblSolido.Name = "lblSolido";
            this.lblSolido.Size = new System.Drawing.Size(36, 13);
            this.lblSolido.TabIndex = 2;
            this.lblSolido.Text = "Sólido";
            // 
            // lblPulsar
            // 
            this.lblPulsar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPulsar.AutoSize = true;
            this.lblPulsar.Location = new System.Drawing.Point(55, 13);
            this.lblPulsar.Name = "lblPulsar";
            this.lblPulsar.Size = new System.Drawing.Size(36, 13);
            this.lblPulsar.TabIndex = 2;
            this.lblPulsar.Text = "Pulsar";
            this.lblPulsar.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblOndas
            // 
            this.lblOndas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOndas.AutoSize = true;
            this.lblOndas.Location = new System.Drawing.Point(51, 13);
            this.lblOndas.Name = "lblOndas";
            this.lblOndas.Size = new System.Drawing.Size(38, 13);
            this.lblOndas.TabIndex = 3;
            this.lblOndas.Text = "Ondas";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 603);
            this.panel1.TabIndex = 15;
            // 
            // DuasCores
            // 
            this.DuasCores.Controls.Add(this.colorWheel3);
            this.DuasCores.Controls.Add(this.colorWheel1);
            this.DuasCores.Location = new System.Drawing.Point(200, 1);
            this.DuasCores.Name = "DuasCores";
            this.DuasCores.Size = new System.Drawing.Size(1058, 600);
            this.DuasCores.TabIndex = 14;
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(105, 67);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(241, 268);
            this.colorWheel1.TabIndex = 4;
            // 
            // colorWheel3
            // 
            this.colorWheel3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel3.Location = new System.Drawing.Point(605, 79);
            this.colorWheel3.Name = "colorWheel3";
            this.colorWheel3.Size = new System.Drawing.Size(241, 268);
            this.colorWheel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1258, 601);
            this.Controls.Add(this.Cores);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.pnlLateral.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.btnCores.ResumeLayout(false);
            this.btnCores.PerformLayout();
            this.btnMusica.ResumeLayout(false);
            this.btnMusica.PerformLayout();
            this.btnTela.ResumeLayout(false);
            this.btnTela.PerformLayout();
            this.btnConfiguracoes.ResumeLayout(false);
            this.btnConfiguracoes.PerformLayout();
            this.Cores.ResumeLayout(false);
            this.btnSolido.ResumeLayout(false);
            this.btnSolido.PerformLayout();
            this.btnPulsar.ResumeLayout(false);
            this.btnPulsar.PerformLayout();
            this.btnOndas.ResumeLayout(false);
            this.btnOndas.PerformLayout();
            this.DuasCores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel btnConfiguracoes;
        private System.Windows.Forms.Panel btnTela;
        private System.Windows.Forms.Panel btnMusica;
        private System.Windows.Forms.Panel btnCores;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Panel Cores;
        private System.Windows.Forms.Panel btnCor8;
        private System.Windows.Forms.Panel btnCor7;
        private System.Windows.Forms.Panel btnCor6;
        private System.Windows.Forms.Panel btnCor5;
        private System.Windows.Forms.Panel btnCor4;
        private System.Windows.Forms.Panel btnCor3;
        private System.Windows.Forms.Panel btnCor2;
        private System.Windows.Forms.Panel btnCor1;
        private System.Windows.Forms.Panel btnOndas;
        private System.Windows.Forms.Panel btnPulsar;
        private System.Windows.Forms.Label lblPulsar;
        private System.Windows.Forms.Panel btnSolido;
        private System.Windows.Forms.Label lblSolido;
        private Cyotek.Windows.Forms.ColorWheel colorWheel2;
        private System.Windows.Forms.Label lblOndas;
        private System.Windows.Forms.Panel DuasCores;
        private Cyotek.Windows.Forms.ColorWheel colorWheel3;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

