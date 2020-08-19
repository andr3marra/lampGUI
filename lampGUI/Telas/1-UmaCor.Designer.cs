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
            this.btnOndas = new System.Windows.Forms.Panel();
            this.lblOndas = new System.Windows.Forms.Label();
            this.btnPulsar = new System.Windows.Forms.Panel();
            this.lblPulsar = new System.Windows.Forms.Label();
            this.btnSolido = new System.Windows.Forms.Panel();
            this.lblSolido = new System.Windows.Forms.Label();
            this.cwUmaCor = new Cyotek.Windows.Forms.ColorWheel();
            this.panel1.SuspendLayout();
            this.btnOndas.SuspendLayout();
            this.btnPulsar.SuspendLayout();
            this.btnSolido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.btnOndas);
            this.panel1.Controls.Add(this.btnPulsar);
            this.panel1.Controls.Add(this.btnSolido);
            this.panel1.Controls.Add(this.cwUmaCor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 550);
            this.panel1.TabIndex = 6;
            // 
            // btnOndas
            // 
            this.btnOndas.Controls.Add(this.lblOndas);
            this.btnOndas.Location = new System.Drawing.Point(413, 437);
            this.btnOndas.Name = "btnOndas";
            this.btnOndas.Size = new System.Drawing.Size(138, 38);
            this.btnOndas.TabIndex = 5;
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
            // btnPulsar
            // 
            this.btnPulsar.Controls.Add(this.lblPulsar);
            this.btnPulsar.Location = new System.Drawing.Point(255, 437);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(138, 38);
            this.btnPulsar.TabIndex = 5;
            this.btnPulsar.Click += new System.EventHandler(this.btnPulsar_Click);
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
            // 
            // btnSolido
            // 
            this.btnSolido.Controls.Add(this.lblSolido);
            this.btnSolido.Location = new System.Drawing.Point(92, 437);
            this.btnSolido.Name = "btnSolido";
            this.btnSolido.Size = new System.Drawing.Size(138, 38);
            this.btnSolido.TabIndex = 4;
            this.btnSolido.Click += new System.EventHandler(this.btnSolido_Click);
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
            // cwUmaCor
            // 
            this.cwUmaCor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cwUmaCor.Location = new System.Drawing.Point(209, 123);
            this.cwUmaCor.Name = "cwUmaCor";
            this.cwUmaCor.Size = new System.Drawing.Size(241, 268);
            this.cwUmaCor.TabIndex = 3;
            this.cwUmaCor.ColorChanged += new System.EventHandler(this.cwUmaCor_ColorChanged);
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
            this.btnOndas.ResumeLayout(false);
            this.btnOndas.PerformLayout();
            this.btnPulsar.ResumeLayout(false);
            this.btnPulsar.PerformLayout();
            this.btnSolido.ResumeLayout(false);
            this.btnSolido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnOndas;
        private System.Windows.Forms.Label lblOndas;
        private System.Windows.Forms.Panel btnPulsar;
        private System.Windows.Forms.Label lblPulsar;
        private System.Windows.Forms.Panel btnSolido;
        private System.Windows.Forms.Label lblSolido;
        private Cyotek.Windows.Forms.ColorWheel cwUmaCor;
    }
}