namespace LightController.Forms
{
    partial class AboutForm
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
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser_EULA = new System.Windows.Forms.WebBrowser();
            this.panel_rec_specs = new System.Windows.Forms.Panel();
            this.txboxRecSpecs = new System.Windows.Forms.TextBox();
            this.lbl_RecSpecs = new System.Windows.Forms.Label();
            this.panel_min_specs = new System.Windows.Forms.Panel();
            this.txboxMinSpecs = new System.Windows.Forms.TextBox();
            this.lbl_MinSpecs = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_rec_specs.SuspendLayout();
            this.panel_min_specs.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppName.Location = new System.Drawing.Point(13, 10);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(68, 30);
            this.labelAppName.TabIndex = 2;
            this.labelAppName.Text = "label1";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersion.Location = new System.Drawing.Point(87, 10);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(68, 30);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "label2";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthor.Location = new System.Drawing.Point(161, 10);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(68, 30);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 69);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser_EULA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_rec_specs);
            this.splitContainer1.Panel2.Controls.Add(this.panel_min_specs);
            this.splitContainer1.Size = new System.Drawing.Size(800, 381);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 6;
            // 
            // webBrowser_EULA
            // 
            this.webBrowser_EULA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_EULA.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_EULA.Margin = new System.Windows.Forms.Padding(5);
            this.webBrowser_EULA.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_EULA.Name = "webBrowser_EULA";
            this.webBrowser_EULA.Size = new System.Drawing.Size(402, 381);
            this.webBrowser_EULA.TabIndex = 0;
            // 
            // panel_rec_specs
            // 
            this.panel_rec_specs.Controls.Add(this.txboxRecSpecs);
            this.panel_rec_specs.Controls.Add(this.lbl_RecSpecs);
            this.panel_rec_specs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rec_specs.Location = new System.Drawing.Point(196, 0);
            this.panel_rec_specs.Name = "panel_rec_specs";
            this.panel_rec_specs.Size = new System.Drawing.Size(198, 381);
            this.panel_rec_specs.TabIndex = 1;
            // 
            // txboxRecSpecs
            // 
            this.txboxRecSpecs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txboxRecSpecs.Location = new System.Drawing.Point(0, 13);
            this.txboxRecSpecs.Multiline = true;
            this.txboxRecSpecs.Name = "txboxRecSpecs";
            this.txboxRecSpecs.ReadOnly = true;
            this.txboxRecSpecs.Size = new System.Drawing.Size(198, 368);
            this.txboxRecSpecs.TabIndex = 2;
            // 
            // lbl_RecSpecs
            // 
            this.lbl_RecSpecs.AutoSize = true;
            this.lbl_RecSpecs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_RecSpecs.Location = new System.Drawing.Point(0, 0);
            this.lbl_RecSpecs.Name = "lbl_RecSpecs";
            this.lbl_RecSpecs.Size = new System.Drawing.Size(38, 13);
            this.lbl_RecSpecs.TabIndex = 1;
            this.lbl_RecSpecs.Text = "label1";
            this.lbl_RecSpecs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_min_specs
            // 
            this.panel_min_specs.Controls.Add(this.txboxMinSpecs);
            this.panel_min_specs.Controls.Add(this.lbl_MinSpecs);
            this.panel_min_specs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_min_specs.Location = new System.Drawing.Point(0, 0);
            this.panel_min_specs.Name = "panel_min_specs";
            this.panel_min_specs.Size = new System.Drawing.Size(196, 381);
            this.panel_min_specs.TabIndex = 0;
            // 
            // txboxMinSpecs
            // 
            this.txboxMinSpecs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txboxMinSpecs.Location = new System.Drawing.Point(0, 13);
            this.txboxMinSpecs.Multiline = true;
            this.txboxMinSpecs.Name = "txboxMinSpecs";
            this.txboxMinSpecs.ReadOnly = true;
            this.txboxMinSpecs.Size = new System.Drawing.Size(196, 368);
            this.txboxMinSpecs.TabIndex = 1;
            // 
            // lbl_MinSpecs
            // 
            this.lbl_MinSpecs.AutoSize = true;
            this.lbl_MinSpecs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_MinSpecs.Location = new System.Drawing.Point(0, 0);
            this.lbl_MinSpecs.Name = "lbl_MinSpecs";
            this.lbl_MinSpecs.Size = new System.Drawing.Size(38, 13);
            this.lbl_MinSpecs.TabIndex = 0;
            this.lbl_MinSpecs.Text = "label1";
            this.lbl_MinSpecs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelAppName);
            this.flowLayoutPanel1.Controls.Add(this.labelVersion);
            this.flowLayoutPanel1.Controls.Add(this.labelAuthor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 69);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_rec_specs.ResumeLayout(false);
            this.panel_rec_specs.PerformLayout();
            this.panel_min_specs.ResumeLayout(false);
            this.panel_min_specs.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser_EULA;
        private System.Windows.Forms.Panel panel_rec_specs;
        private System.Windows.Forms.Panel panel_min_specs;
        private System.Windows.Forms.Label lbl_MinSpecs;
        private System.Windows.Forms.Label lbl_RecSpecs;
        private System.Windows.Forms.TextBox txboxMinSpecs;
        private System.Windows.Forms.TextBox txboxRecSpecs;
    }
}