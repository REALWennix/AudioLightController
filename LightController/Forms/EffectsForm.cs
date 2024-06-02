using LightController.Commands;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
using LightController.Settings;

namespace LightController.Forms
{
    public partial class EffectsForm : Form
    {
        private bool isOn;
        private MainForm mainForm;

        private const int DefaultDelay = 90;

        public EffectsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            numericUpDown_effect_delay.Value = SettingsClass.Instance.DefaultDelay;

            ApplyColorPalette(SettingsClass.Instance.ThemeColor);
        }

        private void ApplyColorPalette(string palette)
        {
            if (ColorPalettes.Palettes.TryGetValue(palette, out List<Color> colors))
            {
                BackColor = colors[5];
                panel_info.BackColor = colors[4];
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Panel panel)
                    {
                        panel.BackColor = colors[2];
                    }
                }
                flowLayoutPanel2.BackColor = colors[3];
            }
            else
            {
                MessageBox.Show("Palette not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exec_all_Click(object sender, EventArgs e)
        {
            EffectController.ExecuteAll();
        }

        private void btn_on_off_all_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                EffectController.TurnOff();
                isOn = false;
                btn_on_off_all.BackColor = ColorTranslator.FromHtml("#F23838");
            }
            else
            {
                EffectController.TurnOn();
                isOn = true;
                btn_on_off_all.BackColor = ColorTranslator.FromHtml("#41D958");
            }
        }

        private void numericUpDown_effect_delay_ValueChanged(object sender, EventArgs e)
        {
            int duration = (int)numericUpDown_effect_delay.Value;

            const int MinDelay = 2;
            const int MaxDelay = 99999;
            numericUpDown_effect_delay.Minimum = MinDelay;
            numericUpDown_effect_delay.Maximum = MaxDelay;

            duration = Math.Max(MinDelay, Math.Min(MaxDelay, duration));

            EffectController.SetDurationAll(duration);

            lbl_effect_delay.Text = $"Effect Delay: {duration} ms";
        }

        private void btn_default_delay_Click(object sender, EventArgs e)
        {
            numericUpDown_effect_delay.Value = SettingsClass.Instance.DefaultDelay;

            lbl_effect_delay.Text = $"Effect Delay: {SettingsClass.Instance.DefaultDelay} ms";
            EffectController.ResetDurationAll();
        }
    }
}
