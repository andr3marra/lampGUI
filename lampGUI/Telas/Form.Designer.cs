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
            this.button4 = new System.Windows.Forms.Button();
            this.btnTela = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMusica = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlCores = new System.Windows.Forms.Panel();
            this.btnCores = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.DuasCores = new System.Windows.Forms.Panel();
            this.colorWheel3 = new Cyotek.Windows.Forms.ColorWheel();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            this.btnConfiguracoes.SuspendLayout();
            this.btnTela.SuspendLayout();
            this.btnMusica.SuspendLayout();
            this.pnlCores.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.DuasCores.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlLateral.Controls.Add(this.btnConfiguracoes);
            this.pnlLateral.Controls.Add(this.btnTela);
            this.pnlLateral.Controls.Add(this.btnMusica);
            this.pnlLateral.Controls.Add(this.pnlCores);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 100);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(200, 550);
            this.pnlLateral.TabIndex = 4;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Controls.Add(this.button4);
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 384);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(200, 100);
            this.btnConfiguracoes.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 100);
            this.button4.TabIndex = 3;
            this.button4.Text = "Configurações";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTela
            // 
            this.btnTela.Controls.Add(this.button3);
            this.btnTela.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTela.Location = new System.Drawing.Point(0, 284);
            this.btnTela.Name = "btnTela";
            this.btnTela.Size = new System.Drawing.Size(200, 100);
            this.btnTela.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tela";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMusica
            // 
            this.btnMusica.Controls.Add(this.button2);
            this.btnMusica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusica.Location = new System.Drawing.Point(0, 184);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(200, 100);
            this.btnMusica.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Música";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnMusica_Click);
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
            // btnCores
            // 
            this.btnCores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCores.FlatAppearance.BorderSize = 0;
            this.btnCores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
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
            this.panel1.Size = new System.Drawing.Size(1058, 603);
            this.panel1.TabIndex = 15;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(200, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 550);
            this.panelChildForm.TabIndex = 5;
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
            this.btnConfiguracoes.ResumeLayout(false);
            this.btnTela.ResumeLayout(false);
            this.btnMusica.ResumeLayout(false);
            this.pnlCores.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.DuasCores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel btnConfiguracoes;
        private System.Windows.Forms.Panel btnTela;
        private System.Windows.Forms.Panel btnMusica;
        private System.Windows.Forms.Panel pnlCores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCores;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel DuasCores;
        private Cyotek.Windows.Forms.ColorWheel colorWheel3;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private System.Windows.Forms.Panel panel1;
    }
}

