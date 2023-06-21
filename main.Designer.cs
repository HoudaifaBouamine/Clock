namespace Clock
{
    partial class main_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.lbl_Stopwatch_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_csecond = new System.Windows.Forms.Label();
            this.btn_ResetStopwatch = new System.Windows.Forms.Button();
            this.btn_FlagStopwatch = new System.Windows.Forms.Button();
            this.btn_StartStopwatch = new System.Windows.Forms.Button();
            this.timer_fram = new System.Windows.Forms.Timer(this.components);
            this.tbc_main = new System.Windows.Forms.TabControl();
            this.tp_Stopwatch = new System.Windows.Forms.TabPage();
            this.lv_recordes = new System.Windows.Forms.ListView();
            this.lvc_stopwatch_laps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvc_stopwatch_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvc_stopwatch_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_timer = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbc_main.SuspendLayout();
            this.tp_Stopwatch.SuspendLayout();
            this.tb_timer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Stopwatch_time
            // 
            this.lbl_Stopwatch_time.AutoSize = true;
            this.lbl_Stopwatch_time.Font = new System.Drawing.Font("Segoe UI", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stopwatch_time.Location = new System.Drawing.Point(44, 73);
            this.lbl_Stopwatch_time.Name = "lbl_Stopwatch_time";
            this.lbl_Stopwatch_time.Size = new System.Drawing.Size(593, 175);
            this.lbl_Stopwatch_time.TabIndex = 2;
            this.lbl_Stopwatch_time.Text = "00:00:00.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "hr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "min";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "sec";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_csecond
            // 
            this.lbl_csecond.AutoSize = true;
            this.lbl_csecond.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_csecond.Location = new System.Drawing.Point(586, 129);
            this.lbl_csecond.Name = "lbl_csecond";
            this.lbl_csecond.Size = new System.Drawing.Size(131, 106);
            this.lbl_csecond.TabIndex = 7;
            this.lbl_csecond.Text = "00";
            this.lbl_csecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ResetStopwatch
            // 
            this.btn_ResetStopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_ResetStopwatch.BackgroundImage = global::Clock.Properties.Resources.stopwatch_reset;
            this.btn_ResetStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ResetStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_ResetStopwatch.Location = new System.Drawing.Point(428, 303);
            this.btn_ResetStopwatch.Name = "btn_ResetStopwatch";
            this.btn_ResetStopwatch.Size = new System.Drawing.Size(75, 73);
            this.btn_ResetStopwatch.TabIndex = 10;
            this.btn_ResetStopwatch.Text = " ";
            this.btn_ResetStopwatch.UseVisualStyleBackColor = false;
            this.btn_ResetStopwatch.Click += new System.EventHandler(this.btn_ResetStopwatch_Click);
            // 
            // btn_FlagStopwatch
            // 
            this.btn_FlagStopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_FlagStopwatch.BackgroundImage = global::Clock.Properties.Resources.stopwatch_flag;
            this.btn_FlagStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FlagStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FlagStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FlagStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_FlagStopwatch.Location = new System.Drawing.Point(347, 303);
            this.btn_FlagStopwatch.Name = "btn_FlagStopwatch";
            this.btn_FlagStopwatch.Size = new System.Drawing.Size(75, 73);
            this.btn_FlagStopwatch.TabIndex = 9;
            this.btn_FlagStopwatch.Text = " ";
            this.btn_FlagStopwatch.UseVisualStyleBackColor = false;
            this.btn_FlagStopwatch.Click += new System.EventHandler(this.btn_FlagStopwatch_Click);
            // 
            // btn_StartStopwatch
            // 
            this.btn_StartStopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(200)))), ((int)(((byte)(39)))));
            this.btn_StartStopwatch.BackgroundImage = global::Clock.Properties.Resources.stopwatch_start;
            this.btn_StartStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_StartStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_StartStopwatch.Location = new System.Drawing.Point(266, 303);
            this.btn_StartStopwatch.Name = "btn_StartStopwatch";
            this.btn_StartStopwatch.Size = new System.Drawing.Size(75, 73);
            this.btn_StartStopwatch.TabIndex = 8;
            this.btn_StartStopwatch.Tag = "0";
            this.btn_StartStopwatch.Text = " ";
            this.btn_StartStopwatch.UseVisualStyleBackColor = false;
            this.btn_StartStopwatch.Click += new System.EventHandler(this.btn_StartStopwatch_Click);
            // 
            // timer_fram
            // 
            this.timer_fram.Interval = 16;
            this.timer_fram.Tick += new System.EventHandler(this.timer_fram_Tick);
            // 
            // tbc_main
            // 
            this.tbc_main.Controls.Add(this.tp_Stopwatch);
            this.tbc_main.Controls.Add(this.tb_timer);
            this.tbc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_main.Location = new System.Drawing.Point(0, 0);
            this.tbc_main.Name = "tbc_main";
            this.tbc_main.SelectedIndex = 0;
            this.tbc_main.Size = new System.Drawing.Size(770, 658);
            this.tbc_main.TabIndex = 11;
            // 
            // tp_Stopwatch
            // 
            this.tp_Stopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tp_Stopwatch.Controls.Add(this.lv_recordes);
            this.tp_Stopwatch.Controls.Add(this.label4);
            this.tp_Stopwatch.Controls.Add(this.btn_StartStopwatch);
            this.tp_Stopwatch.Controls.Add(this.label1);
            this.tp_Stopwatch.Controls.Add(this.btn_FlagStopwatch);
            this.tp_Stopwatch.Controls.Add(this.label2);
            this.tp_Stopwatch.Controls.Add(this.btn_ResetStopwatch);
            this.tp_Stopwatch.Controls.Add(this.lbl_csecond);
            this.tp_Stopwatch.Controls.Add(this.lbl_Stopwatch_time);
            this.tp_Stopwatch.Location = new System.Drawing.Point(4, 25);
            this.tp_Stopwatch.Name = "tp_Stopwatch";
            this.tp_Stopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Stopwatch.Size = new System.Drawing.Size(762, 629);
            this.tp_Stopwatch.TabIndex = 0;
            this.tp_Stopwatch.Text = "Stopwatch";
            this.tp_Stopwatch.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lv_recordes
            // 
            this.lv_recordes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_recordes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lv_recordes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_recordes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvc_stopwatch_laps,
            this.lvc_stopwatch_time,
            this.lvc_stopwatch_total});
            this.lv_recordes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lv_recordes.HideSelection = false;
            this.lv_recordes.Location = new System.Drawing.Point(22, 401);
            this.lv_recordes.Name = "lv_recordes";
            this.lv_recordes.Size = new System.Drawing.Size(718, 206);
            this.lv_recordes.TabIndex = 11;
            this.lv_recordes.UseCompatibleStateImageBehavior = false;
            this.lv_recordes.View = System.Windows.Forms.View.Details;
            // 
            // lvc_stopwatch_laps
            // 
            this.lvc_stopwatch_laps.Text = "Laps";
            // 
            // lvc_stopwatch_time
            // 
            this.lvc_stopwatch_time.Text = "Time";
            // 
            // lvc_stopwatch_total
            // 
            this.lvc_stopwatch_total.Text = "Total";
            // 
            // tb_timer
            // 
            this.tb_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_timer.Controls.Add(this.label3);
            this.tb_timer.Location = new System.Drawing.Point(4, 25);
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Padding = new System.Windows.Forms.Padding(3);
            this.tb_timer.Size = new System.Drawing.Size(762, 629);
            this.tb_timer.TabIndex = 1;
            this.tb_timer.Text = "Timer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.8F);
            this.label3.Location = new System.Drawing.Point(70, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(625, 96);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comming Soon";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(770, 658);
            this.Controls.Add(this.tbc_main);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.tbc_main.ResumeLayout(false);
            this.tp_Stopwatch.ResumeLayout(false);
            this.tp_Stopwatch.PerformLayout();
            this.tb_timer.ResumeLayout(false);
            this.tb_timer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Stopwatch_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_csecond;
        private System.Windows.Forms.Button btn_StartStopwatch;
        private System.Windows.Forms.Button btn_FlagStopwatch;
        private System.Windows.Forms.Button btn_ResetStopwatch;
        private System.Windows.Forms.Timer timer_fram;
        private System.Windows.Forms.TabControl tbc_main;
        private System.Windows.Forms.TabPage tp_Stopwatch;
        private System.Windows.Forms.TabPage tb_timer;
        private System.Windows.Forms.ListView lv_recordes;
        private System.Windows.Forms.ColumnHeader lvc_stopwatch_laps;
        private System.Windows.Forms.ColumnHeader lvc_stopwatch_time;
        private System.Windows.Forms.ColumnHeader lvc_stopwatch_total;
        private System.Windows.Forms.Label label3;
    }
}

