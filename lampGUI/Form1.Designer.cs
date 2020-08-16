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
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.colorWheel2 = new Cyotek.Windows.Forms.ColorWheel();
            this.SuspendLayout();
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(223, 24);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(212, 200);
            this.colorWheel1.TabIndex = 1;
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            // 
            // colorWheel2
            // 
            this.colorWheel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel2.Location = new System.Drawing.Point(441, 24);
            this.colorWheel2.Name = "colorWheel2";
            this.colorWheel2.Size = new System.Drawing.Size(212, 200);
            this.colorWheel2.TabIndex = 2;
            this.colorWheel2.ColorChanged += new System.EventHandler(this.colorWheel2_ColorChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorWheel2);
            this.Controls.Add(this.colorWheel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private Cyotek.Windows.Forms.ColorWheel colorWheel2;
    }
}

