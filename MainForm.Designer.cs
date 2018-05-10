namespace ArkaneSystems.MouseJiggle
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.jiggleTimer = new System.Windows.Forms.Timer(this.components);
            this.cbEnableJiggle = new System.Windows.Forms.CheckBox();
            this.cmdToTray = new System.Windows.Forms.Button();
            this.nifMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.intervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKeepScreenOn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // jiggleTimer
            // 
            this.jiggleTimer.Interval = 1000;
            this.jiggleTimer.Tick += new System.EventHandler(this.jiggleTimer_Tick);
            // 
            // cbEnableJiggle
            // 
            this.cbEnableJiggle.AutoSize = true;
            this.cbEnableJiggle.Location = new System.Drawing.Point(12, 30);
            this.cbEnableJiggle.Name = "cbEnableJiggle";
            this.cbEnableJiggle.Size = new System.Drawing.Size(86, 17);
            this.cbEnableJiggle.TabIndex = 0;
            this.cbEnableJiggle.Text = "Enable jiggle";
            this.cbEnableJiggle.UseVisualStyleBackColor = true;
            this.cbEnableJiggle.CheckedChanged += new System.EventHandler(this.cbEnabledJiggle_CheckedChanged);
            // 
            // cmdToTray
            // 
            this.cmdToTray.Image = ((System.Drawing.Image)(resources.GetObject("cmdToTray.Image")));
            this.cmdToTray.Location = new System.Drawing.Point(119, 7);
            this.cmdToTray.Name = "cmdToTray";
            this.cmdToTray.Size = new System.Drawing.Size(33, 23);
            this.cmdToTray.TabIndex = 3;
            this.cmdToTray.UseVisualStyleBackColor = true;
            this.cmdToTray.Click += new System.EventHandler(this.cmdToTray_Click);
            // 
            // nifMin
            // 
            this.nifMin.Icon = ((System.Drawing.Icon)(resources.GetObject("nifMin.Icon")));
            this.nifMin.Text = "Mouse Jiggler";
            this.nifMin.DoubleClick += new System.EventHandler(this.nifMin_DoubleClick);
            // 
            // intervalUpDown
            // 
            this.intervalUpDown.Enabled = false;
            this.intervalUpDown.Location = new System.Drawing.Point(12, 53);
            this.intervalUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.intervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalUpDown.Name = "intervalUpDown";
            this.intervalUpDown.Size = new System.Drawing.Size(43, 20);
            this.intervalUpDown.TabIndex = 4;
            this.intervalUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intervalUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalUpDown.ValueChanged += new System.EventHandler(this.intervalUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval (min)";
            // 
            // cbKeepScreenOn
            // 
            this.cbKeepScreenOn.AutoSize = true;
            this.cbKeepScreenOn.Location = new System.Drawing.Point(12, 7);
            this.cbKeepScreenOn.Name = "cbKeepScreenOn";
            this.cbKeepScreenOn.Size = new System.Drawing.Size(101, 17);
            this.cbKeepScreenOn.TabIndex = 6;
            this.cbKeepScreenOn.Text = "Keep screen on";
            this.cbKeepScreenOn.UseVisualStyleBackColor = true;
            this.cbKeepScreenOn.CheckedChanged += new System.EventHandler(this.cbKeepScreenOn_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 84);
            this.Controls.Add(this.cbKeepScreenOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalUpDown);
            this.Controls.Add(this.cmdToTray);
            this.Controls.Add(this.cbEnableJiggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MouseJiggle";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer jiggleTimer;
        private System.Windows.Forms.CheckBox cbEnableJiggle;
        private System.Windows.Forms.Button cmdToTray;
        private System.Windows.Forms.NotifyIcon nifMin;
        private System.Windows.Forms.NumericUpDown intervalUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbKeepScreenOn;
    }
}

