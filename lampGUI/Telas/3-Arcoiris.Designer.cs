namespace lampGUI.Telas {
    partial class _3_Arcoiris {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3_Arcoiris));
            this.lblBrilho = new System.Windows.Forms.Label();
            this.tbBrilho = new System.Windows.Forms.TrackBar();
            this.btnArcoIris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrilho
            // 
            this.lblBrilho.AutoSize = true;
            this.lblBrilho.Location = new System.Drawing.Point(334, 409);
            this.lblBrilho.Name = "lblBrilho";
            this.lblBrilho.Size = new System.Drawing.Size(33, 13);
            this.lblBrilho.TabIndex = 22;
            this.lblBrilho.Text = "Brilho";
            this.lblBrilho.Click += new System.EventHandler(this.lblBrilho_Click);
            // 
            // tbBrilho
            // 
            this.tbBrilho.AutoSize = false;
            this.tbBrilho.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbBrilho.Location = new System.Drawing.Point(272, 392);
            this.tbBrilho.Maximum = 100;
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.Size = new System.Drawing.Size(146, 45);
            this.tbBrilho.TabIndex = 21;
            this.tbBrilho.TickFrequency = 100;
            this.tbBrilho.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnArcoIris
            // 
            this.btnArcoIris.Location = new System.Drawing.Point(317, 77);
            this.btnArcoIris.Name = "btnArcoIris";
            this.btnArcoIris.Size = new System.Drawing.Size(75, 23);
            this.btnArcoIris.TabIndex = 23;
            this.btnArcoIris.Text = "Arco Íris";
            this.btnArcoIris.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 210);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // _3_Arcoiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnArcoIris);
            this.Controls.Add(this.lblBrilho);
            this.Controls.Add(this.tbBrilho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_3_Arcoiris";
            this.Text = "_3_Arcoiris";
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.TrackBar tbBrilho;
        private System.Windows.Forms.Button btnArcoIris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}