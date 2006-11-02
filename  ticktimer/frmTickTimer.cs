using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AMW.Tools.TickTimer
{
    public partial class frmTickTimer : Form
    {
        private int ticks;
        private int elaspedSeconds;

        // PlaySound()
        [DllImport("winmm.dll", SetLastError = true,
                                CallingConvention = CallingConvention.Winapi)]
        static extern bool PlaySound(string pszSound,IntPtr hMod,SoundFlags sf);

        // the sound from a filename, so we need only specify 
        // SND_FILENAME | SND_ASYNC
        [Flags]
        public enum SoundFlags : int
        {
            SND_SYNC = 0x0000,  // play synchronously (default) 
            SND_ASYNC = 0x0001,  // play asynchronously 
            SND_NODEFAULT = 0x0002,  // silence (!default) if sound not found 
            SND_MEMORY = 0x0004,  // pszSound points to a memory file
            SND_LOOP = 0x0008,  // loop the sound until next sndPlaySound 
            SND_NOSTOP = 0x0010,  // don't stop any currently playing sound 
            SND_NOWAIT = 0x00002000, // don't wait if the driver is busy 
            SND_ALIAS = 0x00010000, // name is a registry alias 
            SND_ALIAS_ID = 0x00110000, // alias is a predefined ID
            SND_FILENAME = 0x00020000, // name is file name 
            SND_RESOURCE = 0x00040004  // name is resource name or atom 
        }

        public frmTickTimer()
        {
            InitializeComponent();
        }

        private void btnFindSound_Click(object sender, EventArgs e)
        {
            this.ofdOpenSound.ShowDialog();
            this.txtFileLocation.Text = this.ofdOpenSound.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.txtElaspedTicks.Text = "";
            this.txtElaspedTime.Text = "";
            ticks = 0;
            elaspedSeconds = 0;

            this.tmrPlaySound.Interval = (int)(this.nudSeconds.Value) * 1000;
            this.tmrPlaySound.Start();
            this.tmrElapsedTime.Start();

            this.btnStop.Enabled = true;
            this.btnStart.Enabled = false;
            this.btnFindSound.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.tmrPlaySound.Stop();
            this.tmrElapsedTime.Stop();

            this.btnStart.Enabled = true;
            this.btnFindSound.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void tmrPlaySound_Tick(object sender, EventArgs e)
        {
            PlaySound(txtFileLocation.Text, IntPtr.Zero, SoundFlags.SND_FILENAME | SoundFlags.SND_ASYNC);
            ticks++;
            this.txtElaspedTicks.Text = ticks.ToString();

            if (this.nudTicks.Value > 0)
            {
                if (ticks >= this.nudTicks.Value)
                {
                    this.btnStop_Click(sender, e);
                }
            }
        }

        private void tmrElapsedTime_Tick(object sender, EventArgs e)
        {
            elaspedSeconds++;
            this.txtElaspedTime.Text = elaspedSeconds.ToString();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            abtTickTimer about = new abtTickTimer();
            about.ShowDialog();
        }
    }
}