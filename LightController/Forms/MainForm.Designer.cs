namespace LightController.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.windowButtons = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_resize = new System.Windows.Forms.PictureBox();
            this.btn_list = new System.Windows.Forms.PictureBox();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.menuIcon = new System.Windows.Forms.PictureBox();
            this.sideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.panel_graph = new System.Windows.Forms.Panel();
            this.btn_graph = new System.Windows.Forms.Button();
            this.panel_Effects = new System.Windows.Forms.Panel();
            this.btn_Effects = new System.Windows.Forms.Button();
            this.panel_Sequencer = new System.Windows.Forms.Panel();
            this.btn_timecode = new System.Windows.Forms.Button();
            this.panel_About = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.windowButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).BeginInit();
            this.sideBarPanel.SuspendLayout();
            this.panel_Settings.SuspendLayout();
            this.panel_graph.SuspendLayout();
            this.panel_Effects.SuspendLayout();
            this.panel_Sequencer.SuspendLayout();
            this.panel_About.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(137)))), ((int)(((byte)(242)))));
            this.TopPanel.Controls.Add(this.windowButtons);
            this.TopPanel.Controls.Add(this.lbl_Tittle);
            this.TopPanel.Controls.Add(this.menuIcon);
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // windowButtons
            // 
            this.windowButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(109)))), ((int)(((byte)(242)))));
            this.windowButtons.Controls.Add(this.btn_close);
            this.windowButtons.Controls.Add(this.btn_resize);
            this.windowButtons.Controls.Add(this.btn_list);
            resources.ApplyResources(this.windowButtons, "windowButtons");
            this.windowButtons.Name = "windowButtons";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(137)))), ((int)(((byte)(242)))));
            this.btn_close.Image = global::LightController.Properties.Resources.cross;
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Name = "btn_close";
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_resize
            // 
            this.btn_resize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(137)))), ((int)(((byte)(242)))));
            this.btn_resize.Image = global::LightController.Properties.Resources.maximize_window;
            resources.ApplyResources(this.btn_resize, "btn_resize");
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.TabStop = false;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(137)))), ((int)(((byte)(242)))));
            this.btn_list.Image = global::LightController.Properties.Resources.line;
            resources.ApplyResources(this.btn_list, "btn_list");
            this.btn_list.Name = "btn_list";
            this.btn_list.TabStop = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // lbl_Tittle
            // 
            resources.ApplyResources(this.lbl_Tittle, "lbl_Tittle");
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.lbl_Tittle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.lbl_Tittle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // menuIcon
            // 
            this.menuIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(109)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.menuIcon, "menuIcon");
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.TabStop = false;
            this.menuIcon.Click += new System.EventHandler(this.menuIcon_Click);
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(242)))));
            this.sideBarPanel.Controls.Add(this.panel_Settings);
            this.sideBarPanel.Controls.Add(this.panel_graph);
            this.sideBarPanel.Controls.Add(this.panel_Effects);
            this.sideBarPanel.Controls.Add(this.panel_Sequencer);
            this.sideBarPanel.Controls.Add(this.panel_About);
            resources.ApplyResources(this.sideBarPanel, "sideBarPanel");
            this.sideBarPanel.Name = "sideBarPanel";
            // 
            // panel_Settings
            // 
            this.panel_Settings.Controls.Add(this.btn_settings);
            resources.ApplyResources(this.panel_Settings, "panel_Settings");
            this.panel_Settings.Name = "panel_Settings";
            // 
            // btn_settings
            // 
            resources.ApplyResources(this.btn_settings, "btn_settings");
            this.btn_settings.Image = global::LightController.Properties.Resources.settings;
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // panel_graph
            // 
            this.panel_graph.Controls.Add(this.btn_graph);
            resources.ApplyResources(this.panel_graph, "panel_graph");
            this.panel_graph.Name = "panel_graph";
            // 
            // btn_graph
            // 
            resources.ApplyResources(this.btn_graph, "btn_graph");
            this.btn_graph.Image = global::LightController.Properties.Resources.audio_wave;
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.UseVisualStyleBackColor = true;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // panel_Effects
            // 
            this.panel_Effects.Controls.Add(this.btn_Effects);
            resources.ApplyResources(this.panel_Effects, "panel_Effects");
            this.panel_Effects.Name = "panel_Effects";
            // 
            // btn_Effects
            // 
            resources.ApplyResources(this.btn_Effects, "btn_Effects");
            this.btn_Effects.Image = global::LightController.Properties.Resources.launchpad;
            this.btn_Effects.Name = "btn_Effects";
            this.btn_Effects.UseVisualStyleBackColor = true;
            this.btn_Effects.Click += new System.EventHandler(this.btn_Effects_Click);
            // 
            // panel_Sequencer
            // 
            this.panel_Sequencer.Controls.Add(this.btn_timecode);
            resources.ApplyResources(this.panel_Sequencer, "panel_Sequencer");
            this.panel_Sequencer.Name = "panel_Sequencer";
            // 
            // btn_timecode
            // 
            resources.ApplyResources(this.btn_timecode, "btn_timecode");
            this.btn_timecode.Image = global::LightController.Properties.Resources.icons8_timecode_50;
            this.btn_timecode.Name = "btn_timecode";
            this.btn_timecode.UseVisualStyleBackColor = true;
            this.btn_timecode.Click += new System.EventHandler(this.btn_timecode_Click);
            // 
            // panel_About
            // 
            this.panel_About.Controls.Add(this.btn_about);
            resources.ApplyResources(this.panel_About, "panel_About");
            this.panel_About.Name = "panel_About";
            // 
            // btn_about
            // 
            resources.ApplyResources(this.btn_about, "btn_about");
            this.btn_about.Image = global::LightController.Properties.Resources.icons8_about_50;
            this.btn_about.Name = "btn_about";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panel_main
            // 
            resources.ApplyResources(this.panel_main, "panel_main");
            this.panel_main.Name = "panel_main";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.windowButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).EndInit();
            this.sideBarPanel.ResumeLayout(false);
            this.panel_Settings.ResumeLayout(false);
            this.panel_graph.ResumeLayout(false);
            this.panel_Effects.ResumeLayout(false);
            this.panel_Sequencer.ResumeLayout(false);
            this.panel_About.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox menuIcon;
        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.Panel windowButtons;
        private System.Windows.Forms.PictureBox btn_list;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_resize;
        private System.Windows.Forms.FlowLayoutPanel sideBarPanel;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_graph;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Panel panel_Effects;
        private System.Windows.Forms.Button btn_Effects;
        private System.Windows.Forms.Panel panel_About;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Panel panel_Sequencer;
        private System.Windows.Forms.Button btn_timecode;
        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.Button btn_settings;
    }
}

