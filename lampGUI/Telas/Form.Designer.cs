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
            this.btnConfiguracoes = new System.Windows.Forms.Panel();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.btnTela = new System.Windows.Forms.Panel();
            this.lblTela = new System.Windows.Forms.Label();
            this.btnMusica = new System.Windows.Forms.Panel();
            this.lblMusica = new System.Windows.Forms.Label();
            this.btnCores = new System.Windows.Forms.Panel();
            this.lblCores = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.DuasCores = new System.Windows.Forms.Panel();
            this.colorWheel3 = new Cyotek.Windows.Forms.ColorWheel();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlLateral.SuspendLayout();
            this.btnConfiguracoes.SuspendLayout();
            this.btnTela.SuspendLayout();
            this.btnMusica.SuspendLayout();
            this.btnCores.SuspendLayout();
            this.pnlLogo.SuspendLayout();
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
            this.pnlLateral.Size = new System.Drawing.Size(200, 650);
            this.pnlLateral.TabIndex = 4;
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
            // btnTela
            // 
            this.btnTela.Controls.Add(this.lblTela);
            this.btnTela.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTela.Location = new System.Drawing.Point(0, 403);
            this.btnTela.Name = "btnTela";
            this.btnTela.Size = new System.Drawing.Size(200, 100);
            this.btnTela.TabIndex = 3;
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
            // btnMusica
            // 
            this.btnMusica.Controls.Add(this.lblMusica);
            this.btnMusica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusica.Location = new System.Drawing.Point(0, 303);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(200, 100);
            this.btnMusica.TabIndex = 2;
            this.btnMusica.Click += new System.EventHandler(this.btnMusica_Click);
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
            // btnCores
            // 
            this.btnCores.Controls.Add(this.lblCores);
            this.btnCores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCores.Location = new System.Drawing.Point(0, 203);
            this.btnCores.Name = "btnCores";
            this.btnCores.Size = new System.Drawing.Size(200, 100);
            this.btnCores.TabIndex = 1;
            this.btnCores.Tag = "";
            this.btnCores.Click += new System.EventHandler(this.btnCores_Click);
            this.btnCores.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCores_Paint);
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
            // DuasCores
            // 
            this.DuasCores.Controls.Add(this.colorWheel3);
            this.DuasCores.Controls.Add(this.colorWheel1);
            this.DuasCores.Location = new System.Drawing.Point(200, 1);
            this.DuasCores.Name = "DuasCores";
            this.DuasCores.Size = new System.Drawing.Size(1058, 600);
            this.DuasCores.TabIndex = 14;
            // 
            // colorWheel3
            // 
            this.colorWheel3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel3.Location = new System.Drawing.Point(605, 79);
            this.colorWheel3.Name = "colorWheel3";
            this.colorWheel3.Size = new System.Drawing.Size(241, 268);
            this.colorWheel3.TabIndex = 5;
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(105, 67);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(241, 268);
            this.colorWheel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 603);
            this.panel1.TabIndex = 15;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(200, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 550);
            this.panelChildForm.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 100);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.pnlLateral.ResumeLayout(false);
            this.btnConfiguracoes.ResumeLayout(false);
            this.btnConfiguracoes.PerformLayout();
            this.btnTela.ResumeLayout(false);
            this.btnTela.PerformLayout();
            this.btnMusica.ResumeLayout(false);
            this.btnMusica.PerformLayout();
            this.btnCores.ResumeLayout(false);
            this.btnCores.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
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
        private System.Windows.Forms.Panel DuasCores;
        private Cyotek.Windows.Forms.ColorWheel colorWheel3;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel2;
    }
}

