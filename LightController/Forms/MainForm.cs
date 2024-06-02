using AudioAnalyzer;
using CSCore.SoundIn;
using LightController.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LightController.Forms
{
    public partial class MainForm : Form
    {
        public SettingsForm settingsForm_;
        public GraphForm graphForm_;
        public EffectsForm effectsForm_;
        public AboutForm aboutForm_;
        public TimecodeForm timecodeForm_;
        private SoundEnergyDetector detector_;
        private WasapiLoopbackCapture wasapi_;
        public SoundEnergyDetector Detector
        {
            get { return detector_; }
            set { detector_ = value; }
        }

        public WasapiLoopbackCapture Wasapi
        {
            get { return wasapi_; }
            set { wasapi_ = value; }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private bool isDragging_ = false;
        private Point lastCursor_;
        private Point lastForm_;

        private Image normalImage_;
        private Image maximizedImage_;

        public MainForm()
        {
            Application.ApplicationExit += Application_ApplicationExit;
            InitializeComponent();

            detector_ = new SoundEnergyDetector();
            wasapi_ = new WasapiLoopbackCapture(10);
            wasapi_.Initialize();
            wasapi_.Start();

            normalImage_ = Properties.Resources.minimize_window;
            maximizedImage_ = Properties.Resources.maximize_window;

            InitializeSubForms();
            ApplyColorPalette("blue-black");

            detector_.BeatDetected += graphForm_.CallDetectorBeatDetected;
            wasapi_.DataAvailable += graphForm_.CallWasapiDataAvailable;
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ApplyColorPalette(string paletteName)
        {
            if (ColorPalettes.Palettes.TryGetValue(paletteName, out List<Color> colors))
            {
                this.BackColor = colors[5];
                btn_close.BackColor = colors[3];
                btn_list.BackColor = colors[3];
                btn_resize.BackColor = colors[3];
                sideBarPanel.BackColor = colors[4];
                menuIcon.BackColor = colors[1];
                windowButtons.BackColor = colors[2];

            }
        }
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        [Flags]
        enum AnimateWindowFlags : int
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }
        private void btn_resize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                AnimateWindow(this.Handle, 200, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_HOR_POSITIVE);
                this.WindowState = FormWindowState.Maximized;
                btn_resize.Image = maximizedImage_;
            }
            else
            {
                AnimateWindow(this.Handle, 200, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_HOR_NEGATIVE);
                this.WindowState = FormWindowState.Normal;
                btn_resize.Image = normalImage_;
            }
        }
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging_)
            {
                int deltaX = Cursor.Position.X - lastCursor_.X;
                int deltaY = Cursor.Position.Y - lastCursor_.Y;
                this.Location = new Point(lastForm_.X + deltaX, lastForm_.Y + deltaY);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
                isDragging_ = false;
            }
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            SerialCommunication.Instance.Close();
            wasapi_.Stop();
            wasapi_.DataAvailable -= graphForm_.CallWasapiDataAvailable;
            wasapi_.Dispose();
        }

        bool sidebarExpanded = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sideBarPanel.Width -= 25;
                if (sideBarPanel.Width <= 90)
                {
                    sidebarExpanded = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sideBarPanel.Width += 25;
                if (sideBarPanel.Width >= 250)
                {
                    sidebarExpanded = true;
                    sidebarTransition.Stop();
                }
            }
        }
        private void InitializeSubForms()
        {
            // Initialize settingsForm_
            settingsForm_ = new SettingsForm(this);
            settingsForm_.Owner = this;
            settingsForm_.TopLevel = false;
            settingsForm_.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(settingsForm_);
            settingsForm_.Dock = DockStyle.Fill;


            graphForm_ = new GraphForm(this);
            graphForm_.Owner = this;
            graphForm_.TopLevel = false;
            graphForm_.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(graphForm_);
            graphForm_.Dock = DockStyle.Fill;


            effectsForm_ = new EffectsForm(this);
            effectsForm_.Owner = this;
            effectsForm_.TopLevel = false;
            effectsForm_.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(effectsForm_);
            effectsForm_.Dock = DockStyle.Fill;

            aboutForm_ = new AboutForm(this);
            aboutForm_.Owner = this;
            aboutForm_.TopLevel = false;
            aboutForm_.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(aboutForm_);
            aboutForm_.Dock = DockStyle.Fill;

            timecodeForm_ = new TimecodeForm(this);
            timecodeForm_.Owner = this;
            timecodeForm_.TopLevel = false;
            timecodeForm_.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(timecodeForm_);
            timecodeForm_.Dock = DockStyle.Fill;

        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging_ = true;
                lastCursor_ = Cursor.Position;
                lastForm_ = this.Location;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging_)
            {
                int deltaX = Cursor.Position.X - lastCursor_.X;
                int deltaY = Cursor.Position.Y - lastCursor_.Y;
                this.Location = new Point(lastForm_.X + deltaX, lastForm_.Y + deltaY);
            }
        }

        // Method to toggle between maximized and normal window states
        private void ToggleWindowState()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // If currently maximized, restore to normal state
                WindowState = FormWindowState.Normal;
            }
            else
            {
                // If currently normal, maximize the window
                WindowState = FormWindowState.Maximized;
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging_ = false;
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (settingsForm_ != null && !settingsForm_.IsDisposed)
            {
                settingsForm_.Show();
                settingsForm_.BringToFront();
            }
            else
            {
                settingsForm_ = new SettingsForm(this);
                settingsForm_.Owner = this;
                settingsForm_.TopLevel = false;
                settingsForm_.FormBorderStyle = FormBorderStyle.None;
                panel_main.Controls.Add(settingsForm_);
                settingsForm_.Dock = DockStyle.Fill;
                settingsForm_.Show();
                settingsForm_.BringToFront();
            }
        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            if (graphForm_ != null && !graphForm_.IsDisposed)
            {
                graphForm_.Show();
                graphForm_.BringToFront();
            }
            else
            {
                graphForm_ = new GraphForm(this);
                graphForm_.Owner = this;
                graphForm_.TopLevel = false;
                graphForm_.FormBorderStyle = FormBorderStyle.None;
                panel_main.Controls.Add(graphForm_);
                graphForm_.Dock = DockStyle.Fill;
                graphForm_.Show();
                graphForm_.BringToFront();
            }
        }

        private void btn_Effects_Click(object sender, EventArgs e)
        {
            if (effectsForm_ != null && !effectsForm_.IsDisposed)
            {
                effectsForm_.Show();
                effectsForm_.BringToFront();
            }
            else
            {
                effectsForm_ = new EffectsForm(this);
                effectsForm_.Owner = this;
                effectsForm_.TopLevel = false;
                effectsForm_.FormBorderStyle = FormBorderStyle.None;
                panel_main.Controls.Add(effectsForm_);
                effectsForm_.Dock = DockStyle.Fill;
                effectsForm_.Show();
                effectsForm_.BringToFront();
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            if (aboutForm_ != null && !aboutForm_.IsDisposed)
            {
                aboutForm_.Show();
                aboutForm_.BringToFront();
            }
            else
            {
                aboutForm_ = new AboutForm(this);
                aboutForm_.Owner = this;
                aboutForm_.TopLevel = false;
                aboutForm_.FormBorderStyle = FormBorderStyle.None;
                panel_main.Controls.Add(aboutForm_);
                aboutForm_.Dock = DockStyle.Fill;
                aboutForm_.Show();
                aboutForm_.BringToFront();
            }
        }

        private void btn_timecode_Click(object sender, EventArgs e)
        {
            if (timecodeForm_ != null && !timecodeForm_.IsDisposed)
            {
                timecodeForm_.Show();
                timecodeForm_.BringToFront();
            }
            else
            {
                timecodeForm_ = new TimecodeForm(this);
                timecodeForm_.Owner = this;
                timecodeForm_.TopLevel = false;
                timecodeForm_.FormBorderStyle = FormBorderStyle.None;
                panel_main.Controls.Add(timecodeForm_);
                timecodeForm_.Dock = DockStyle.Fill;
                timecodeForm_.Show();
                timecodeForm_.BringToFront();
            }
        }

        private void PanelMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToggleWindowState();
            }
        }

    }
}
