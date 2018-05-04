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
                // I really don't know why this needs to be less to stay in the same
                // place; if I was likely to use it again, then I'd worry.
                Jiggler.Jiggle(-4, -4);
                this.jiggleTimer.Interval = Program.JiggleInterval * 60 * 1000;
            }

            this.zig = !this.zig;
        }

        private void updateJiggleTimer()
        {
            this.jiggleTimer.Interval = Program.JiggleInterval * 60 * 1000;
        }

        private void cbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            updateJiggleTimer();
            this.jiggleTimer.Enabled = this.cbEnabled.Checked;
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            using (var a = new AboutBox())
                a.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.StartJiggling)
                this.cbEnabled.Checked = true;

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
    }
}
