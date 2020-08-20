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
            this.btnDuasCores = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnArcoIris = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUmaCor = new System.Windows.Forms.Button();
            this.panelChildCores = new System.Windows.Forms.Panel();
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
            this.panel4.Controls.Add(this.btnDuasCores);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(233, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 50);
            this.panel4.TabIndex = 2;
            // 
            // btnDuasCores
            // 
            this.btnDuasCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuasCores.Location = new System.Drawing.Point(0, 0);
            this.btnDuasCores.Name = "btnDuasCores";
            this.btnDuasCores.Size = new System.Drawing.Size(234, 50);
            this.btnDuasCores.TabIndex = 3;
            this.btnDuasCores.Text = "Duas Cores";
            this.btnDuasCores.UseVisualStyleBackColor = true;
            this.btnDuasCores.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnArcoIris);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(467, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 50);
            this.panel3.TabIndex = 1;
            // 
            // btnArcoIris
            // 
            this.btnArcoIris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArcoIris.Location = new System.Drawing.Point(0, 0);
            this.btnArcoIris.Name = "btnArcoIris";
            this.btnArcoIris.Size = new System.Drawing.Size(233, 50);
            this.btnArcoIris.TabIndex = 3;
            this.btnArcoIris.Text = "Arco Íris";
            this.btnArcoIris.UseVisualStyleBackColor = true;
            this.btnArcoIris.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUmaCor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnUmaCor
            // 
            this.btnUmaCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUmaCor.Location = new System.Drawing.Point(0, 0);
            this.btnUmaCor.Name = "btnUmaCor";
            this.btnUmaCor.Size = new System.Drawing.Size(233, 50);
            this.btnUmaCor.TabIndex = 2;
            this.btnUmaCor.Text = "Uma Cor";
            this.btnUmaCor.UseVisualStyleBackColor = true;
            this.btnUmaCor.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelChildCores
            // 
            this.panelChildCores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.panelChildCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildCores.Location = new System.Drawing.Point(0, 50);
            this.panelChildCores.Name = "panelChildCores";
            this.panelChildCores.Size = new System.Drawing.Size(700, 500);
            this.panelChildCores.TabIndex = 1;
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
        private System.Windows.Forms.Button btnDuasCores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnArcoIris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUmaCor;
        private System.Windows.Forms.Panel panelChildCores;
    }
}