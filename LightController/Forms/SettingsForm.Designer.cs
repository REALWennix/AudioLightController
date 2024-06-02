namespace LightController.Forms
{
    partial class SettingsForm
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
            this.panel_MinBeatGap = new System.Windows.Forms.Panel();
            this.lbl_MinBeatGap = new System.Windows.Forms.Label();
            this.numericUpDown_MinBeatGap = new System.Windows.Forms.NumericUpDown();
            this.panel_BeatThreshold = new System.Windows.Forms.Panel();
            this.lbl_BeatThreshold = new System.Windows.Forms.Label();
            this.numericUpDown_BeatThreshold = new System.Windows.Forms.NumericUpDown();
            this.panel_ComPort = new System.Windows.Forms.Panel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconect = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.combo_baudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_comPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_MinBeatWidth = new System.Windows.Forms.Panel();
            this.lbl_MinBeatWidth = new System.Windows.Forms.Label();
            this.numericUpDown_MinBeatWidth = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_audio_reactive = new System.Windows.Forms.Panel();
            this.checkBox_audio_reactive = new System.Windows.Forms.CheckBox();
            this.panel_MinBeatGap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MinBeatGap)).BeginInit();
            this.panel_BeatThreshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BeatThreshold)).BeginInit();
            this.panel_ComPort.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_MinBeatWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MinBeatWidth)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_audio_reactive.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MinBeatGap
            // 
            this.panel_MinBeatGap.BackColor = System.Drawing.Color.Transparent;
            this.panel_MinBeatGap.Controls.Add(this.lbl_MinBeatGap);
            this.panel_MinBeatGap.Controls.Add(this.numericUpDown_MinBeatGap);
            this.panel_MinBeatGap.Location = new System.Drawing.Point(281, 3);
            this.panel_MinBeatGap.Name = "panel_MinBeatGap";
            this.panel_MinBeatGap.Padding = new System.Windows.Forms.Padding(10);
            this.panel_MinBeatGap.Size = new System.Drawing.Size(272, 156);
            this.panel_MinBeatGap.TabIndex = 4;
            // 
            // lbl_MinBeatGap
            // 
            this.lbl_MinBeatGap.AutoSize = true;
            this.lbl_MinBeatGap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_MinBeatGap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MinBeatGap.Location = new System.Drawing.Point(10, 10);
            this.lbl_MinBeatGap.Name = "lbl_MinBeatGap";
            this.lbl_MinBeatGap.Size = new System.Drawing.Size(141, 21);
            this.lbl_MinBeatGap.TabIndex = 3;
            this.lbl_MinBeatGap.Text = "Min Beat Gap (ms):";
            // 
            // numericUpDown_MinBeatGap
            // 
            this.numericUpDown_MinBeatGap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown_MinBeatGap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_MinBeatGap.Location = new System.Drawing.Point(10, 111);
            this.numericUpDown_MinBeatGap.Name = "numericUpDown_MinBeatGap";
            this.numericUpDown_MinBeatGap.Size = new System.Drawing.Size(252, 35);
            this.numericUpDown_MinBeatGap.TabIndex = 2;
            this.numericUpDown_MinBeatGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_BeatThreshold
            // 
            this.panel_BeatThreshold.BackColor = System.Drawing.Color.Transparent;
            this.panel_BeatThreshold.Controls.Add(this.lbl_BeatThreshold);
            this.panel_BeatThreshold.Controls.Add(this.numericUpDown_BeatThreshold);
            this.panel_BeatThreshold.Location = new System.Drawing.Point(3, 3);
            this.panel_BeatThreshold.Name = "panel_BeatThreshold";
            this.panel_BeatThreshold.Padding = new System.Windows.Forms.Padding(10);
            this.panel_BeatThreshold.Size = new System.Drawing.Size(272, 156);
            this.panel_BeatThreshold.TabIndex = 3;
            // 
            // lbl_BeatThreshold
            // 
            this.lbl_BeatThreshold.AutoSize = true;
            this.lbl_BeatThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_BeatThreshold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BeatThreshold.Location = new System.Drawing.Point(10, 10);
            this.lbl_BeatThreshold.Name = "lbl_BeatThreshold";
            this.lbl_BeatThreshold.Size = new System.Drawing.Size(116, 21);
            this.lbl_BeatThreshold.TabIndex = 3;
            this.lbl_BeatThreshold.Text = "Beat Threshold:";
            // 
            // numericUpDown_BeatThreshold
            // 
            this.numericUpDown_BeatThreshold.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown_BeatThreshold.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_BeatThreshold.Location = new System.Drawing.Point(10, 113);
            this.numericUpDown_BeatThreshold.Name = "numericUpDown_BeatThreshold";
            this.numericUpDown_BeatThreshold.Size = new System.Drawing.Size(252, 33);
            this.numericUpDown_BeatThreshold.TabIndex = 2;
            this.numericUpDown_BeatThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_ComPort
            // 
            this.panel_ComPort.Controls.Add(this.btn_connect);
            this.panel_ComPort.Controls.Add(this.btn_disconect);
            this.panel_ComPort.Controls.Add(this.tableLayoutPanel2);
            this.panel_ComPort.Controls.Add(this.label1);
            this.panel_ComPort.Location = new System.Drawing.Point(12, 12);
            this.panel_ComPort.Name = "panel_ComPort";
            this.panel_ComPort.Size = new System.Drawing.Size(388, 191);
            this.panel_ComPort.TabIndex = 1;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_connect.Location = new System.Drawing.Point(174, 25);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(107, 30);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconect
            // 
            this.btn_disconect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_disconect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_disconect.Location = new System.Drawing.Point(281, 25);
            this.btn_disconect.Name = "btn_disconect";
            this.btn_disconect.Size = new System.Drawing.Size(107, 30);
            this.btn_disconect.TabIndex = 6;
            this.btn_disconect.Text = "Disconect";
            this.btn_disconect.UseVisualStyleBackColor = true;
            this.btn_disconect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.combo_baudRate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.combo_comPorts, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 136);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // combo_baudRate
            // 
            this.combo_baudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combo_baudRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combo_baudRate.FormattingEnabled = true;
            this.combo_baudRate.Location = new System.Drawing.Point(197, 71);
            this.combo_baudRate.Name = "combo_baudRate";
            this.combo_baudRate.Size = new System.Drawing.Size(187, 29);
            this.combo_baudRate.TabIndex = 3;
            this.combo_baudRate.SelectedIndexChanged += new System.EventHandler(this.Combo_baudRate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 66);
            this.label2.TabIndex = 4;
            this.label2.Text = "COM-Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_comPorts
            // 
            this.combo_comPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combo_comPorts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combo_comPorts.FormattingEnabled = true;
            this.combo_comPorts.Location = new System.Drawing.Point(197, 4);
            this.combo_comPorts.Name = "combo_comPorts";
            this.combo_comPorts.Size = new System.Drawing.Size(187, 29);
            this.combo_comPorts.TabIndex = 2;
            this.combo_comPorts.SelectedIndexChanged += new System.EventHandler(this.Combo_comPorts_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 67);
            this.label3.TabIndex = 5;
            this.label3.Text = "Baud-Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com-port";
            // 
            // panel_MinBeatWidth
            // 
            this.panel_MinBeatWidth.BackColor = System.Drawing.Color.Transparent;
            this.panel_MinBeatWidth.Controls.Add(this.lbl_MinBeatWidth);
            this.panel_MinBeatWidth.Controls.Add(this.numericUpDown_MinBeatWidth);
            this.panel_MinBeatWidth.Location = new System.Drawing.Point(3, 165);
            this.panel_MinBeatWidth.Name = "panel_MinBeatWidth";
            this.panel_MinBeatWidth.Padding = new System.Windows.Forms.Padding(10);
            this.panel_MinBeatWidth.Size = new System.Drawing.Size(272, 156);
            this.panel_MinBeatWidth.TabIndex = 5;
            // 
            // lbl_MinBeatWidth
            // 
            this.lbl_MinBeatWidth.AutoSize = true;
            this.lbl_MinBeatWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_MinBeatWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_MinBeatWidth.Location = new System.Drawing.Point(10, 10);
            this.lbl_MinBeatWidth.Name = "lbl_MinBeatWidth";
            this.lbl_MinBeatWidth.Size = new System.Drawing.Size(141, 21);
            this.lbl_MinBeatWidth.TabIndex = 3;
            this.lbl_MinBeatWidth.Text = "Min Beat Gap (ms):";
            // 
            // numericUpDown_MinBeatWidth
            // 
            this.numericUpDown_MinBeatWidth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown_MinBeatWidth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_MinBeatWidth.Location = new System.Drawing.Point(10, 111);
            this.numericUpDown_MinBeatWidth.Name = "numericUpDown_MinBeatWidth";
            this.numericUpDown_MinBeatWidth.Size = new System.Drawing.Size(252, 35);
            this.numericUpDown_MinBeatWidth.TabIndex = 2;
            this.numericUpDown_MinBeatWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel_BeatThreshold);
            this.flowLayoutPanel1.Controls.Add(this.panel_MinBeatGap);
            this.flowLayoutPanel1.Controls.Add(this.panel_MinBeatWidth);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(429, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(565, 481);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel_audio_reactive
            // 
            this.panel_audio_reactive.Controls.Add(this.checkBox_audio_reactive);
            this.panel_audio_reactive.Location = new System.Drawing.Point(12, 209);
            this.panel_audio_reactive.Name = "panel_audio_reactive";
            this.panel_audio_reactive.Padding = new System.Windows.Forms.Padding(5);
            this.panel_audio_reactive.Size = new System.Drawing.Size(384, 58);
            this.panel_audio_reactive.TabIndex = 3;
            // 
            // checkBox_audio_reactive
            // 
            this.checkBox_audio_reactive.AutoSize = true;
            this.checkBox_audio_reactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_audio_reactive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_audio_reactive.Location = new System.Drawing.Point(5, 5);
            this.checkBox_audio_reactive.Name = "checkBox_audio_reactive";
            this.checkBox_audio_reactive.Padding = new System.Windows.Forms.Padding(5);
            this.checkBox_audio_reactive.Size = new System.Drawing.Size(374, 48);
            this.checkBox_audio_reactive.TabIndex = 1;
            this.checkBox_audio_reactive.Text = "Is audio reactive?";
            this.checkBox_audio_reactive.UseVisualStyleBackColor = true;
            this.checkBox_audio_reactive.CheckedChanged += new System.EventHandler(this.checkBox_audio_reactive_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 481);
            this.Controls.Add(this.panel_audio_reactive);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_ComPort);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "A";
            this.panel_MinBeatGap.ResumeLayout(false);
            this.panel_MinBeatGap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MinBeatGap)).EndInit();
            this.panel_BeatThreshold.ResumeLayout(false);
            this.panel_BeatThreshold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BeatThreshold)).EndInit();
            this.panel_ComPort.ResumeLayout(false);
            this.panel_ComPort.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_MinBeatWidth.ResumeLayout(false);
            this.panel_MinBeatWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MinBeatWidth)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_audio_reactive.ResumeLayout(false);
            this.panel_audio_reactive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_comPorts;
        private System.Windows.Forms.ComboBox combo_baudRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_BeatThreshold;
        private System.Windows.Forms.Panel panel_BeatThreshold;
        private System.Windows.Forms.Label lbl_BeatThreshold;
        private System.Windows.Forms.Panel panel_MinBeatGap;
        private System.Windows.Forms.Label lbl_MinBeatGap;
        private System.Windows.Forms.NumericUpDown numericUpDown_MinBeatGap;
        private System.Windows.Forms.Panel panel_MinBeatWidth;
        private System.Windows.Forms.Label lbl_MinBeatWidth;
        private System.Windows.Forms.NumericUpDown numericUpDown_MinBeatWidth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_audio_reactive;
        private System.Windows.Forms.CheckBox checkBox_audio_reactive;
        private System.Windows.Forms.Button btn_disconect;
        private System.Windows.Forms.Button btn_connect;
    }
}