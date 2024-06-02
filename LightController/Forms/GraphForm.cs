using AudioAnalyzer.Utils;
using AudioAnalyzer;
using CSCore.SoundIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Policy;
using LightController.Commands;
using LightController.Settings;

namespace LightController.Forms
{
    public partial class GraphForm : Form
    {
        private const int PeakUpdateInterval = 1;
        private DateTime lastPeakUpdate = DateTime.MinValue;
        private float maxLeftVolume = 0;
        private float maxRightVolume = 0;
        private float maxCombinedVolume = 0;
        private bool isAudioReactive = false;

        private SoundEnergyDetector detector;
        private WasapiLoopbackCapture wasapi;

        private MainForm mainForm;
        public GraphForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            detector = mainForm.Detector;
            wasapi = mainForm.Wasapi;

            InitializeGraph();
            mainForm.settingsForm_.AudioReactiveChanged += Settings_AudioReactiveChanged;

            ApplyColorPalette(SettingsClass.Instance.ThemeColor);
        }

        private void Settings_AudioReactiveChanged(object sender, AudioReactiveChangedEventArgs e)
        {
            isAudioReactive = e.IsAudioReactive;
        }

        private void InitializeGraph()
        {
            chart_visulizer.ChartAreas[0].AxisY.Maximum = 100;
            chart_visulizer.ChartAreas[0].AxisX.Minimum = 0;
            chart_visulizer.ChartAreas[0].AxisX.Maximum = detector.WindowSize;

            chart_volume.ChartAreas[0].AxisX.Minimum = 0;
            chart_volume.ChartAreas[0].AxisY.Maximum = 100;
            chart_volume.ChartAreas[0].AxisX.Maximum = 2;
        }

