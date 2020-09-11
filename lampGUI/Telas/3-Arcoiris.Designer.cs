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
            this.pbArcoIris = new System.Windows.Forms.PictureBox();
            this.btnSolido = new System.Windows.Forms.Button();
            this.btnBreath = new System.Windows.Forms.Button();
            this.tbFrequencia = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArcoIris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrilho
            // 
            this.lblBrilho.AutoSize = true;
            this.lblBrilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBrilho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrilho.Location = new System.Drawing.Point(334, 391);
            this.lblBrilho.Name = "lblBrilho";
            this.lblBrilho.Size = new System.Drawing.Size(39, 15);
            this.lblBrilho.TabIndex = 22;
            this.lblBrilho.Text = "Brilho";
            this.lblBrilho.Click += new System.EventHandler(this.lblBrilho_Click);
            // 
            // tbBrilho
            // 
            this.tbBrilho.AutoSize = false;
            this.tbBrilho.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbBrilho.Location = new System.Drawing.Point(237, 372);
            this.tbBrilho.Maximum = 255;
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.Size = new System.Drawing.Size(232, 45);
            this.tbBrilho.TabIndex = 21;
            this.tbBrilho.TickFrequency = 100;
            this.tbBrilho.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBrilho.Scroll += new System.EventHandler(this.tbBrilho_Scroll);
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
            // btnSolido
            // 
            this.btnSolido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.btnSolido.FlatAppearance.BorderSize = 0;
            this.btnSolido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSolido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolido.Location = new System.Drawing.Point(234, 334);
            this.btnSolido.Name = "btnSolido";
            this.btnSolido.Size = new System.Drawing.Size(97, 32);
            this.btnSolido.TabIndex = 25;
            this.btnSolido.Text = "Sólido";
            this.btnSolido.UseVisualStyleBackColor = false;
            this.btnSolido.Click += new System.EventHandler(this.btnSolido_Click);
            // 
            // btnBreath
            // 
            this.btnBreath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.btnBreath.FlatAppearance.BorderSize = 0;
            this.btnBreath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBreath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBreath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBreath.Location = new System.Drawing.Point(369, 334);
            this.btnBreath.Name = "btnBreath";
            this.btnBreath.Size = new System.Drawing.Size(97, 32);
            this.btnBreath.TabIndex = 26;
            this.btnBreath.Text = "Pulsar";
            this.btnBreath.UseVisualStyleBackColor = false;
            this.btnBreath.Click += new System.EventHandler(this.btnBreath_Click);
            // 
            // tbFrequencia
            // 
            this.tbFrequencia.AutoSize = false;
            this.tbFrequencia.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFrequencia.Location = new System.Drawing.Point(237, 409);
            this.tbFrequencia.Maximum = 5000;
            this.tbFrequencia.Minimum = 200;
            this.tbFrequencia.Name = "tbFrequencia";
            this.tbFrequencia.Size = new System.Drawing.Size(232, 45);
            this.tbFrequencia.TabIndex = 27;
            this.tbFrequencia.TickFrequency = 100;
            this.tbFrequencia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbFrequencia.Value = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(319, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Frequência";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // _3_Arcoiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFrequencia);
            this.Controls.Add(this.btnBreath);
            this.Controls.Add(this.btnSolido);
            this.Controls.Add(this.pbArcoIris);
            this.Controls.Add(this.lblBrilho);
            this.Controls.Add(this.tbBrilho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_3_Arcoiris";
            this.Text = "_3_Arcoiris";
            this.Load += new System.EventHandler(this._3_Arcoiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArcoIris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.TrackBar tbBrilho;
        private System.Windows.Forms.PictureBox pbArcoIris;
        private System.Windows.Forms.Button btnSolido;
        private System.Windows.Forms.Button btnBreath;
        private System.Windows.Forms.TrackBar tbFrequencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}