namespace Music
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddSong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSavePlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLoadPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Extras = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.SlowerToolStripMenuItem05 = new System.Windows.Forms.ToolStripMenuItem();
            this.SlowertoolStripMenuItem07 = new System.Windows.Forms.ToolStripMenuItem();
            this.SlowertoolStripMenuItem09 = new System.Windows.Forms.ToolStripMenuItem();
            this.NormaltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FastertoolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.FastertoolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.FastertoolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.contextMenuStripPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlaylistStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.contextMenuStripProgressBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsongtime = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdered = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.contextMenuStripProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.Extras});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAddSong,
            this.toolStripMenuSavePlaylist,
            this.toolStripMenuLoadPlaylist,
            this.toolStripMenuAbout});
            this.toolStripMenuFile.Font = new System.Drawing.Font("MS Gothic", 9F);
            this.toolStripMenuFile.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuFile.Text = "File";
            // 
            // toolStripMenuAddSong
            // 
            this.toolStripMenuAddSong.Name = "toolStripMenuAddSong";
            this.toolStripMenuAddSong.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuAddSong.Text = "Add Song";
            this.toolStripMenuAddSong.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuSavePlaylist
            // 
            this.toolStripMenuSavePlaylist.Name = "toolStripMenuSavePlaylist";
            this.toolStripMenuSavePlaylist.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuSavePlaylist.Text = "Save Playlist";
            this.toolStripMenuSavePlaylist.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuLoadPlaylist
            // 
            this.toolStripMenuLoadPlaylist.Name = "toolStripMenuLoadPlaylist";
            this.toolStripMenuLoadPlaylist.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuLoadPlaylist.Text = "Load PLaylist";
            this.toolStripMenuLoadPlaylist.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuAbout
            // 
            this.toolStripMenuAbout.Name = "toolStripMenuAbout";
            this.toolStripMenuAbout.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuAbout.Text = "About";
            this.toolStripMenuAbout.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // Extras
            // 
            this.Extras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSpeed});
            this.Extras.Font = new System.Drawing.Font("MS Gothic", 9F);
            this.Extras.ForeColor = System.Drawing.Color.Red;
            this.Extras.Name = "Extras";
            this.Extras.Size = new System.Drawing.Size(53, 20);
            this.Extras.Text = "Extras";
            // 
            // toolStripMenuItemSpeed
            // 
            this.toolStripMenuItemSpeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SlowerToolStripMenuItem05,
            this.SlowertoolStripMenuItem07,
            this.SlowertoolStripMenuItem09,
            this.NormaltoolStripMenuItem,
            this.FastertoolStripMenuItem11,
            this.FastertoolStripMenuItem13,
            this.FastertoolStripMenuItem15});
            this.toolStripMenuItemSpeed.Name = "toolStripMenuItemSpeed";
            this.toolStripMenuItemSpeed.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemSpeed.Text = "Speed";
            // 
            // SlowerToolStripMenuItem05
            // 
            this.SlowerToolStripMenuItem05.Name = "SlowerToolStripMenuItem05";
            this.SlowerToolStripMenuItem05.Size = new System.Drawing.Size(106, 22);
            this.SlowerToolStripMenuItem05.Text = "x0.5";
            this.SlowerToolStripMenuItem05.Click += new System.EventHandler(this.SlowerToolStripMenuItem_Click);
            // 
            // SlowertoolStripMenuItem07
            // 
            this.SlowertoolStripMenuItem07.Name = "SlowertoolStripMenuItem07";
            this.SlowertoolStripMenuItem07.Size = new System.Drawing.Size(106, 22);
            this.SlowertoolStripMenuItem07.Text = "x0.7";
            this.SlowertoolStripMenuItem07.Click += new System.EventHandler(this.SlowertoolStripMenuItem07_Click);
            // 
            // SlowertoolStripMenuItem09
            // 
            this.SlowertoolStripMenuItem09.Name = "SlowertoolStripMenuItem09";
            this.SlowertoolStripMenuItem09.Size = new System.Drawing.Size(106, 22);
            this.SlowertoolStripMenuItem09.Text = "x0.9";
            this.SlowertoolStripMenuItem09.Click += new System.EventHandler(this.SlowertoolStripMenuItem09_Click);
            // 
            // NormaltoolStripMenuItem
            // 
            this.NormaltoolStripMenuItem.Name = "NormaltoolStripMenuItem";
            this.NormaltoolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.NormaltoolStripMenuItem.Text = "Normal";
            this.NormaltoolStripMenuItem.Click += new System.EventHandler(this.NormaltoolStripMenuItem_Click);
            // 
            // FastertoolStripMenuItem11
            // 
            this.FastertoolStripMenuItem11.Name = "FastertoolStripMenuItem11";
            this.FastertoolStripMenuItem11.Size = new System.Drawing.Size(106, 22);
            this.FastertoolStripMenuItem11.Text = "x1.1";
            this.FastertoolStripMenuItem11.Click += new System.EventHandler(this.FastertoolStripMenuItem11_Click);
            // 
            // FastertoolStripMenuItem13
            // 
            this.FastertoolStripMenuItem13.Name = "FastertoolStripMenuItem13";
            this.FastertoolStripMenuItem13.Size = new System.Drawing.Size(106, 22);
            this.FastertoolStripMenuItem13.Text = "x1.3";
            this.FastertoolStripMenuItem13.Click += new System.EventHandler(this.FastertoolStripMenuItem13_Click);
            // 
            // FastertoolStripMenuItem15
            // 
            this.FastertoolStripMenuItem15.Name = "FastertoolStripMenuItem15";
            this.FastertoolStripMenuItem15.Size = new System.Drawing.Size(106, 22);
            this.FastertoolStripMenuItem15.Text = "x1.5";
            this.FastertoolStripMenuItem15.Click += new System.EventHandler(this.FastertoolStripMenuItem15_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPlaylist.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBoxPlaylist.ContextMenuStrip = this.contextMenuStripPlaylist;
            this.listBoxPlaylist.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlaylist.ForeColor = System.Drawing.Color.Red;
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 12;
            this.listBoxPlaylist.Location = new System.Drawing.Point(12, 87);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(398, 88);
            this.listBoxPlaylist.TabIndex = 1;
            // 
            // contextMenuStripPlaylist
            // 
            this.contextMenuStripPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem,
            this.savePlaylistToolStripMenuItem,
            this.loadPlaylistStripMenuItem1});
            this.contextMenuStripPlaylist.Name = "contextMenuStripPlaylist";
            this.contextMenuStripPlaylist.Size = new System.Drawing.Size(141, 70);
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addSongToolStripMenuItem.Text = "Add Song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.addSongToolStripMenuItem_Click);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // loadPlaylistStripMenuItem1
            // 
            this.loadPlaylistStripMenuItem1.Name = "loadPlaylistStripMenuItem1";
            this.loadPlaylistStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.loadPlaylistStripMenuItem1.Text = "Load Playlist";
            this.loadPlaylistStripMenuItem1.Click += new System.EventHandler(this.loadPlaylistStripMenuItem1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.BackColor = System.Drawing.Color.Red;
            this.buttonPlay.Font = new System.Drawing.Font("Mustafa", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(12, 206);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 65);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStop.Font = new System.Drawing.Font("Mustafa", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonStop.Location = new System.Drawing.Point(93, 206);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 65);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBack.Font = new System.Drawing.Font("Mustafa", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(174, 206);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 65);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPause.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPause.Font = new System.Drawing.Font("Mustafa", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonPause.Location = new System.Drawing.Point(255, 206);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 65);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonForward.BackColor = System.Drawing.Color.DarkGray;
            this.buttonForward.Font = new System.Drawing.Font("Mustafa", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonForward.Location = new System.Drawing.Point(336, 206);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(75, 65);
            this.buttonForward.TabIndex = 6;
            this.buttonForward.Text = "Next";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(344, 277);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBar.BackColor = System.Drawing.Color.DarkGray;
            this.progressBar.ContextMenuStrip = this.contextMenuStripProgressBar;
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(12, 69);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(399, 12);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 8;
            this.progressBar.ForeColorChanged += new System.EventHandler(this.toolStripMenuItemChangeColor_Click);
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // contextMenuStripProgressBar
            // 
            this.contextMenuStripProgressBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemChangeColor});
            this.contextMenuStripProgressBar.Name = "contextMenuStripProgressBar";
            this.contextMenuStripProgressBar.Size = new System.Drawing.Size(148, 26);
            // 
            // toolStripMenuItemChangeColor
            // 
            this.toolStripMenuItemChangeColor.Name = "toolStripMenuItemChangeColor";
            this.toolStripMenuItemChangeColor.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemChangeColor.Text = "Change Color";
            this.toolStripMenuItemChangeColor.Click += new System.EventHandler(this.toolStripMenuItemChangeColor_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsongtime
            // 
            this.lblsongtime.AutoSize = true;
            this.lblsongtime.Font = new System.Drawing.Font("Mustafa", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lblsongtime.Location = new System.Drawing.Point(12, 41);
            this.lblsongtime.Name = "lblsongtime";
            this.lblsongtime.Size = new System.Drawing.Size(53, 25);
            this.lblsongtime.TabIndex = 9;
            this.lblsongtime.Text = "00:00";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Black;
            this.lblClose.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(398, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 19);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Black;
            this.lblMin.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMin.ForeColor = System.Drawing.Color.Red;
            this.lblMin.Location = new System.Drawing.Point(372, 2);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(20, 19);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "-";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(12, 277);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(156, 45);
            this.trackBarVolume.TabIndex = 14;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.Value = 30;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("MS Gothic", 9F);
            this.lblVolume.Location = new System.Drawing.Point(174, 277);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(17, 12);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "30";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Font = new System.Drawing.Font("MS Gothic", 9F);
            this.radioButtonRandom.Location = new System.Drawing.Point(191, 277);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(119, 16);
            this.radioButtonRandom.TabIndex = 16;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Play random song";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrdered
            // 
            this.radioButtonOrdered.AutoSize = true;
            this.radioButtonOrdered.Font = new System.Drawing.Font("MS Gothic", 9F);
            this.radioButtonOrdered.Location = new System.Drawing.Point(191, 300);
            this.radioButtonOrdered.Name = "radioButtonOrdered";
            this.radioButtonOrdered.Size = new System.Drawing.Size(107, 16);
            this.radioButtonOrdered.TabIndex = 17;
            this.radioButtonOrdered.TabStop = true;
            this.radioButtonOrdered.Text = "Play next song";
            this.radioButtonOrdered.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(419, 333);
            this.Controls.Add(this.radioButtonOrdered);
            this.Controls.Add(this.radioButtonRandom);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblsongtime);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 376);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZB Music";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.contextMenuStripProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddSong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSavePlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLoadPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAbout;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonForward;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsongtime;
        private System.Windows.Forms.ToolStripMenuItem Extras;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlaylist;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlaylistStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangeColor;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonOrdered;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpeed;
        private System.Windows.Forms.ToolStripMenuItem SlowerToolStripMenuItem05;
        private System.Windows.Forms.ToolStripMenuItem SlowertoolStripMenuItem07;
        private System.Windows.Forms.ToolStripMenuItem SlowertoolStripMenuItem09;
        private System.Windows.Forms.ToolStripMenuItem NormaltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FastertoolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem FastertoolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem FastertoolStripMenuItem15;
        private System.Windows.Forms.ListBox listBoxPlaylist;
    }
}

