using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioAnalyzer;
using LightController.Commands;
using LightController.Settings;

namespace LightController.Forms
{
    public partial class SettingsForm : Form
    {
        private string selectedComPort;
        private int selectedBaudRate;

        public event EventHandler<AudioReactiveChangedEventArgs> AudioReactiveChanged;

        private MainForm mainForm;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            ApplyColorPalette(SettingsClass.Instance.ThemeColor);
            InitializeControls();
            SetDefaultComPort();
        }

        private void InitializeControls()
        {
            AddAvailableComPortsToComboBox();
            AddBaudRatesToComboBox();
            AddPropertiesToTableLayoutPanel();

            combo_baudRate.SelectedIndexChanged += Combo_baudRate_SelectedIndexChanged;
            combo_comPorts.SelectedIndexChanged += Combo_comPorts_SelectedIndexChanged;

            selectedComPort = "com3";
            selectedBaudRate = 115200;
            combo_baudRate.SelectedItem = selectedBaudRate.ToString();
        }
        private void checkBox_audio_reactive_CheckedChanged(object sender, EventArgs e)
        {
            AudioReactiveChanged?.Invoke(this, new AudioReactiveChangedEventArgs(checkBox_audio_reactive.Checked));
        }
        private void ApplyColorPalette(string paletteName)
        {
            if (ColorPalettes.Palettes.TryGetValue(paletteName, out List<Color> colors))
            {
                this.BackColor = colors[5];
                panel_ComPort.BackColor = colors[3];
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    // Pokud je ovládací prvek typu Panel, přidejte ho do kolekce
                    if (control is Panel panel)
                    {
                        panel.BackColor = colors[3];
                    }
                }
                panel_audio_reactive.BackColor = colors[3];
            }
        }

        private void AddAvailableComPortsToComboBox()
        {
            string[] ports = SerialPort.GetPortNames();
            combo_comPorts.Items.Clear();

            if (ports.Length == 0)
            {
                combo_comPorts.Items.Add("No COM ports available");
                combo_comPorts.BackColor = Color.Red;
                combo_comPorts.SelectedIndex = 0;
                combo_comPorts.Enabled = false;
            }
            else
            {
                foreach (string port in ports)
                {
                    bool isPortInUse = IsPortInUse(port);
                    ComPortItem portItem = new ComPortItem(port, isPortInUse);
                    combo_comPorts.Items.Add(portItem);

                    if (isPortInUse)
                    {
                        combo_comPorts.BackColor = Color.Red;
                    }
                    else
                    {
                        combo_comPorts.BackColor = Color.Green;
                    }
                }
                combo_comPorts.Enabled = true;
            }
        }

        private bool IsPortInUse(string portName)
        {
            bool result = false;
            try
            {
                using (var port = new SerialPort(portName))
                {
                    port.Open();
                    result = false;
                    port.Close();
                }
            }
            catch (UnauthorizedAccessException)
            {
                result = true;
            }
            catch (IOException)
            {
                result = true;
            }
            return result;
        }

        private void AddBaudRatesToComboBox()
        {
            int[] baudRates = { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 };
            foreach (int baudRate in baudRates)
            {
                combo_baudRate.Items.Add(baudRate.ToString());
            }
        }

        private void Combo_comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedComPort = combo_comPorts.SelectedItem?.ToString();
        }

        private void Combo_baudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBaudRate = int.Parse(combo_baudRate.SelectedItem.ToString());
        }

        private void SetDefaultComPort()
        {
            foreach (object item in combo_comPorts.Items)
            {
                if (item is ComPortItem portItem && !portItem.IsInUse)
                {
                    combo_comPorts.SelectedItem = item;
                    combo_comPorts.BackColor = Color.Green;
                    return;
                }
            }

            combo_comPorts.Items.Clear();
            combo_comPorts.Items.Add("No COM ports available");
            combo_comPorts.BackColor = Color.Red;
            combo_comPorts.SelectedIndex = 0;
            combo_comPorts.Enabled = false;
        }

        private void AddPropertiesToTableLayoutPanel()
        {
            BeatDetector det = mainForm.Detector;

            lbl_BeatThreshold.Text = $"Beat Threshold \n" + $"Current: {det.BeatThreshold * 100}\n".PadRight(5) + $"MIN: 0 - MAX: 100"; ;
            numericUpDown_BeatThreshold.Minimum = 0;
            numericUpDown_BeatThreshold.Maximum = 100;
            numericUpDown_BeatThreshold.Value = (decimal)(det.BeatThreshold * 100);
            numericUpDown_BeatThreshold.ValueChanged += (sender, e) =>
            {
                lbl_BeatThreshold.Text = $"Beat Threshold \n" + $"Current: {numericUpDown_BeatThreshold.Value}\n".PadRight(5) + $"MIN: 0 - MAX: 100";
                det.BeatThreshold = (float)numericUpDown_BeatThreshold.Value / 100f;
            };
            lbl_MinBeatGap.Text = $"Min Beat Gap \n" + $"Current: {det.MinBeatGap}\n".PadRight(5) + $"MIN: 0 - MAX: 1000";
            numericUpDown_MinBeatGap.Minimum = 0;
            numericUpDown_MinBeatGap.Maximum = 1000;
            numericUpDown_MinBeatGap.Value = det.MinBeatGap;
            numericUpDown_MinBeatGap.ValueChanged += (sender, e) =>
            {
                lbl_MinBeatGap.Text = $"Min Beat Gap \n" + $"Current: {numericUpDown_MinBeatGap.Value}\n".PadRight(5) + $"MIN: 0 - MAX: 1000";
                det.MinBeatGap = (int)numericUpDown_MinBeatGap.Value;
            };

            lbl_MinBeatWidth.Text = $"Min Beat Width \n" + $"Current: {det.MinBeatWidth}\n".PadRight(5) + $"MIN: 0 - MAX: 10";
            numericUpDown_MinBeatWidth.Minimum = 0;
            numericUpDown_MinBeatWidth.Maximum = 10;
            numericUpDown_MinBeatWidth.Value = det.MinBeatWidth;
            numericUpDown_MinBeatWidth.ValueChanged += (sender, e) =>
            {
                lbl_MinBeatWidth.Text = $"Min Beat Width \n" + $"Current: {numericUpDown_MinBeatWidth.Value}\n".PadRight(5) + $"MIN: 0 - MAX: 10";
                det.MinBeatWidth = (int)numericUpDown_MinBeatWidth.Value;
            };
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                SerialCommunication.Instance.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error closings serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                SerialCommunication.Instance.Connect(selectedComPort, selectedBaudRate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ComPortItem
    {
        public string PortName { get; set; }
        public bool IsInUse { get; set; }

        public ComPortItem(string portName, bool isInUse)
        {
            PortName = portName;
            IsInUse = isInUse;
        }

        public override string ToString()
        {
            return $"{PortName} {(IsInUse ? "(In Use)" : "")}";
        }
    }

    public class AudioReactiveChangedEventArgs : EventArgs
    {
        public bool IsAudioReactive { get; }

        public AudioReactiveChangedEventArgs(bool isAudioReactive)
        {
            IsAudioReactive = isAudioReactive;
        }
    }
}
