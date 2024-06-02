using System;
using System.Windows.Forms;

namespace LightController.Forms
{
    public partial class TimePickerForm : Form
    {
        public int SelectedHours => (int)numericUpDownHours.Value;
        public int SelectedMinutes => (int)numericUpDownMinutes.Value;
        public int SelectedSeconds => (int)numericUpDownSeconds.Value;

        public TimePickerForm()
        {
            InitializeComponent();

            // Set maximum values for hours, minutes, and seconds
            numericUpDownHours.Maximum = 23;
            numericUpDownMinutes.Maximum = 59;
            numericUpDownSeconds.Maximum = 59;

            numericUpDownMinutes.ValueChanged += NumericUpDownMinutes_ValueChanged;
            numericUpDownSeconds.ValueChanged += NumericUpDownSeconds_ValueChanged;
            UpdateTimecodeDisplay();
        }

        private void NumericUpDownMinutes_ValueChanged(object sender, EventArgs e)
        {
            // If minutes value exceeds 59, increment hours and reset minutes to 0
            if (numericUpDownMinutes.Value > 59)
            {
                numericUpDownHours.Value++;
                numericUpDownMinutes.Value = 0;
            }
            UpdateTimecodeDisplay();
        }

        private void NumericUpDownSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSeconds.Value > 59)
            {
                numericUpDownMinutes.Value++;
                numericUpDownSeconds.Value = 0;
            }
            UpdateTimecodeDisplay();
        }
        private void UpdateTimecodeDisplay()
        {
            // Ensure that the values are within the valid range (0-23 for hours, 0-59 for minutes and seconds)
            int hours = (int)numericUpDownHours.Value;
            int minutes = (int)numericUpDownMinutes.Value;
            int seconds = (int)numericUpDownSeconds.Value;

            // Validate hours
            if (hours < 0 || hours > 23)
            {
                hours = 0; // Default to 0 if the value is out of range
            }

            // Validate minutes
            if (minutes < 0 || minutes > 59)
            {
                minutes = 0;
            }

            // Validate seconds
            if (seconds < 0 || seconds > 59)
            {
                seconds = 0;
            }

            // Update the label to display the selected time in the format "HH:MM:SS"
            lbl_TIMECODE.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
