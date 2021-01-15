using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BatteryMonitor
{
    public partial class BatteryMonitorForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public BatteryMonitorForm()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Refreshes the form's controls with the current power status.
        /// </summary>
        private void RefreshStatus()
        {
            PowerStatus power = SystemInformation.PowerStatus;

            // Show the main power status
            switch (power.PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    MainsPower.Checked = true;
                    break;

                case PowerLineStatus.Offline:
                    MainsPower.Checked = false;
                    break;

                case PowerLineStatus.Unknown:
                    MainsPower.CheckState = CheckState.Indeterminate;
                    break;
            }

            // Power level
            int powerPercent = (int)(power.BatteryLifePercent * 100);
            if (powerPercent <= 100)
                BatteryIndicator.Value = powerPercent;
            else
                BatteryIndicator.Value = 0;

            // Battery Remaining
            int secondsRemaining = power.BatteryLifeRemaining;
            if (secondsRemaining >= 0)
            {
                BatteryLifeRemaining.Text = string.Format("{0} min", secondsRemaining / 60);
            }
            else
            {
                BatteryLifeRemaining.Text = string.Empty;
            }

            // Battery Status
            //BatteryStatus.Text = power.BatteryChargeStatus.ToString();

            BatteryStatus.Text = power.BatteryLifePercent.ToString();

        }



        /// <summary>
        /// Refresh the power status immediately on loading.
        /// </summary>
        private void BatteryMonitorForm_Load(object sender, EventArgs e)
        {
            RefreshStatus();
            RefreshTimer.Enabled = true;
        }



        /// <summary>
        /// Refresh the power status periodically.
        /// </summary>
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }
    }
}
