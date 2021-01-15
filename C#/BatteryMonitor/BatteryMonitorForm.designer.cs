namespace BatteryMonitor
{
    partial class BatteryMonitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryMonitorForm));
            this.MainsPower = new System.Windows.Forms.CheckBox();
            this.BatteryIndicator = new System.Windows.Forms.ProgressBar();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.BatteryLifeRemaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BatteryStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainsPower
            // 
            this.MainsPower.AutoCheck = false;
            this.MainsPower.AutoSize = true;
            this.MainsPower.Location = new System.Drawing.Point(12, 12);
            this.MainsPower.Name = "MainsPower";
            this.MainsPower.Size = new System.Drawing.Size(145, 17);
            this.MainsPower.TabIndex = 0;
            this.MainsPower.Text = "Running on Mains Power";
            this.MainsPower.ThreeState = true;
            this.MainsPower.UseVisualStyleBackColor = true;
            // 
            // BatteryIndicator
            // 
            this.BatteryIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BatteryIndicator.Location = new System.Drawing.Point(12, 35);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(270, 23);
            this.BatteryIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BatteryIndicator.TabIndex = 1;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // BatteryLifeRemaining
            // 
            this.BatteryLifeRemaining.Location = new System.Drawing.Point(111, 71);
            this.BatteryLifeRemaining.Name = "BatteryLifeRemaining";
            this.BatteryLifeRemaining.Size = new System.Drawing.Size(168, 13);
            this.BatteryLifeRemaining.TabIndex = 2;
            this.BatteryLifeRemaining.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Charge remaining:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Battery status:";
            // 
            // BatteryStatus
            // 
            this.BatteryStatus.Location = new System.Drawing.Point(111, 92);
            this.BatteryStatus.Name = "BatteryStatus";
            this.BatteryStatus.Size = new System.Drawing.Size(168, 13);
            this.BatteryStatus.TabIndex = 4;
            this.BatteryStatus.Text = "?";
            // 
            // BatteryMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 117);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BatteryStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BatteryLifeRemaining);
            this.Controls.Add(this.BatteryIndicator);
            this.Controls.Add(this.MainsPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatteryMonitorForm";
            this.Text = "Battery Monitor";
            this.Load += new System.EventHandler(this.BatteryMonitorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MainsPower;
        private System.Windows.Forms.ProgressBar BatteryIndicator;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label BatteryLifeRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BatteryStatus;
    }
}

