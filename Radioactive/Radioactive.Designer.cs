namespace Radioactive
{
    partial class Radioactive
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radioactive));
            dragpanel = new Panel();
            settingsbtn = new Button();
            minimizebtn = new Button();
            exitbtn = new Button();
            startbtn = new Button();
            launchserver = new Button();
            musicpanel = new Panel();
            volumebar = new TrackBar();
            playbtn = new Button();
            stopbtn = new Button();
            pausebtn = new Button();
            aboutbtn = new Button();
            dragpanel.SuspendLayout();
            musicpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumebar).BeginInit();
            SuspendLayout();
            // 
            // dragpanel
            // 
            dragpanel.BackColor = Color.FromArgb(128, 20, 20, 20);
            dragpanel.Controls.Add(settingsbtn);
            dragpanel.Controls.Add(minimizebtn);
            dragpanel.Controls.Add(exitbtn);
            dragpanel.Location = new Point(0, -3);
            dragpanel.Name = "dragpanel";
            dragpanel.Size = new Size(806, 36);
            dragpanel.TabIndex = 0;
            dragpanel.MouseDown += dragpanel_MouseDown;
            dragpanel.MouseMove += dragpanel_MouseMove;
            dragpanel.MouseUp += dragpanel_MouseUp;
            // 
            // settingsbtn
            // 
            settingsbtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            settingsbtn.BackgroundImage = (Image)resources.GetObject("settingsbtn.BackgroundImage");
            settingsbtn.BackgroundImageLayout = ImageLayout.Zoom;
            settingsbtn.FlatStyle = FlatStyle.Flat;
            settingsbtn.Location = new Point(12, 8);
            settingsbtn.Name = "settingsbtn";
            settingsbtn.Size = new Size(30, 25);
            settingsbtn.TabIndex = 3;
            settingsbtn.UseVisualStyleBackColor = false;
            settingsbtn.Click += settingsbtn_Click;
            // 
            // minimizebtn
            // 
            minimizebtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            minimizebtn.FlatStyle = FlatStyle.Flat;
            minimizebtn.Location = new Point(722, 8);
            minimizebtn.Name = "minimizebtn";
            minimizebtn.Size = new Size(30, 25);
            minimizebtn.TabIndex = 2;
            minimizebtn.Text = "_";
            minimizebtn.UseVisualStyleBackColor = false;
            minimizebtn.Click += minimizebtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Location = new Point(758, 8);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(30, 25);
            exitbtn.TabIndex = 1;
            exitbtn.Text = "X";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // startbtn
            // 
            startbtn.BackColor = Color.FromArgb(128, 35, 35, 35);
            startbtn.FlatStyle = FlatStyle.Flat;
            startbtn.Location = new Point(325, 400);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(155, 40);
            startbtn.TabIndex = 3;
            startbtn.Text = "Launch Rust";
            startbtn.UseVisualStyleBackColor = false;
            startbtn.Click += startbtn_Click;
            // 
            // launchserver
            // 
            launchserver.BackColor = Color.FromArgb(128, 35, 35, 35);
            launchserver.FlatStyle = FlatStyle.Flat;
            launchserver.Location = new Point(325, 371);
            launchserver.Name = "launchserver";
            launchserver.Size = new Size(155, 23);
            launchserver.TabIndex = 5;
            launchserver.Text = "Launch Into Our Server";
            launchserver.UseVisualStyleBackColor = false;
            launchserver.Click += launchserver_Click;
            // 
            // musicpanel
            // 
            musicpanel.BackColor = Color.FromArgb(128, 35, 35, 35);
            musicpanel.Controls.Add(volumebar);
            musicpanel.Controls.Add(playbtn);
            musicpanel.Controls.Add(stopbtn);
            musicpanel.Controls.Add(pausebtn);
            musicpanel.Location = new Point(12, 371);
            musicpanel.Name = "musicpanel";
            musicpanel.Size = new Size(192, 69);
            musicpanel.TabIndex = 6;
            // 
            // volumebar
            // 
            volumebar.BackColor = Color.FromArgb(35, 35, 35);
            volumebar.Location = new Point(3, 39);
            volumebar.Name = "volumebar";
            volumebar.Size = new Size(186, 45);
            volumebar.TabIndex = 7;
            volumebar.TickStyle = TickStyle.None;
            volumebar.Value = 5;
            volumebar.Scroll += volumebar_Scroll;
            // 
            // playbtn
            // 
            playbtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            playbtn.FlatStyle = FlatStyle.Flat;
            playbtn.Location = new Point(127, 8);
            playbtn.Name = "playbtn";
            playbtn.Size = new Size(46, 25);
            playbtn.TabIndex = 6;
            playbtn.Text = "Play";
            playbtn.UseVisualStyleBackColor = false;
            playbtn.Click += playbtn_Click;
            // 
            // stopbtn
            // 
            stopbtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            stopbtn.FlatStyle = FlatStyle.Flat;
            stopbtn.Location = new Point(65, 8);
            stopbtn.Name = "stopbtn";
            stopbtn.Size = new Size(56, 25);
            stopbtn.TabIndex = 5;
            stopbtn.Text = "Stop";
            stopbtn.UseVisualStyleBackColor = false;
            stopbtn.Click += stopbtn_Click;
            // 
            // pausebtn
            // 
            pausebtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            pausebtn.FlatStyle = FlatStyle.Flat;
            pausebtn.Location = new Point(3, 8);
            pausebtn.Name = "pausebtn";
            pausebtn.Size = new Size(56, 25);
            pausebtn.TabIndex = 4;
            pausebtn.Text = "Pause";
            pausebtn.UseVisualStyleBackColor = false;
            pausebtn.Click += pausebtn_Click;
            // 
            // aboutbtn
            // 
            aboutbtn.BackColor = Color.FromArgb(128, 30, 30, 30);
            aboutbtn.BackgroundImage = (Image)resources.GetObject("aboutbtn.BackgroundImage");
            aboutbtn.BackgroundImageLayout = ImageLayout.Zoom;
            aboutbtn.FlatStyle = FlatStyle.Flat;
            aboutbtn.Location = new Point(758, 415);
            aboutbtn.Name = "aboutbtn";
            aboutbtn.Size = new Size(30, 25);
            aboutbtn.TabIndex = 4;
            aboutbtn.UseVisualStyleBackColor = false;
            // 
            // Radioactive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(aboutbtn);
            Controls.Add(musicpanel);
            Controls.Add(launchserver);
            Controls.Add(startbtn);
            Controls.Add(dragpanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Radioactive";
            Text = " Rebellion Launcher";
            FormClosing += Radioactive_FormClosing;
            Load += Radioactive_Load;
            dragpanel.ResumeLayout(false);
            musicpanel.ResumeLayout(false);
            musicpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumebar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dragpanel;
        private Button exitbtn;
        private Button minimizebtn;
        private Button startbtn;
        private Button settingsbtn;
        private Button launchserver;
        private Panel musicpanel;
        private Button pausebtn;
        private Button stopbtn;
        private Button playbtn;
        private TrackBar volumebar;
        private Button aboutbtn;
    }
}