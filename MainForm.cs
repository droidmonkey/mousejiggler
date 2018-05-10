#region header

// MouseJiggle - MainForm.cs
// 
// Alistair J. R. Young
// Arkane Systems
// 
// Copyright Arkane Systems 2012-2013.
// 
// Created: 2013-08-24 12:41 PM

#endregion

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Microsoft.Win32;

namespace ArkaneSystems.MouseJiggle
{
    public partial class MainForm : Form
    {
        private const int MOUSEMOVE = 8;
        protected bool zig = true;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void jiggleTimer_Tick(object sender, EventArgs e)
        {
            if (this.zig)
            {
                Jiggler.Jiggle(4, 4);
                this.jiggleTimer.Interval = 500;
            }
            else // zag
            {
                Jiggler.Jiggle(-4, -4);
                this.jiggleTimer.Interval = Program.JiggleInterval * 60 * 1000;
            }

            this.zig = !this.zig;
        }

        private void updateJiggleTimer()
        {
            this.jiggleTimer.Interval = Program.JiggleInterval * 60 * 1000;
        }

        private void cbEnabledJiggle_CheckedChanged(object sender, EventArgs e)
        {
            updateJiggleTimer();
            this.jiggleTimer.Enabled = this.cbEnableJiggle.Checked;
            this.intervalUpDown.Enabled = this.cbEnableJiggle.Checked;
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            using (var a = new AboutBox())
                a.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.StartJiggling)
                this.cbEnableJiggle.Checked = true;

            if (Program.StartScreenOn)
                this.cbKeepScreenOn.Checked = true;

            if (Program.StartMinimized)
                this.cmdToTray_Click(this, null);

            this.intervalUpDown.Value = Program.JiggleInterval;
        }

        private void cmdToTray_Click (object sender, EventArgs e)
        {
            // minimize to tray
            this.Visible = false;

            // remove from taskbar
            this.ShowInTaskbar = false;

            // show tray icon
            this.nifMin.Visible = true;
        }

        private void nifMin_DoubleClick(object sender, EventArgs e)
        {
            // restore the window
            this.Visible = true;

            // replace in taskbar
            this.ShowInTaskbar = true;

            // hide tray icon
            this.nifMin.Visible = false;
        }

        private void intervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            Program.JiggleInterval = (int) ((NumericUpDown)sender).Value;
            updateJiggleTimer();
        }

        private void cbKeepScreenOn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbKeepScreenOn.Checked)
                NativeMethods.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
            else
                NativeMethods.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
        }
    }

    public enum EXECUTION_STATE : uint
    {
        ES_AWAYMODE_REQUIRED = 0x00000040,
        ES_CONTINUOUS = 0x80000000,
        ES_DISPLAY_REQUIRED = 0x00000002,
        ES_SYSTEM_REQUIRED = 0x00000001
    }

    internal class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
    }
}
