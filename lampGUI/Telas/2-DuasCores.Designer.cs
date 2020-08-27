namespace lampGUI
{
    partial class DuasCores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.tbFrequencia = new System.Windows.Forms.TrackBar();
            this.lblBrilho = new System.Windows.Forms.Label();
            this.tbBrilho = new System.Windows.Forms.TrackBar();
            this.btnWave = new System.Windows.Forms.Button();
            this.btnBreath = new System.Windows.Forms.Button();
            this.btnSolido = new System.Windows.Forms.Button();
            this.cwDuasCores2 = new Cyotek.Windows.Forms.ColorWheel();
            this.cwDuasCores1 = new Cyotek.Windows.Forms.ColorWheel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.lblFrequencia);
            this.panel1.Controls.Add(this.tbFrequencia);
            this.panel1.Controls.Add(this.lblBrilho);
            this.panel1.Controls.Add(this.tbBrilho);
            this.panel1.Controls.Add(this.btnWave);
            this.panel1.Controls.Add(this.btnBreath);
            this.panel1.Controls.Add(this.btnSolido);
            this.panel1.Controls.Add(this.cwDuasCores2);
            this.panel1.Controls.Add(this.cwDuasCores1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 500);
            this.panel1.TabIndex = 7;
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFrequencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrequencia.Location = new System.Drawing.Point(315, 391);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(69, 15);
            this.lblFrequencia.TabIndex = 26;
            this.lblFrequencia.Text = "Frequência";
            // 
            // tbFrequencia
            // 
            this.tbFrequencia.AutoSize = false;
            this.tbFrequencia.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFrequencia.Location = new System.Drawing.Point(233, 373);
            this.tbFrequencia.Maximum = 5000;
            this.tbFrequencia.Minimum = 200;
            this.tbFrequencia.Name = "tbFrequencia";
            this.tbFrequencia.Size = new System.Drawing.Size(232, 45);
            this.tbFrequencia.TabIndex = 25;
            this.tbFrequencia.TickFrequency = 100;
            this.tbFrequencia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbFrequencia.Value = 200;
            // 
            // lblBrilho
            // 
            this.lblBrilho.AutoSize = true;
            this.lblBrilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBrilho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrilho.Location = new System.Drawing.Point(330, 438);
            this.lblBrilho.Name = "lblBrilho";
            this.lblBrilho.Size = new System.Drawing.Size(39, 15);
            this.lblBrilho.TabIndex = 24;
            this.lblBrilho.Text = "Brilho";
            // 
            // tbBrilho
            // 
            this.tbBrilho.AutoSize = false;
            this.tbBrilho.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbBrilho.Location = new System.Drawing.Point(233, 421);
            this.tbBrilho.Maximum = 255;
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.Size = new System.Drawing.Size(232, 45);
            this.tbBrilho.TabIndex = 23;
            this.tbBrilho.TickFrequency = 100;
            this.tbBrilho.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBrilho.Scroll += new System.EventHandler(this.tbBrilho_Scroll);
            // 
            // btnWave
            // 
            this.btnWave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.btnWave.FlatAppearance.BorderSize = 0;
            this.btnWave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnWave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWave.Location = new System.Drawing.Point(470, 335);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(97, 32);
            this.btnWave.TabIndex = 17;
            this.btnWave.Text = "Onda";
            this.btnWave.UseVisualStyleBackColor = false;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // btnBreath
            // 
            this.btnBreath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.btnBreath.FlatAppearance.BorderSize = 0;
            this.btnBreath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBreath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBreath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBreath.Location = new System.Drawing.Point(300, 335);
            this.btnBreath.Name = "btnBreath";
            this.btnBreath.Size = new System.Drawing.Size(97, 32);
            this.btnBreath.TabIndex = 16;
            this.btnBreath.Text = "Pulsar";
            this.btnBreath.UseVisualStyleBackColor = false;
            this.btnBreath.Click += new System.EventHandler(this.btnBreath_Click);
            // 
            // btnSolido
            // 
            this.btnSolido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.btnSolido.FlatAppearance.BorderSize = 0;
            this.btnSolido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSolido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolido.Location = new System.Drawing.Point(130, 335);
            this.btnSolido.Name = "btnSolido";
            this.btnSolido.Size = new System.Drawing.Size(97, 32);
            this.btnSolido.TabIndex = 15;
            this.btnSolido.Text = "Sólido";
            this.btnSolido.UseVisualStyleBackColor = false;
            this.btnSolido.Click += new System.EventHandler(this.btnSolido_Click_1);
            // 
            // cwDuasCores2
            // 
            this.cwDuasCores2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cwDuasCores2.Location = new System.Drawing.Point(404, 50);
            this.cwDuasCores2.Name = "cwDuasCores2";
            this.cwDuasCores2.Size = new System.Drawing.Size(241, 268);
            this.cwDuasCores2.TabIndex = 14;
            this.cwDuasCores2.ColorChanged += new System.EventHandler(this.cwDuasCores2_ColorChanged);
            // 
            // cwDuasCores1
            // 
            this.cwDuasCores1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cwDuasCores1.Location = new System.Drawing.Point(55, 50);
            this.cwDuasCores1.Name = "cwDuasCores1";
            this.cwDuasCores1.Size = new System.Drawing.Size(241, 268);
            this.cwDuasCores1.TabIndex = 3;
            this.cwDuasCores1.ColorChanged += new System.EventHandler(this.cwDuasCores1_ColorChanged);
            // 
            // DuasCores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuasCores";
            this.Text = "DuasCores";
            this.Load += new System.EventHandler(this.DuasCores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Cyotek.Windows.Forms.ColorWheel cwDuasCores2;
        private Cyotek.Windows.Forms.ColorWheel cwDuasCores1;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.Button btnBreath;
        private System.Windows.Forms.Button btnSolido;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.TrackBar tbFrequencia;
        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.TrackBar tbBrilho;
    }
}