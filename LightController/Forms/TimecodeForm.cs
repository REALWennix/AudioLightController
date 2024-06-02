using System;
using System.Windows.Forms;
using System.Timers;
using LightController.Settings;
using System.Collections.Generic;
using System.Drawing;

namespace LightController.Forms
{
    public partial class TimecodeForm : Form
    {
        private readonly MainForm mainForm_;
        private System.Timers.Timer timer;
        private bool isRunning;
        private TimeSpan elapsedTime;
        private TimeSpan maxTimeLimit; // Maximum time limit
        private bool countUpMode; // Flag to indicate whether to count up or down
        private DateTime lastTickTime; // Track the time of the last tick

        public TimecodeForm(MainForm mainForm)
        {
            InitializeComponent();
            mainForm_ = mainForm;

            ApplyColorPalette(SettingsClass.Instance.ThemeColor);

            // Initialize timer
            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += Timer_Tick;

            // Set initial state
            isRunning = false;
            elapsedTime = TimeSpan.Zero;
            maxTimeLimit = TimeSpan.MaxValue; // Set initial maximum time limit to maximum value
            countUpMode = true; // Start in count up mode
            lastTickTime = DateTime.Now; // Initialize last tick time
        }
        private void ApplyColorPalette(string paletteName)
        {
            if (ColorPalettes.Palettes.TryGetValue(paletteName, out List<Color> colors))
            {
                this.BackColor = colors[5];
                panel_timecode.BackColor = colors[3];
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = colors[3];
                    }
                }
            }
        }

        private void Timer_Tick(object sender, ElapsedEventArgs e)
        {
            // Calculate the time elapsed since the last tick
            TimeSpan timeSinceLastTick = DateTime.Now - lastTickTime;
            lastTickTime = DateTime.Now; // Update last tick time

            if (countUpMode)
            {
                // Count up from zero
                elapsedTime = elapsedTime.Add(timeSinceLastTick);
            }
            else
            {
                // Count down from the specified maximum time limit
                elapsedTime = elapsedTime.Subtract(timeSinceLastTick);

                if (elapsedTime <= TimeSpan.Zero)
                {
                    timer.Stop();
                    isRunning = false;
                    MessageBox.Show("Time's up!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (elapsedTime < maxTimeLimit)
                {
                    UpdateTimecodeDisplay();
                }
                else
                {
                    // If elapsedTime exceeds maxTimeLimit, reset elapsedTime and stop the timer
                    elapsedTime = TimeSpan.Zero;
                    isRunning = false;
                    timer.Stop();
                    MessageBox.Show("Maximum time limit reached.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            UpdateTimecodeDisplay();
        }



        private void UpdateTimecodeDisplay()
        {
            if (lbl_timecode.InvokeRequired)
            {
                lbl_timecode.Invoke((MethodInvoker)delegate
                {
                    lbl_timecode.Text = elapsedTime.ToString(@"hh\:mm\:ss\.fff");
                });
            }
            else
            {
                lbl_timecode.Text = elapsedTime.ToString(@"hh\:mm\:ss\.fff");
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning && maxTimeLimit != TimeSpan.Zero) // Check if maxTimeLimit is set
            {
                lastTickTime = DateTime.Now; // Reset last tick time
                timer.Start();
                isRunning = true;

                // Disable buttons while timer is running
                btn_start.Enabled = false;
                btn_pause.Enabled = true;
                btn_stop.Enabled = true;
                btn_restart.Enabled = true; 
                btn_setmaxtime.Enabled = false;
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;

                // Enable buttons when timer is stopped
                btn_start.Enabled = true;
                btn_pause.Enabled = false;
                btn_stop.Enabled = false;
                btn_restart.Enabled = true;
                btn_setmaxtime.Enabled = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;

                // Enable buttons when timer is paused
                btn_start.Enabled = true;
                btn_pause.Enabled = false;
                btn_stop.Enabled = true;
                btn_restart.Enabled = true;
                btn_setmaxtime.Enabled = true;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            elapsedTime = TimeSpan.Zero;
            UpdateTimecodeDisplay();
            if (isRunning)
            {
                timer.Stop();
                timer.Start();
                // Keep restart button disabled while the timer is running
                btn_restart.Enabled = false;
            }
            else
            {
                btn_restart.Enabled = true;
            }
        }

        private void btnSetMaxTime_Click(object sender, EventArgs e)
        {
            // Open a dialog for the user to set the maximum time limit
            using (var form = new TimePickerForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    elapsedTime = new TimeSpan(form.SelectedHours, form.SelectedMinutes, form.SelectedSeconds);
                    UpdateTimecodeDisplay();
                    countUpMode = false;

                    // Disable buttons while timer is running
                    btn_start.Enabled = true;
                    btn_pause.Enabled = true;
                    btn_stop.Enabled = true;
                    btn_restart.Enabled = false; // Disable restart button while running
                    btn_setmaxtime.Enabled = false;
                }
                else
                {
                    // If the user cancels, default to zero time and count up mode
                    elapsedTime = TimeSpan.Zero;
                    UpdateTimecodeDisplay();
                    countUpMode = true;

                    // Enable buttons when timer is stopped
                    btn_start.Enabled = true;
                    btn_pause.Enabled = false;
                    btn_stop.Enabled = false;
                    btn_restart.Enabled = true;
                    btn_setmaxtime.Enabled = true;
                }
            }
        }

    }
}