        private void ApplyColorPalette(string paletteName)
        {
            if (ColorPalettes.Palettes.TryGetValue(paletteName, out List<Color> colors))
            {
                this.BackColor = colors[5];
                panel_background.BackColor = colors[5];

                chart_visulizer.Series[0].Color = ColorTranslator.FromHtml("#076DF2");
                chart_visulizer.Series[1].Color = ColorTranslator.FromHtml("#F23838");
                chart_visulizer.Series[2].Color = ColorTranslator.FromHtml("#41D958");

                chart_volume.Series[0].Color = ColorTranslator.FromHtml("#41D958");
                chart_volume.Series[1].Color = ColorTranslator.FromHtml("#402B2B");
                chart_volume.Series[2].Color = ColorTranslator.FromHtml("#F23838");

                chart_volume.ChartAreas[0].AxisY.MajorGrid.LineColor = colors[3];


                chart_visulizer.ChartAreas[0].BackColor = Color.Transparent;
                chart_visulizer.BackColor = colors[3];

                chart_visulizer.ChartAreas[0].AxisX.MajorGrid.LineColor = colors[5];
                chart_visulizer.ChartAreas[0].AxisY.MajorGrid.LineColor = colors[5];

                chart_visulizer.ChartAreas[0].AxisX.MinorGrid.LineColor = colors[3];
                chart_visulizer.ChartAreas[0].AxisY.MinorGrid.LineColor = colors[3];

                chart_visulizer.ChartAreas[0].AxisX.LabelStyle.ForeColor = colors[4];
                chart_visulizer.ChartAreas[0].AxisY.LabelStyle.ForeColor = colors[4];

                chart_visulizer.Legends[0].ForeColor = colors[5];

                chart_visulizer.Legends[0].BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("Palette not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CallDetectorBeatDetected(object sender, BeatDetectedEventArgs e)
        {
            Detector_BeatDetected(sender, e);
        }

        public void CallWasapiDataAvailable(object sender, DataAvailableEventArgs e)
        {
            Wasapi_DataAvailable(sender, e);
        }
        private void Detector_BeatDetected(object sender, BeatDetectedEventArgs e)
        {
            Flash();
            /*chart_volume.Series[0].Points.Clear();
            chart_volume.Series[1].Points.Clear();

            chart_volume.Series[0].Points.AddXY(0, e.Value);
            chart_volume.Series[1].Points.AddXY(0, e.Value);*/
        }



        private void Flash()
        {
            if (isAudioReactive)
            {
                EffectController.ExecuteAll();
            }
            else
            {
                // Non-reactive behavior...
            }
        }


        // Process audio data
        private void Wasapi_DataAvailable(object sender, DataAvailableEventArgs e)
        {
            if (IsHandleCreated && !Disposing && !IsDisposed)
            {
                try
                {
                    Invoke(new Action(() =>
                    {
                        ClearChartSeries();
                        ProcessAudioData(e);
                        UpdatePeakVolumes(e);
                        UpdateGainLabel();
                    }));
                }
                catch (ObjectDisposedException)
                {
                }
            }
        }

        private void ClearChartSeries()
        {
            foreach (var item in chart_volume.Series)
            {
                item.Points.Clear();
            }
        }

        private void ProcessAudioData(DataAvailableEventArgs e)
        {
            var samples = PCMUtils.PCM32ToSamples(e.Data, e.ByteCount, 2);
            detector.ProcessData(samples);

            chart_visulizer.Series[0].Points.Clear();
            chart_visulizer.Series[1].Points.Clear();

            chart_visulizer.Series[2].Points.Clear();
            chart_visulizer.Series[2].Points.AddXY(0, detector.BeatThreshold.Map(0, 1, 0, 100));

            chart_visulizer.Series[2].Points.AddXY(detector.WindowSize, detector.BeatThreshold.Map(0, 1, 0, 100));

            for (int i = 0; i < detector.energyBuffer.Count; i++)
            {
                float remappedValue = detector.energyBuffer[i].Map(0, 2, 1, 100);

                chart_visulizer.Series[0].Points.Add(remappedValue);
                chart_visulizer.Series[1].Points.Add(detector.beatBuffer[i].Map(0, 1, 0, 100));
            }
            chart_visulizer.Series[0].ChartType = SeriesChartType.SplineArea;
            chart_visulizer.Series[1].ChartType = SeriesChartType.Column;
        }


        private void UpdatePeakVolumes(DataAvailableEventArgs e)
        {
            var leftChannelSamples = new float[e.ByteCount / 8];
            var rightChannelSamples = new float[e.ByteCount / 8];

            for (int i = 0; i < e.ByteCount; i += 8)
            {
                leftChannelSamples[i / 8] = BitConverter.ToSingle(e.Data, i);
                rightChannelSamples[i / 8] = BitConverter.ToSingle(e.Data, i + 4);
            }

            float leftVolume = CalculateRMSVolume(leftChannelSamples);
            float rightVolume = CalculateRMSVolume(rightChannelSamples);
            float combinedVolume = (leftVolume + rightVolume) / 2;

            // Update maximum volumes
            maxLeftVolume = Math.Max(maxLeftVolume, leftVolume).Map(0, 1, 0, 100);
            maxRightVolume = Math.Max(maxRightVolume, rightVolume).Map(0, 1, 0, 100);
            maxCombinedVolume = Math.Max(maxCombinedVolume, combinedVolume).Map(0, 1, 0, 100);


            // Check if it's time to update the peaks
            if ((DateTime.Now - lastPeakUpdate).TotalMilliseconds >= PeakUpdateInterval)
            {
                // Add the peak volumes to the series
                chart_volume.Series["Right Channel Volume"].Points.AddY(maxRightVolume);
                chart_volume.Series["Combined Volume"].Points.AddY(maxCombinedVolume);
                chart_volume.Series["Left Channel Volume"].Points.AddY(maxLeftVolume);

                // Remove old points to keep the graph updated


                // Reset maximum volumes
                maxLeftVolume = 0F;
                maxRightVolume = 0F;
                maxCombinedVolume = 0F;

                // Update last peak update time
                lastPeakUpdate = DateTime.Now;
            }

        }

        private void UpdateGainLabel()
        {
            string formattedGain = $"Gain: {detector.Gain:0.00}".PadRight(15);
            lbl_gain.Text = formattedGain;
        }


        private float CalculateRMSVolume(float[] samples)
        {
            float sumOfSquares = 0;
            foreach (float sample in samples)
            {
                sumOfSquares += sample * sample;
            }
            float rms = (float)Math.Sqrt(sumOfSquares / samples.Length);
            return rms;
        }

    }

    public static class ExtensionMethods
    {
        public static float Map(this float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
    }


}
