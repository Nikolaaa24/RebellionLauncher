namespace Radioactive
{
    partial class RadioactiveSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadioactiveSettings));
            dragpanel = new Panel();
            csoonlbl = new Label();
            exitbtn = new Button();
            inseclaunchcb = new CheckBox();
            potatopccb = new CheckBox();
            btndisablecb = new CheckBox();
            notelbl = new Label();
            bonlycb = new CheckBox();
            autostartcb = new CheckBox();
            nasapccb = new CheckBox();
            musicdisablecb = new CheckBox();
            dragpanel.SuspendLayout();
            SuspendLayout();
            // 
            // dragpanel
            // 
            dragpanel.BackColor = Color.FromArgb(128, 20, 20, 20);
            dragpanel.Controls.Add(csoonlbl);
            dragpanel.Controls.Add(exitbtn);
            dragpanel.Location = new Point(0, 0);
            dragpanel.Name = "dragpanel";
            dragpanel.Size = new Size(359, 32);
            dragpanel.TabIndex = 0;
            dragpanel.MouseDown += dragpanel_MouseDown;
            dragpanel.MouseMove += dragpanel_MouseMove;
            dragpanel.MouseUp += dragpanel_MouseUp;
            // 
            // csoonlbl
            // 
            csoonlbl.AutoSize = true;
            csoonlbl.BackColor = Color.Transparent;
            csoonlbl.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            csoonlbl.ForeColor = Color.Red;
            csoonlbl.Location = new Point(12, 6);
            csoonlbl.Name = "csoonlbl";
            csoonlbl.Size = new Size(106, 17);
            csoonlbl.TabIndex = 9;
            csoonlbl.Text = "COMING SOON";
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Location = new Point(314, 3);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(30, 25);
            exitbtn.TabIndex = 2;
            exitbtn.Text = "X";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // inseclaunchcb
            // 
            inseclaunchcb.AutoSize = true;
            inseclaunchcb.BackColor = Color.Transparent;
            inseclaunchcb.ForeColor = Color.White;
            inseclaunchcb.Location = new Point(12, 49);
            inseclaunchcb.Name = "inseclaunchcb";
            inseclaunchcb.Size = new Size(298, 19);
            inseclaunchcb.TabIndex = 1;
            inseclaunchcb.Text = "Launch Insecure (will not be able to join AC servers)";
            inseclaunchcb.UseVisualStyleBackColor = false;
            // 
            // potatopccb
            // 
            potatopccb.AutoSize = true;
            potatopccb.BackColor = Color.Transparent;
            potatopccb.ForeColor = Color.White;
            potatopccb.Location = new Point(12, 74);
            potatopccb.Name = "potatopccb";
            potatopccb.Size = new Size(255, 19);
            potatopccb.TabIndex = 2;
            potatopccb.Text = "Potato PC (optimizes the game to its limits)";
            potatopccb.UseVisualStyleBackColor = false;
            // 
            // btndisablecb
            // 
            btndisablecb.AutoSize = true;
            btndisablecb.BackColor = Color.Transparent;
            btndisablecb.ForeColor = Color.White;
            btndisablecb.Location = new Point(12, 99);
            btndisablecb.Name = "btndisablecb";
            btndisablecb.Size = new Size(326, 19);
            btndisablecb.TabIndex = 3;
            btndisablecb.Text = "Hide Server Button (if you only want to use our launcher)";
            btndisablecb.UseVisualStyleBackColor = false;
            // 
            // notelbl
            // 
            notelbl.AutoSize = true;
            notelbl.BackColor = Color.Transparent;
            notelbl.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            notelbl.ForeColor = Color.Red;
            notelbl.Location = new Point(78, 424);
            notelbl.Name = "notelbl";
            notelbl.Size = new Size(266, 17);
            notelbl.TabIndex = 4;
            notelbl.Text = "NONE OF THESE CAN GET YOU BANNED";
            // 
            // bonlycb
            // 
            bonlycb.AutoSize = true;
            bonlycb.BackColor = Color.Transparent;
            bonlycb.ForeColor = Color.White;
            bonlycb.Location = new Point(12, 124);
            bonlycb.Name = "bonlycb";
            bonlycb.Size = new Size(349, 19);
            bonlycb.TabIndex = 5;
            bonlycb.Text = "Bootstrap Only (closes the launcher when opening the game)";
            bonlycb.UseVisualStyleBackColor = false;
            // 
            // autostartcb
            // 
            autostartcb.AutoSize = true;
            autostartcb.BackColor = Color.Transparent;
            autostartcb.ForeColor = Color.White;
            autostartcb.Location = new Point(12, 149);
            autostartcb.Name = "autostartcb";
            autostartcb.Size = new Size(294, 19);
            autostartcb.TabIndex = 7;
            autostartcb.Text = "Auto Startup (Launch when computer starts, why?)";
            autostartcb.UseVisualStyleBackColor = false;
            // 
            // nasapccb
            // 
            nasapccb.AutoSize = true;
            nasapccb.BackColor = Color.Transparent;
            nasapccb.ForeColor = Color.White;
            nasapccb.Location = new Point(12, 174);
            nasapccb.Name = "nasapccb";
            nasapccb.Size = new Size(341, 19);
            nasapccb.TabIndex = 8;
            nasapccb.Text = "NASA PC (maxes settings so you can cook eggs on the cpu)";
            nasapccb.UseVisualStyleBackColor = false;
            // 
            // musicdisablecb
            // 
            musicdisablecb.AutoSize = true;
            musicdisablecb.BackColor = Color.Transparent;
            musicdisablecb.ForeColor = Color.White;
            musicdisablecb.Location = new Point(12, 199);
            musicdisablecb.Name = "musicdisablecb";
            musicdisablecb.Size = new Size(328, 19);
            musicdisablecb.TabIndex = 9;
            musicdisablecb.Text = "Disable music (Music does not play when launcher starts)";
            musicdisablecb.UseVisualStyleBackColor = false;
            // 
            // RadioactiveSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(356, 450);
            Controls.Add(musicdisablecb);
            Controls.Add(nasapccb);
            Controls.Add(autostartcb);
            Controls.Add(bonlycb);
            Controls.Add(notelbl);
            Controls.Add(btndisablecb);
            Controls.Add(potatopccb);
            Controls.Add(inseclaunchcb);
            Controls.Add(dragpanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RadioactiveSettings";
            Text = "Rebellion Launcher Settings";
            FormClosing += RadioactiveSettings_FormClosing;
            Load += RadioactiveSettings_Load;
            dragpanel.ResumeLayout(false);
            dragpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel dragpanel;
        private Button exitbtn;
        private CheckBox inseclaunchcb;
        private CheckBox potatopccb;
        private CheckBox btndisablecb;
        private Label notelbl;
        private CheckBox bonlycb;
        private CheckBox autostartcb;
        private CheckBox nasapccb;
        private Label csoonlbl;
        private CheckBox musicdisablecb;
    }
}