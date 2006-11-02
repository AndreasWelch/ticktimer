namespace AMW.Tools.TickTimer
{
    partial class frmTickTimer
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
            this.btnFindSound = new System.Windows.Forms.Button();
            this.lblChooseSound = new System.Windows.Forms.Label();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.ofdOpenSound = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSecondsToDelay = new System.Windows.Forms.Label();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.txtElaspedTime = new System.Windows.Forms.TextBox();
            this.lblElaspedTicks = new System.Windows.Forms.Label();
            this.txtElaspedTicks = new System.Windows.Forms.TextBox();
            this.lblMaxTicks = new System.Windows.Forms.Label();
            this.nudTicks = new System.Windows.Forms.NumericUpDown();
            this.tmrPlaySound = new System.Windows.Forms.Timer(this.components);
            this.tmrElapsedTime = new System.Windows.Forms.Timer(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindSound
            // 
            this.btnFindSound.Location = new System.Drawing.Point(372, 4);
            this.btnFindSound.Name = "btnFindSound";
            this.btnFindSound.Size = new System.Drawing.Size(75, 23);
            this.btnFindSound.TabIndex = 0;
            this.btnFindSound.Text = "...";
            this.btnFindSound.UseVisualStyleBackColor = true;
            this.btnFindSound.Click += new System.EventHandler(this.btnFindSound_Click);
            // 
            // lblChooseSound
            // 
            this.lblChooseSound.AutoSize = true;
            this.lblChooseSound.Location = new System.Drawing.Point(12, 9);
            this.lblChooseSound.Name = "lblChooseSound";
            this.lblChooseSound.Size = new System.Drawing.Size(80, 13);
            this.lblChooseSound.TabIndex = 1;
            this.lblChooseSound.Text = "Choose Sound:";
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(98, 6);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(268, 20);
            this.txtFileLocation.TabIndex = 2;
            this.txtFileLocation.Text = "C:\\WINDOWS\\Media\\ding.wav";
            // 
            // ofdOpenSound
            // 
            this.ofdOpenSound.Filter = "Sound Files|*.wav";
            this.ofdOpenSound.SupportMultiDottedExtensions = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(138, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSecondsToDelay
            // 
            this.lblSecondsToDelay.AutoSize = true;
            this.lblSecondsToDelay.Location = new System.Drawing.Point(12, 46);
            this.lblSecondsToDelay.Name = "lblSecondsToDelay";
            this.lblSecondsToDelay.Size = new System.Drawing.Size(98, 13);
            this.lblSecondsToDelay.TabIndex = 4;
            this.lblSecondsToDelay.Text = "Seconds To Delay:";
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(116, 44);
            this.nudSeconds.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(63, 20);
            this.nudSeconds.TabIndex = 6;
            this.nudSeconds.ThousandsSeparator = true;
            this.nudSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(229, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Location = new System.Drawing.Point(12, 96);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(125, 13);
            this.lblElapsedTime.TabIndex = 8;
            this.lblElapsedTime.Text = "Elapsed Time (Seconds):";
            // 
            // txtElaspedTime
            // 
            this.txtElaspedTime.Location = new System.Drawing.Point(143, 93);
            this.txtElaspedTime.Name = "txtElaspedTime";
            this.txtElaspedTime.ReadOnly = true;
            this.txtElaspedTime.Size = new System.Drawing.Size(73, 20);
            this.txtElaspedTime.TabIndex = 9;
            // 
            // lblElaspedTicks
            // 
            this.lblElaspedTicks.AutoSize = true;
            this.lblElaspedTicks.Location = new System.Drawing.Point(246, 96);
            this.lblElaspedTicks.Name = "lblElaspedTicks";
            this.lblElaspedTicks.Size = new System.Drawing.Size(77, 13);
            this.lblElaspedTicks.TabIndex = 12;
            this.lblElaspedTicks.Text = "Elapsed Ticks:";
            // 
            // txtElaspedTicks
            // 
            this.txtElaspedTicks.Location = new System.Drawing.Point(329, 93);
            this.txtElaspedTicks.Name = "txtElaspedTicks";
            this.txtElaspedTicks.ReadOnly = true;
            this.txtElaspedTicks.Size = new System.Drawing.Size(65, 20);
            this.txtElaspedTicks.TabIndex = 13;
            // 
            // lblMaxTicks
            // 
            this.lblMaxTicks.AutoSize = true;
            this.lblMaxTicks.Location = new System.Drawing.Point(246, 46);
            this.lblMaxTicks.Name = "lblMaxTicks";
            this.lblMaxTicks.Size = new System.Drawing.Size(59, 13);
            this.lblMaxTicks.TabIndex = 14;
            this.lblMaxTicks.Text = "Max Ticks:";
            // 
            // nudTicks
            // 
            this.nudTicks.Location = new System.Drawing.Point(311, 44);
            this.nudTicks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTicks.Name = "nudTicks";
            this.nudTicks.Size = new System.Drawing.Size(63, 20);
            this.nudTicks.TabIndex = 15;
            // 
            // tmrPlaySound
            // 
            this.tmrPlaySound.Tick += new System.EventHandler(this.tmrPlaySound_Tick);
            // 
            // tmrElapsedTime
            // 
            this.tmrElapsedTime.Interval = 1000;
            this.tmrElapsedTime.Tick += new System.EventHandler(this.tmrElapsedTime_Tick);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(425, 137);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(24, 23);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmTickTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 172);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.nudTicks);
            this.Controls.Add(this.lblMaxTicks);
            this.Controls.Add(this.txtElaspedTicks);
            this.Controls.Add(this.lblElaspedTicks);
            this.Controls.Add(this.txtElaspedTime);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.lblSecondsToDelay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.lblChooseSound);
            this.Controls.Add(this.btnFindSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmTickTimer";
            this.Text = "Tick Timer";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindSound;
        private System.Windows.Forms.Label lblChooseSound;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.OpenFileDialog ofdOpenSound;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSecondsToDelay;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.TextBox txtElaspedTime;
        private System.Windows.Forms.Label lblElaspedTicks;
        private System.Windows.Forms.TextBox txtElaspedTicks;
        private System.Windows.Forms.Label lblMaxTicks;
        private System.Windows.Forms.NumericUpDown nudTicks;
        private System.Windows.Forms.Timer tmrPlaySound;
        private System.Windows.Forms.Timer tmrElapsedTime;
        private System.Windows.Forms.Button btnAbout;
    }
}

