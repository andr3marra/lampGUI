namespace lampGUI {
    partial class _0_Cores {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildCores = new System.Windows.Forms.Panel();
            this.btnSingle = new Syncfusion.WinForms.Controls.SfButton();
            this.btnGradient = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRainbow = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGradient);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(233, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 50);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRainbow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(467, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 50);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSingle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 50);
            this.panel2.TabIndex = 0;
            // 
            // panelChildCores
            // 
            this.panelChildCores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelChildCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildCores.Location = new System.Drawing.Point(0, 50);
            this.panelChildCores.Name = "panelChildCores";
            this.panelChildCores.Size = new System.Drawing.Size(700, 500);
            this.panelChildCores.TabIndex = 1;
            // 
            // btnSingle
            // 
            this.btnSingle.AccessibleName = "Button";
            this.btnSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSingle.Location = new System.Drawing.Point(0, 0);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(233, 50);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "Uma Cor";
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnGradient
            // 
            this.btnGradient.AccessibleName = "Button";
            this.btnGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGradient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnGradient.Location = new System.Drawing.Point(0, 0);
            this.btnGradient.Name = "btnGradient";
            this.btnGradient.Size = new System.Drawing.Size(234, 50);
            this.btnGradient.TabIndex = 1;
            this.btnGradient.Text = "Gradiente";
            this.btnGradient.Click += new System.EventHandler(this.btnGradient_Click);
            // 
            // btnRainbow
            // 
            this.btnRainbow.AccessibleName = "Button";
            this.btnRainbow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRainbow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRainbow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnRainbow.Location = new System.Drawing.Point(0, 0);
            this.btnRainbow.Name = "btnRainbow";
            this.btnRainbow.Size = new System.Drawing.Size(233, 50);
            this.btnRainbow.TabIndex = 2;
            this.btnRainbow.Text = "Arco Íris";
            this.btnRainbow.Click += new System.EventHandler(this.btnRainbow_Click);
            // 
            // _0_Cores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.panelChildCores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_0_Cores";
            this.Text = "_0_Cores";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildCores;
        private Syncfusion.WinForms.Controls.SfButton btnRainbow;
        private Syncfusion.WinForms.Controls.SfButton btnGradient;
        private Syncfusion.WinForms.Controls.SfButton btnSingle;
    }
}