namespace LightController.Forms
{
    partial class GraphForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_background = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPane_details = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_gain = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart_visulizer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_volume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPane_details.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_visulizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.Controls.Add(this.splitContainer1);
            this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(800, 450);
            this.panel_background.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(700, 400);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPane_details);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPane_details
            // 
            this.flowLayoutPane_details.Controls.Add(this.panel1);
            this.flowLayoutPane_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPane_details.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPane_details.Name = "flowLayoutPane_details";
            this.flowLayoutPane_details.Size = new System.Drawing.Size(800, 100);
            this.flowLayoutPane_details.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_gain);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 73);
            this.panel1.TabIndex = 0;
            // 
            // lbl_gain
            // 
            this.lbl_gain.AutoSize = true;
            this.lbl_gain.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_gain.Location = new System.Drawing.Point(9, 17);
            this.lbl_gain.Name = "lbl_gain";
            this.lbl_gain.Size = new System.Drawing.Size(89, 40);
            this.lbl_gain.TabIndex = 0;
            this.lbl_gain.Text = "Gain: ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart_visulizer);
            this.splitContainer2.Panel1MinSize = 600;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.Controls.Add(this.chart_volume);
            this.splitContainer2.Panel2MinSize = 150;
            this.splitContainer2.Size = new System.Drawing.Size(800, 346);
            this.splitContainer2.SplitterDistance = 620;
            this.splitContainer2.TabIndex = 1;
            // 
            // chart_visulizer
            // 
            this.chart_visulizer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_visulizer.BorderlineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart_visulizer.ChartAreas.Add(chartArea3);
            this.chart_visulizer.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_visulizer.Legends.Add(legend3);
            this.chart_visulizer.Location = new System.Drawing.Point(0, 0);
            this.chart_visulizer.MinimumSize = new System.Drawing.Size(400, 300);
            this.chart_visulizer.Name = "chart_visulizer";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Sound Energy";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series11.Legend = "Legend1";
            series11.Name = "Detected Beats";
            series11.YValuesPerPoint = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Legend = "Legend1";
            series12.Name = "Threshold";
            this.chart_visulizer.Series.Add(series10);
            this.chart_visulizer.Series.Add(series11);
            this.chart_visulizer.Series.Add(series12);
            this.chart_visulizer.Size = new System.Drawing.Size(620, 346);
            this.chart_visulizer.TabIndex = 0;
            this.chart_visulizer.Text = "chart1";
            // 
            // chart_volume
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_volume.ChartAreas.Add(chartArea4);
            this.chart_volume.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart_volume.Legends.Add(legend4);
            this.chart_volume.Location = new System.Drawing.Point(0, 0);
            this.chart_volume.Name = "chart_volume";
            series13.ChartArea = "ChartArea1";
            series13.LabelAngle = 10;
            series13.Legend = "Legend1";
            series13.Name = "Right Channel Volume";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Combined Volume";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Left Channel Volume";
            series16.ChartArea = "ChartArea1";
            series16.IsVisibleInLegend = false;
            series16.Legend = "Legend1";
            series16.Name = "R Channel Peak";
            series17.ChartArea = "ChartArea1";
            series17.IsVisibleInLegend = false;
            series17.Legend = "Legend1";
            series17.Name = "Combined Volume Peak";
            series18.ChartArea = "ChartArea1";
            series18.IsVisibleInLegend = false;
            series18.Legend = "Legend1";
            series18.Name = "L Channel Peak";
            this.chart_volume.Series.Add(series13);
            this.chart_volume.Series.Add(series14);
            this.chart_volume.Series.Add(series15);
            this.chart_volume.Series.Add(series16);
            this.chart_volume.Series.Add(series17);
            this.chart_volume.Series.Add(series18);
            this.chart_volume.Size = new System.Drawing.Size(176, 346);
            this.chart_volume.TabIndex = 0;
            this.chart_volume.Text = "chart1";
            // 
            // graphForm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_background);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "graphForm_";
            this.Text = "graphForm_";
            this.panel_background.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPane_details.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_visulizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_visulizer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_volume;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPane_details;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_gain;
    }
}