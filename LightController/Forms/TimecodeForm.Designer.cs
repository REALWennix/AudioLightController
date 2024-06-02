namespace LightController.Forms
{
    partial class TimecodeForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_timecode = new System.Windows.Forms.Panel();
            this.lbl_timecode = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_setmaxtime = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_timecode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_timecode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(801, 450);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel_timecode
            // 
            this.panel_timecode.Controls.Add(this.lbl_timecode);
            this.panel_timecode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timecode.Location = new System.Drawing.Point(0, 0);
            this.panel_timecode.Name = "panel_timecode";
            this.panel_timecode.Size = new System.Drawing.Size(801, 165);
            this.panel_timecode.TabIndex = 1;
            // 
            // lbl_timecode
            // 
            this.lbl_timecode.AutoSize = true;
            this.lbl_timecode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_timecode.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_timecode.Location = new System.Drawing.Point(0, 0);
            this.lbl_timecode.Name = "lbl_timecode";
            this.lbl_timecode.Size = new System.Drawing.Size(359, 86);
            this.lbl_timecode.TabIndex = 0;
            this.lbl_timecode.Text = "00:00:00.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btn_stop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_pause, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_setmaxtime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_restart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_start, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 181);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_stop
            // 
            this.btn_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_stop.Location = new System.Drawing.Point(482, 8);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(152, 84);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pause.Location = new System.Drawing.Point(640, 8);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(153, 84);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.Text = "PAUSE";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btn_setmaxtime
            // 
            this.btn_setmaxtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_setmaxtime.Location = new System.Drawing.Point(324, 8);
            this.btn_setmaxtime.Name = "btn_setmaxtime";
            this.btn_setmaxtime.Size = new System.Drawing.Size(152, 84);
            this.btn_setmaxtime.TabIndex = 3;
            this.btn_setmaxtime.Text = "SET MAX TIME";
            this.btn_setmaxtime.UseVisualStyleBackColor = true;
            this.btn_setmaxtime.Click += new System.EventHandler(this.btnSetMaxTime_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_restart.Location = new System.Drawing.Point(8, 8);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(152, 84);
            this.btn_restart.TabIndex = 2;
            this.btn_restart.Text = "RESTART";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btn_start
            // 
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.Location = new System.Drawing.Point(166, 8);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(152, 84);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TimecodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "TimecodeForm";
            this.Text = "TimecodeForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_timecode.ResumeLayout(false);
            this.panel_timecode.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_timecode;
        private System.Windows.Forms.Label lbl_timecode;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_setmaxtime;
    }
}