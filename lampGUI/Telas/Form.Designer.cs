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
            this.pnlConfiguracoes = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.btnTela = new System.Windows.Forms.Button();
            this.pnlMusica = new System.Windows.Forms.Panel();
            this.btnMusica = new System.Windows.Forms.Button();
            this.pnlCores = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnCores = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.DuasCores = new System.Windows.Forms.Panel();
            this.colorWheel3 = new Cyotek.Windows.Forms.ColorWheel();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnlLateral.SuspendLayout();
            this.pnlConfiguracoes.SuspendLayout();
            this.pnlTela.SuspendLayout();
            this.pnlMusica.SuspendLayout();
            this.pnlCores.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.DuasCores.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pnlLateral.Location = new System.Drawing.Point(0, 100);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(200, 550);
            this.pnlLateral.TabIndex = 4;
            // 
            // pnlConfiguracoes
            // 
            this.pnlConfiguracoes.Controls.Add(this.btnConfiguracoes);
            this.pnlConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguracoes.Location = new System.Drawing.Point(0, 384);
            this.pnlConfiguracoes.Name = "pnlConfiguracoes";
            this.pnlConfiguracoes.Size = new System.Drawing.Size(200, 100);
            this.pnlConfiguracoes.TabIndex = 4;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(200, 100);
            this.btnConfiguracoes.TabIndex = 3;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // pnlTela
            // 
            this.pnlTela.Controls.Add(this.btnTela);
            this.pnlTela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTela.Location = new System.Drawing.Point(0, 284);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(200, 100);
            this.pnlTela.TabIndex = 3;
            // 
            // btnTela
            // 
            this.btnTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTela.FlatAppearance.BorderSize = 0;
            this.btnTela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTela.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnTela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTela.Location = new System.Drawing.Point(0, 0);
            this.btnTela.Name = "btnTela";
            this.btnTela.Size = new System.Drawing.Size(200, 100);
            this.btnTela.TabIndex = 2;
            this.btnTela.Text = "Tela";
            this.btnTela.UseVisualStyleBackColor = false;
            this.btnTela.Click += new System.EventHandler(this.btnTela_Click);
            // 
            // pnlMusica
            // 
            this.pnlMusica.Controls.Add(this.btnMusica);
            this.pnlMusica.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMusica.Location = new System.Drawing.Point(0, 184);
            this.pnlMusica.Name = "pnlMusica";
            this.pnlMusica.Size = new System.Drawing.Size(200, 100);
            this.pnlMusica.TabIndex = 2;
            // 
            // btnMusica
            // 
            this.btnMusica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMusica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMusica.FlatAppearance.BorderSize = 0;
            this.btnMusica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnMusica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMusica.Location = new System.Drawing.Point(0, 0);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(200, 100);
            this.btnMusica.TabIndex = 1;
            this.btnMusica.Text = "Música";
            this.btnMusica.UseVisualStyleBackColor = false;
            this.btnMusica.Click += new System.EventHandler(this.btnMusica_Click);
            // 
            // pnlCores
            // 
            this.pnlCores.Controls.Add(this.btnCores);
            this.pnlCores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCores.Location = new System.Drawing.Point(0, 84);
            this.pnlCores.Name = "pnlCores";
            this.pnlCores.Size = new System.Drawing.Size(200, 100);
            this.pnlCores.TabIndex = 1;
            this.pnlCores.Tag = "";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.pnlLeft.Location = new System.Drawing.Point(0, 84);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(21, 100);
            this.pnlLeft.TabIndex = 5;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // btnCores
            // 
            this.btnCores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCores.FlatAppearance.BorderSize = 0;
            this.btnCores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCores.Location = new System.Drawing.Point(0, 0);
            this.btnCores.Name = "btnCores";
            this.btnCores.Size = new System.Drawing.Size(200, 100);
            this.btnCores.TabIndex = 0;
            this.btnCores.Text = "Cores";
            this.btnCores.UseVisualStyleBackColor = false;
            this.btnCores.Click += new System.EventHandler(this.btnCores_Click_1);
            this.btnCores.Enter += new System.EventHandler(this.btnCores_Enter);
            this.btnCores.Leave += new System.EventHandler(this.btnCores_Leave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlLogo.Controls.Add(this.DuasCores);
            this.pnlLogo.Controls.Add(this.panel1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 84);
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
            this.panel1.Size = new System.Drawing.Size(700, 603);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.btnCloseWindow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 100);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(863, 10);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(25, 25);
            this.btnCloseWindow.TabIndex = 0;
            this.btnCloseWindow.Text = "X";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelChildForm.Controls.Add(this.pnlLeft);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(200, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 550);
            this.panelChildForm.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.pnlLateral.ResumeLayout(false);
            this.pnlConfiguracoes.ResumeLayout(false);
            this.pnlTela.ResumeLayout(false);
            this.pnlMusica.ResumeLayout(false);
            this.pnlCores.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.DuasCores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnTela;
        private System.Windows.Forms.Button btnMusica;
        private System.Windows.Forms.Button btnCores;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel DuasCores;
        private Cyotek.Windows.Forms.ColorWheel colorWheel3;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

