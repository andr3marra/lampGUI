namespace lampGUI
{
    partial class UmaCor
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
            this.cwUmaCor = new Cyotek.Windows.Forms.ColorWheel();
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
            this.panel1.Controls.Add(this.cwUmaCor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 550);
            this.panel1.TabIndex = 6;
            // 
            // cwUmaCor
            // 
            this.cwUmaCor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cwUmaCor.Location = new System.Drawing.Point(209, 123);
            this.cwUmaCor.Name = "cwUmaCor";
            this.cwUmaCor.Size = new System.Drawing.Size(241, 268);
            this.cwUmaCor.TabIndex = 3;
            this.cwUmaCor.ColorChanged += new System.EventHandler(this.cwUmaCor_ColorChanged);
            // 
            // btnSolido
            // 
            this.btnSolido.Location = new System.Drawing.Point(137, 445);
            this.btnSolido.Name = "btnSolido";
            this.btnSolido.Size = new System.Drawing.Size(75, 23);
            this.btnSolido.TabIndex = 16;
            this.btnSolido.Text = "Sólido";
            this.btnSolido.UseVisualStyleBackColor = true;
            this.btnSolido.Click += new System.EventHandler(this.btnSolido_Click);
            // 
            // btnBreath
            // 
            this.btnBreath.Location = new System.Drawing.Point(314, 445);
            this.btnBreath.Name = "btnBreath";
            this.btnBreath.Size = new System.Drawing.Size(75, 23);
            this.btnBreath.TabIndex = 17;
            this.btnBreath.Text = "Pulsar";
            this.btnBreath.UseVisualStyleBackColor = true;
            this.btnBreath.Click += new System.EventHandler(this.btnPulsar_Click);
            // 
            // btnWave
            // 
            this.btnWave.Location = new System.Drawing.Point(489, 445);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(75, 23);
            this.btnWave.TabIndex = 18;
            this.btnWave.Text = "Onda";
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // UmaCor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UmaCor";
            this.Text = "Cores";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Cyotek.Windows.Forms.ColorWheel cwUmaCor;
        private System.Windows.Forms.Button btnSolido;
        private System.Windows.Forms.Button btnBreath;
        private System.Windows.Forms.Button btnWave;
    }
}