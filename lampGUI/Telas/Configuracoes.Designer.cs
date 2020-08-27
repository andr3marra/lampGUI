namespace lampGUI.Telas {
    partial class Configuracoes {
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
            this.lvLamps = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvLamps
            // 
            this.lvLamps.HideSelection = false;
            this.lvLamps.Location = new System.Drawing.Point(73, 55);
            this.lvLamps.Name = "lvLamps";
            this.lvLamps.Size = new System.Drawing.Size(245, 97);
            this.lvLamps.TabIndex = 0;
            this.lvLamps.UseCompatibleStateImageBehavior = false;
            this.lvLamps.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar Manualmente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvLamps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLamps;
        private System.Windows.Forms.Button button1;
    }
}