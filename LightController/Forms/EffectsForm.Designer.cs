namespace LightController.Forms
{
    partial class EffectsForm
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
            this.panel_info = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_effect_delay = new System.Windows.Forms.Panel();
            this.lbl_effect_delay = new System.Windows.Forms.Label();
            this.numericUpDown_effect_delay = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_exec_all = new System.Windows.Forms.Panel();
            this.btn_exec_all = new System.Windows.Forms.Button();
            this.panel_on_off = new System.Windows.Forms.Panel();
            this.btn_on_off_all = new System.Windows.Forms.Button();
            this.panel_default_delay = new System.Windows.Forms.Panel();
            this.btn_default_delay = new System.Windows.Forms.Button();
            this.panel_info.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_effect_delay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_effect_delay)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_exec_all.SuspendLayout();
            this.panel_on_off.SuspendLayout();
            this.panel_default_delay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.flowLayoutPanel2);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(800, 111);
            this.panel_info.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel_effect_delay);
            this.flowLayoutPanel2.Controls.Add(this.panel_default_delay);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 111);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel_effect_delay
            // 
            this.panel_effect_delay.Controls.Add(this.lbl_effect_delay);
            this.panel_effect_delay.Controls.Add(this.numericUpDown_effect_delay);
            this.panel_effect_delay.Location = new System.Drawing.Point(3, 3);
            this.panel_effect_delay.Name = "panel_effect_delay";
            this.panel_effect_delay.Size = new System.Drawing.Size(154, 102);
            this.panel_effect_delay.TabIndex = 0;
            // 
            // lbl_effect_delay
            // 
            this.lbl_effect_delay.AutoSize = true;
            this.lbl_effect_delay.Location = new System.Drawing.Point(12, 25);
            this.lbl_effect_delay.Name = "lbl_effect_delay";
            this.lbl_effect_delay.Size = new System.Drawing.Size(108, 13);
            this.lbl_effect_delay.TabIndex = 1;
            this.lbl_effect_delay.Text = "EFFECT DELAY (MS): ";
            // 
            // numericUpDown_effect_delay
            // 
            this.numericUpDown_effect_delay.Location = new System.Drawing.Point(9, 68);
            this.numericUpDown_effect_delay.Name = "numericUpDown_effect_delay";
            this.numericUpDown_effect_delay.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_effect_delay.TabIndex = 0;
            this.numericUpDown_effect_delay.ValueChanged += new System.EventHandler(this.numericUpDown_effect_delay_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel_exec_all);
            this.flowLayoutPanel1.Controls.Add(this.panel_on_off);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 339);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel_exec_all
            // 
            this.panel_exec_all.Controls.Add(this.btn_exec_all);
            this.panel_exec_all.Location = new System.Drawing.Point(8, 8);
            this.panel_exec_all.MaximumSize = new System.Drawing.Size(200, 200);
            this.panel_exec_all.Name = "panel_exec_all";
            this.panel_exec_all.Padding = new System.Windows.Forms.Padding(10);
            this.panel_exec_all.Size = new System.Drawing.Size(149, 139);
            this.panel_exec_all.TabIndex = 0;
            // 
            // btn_exec_all
            // 
            this.btn_exec_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exec_all.Location = new System.Drawing.Point(10, 10);
            this.btn_exec_all.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_exec_all.Name = "btn_exec_all";
            this.btn_exec_all.Size = new System.Drawing.Size(129, 119);
            this.btn_exec_all.TabIndex = 0;
            this.btn_exec_all.Text = "EXECUTE ALL";
            this.btn_exec_all.UseVisualStyleBackColor = true;
            this.btn_exec_all.Click += new System.EventHandler(this.btn_exec_all_Click);
            // 
            // panel_on_off
            // 
            this.panel_on_off.Controls.Add(this.btn_on_off_all);
            this.panel_on_off.Location = new System.Drawing.Point(163, 8);
            this.panel_on_off.MaximumSize = new System.Drawing.Size(200, 200);
            this.panel_on_off.Name = "panel_on_off";
            this.panel_on_off.Padding = new System.Windows.Forms.Padding(10);
            this.panel_on_off.Size = new System.Drawing.Size(149, 139);
            this.panel_on_off.TabIndex = 1;
            // 
            // btn_on_off_all
            // 
            this.btn_on_off_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_on_off_all.Location = new System.Drawing.Point(10, 10);
            this.btn_on_off_all.Name = "btn_on_off_all";
            this.btn_on_off_all.Size = new System.Drawing.Size(129, 119);
            this.btn_on_off_all.TabIndex = 0;
            this.btn_on_off_all.Text = "ON/OFF ALL";
            this.btn_on_off_all.UseVisualStyleBackColor = true;
            this.btn_on_off_all.Click += new System.EventHandler(this.btn_on_off_all_Click);
            // 
            // panel_default_delay
            // 
            this.panel_default_delay.Controls.Add(this.btn_default_delay);
            this.panel_default_delay.Location = new System.Drawing.Point(163, 3);
            this.panel_default_delay.MaximumSize = new System.Drawing.Size(200, 200);
            this.panel_default_delay.Name = "panel_default_delay";
            this.panel_default_delay.Padding = new System.Windows.Forms.Padding(10);
            this.panel_default_delay.Size = new System.Drawing.Size(149, 105);
            this.panel_default_delay.TabIndex = 1;
            // 
            // btn_default_delay
            // 
            this.btn_default_delay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_default_delay.Location = new System.Drawing.Point(10, 10);
            this.btn_default_delay.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_default_delay.Name = "btn_default_delay";
            this.btn_default_delay.Size = new System.Drawing.Size(129, 85);
            this.btn_default_delay.TabIndex = 0;
            this.btn_default_delay.Text = "DEFAULT DELAY";
            this.btn_default_delay.UseVisualStyleBackColor = true;
            this.btn_default_delay.Click += new System.EventHandler(this.btn_default_delay_Click);
            // 
            // EffectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_info);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "EffectsForm";
            this.Text = "EffectsForm";
            this.panel_info.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel_effect_delay.ResumeLayout(false);
            this.panel_effect_delay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_effect_delay)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_exec_all.ResumeLayout(false);
            this.panel_on_off.ResumeLayout(false);
            this.panel_default_delay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_exec_all;
        private System.Windows.Forms.Button btn_exec_all;
        private System.Windows.Forms.Panel panel_on_off;
        private System.Windows.Forms.Button btn_on_off_all;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel_effect_delay;
        private System.Windows.Forms.Label lbl_effect_delay;
        private System.Windows.Forms.NumericUpDown numericUpDown_effect_delay;
        private System.Windows.Forms.Panel panel_default_delay;
        private System.Windows.Forms.Button btn_default_delay;
    }
}