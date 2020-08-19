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
            this.cwDuasCores2 = new Cyotek.Windows.Forms.ColorWheel();
            this.cwDuasCores1 = new Cyotek.Windows.Forms.ColorWheel();
            this.btnSolido = new System.Windows.Forms.Button();
            this.btnBreath = new System.Windows.Forms.Button();
            this.btnWave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.btnWave);
            this.panel1.Controls.Add(this.btnBreath);
            this.panel1.Controls.Add(this.btnSolido);
            this.panel1.Controls.Add(this.cwDuasCores2);
            this.panel1.Controls.Add(this.cwDuasCores1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 550);
            this.panel1.TabIndex = 7;
            // 
            // cwDuasCores2
            // 
            this.cwDuasCores2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cwDuasCores2.Location = new System.Drawing.Point(391, 62);
            this.cwDuasCores2.Name = "cwDuasCores2";
            this.cwDuasCores2.Size = new System.Drawing.Size(241, 268);
            this.cwDuasCores2.TabIndex = 14;
            this.cwDuasCores2.ColorChanged += new System.EventHandler(this.cwDuasCores2_ColorChanged);
            // 
            // cwDuasCores1
            // 
            this.cwDuasCores1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cwDuasCores1.Location = new System.Drawing.Point(56, 62);
            this.cwDuasCores1.Name = "cwDuasCores1";
            this.cwDuasCores1.Size = new System.Drawing.Size(241, 268);
            this.cwDuasCores1.TabIndex = 3;
            this.cwDuasCores1.ColorChanged += new System.EventHandler(this.cwDuasCores1_ColorChanged);
            // 
            // btnSolido
            // 
            this.btnSolido.Location = new System.Drawing.Point(155, 402);
            this.btnSolido.Name = "btnSolido";
            this.btnSolido.Size = new System.Drawing.Size(75, 23);
            this.btnSolido.TabIndex = 15;
            this.btnSolido.Text = "Sólido";
            this.btnSolido.UseVisualStyleBackColor = true;
            this.btnSolido.Click += new System.EventHandler(this.btnSolido_Click_1);
            // 
            // btnBreath
            // 
            this.btnBreath.Location = new System.Drawing.Point(330, 402);
            this.btnBreath.Name = "btnBreath";
            this.btnBreath.Size = new System.Drawing.Size(75, 23);
            this.btnBreath.TabIndex = 16;
            this.btnBreath.Text = "Pulsar";
            this.btnBreath.UseVisualStyleBackColor = true;
            this.btnBreath.Click += new System.EventHandler(this.btnBreath_Click);
            // 
            // btnWave
            // 
            this.btnWave.Location = new System.Drawing.Point(480, 402);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(75, 23);
            this.btnWave.TabIndex = 17;
            this.btnWave.Text = "Onda";
            this.btnWave.UseVisualStyleBackColor = true;
            // 
            // DuasCores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuasCores";
            this.Text = "DuasCores";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Cyotek.Windows.Forms.ColorWheel cwDuasCores2;
        private Cyotek.Windows.Forms.ColorWheel cwDuasCores1;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.Button btnBreath;
        private System.Windows.Forms.Button btnSolido;
    }
}