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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UmaCor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor4x3 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor4x2 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor4x1 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor3x3 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor3x2 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor3x1 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor2x3 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor2x2 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor2x1 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor1x3 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor1x2 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnColor1x1 = new Syncfusion.WinForms.Controls.SfButton();
            this.tbBrilho = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 255);
            this.tbFrequencia = new Syncfusion.Windows.Forms.Tools.TrackBarEx(200, 2000);
            this.button1 = new System.Windows.Forms.Button();
            this.chklbLamp = new System.Windows.Forms.CheckedListBox();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.lblBrilho = new System.Windows.Forms.Label();
            this.btnWave = new System.Windows.Forms.Button();
            this.btnBreath = new System.Windows.Forms.Button();
            this.btnSolido = new System.Windows.Forms.Button();
            this.cwUmaCor = new Cyotek.Windows.Forms.ColorWheel();
            this.timerPreventOversending = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnColor4x3);
            this.panel1.Controls.Add(this.btnColor4x2);
            this.panel1.Controls.Add(this.btnColor4x1);
            this.panel1.Controls.Add(this.btnColor3x3);
            this.panel1.Controls.Add(this.btnColor3x2);
            this.panel1.Controls.Add(this.btnColor3x1);
            this.panel1.Controls.Add(this.btnColor2x3);
            this.panel1.Controls.Add(this.btnColor2x2);
            this.panel1.Controls.Add(this.btnColor2x1);
            this.panel1.Controls.Add(this.btnColor1x3);
            this.panel1.Controls.Add(this.btnColor1x2);
            this.panel1.Controls.Add(this.btnColor1x1);
            this.panel1.Controls.Add(this.tbBrilho);
            this.panel1.Controls.Add(this.tbFrequencia);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chklbLamp);
            this.panel1.Controls.Add(this.lblFrequencia);
            this.panel1.Controls.Add(this.lblBrilho);
            this.panel1.Controls.Add(this.btnWave);
            this.panel1.Controls.Add(this.btnBreath);
            this.panel1.Controls.Add(this.btnSolido);
            this.panel1.Controls.Add(this.cwUmaCor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 500);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Customizada";
            // 
            // btnColor4x3
            // 
            this.btnColor4x3.AccessibleName = "Button";
            this.btnColor4x3.BackColor = System.Drawing.Color.Red;
            this.btnColor4x3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor4x3.Location = new System.Drawing.Point(632, 279);
            this.btnColor4x3.Name = "btnColor4x3";
            this.btnColor4x3.Size = new System.Drawing.Size(30, 30);
            this.btnColor4x3.Style.BackColor = System.Drawing.Color.Red;
            this.btnColor4x3.Style.FocusedBackColor = System.Drawing.Color.Red;
            this.btnColor4x3.Style.HoverBackColor = System.Drawing.Color.Red;
            this.btnColor4x3.TabIndex = 39;
            this.btnColor4x3.UseVisualStyleBackColor = false;
            this.btnColor4x3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnColor4x3_MouseDown);
            // 
            // btnColor4x2
            // 
            this.btnColor4x2.AccessibleName = "Button";
            this.btnColor4x2.BackColor = System.Drawing.Color.Red;
            this.btnColor4x2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor4x2.Location = new System.Drawing.Point(584, 279);
            this.btnColor4x2.Name = "btnColor4x2";
            this.btnColor4x2.Size = new System.Drawing.Size(30, 30);
            this.btnColor4x2.Style.BackColor = System.Drawing.Color.Red;
            this.btnColor4x2.Style.FocusedBackColor = System.Drawing.Color.Red;
            this.btnColor4x2.Style.HoverBackColor = System.Drawing.Color.Red;
            this.btnColor4x2.TabIndex = 38;
            this.btnColor4x2.UseVisualStyleBackColor = false;
            this.btnColor4x2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnColor4x2_MouseDown);
            // 
            // btnColor4x1
            // 
            this.btnColor4x1.AccessibleName = "Button";
            this.btnColor4x1.BackColor = System.Drawing.Color.Red;
            this.btnColor4x1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor4x1.Location = new System.Drawing.Point(537, 279);
            this.btnColor4x1.Name = "btnColor4x1";
            this.btnColor4x1.Size = new System.Drawing.Size(30, 30);
            this.btnColor4x1.Style.BackColor = System.Drawing.Color.Red;
            this.btnColor4x1.Style.FocusedBackColor = System.Drawing.Color.Red;
            this.btnColor4x1.Style.HoverBackColor = System.Drawing.Color.Red;
            this.btnColor4x1.TabIndex = 37;
            this.btnColor4x1.UseVisualStyleBackColor = false;
            this.btnColor4x1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnColor4x1_MouseDown);
            // 
            // btnColor3x3
            // 
            this.btnColor3x3.AccessibleName = "Button";
            this.btnColor3x3.BackColor = System.Drawing.Color.Cyan;
            this.btnColor3x3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor3x3.Location = new System.Drawing.Point(632, 222);
            this.btnColor3x3.Name = "btnColor3x3";
            this.btnColor3x3.Size = new System.Drawing.Size(30, 30);
            this.btnColor3x3.Style.BackColor = System.Drawing.Color.Cyan;
            this.btnColor3x3.Style.FocusedBackColor = System.Drawing.Color.Cyan;
            this.btnColor3x3.Style.HoverBackColor = System.Drawing.Color.Cyan;
            this.btnColor3x3.Style.PressedBackColor = System.Drawing.Color.Cyan;
            this.btnColor3x3.TabIndex = 36;
            this.btnColor3x3.UseVisualStyleBackColor = false;
            this.btnColor3x3.Click += new System.EventHandler(this.btnColor3x3_Click);
            // 
            // btnColor3x2
            // 
            this.btnColor3x2.AccessibleName = "Button";
            this.btnColor3x2.BackColor = System.Drawing.Color.Magenta;
            this.btnColor3x2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor3x2.Location = new System.Drawing.Point(584, 222);
            this.btnColor3x2.Name = "btnColor3x2";
            this.btnColor3x2.Size = new System.Drawing.Size(30, 30);
            this.btnColor3x2.Style.BackColor = System.Drawing.Color.Magenta;
            this.btnColor3x2.Style.FocusedBackColor = System.Drawing.Color.Magenta;
            this.btnColor3x2.Style.HoverBackColor = System.Drawing.Color.Magenta;
            this.btnColor3x2.Style.PressedBackColor = System.Drawing.Color.Magenta;
            this.btnColor3x2.TabIndex = 35;
            this.btnColor3x2.UseVisualStyleBackColor = false;
            this.btnColor3x2.Click += new System.EventHandler(this.btnColor3x2_Click);
            // 
            // btnColor3x1
            // 
            this.btnColor3x1.AccessibleName = "Button";
            this.btnColor3x1.BackColor = System.Drawing.Color.Yellow;
            this.btnColor3x1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor3x1.Location = new System.Drawing.Point(537, 222);
            this.btnColor3x1.Name = "btnColor3x1";
            this.btnColor3x1.Size = new System.Drawing.Size(30, 30);
            this.btnColor3x1.Style.BackColor = System.Drawing.Color.Yellow;
            this.btnColor3x1.Style.FocusedBackColor = System.Drawing.Color.Yellow;
            this.btnColor3x1.Style.HoverBackColor = System.Drawing.Color.Yellow;
            this.btnColor3x1.Style.PressedBackColor = System.Drawing.Color.Yellow;
            this.btnColor3x1.TabIndex = 34;
            this.btnColor3x1.UseVisualStyleBackColor = false;
            this.btnColor3x1.Click += new System.EventHandler(this.btnColor3x1_Click);
            // 
            // btnColor2x3
            // 
            this.btnColor2x3.AccessibleName = "Button";
            this.btnColor2x3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnColor2x3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor2x3.Location = new System.Drawing.Point(632, 175);
            this.btnColor2x3.Name = "btnColor2x3";
            this.btnColor2x3.Size = new System.Drawing.Size(30, 30);
            this.btnColor2x3.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnColor2x3.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnColor2x3.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnColor2x3.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnColor2x3.TabIndex = 33;
            this.btnColor2x3.UseVisualStyleBackColor = false;
            this.btnColor2x3.Click += new System.EventHandler(this.btnColor2x3_Click);
            // 
            // btnColor2x2
            // 
            this.btnColor2x2.AccessibleName = "Button";
            this.btnColor2x2.BackColor = System.Drawing.Color.Chartreuse;
            this.btnColor2x2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor2x2.Location = new System.Drawing.Point(584, 175);
            this.btnColor2x2.Name = "btnColor2x2";
            this.btnColor2x2.Size = new System.Drawing.Size(30, 30);
            this.btnColor2x2.Style.BackColor = System.Drawing.Color.Chartreuse;
            this.btnColor2x2.Style.FocusedBackColor = System.Drawing.Color.Chartreuse;
            this.btnColor2x2.Style.HoverBackColor = System.Drawing.Color.Chartreuse;
            this.btnColor2x2.Style.PressedBackColor = System.Drawing.Color.Chartreuse;
            this.btnColor2x2.TabIndex = 32;
            this.btnColor2x2.UseVisualStyleBackColor = false;
            this.btnColor2x2.Click += new System.EventHandler(this.btnColor2x2_Click);
            // 
            // btnColor2x1
            // 
            this.btnColor2x1.AccessibleName = "Button";
            this.btnColor2x1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnColor2x1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor2x1.Location = new System.Drawing.Point(537, 175);
            this.btnColor2x1.Name = "btnColor2x1";
            this.btnColor2x1.Size = new System.Drawing.Size(30, 30);
            this.btnColor2x1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnColor2x1.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnColor2x1.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnColor2x1.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnColor2x1.TabIndex = 31;
            this.btnColor2x1.UseVisualStyleBackColor = false;
            this.btnColor2x1.Click += new System.EventHandler(this.btnColor2x1_Click);
            // 
            // btnColor1x3
            // 
            this.btnColor1x3.AccessibleName = "Button";
            this.btnColor1x3.BackColor = System.Drawing.Color.Blue;
            this.btnColor1x3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor1x3.Location = new System.Drawing.Point(632, 125);
            this.btnColor1x3.Name = "btnColor1x3";
            this.btnColor1x3.Size = new System.Drawing.Size(30, 30);
            this.btnColor1x3.Style.BackColor = System.Drawing.Color.Blue;
            this.btnColor1x3.Style.FocusedBackColor = System.Drawing.Color.Blue;
            this.btnColor1x3.Style.HoverBackColor = System.Drawing.Color.Blue;
            this.btnColor1x3.Style.PressedBackColor = System.Drawing.Color.Blue;
            this.btnColor1x3.TabIndex = 30;
            this.btnColor1x3.UseVisualStyleBackColor = false;
            this.btnColor1x3.Click += new System.EventHandler(this.btnColor1x3_Click);
            // 
            // btnColor1x2
            // 
            this.btnColor1x2.AccessibleName = "Button";
            this.btnColor1x2.BackColor = System.Drawing.Color.Green;
            this.btnColor1x2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor1x2.Location = new System.Drawing.Point(584, 125);
            this.btnColor1x2.Name = "btnColor1x2";
            this.btnColor1x2.Size = new System.Drawing.Size(30, 30);
            this.btnColor1x2.Style.BackColor = System.Drawing.Color.Green;
            this.btnColor1x2.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnColor1x2.Style.HoverBackColor = System.Drawing.Color.Green;
            this.btnColor1x2.Style.PressedBackColor = System.Drawing.Color.Green;
            this.btnColor1x2.TabIndex = 29;
            this.btnColor1x2.UseVisualStyleBackColor = false;
            this.btnColor1x2.Click += new System.EventHandler(this.btnColor1x2_Click);
            // 
            // btnColor1x1
            // 
            this.btnColor1x1.AccessibleName = "Button";
            this.btnColor1x1.BackColor = System.Drawing.Color.Red;
            this.btnColor1x1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnColor1x1.Location = new System.Drawing.Point(537, 125);
            this.btnColor1x1.Name = "btnColor1x1";
            this.btnColor1x1.Size = new System.Drawing.Size(30, 30);
            this.btnColor1x1.Style.BackColor = System.Drawing.Color.Red;
            this.btnColor1x1.Style.FocusedBackColor = System.Drawing.Color.Red;
            this.btnColor1x1.Style.HoverBackColor = System.Drawing.Color.Red;
            this.btnColor1x1.Style.PressedBackColor = System.Drawing.Color.Red;
            this.btnColor1x1.TabIndex = 28;
            this.btnColor1x1.UseVisualStyleBackColor = false;
            this.btnColor1x1.Click += new System.EventHandler(this.btnColor1x1_Click);
            // 
            // tbBrilho
            // 
            this.tbBrilho.BackColor = System.Drawing.Color.White;
            this.tbBrilho.BeforeTouchSize = new System.Drawing.Size(250, 20);
            this.tbBrilho.ChannelHeight = 6;
            this.tbBrilho.DecreaseButtonSize = new System.Drawing.Size(0, 0);
            this.tbBrilho.IncreaseButtonSize = new System.Drawing.Size(0, 0);
            this.tbBrilho.Location = new System.Drawing.Point(221, 364);
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.ShowButtons = false;
            this.tbBrilho.Size = new System.Drawing.Size(250, 20);
            this.tbBrilho.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.tbBrilho.TabIndex = 26;
            this.tbBrilho.Text = "trackBarEx1";
            this.tbBrilho.ThemeName = "Metro";
            this.tbBrilho.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbBrilho.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbBrilho.ThemeStyle.DisabledTrackBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbBrilho.TimerInterval = 100;
            this.tbBrilho.Value = 255;
            this.tbBrilho.Scroll += new System.EventHandler(this.tbBrilho_Scroll);
            // 
            // tbFrequencia
            // 
            this.tbFrequencia.BackColor = System.Drawing.Color.White;
            this.tbFrequencia.BeforeTouchSize = new System.Drawing.Size(250, 20);
            this.tbFrequencia.ChannelHeight = 6;
            this.tbFrequencia.DecreaseButtonSize = new System.Drawing.Size(0, 0);
            this.tbFrequencia.IncreaseButtonSize = new System.Drawing.Size(0, 0);
            this.tbFrequencia.Location = new System.Drawing.Point(221, 413);
            this.tbFrequencia.Name = "tbFrequencia";
            this.tbFrequencia.ShowButtons = false;
            this.tbFrequencia.Size = new System.Drawing.Size(250, 20);
            this.tbFrequencia.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.tbFrequencia.TabIndex = 25;
            this.tbFrequencia.Text = "trackBarEx1";
            this.tbFrequencia.ThemeName = "Metro";
            this.tbFrequencia.TimerInterval = 100;
            this.tbFrequencia.Value = 255;
            this.tbFrequencia.Scroll += new System.EventHandler(this.tbFrequencia_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chklbLamp
            // 
            this.chklbLamp.FormattingEnabled = true;
            this.chklbLamp.Location = new System.Drawing.Point(43, 50);
            this.chklbLamp.Name = "chklbLamp";
            this.chklbLamp.Size = new System.Drawing.Size(113, 124);
            this.chklbLamp.Sorted = true;
            this.chklbLamp.TabIndex = 23;
            this.chklbLamp.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklbLamp_ItemCheck);
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFrequencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrequencia.Location = new System.Drawing.Point(227, 446);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(69, 15);
            this.lblFrequencia.TabIndex = 22;
            this.lblFrequencia.Text = "Frequência";
            // 
            // lblBrilho
            // 
            this.lblBrilho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrilho.AutoSize = true;
            this.lblBrilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBrilho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrilho.Location = new System.Drawing.Point(534, 467);
            this.lblBrilho.Name = "lblBrilho";
            this.lblBrilho.Size = new System.Drawing.Size(39, 15);
            this.lblBrilho.TabIndex = 20;
            this.lblBrilho.Text = "Brilho";
            // 
            // btnWave
            // 
            this.btnWave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnWave.FlatAppearance.BorderSize = 0;
            this.btnWave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnWave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWave.Location = new System.Drawing.Point(43, 382);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(97, 32);
            this.btnWave.TabIndex = 18;
            this.btnWave.Text = "Onda";
            this.btnWave.UseVisualStyleBackColor = false;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // btnBreath
            // 
            this.btnBreath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnBreath.FlatAppearance.BorderSize = 0;
            this.btnBreath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBreath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBreath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBreath.Location = new System.Drawing.Point(43, 335);
            this.btnBreath.Name = "btnBreath";
            this.btnBreath.Size = new System.Drawing.Size(97, 32);
            this.btnBreath.TabIndex = 17;
            this.btnBreath.Text = "Pulsar";
            this.btnBreath.UseVisualStyleBackColor = false;
            this.btnBreath.Click += new System.EventHandler(this.btnPulsar_Click);
            // 
            // btnSolido
            // 
            this.btnSolido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSolido.FlatAppearance.BorderSize = 0;
            this.btnSolido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSolido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolido.Location = new System.Drawing.Point(43, 286);
            this.btnSolido.Name = "btnSolido";
            this.btnSolido.Size = new System.Drawing.Size(97, 32);
            this.btnSolido.TabIndex = 16;
            this.btnSolido.Text = "Sólido";
            this.btnSolido.UseVisualStyleBackColor = false;
            this.btnSolido.Click += new System.EventHandler(this.btnSolido_Click);
            // 
            // cwUmaCor
            // 
            this.cwUmaCor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cwUmaCor.Location = new System.Drawing.Point(230, 50);
            this.cwUmaCor.Name = "cwUmaCor";
            this.cwUmaCor.Size = new System.Drawing.Size(241, 268);
            this.cwUmaCor.TabIndex = 3;
            this.cwUmaCor.ColorChanged += new System.EventHandler(this.cwUmaCor_ColorChanged);
            // 
            // timerPreventOversending
            // 
            this.timerPreventOversending.Interval = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UmaCor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UmaCor";
            this.Text = "Cores";
            this.Load += new System.EventHandler(this.UmaCor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Cyotek.Windows.Forms.ColorWheel cwUmaCor;
        private System.Windows.Forms.Button btnSolido;
        private System.Windows.Forms.Button btnBreath;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.CheckedListBox chklbLamp;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.Button button1;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx tbFrequencia;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx tbBrilho;
        private Syncfusion.WinForms.Controls.SfButton btnColor1x1;
        private Syncfusion.WinForms.Controls.SfButton btnColor4x3;
        private Syncfusion.WinForms.Controls.SfButton btnColor4x2;
        private Syncfusion.WinForms.Controls.SfButton btnColor4x1;
        private Syncfusion.WinForms.Controls.SfButton btnColor3x3;
        private Syncfusion.WinForms.Controls.SfButton btnColor3x2;
        private Syncfusion.WinForms.Controls.SfButton btnColor3x1;
        private Syncfusion.WinForms.Controls.SfButton btnColor2x3;
        private Syncfusion.WinForms.Controls.SfButton btnColor2x2;
        private Syncfusion.WinForms.Controls.SfButton btnColor2x1;
        private Syncfusion.WinForms.Controls.SfButton btnColor1x3;
        private Syncfusion.WinForms.Controls.SfButton btnColor1x2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerPreventOversending;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}