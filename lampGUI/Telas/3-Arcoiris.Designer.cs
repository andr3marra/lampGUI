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
            this.pbArcoIris = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArcoIris)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrilho
            // 
            this.lblBrilho.AutoSize = true;
            this.lblBrilho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lblBrilho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrilho.Location = new System.Drawing.Point(335, 391);
            this.lblBrilho.Name = "lblBrilho";
            this.lblBrilho.Size = new System.Drawing.Size(41, 14);
            this.lblBrilho.TabIndex = 22;
            this.lblBrilho.Text = "Brilho";
            this.lblBrilho.Click += new System.EventHandler(this.lblBrilho_Click);
            // 
            // tbBrilho
            // 
            this.tbBrilho.AutoSize = false;
            this.tbBrilho.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbBrilho.Location = new System.Drawing.Point(234, 372);
            this.tbBrilho.Maximum = 255;
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.Size = new System.Drawing.Size(232, 45);
            this.tbBrilho.TabIndex = 21;
            this.tbBrilho.TickFrequency = 100;
            this.tbBrilho.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBrilho.Scroll += new System.EventHandler(this.tbBrilho_Scroll);
            // 
            // btnArcoIris
            // 
            this.btnArcoIris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.btnArcoIris.FlatAppearance.BorderSize = 0;
            this.btnArcoIris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArcoIris.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnArcoIris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArcoIris.Location = new System.Drawing.Point(300, 335);
            this.btnArcoIris.Name = "btnArcoIris";
            this.btnArcoIris.Size = new System.Drawing.Size(97, 32);
            this.btnArcoIris.TabIndex = 23;
            this.btnArcoIris.Text = "Arco Íris";
            this.btnArcoIris.UseVisualStyleBackColor = false;
            this.btnArcoIris.Click += new System.EventHandler(this.lblBrilho_Click);
            // 
            // pbArcoIris
            // 
            this.pbArcoIris.Image = ((System.Drawing.Image)(resources.GetObject("pbArcoIris.Image")));
            this.pbArcoIris.Location = new System.Drawing.Point(170, 81);
            this.pbArcoIris.Name = "pbArcoIris";
            this.pbArcoIris.Size = new System.Drawing.Size(360, 210);
            this.pbArcoIris.TabIndex = 24;
            this.pbArcoIris.TabStop = false;
            this.pbArcoIris.Tag = "Arco Íris";
            this.pbArcoIris.Click += new System.EventHandler(this.pbArcoIris_Click);
            // 
            // _3_Arcoiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pbArcoIris);
            this.Controls.Add(this.btnArcoIris);
            this.Controls.Add(this.lblBrilho);
            this.Controls.Add(this.tbBrilho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_3_Arcoiris";
            this.Text = "_3_Arcoiris";
            this.Load += new System.EventHandler(this._3_Arcoiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArcoIris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.TrackBar tbBrilho;
        private System.Windows.Forms.Button btnArcoIris;
        private System.Windows.Forms.PictureBox pbArcoIris;
    }
}