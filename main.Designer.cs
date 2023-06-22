using System.Drawing;

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
            this.lbl_stopwatch_hours_title = new System.Windows.Forms.Label();
            this.lbl_stopwatch_mins_title = new System.Windows.Forms.Label();
            this.lbl_stopwatch_secs_title = new System.Windows.Forms.Label();
            this.lbl_csecond = new System.Windows.Forms.Label();
            this.timer_fram = new System.Windows.Forms.Timer(this.components);
            this.tbc_main = new System.Windows.Forms.TabControl();
            this.tp_Stopwatch = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Smallwindow = new System.Windows.Forms.Button();
            this.btn_Fullscreen = new System.Windows.Forms.Button();
            this.lv_recordes = new System.Windows.Forms.ListView();
            this.lvc_stopwatch_laps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvc_stopwatch_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvc_stopwatch_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_StartStopwatch = new System.Windows.Forms.Button();
            this.btn_FlagStopwatch = new System.Windows.Forms.Button();
            this.btn_ResetStopwatch = new System.Windows.Forms.Button();
            this.tb_timer = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tab_timer = new System.Windows.Forms.Button();
            this.btn_tab_alarm = new System.Windows.Forms.Button();
            this.btn_tab_stopwatch = new System.Windows.Forms.Button();
            this.btn_tab_clock = new System.Windows.Forms.Button();
            this.tp_alarm = new System.Windows.Forms.TabPage();
            this.tp_clock = new System.Windows.Forms.TabPage();
            this.tbc_main.SuspendLayout();
            this.tp_Stopwatch.SuspendLayout();
            this.tb_timer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Stopwatch_time
            // 
            this.lbl_Stopwatch_time.AutoSize = true;
            this.lbl_Stopwatch_time.Font = new System.Drawing.Font("Segoe UI", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stopwatch_time.Location = new System.Drawing.Point(19, 65);
            this.lbl_Stopwatch_time.Name = "lbl_Stopwatch_time";
            this.lbl_Stopwatch_time.Size = new System.Drawing.Size(593, 175);
            this.lbl_Stopwatch_time.TabIndex = 2;
            this.lbl_Stopwatch_time.Text = "00:00:00.";
            // 
            // lbl_stopwatch_hours_title
            // 
            this.lbl_stopwatch_hours_title.AutoSize = true;
            this.lbl_stopwatch_hours_title.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stopwatch_hours_title.Location = new System.Drawing.Point(102, 223);
            this.lbl_stopwatch_hours_title.Name = "lbl_stopwatch_hours_title";
            this.lbl_stopwatch_hours_title.Size = new System.Drawing.Size(36, 31);
            this.lbl_stopwatch_hours_title.TabIndex = 4;
            this.lbl_stopwatch_hours_title.Text = "hr";
            // 
            // lbl_stopwatch_mins_title
            // 
            this.lbl_stopwatch_mins_title.AutoSize = true;
            this.lbl_stopwatch_mins_title.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stopwatch_mins_title.Location = new System.Drawing.Point(266, 223);
            this.lbl_stopwatch_mins_title.Name = "lbl_stopwatch_mins_title";
            this.lbl_stopwatch_mins_title.Size = new System.Drawing.Size(53, 31);
            this.lbl_stopwatch_mins_title.TabIndex = 5;
            this.lbl_stopwatch_mins_title.Text = "min";
            this.lbl_stopwatch_mins_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_stopwatch_secs_title
            // 
            this.lbl_stopwatch_secs_title.AutoSize = true;
            this.lbl_stopwatch_secs_title.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stopwatch_secs_title.Location = new System.Drawing.Point(443, 223);
            this.lbl_stopwatch_secs_title.Name = "lbl_stopwatch_secs_title";
            this.lbl_stopwatch_secs_title.Size = new System.Drawing.Size(47, 31);
            this.lbl_stopwatch_secs_title.TabIndex = 6;
            this.lbl_stopwatch_secs_title.Text = "sec";
            this.lbl_stopwatch_secs_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_csecond
            // 
            this.lbl_csecond.AutoSize = true;
            this.lbl_csecond.BackColor = System.Drawing.Color.Transparent;
            this.lbl_csecond.Font = new System.Drawing.Font("Segoe UI", 60F);
            this.lbl_csecond.Location = new System.Drawing.Point(565, 107);
            this.lbl_csecond.Name = "lbl_csecond";
            this.lbl_csecond.Size = new System.Drawing.Size(165, 133);
            this.lbl_csecond.TabIndex = 7;
            this.lbl_csecond.Text = "00";
            this.lbl_csecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tbc_main.Controls.Add(this.tp_alarm);
            this.tbc_main.Controls.Add(this.tp_clock);
            this.tbc_main.Location = new System.Drawing.Point(264, 1);
            this.tbc_main.Name = "tbc_main";
            this.tbc_main.SelectedIndex = 0;
            this.tbc_main.Size = new System.Drawing.Size(741, 675);
            this.tbc_main.TabIndex = 11;
            // 
            // tp_Stopwatch
            // 
            this.tp_Stopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tp_Stopwatch.Controls.Add(this.label1);
            this.tp_Stopwatch.Controls.Add(this.btn_Smallwindow);
            this.tp_Stopwatch.Controls.Add(this.btn_Fullscreen);
            this.tp_Stopwatch.Controls.Add(this.lv_recordes);
            this.tp_Stopwatch.Controls.Add(this.lbl_stopwatch_secs_title);
            this.tp_Stopwatch.Controls.Add(this.btn_StartStopwatch);
            this.tp_Stopwatch.Controls.Add(this.lbl_stopwatch_mins_title);
            this.tp_Stopwatch.Controls.Add(this.btn_FlagStopwatch);
            this.tp_Stopwatch.Controls.Add(this.lbl_stopwatch_hours_title);
            this.tp_Stopwatch.Controls.Add(this.btn_ResetStopwatch);
            this.tp_Stopwatch.Controls.Add(this.lbl_csecond);
            this.tp_Stopwatch.Controls.Add(this.lbl_Stopwatch_time);
            this.tp_Stopwatch.Location = new System.Drawing.Point(4, 25);
            this.tp_Stopwatch.Name = "tp_Stopwatch";
            this.tp_Stopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Stopwatch.Size = new System.Drawing.Size(733, 646);
            this.tp_Stopwatch.TabIndex = 0;
            this.tp_Stopwatch.Text = "Stopwatch";
            this.tp_Stopwatch.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btn_Smallwindow
            // 
            this.btn_Smallwindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Smallwindow.BackgroundImage = global::Clock.Properties.Resources.img_smallwindow;
            this.btn_Smallwindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Smallwindow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Smallwindow.Location = new System.Drawing.Point(654, 65);
            this.btn_Smallwindow.Name = "btn_Smallwindow";
            this.btn_Smallwindow.Size = new System.Drawing.Size(30, 30);
            this.btn_Smallwindow.TabIndex = 13;
            this.btn_Smallwindow.UseVisualStyleBackColor = false;
            // 
            // btn_Fullscreen
            // 
            this.btn_Fullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Fullscreen.BackgroundImage = global::Clock.Properties.Resources.img_FullScreen1;
            this.btn_Fullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fullscreen.Location = new System.Drawing.Point(618, 65);
            this.btn_Fullscreen.Name = "btn_Fullscreen";
            this.btn_Fullscreen.Size = new System.Drawing.Size(30, 30);
            this.btn_Fullscreen.TabIndex = 12;
            this.btn_Fullscreen.UseVisualStyleBackColor = false;
            this.btn_Fullscreen.Click += new System.EventHandler(this.btn_Fullscreen_Click);
            // 
            // lv_recordes
            // 
            this.lv_recordes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lv_recordes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lv_recordes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_recordes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvc_stopwatch_laps,
            this.lvc_stopwatch_time,
            this.lvc_stopwatch_total});
            this.lv_recordes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lv_recordes.HideSelection = false;
            this.lv_recordes.Location = new System.Drawing.Point(21, 389);
            this.lv_recordes.Name = "lv_recordes";
            this.lv_recordes.Size = new System.Drawing.Size(688, 257);
            this.lv_recordes.TabIndex = 11;
            this.lv_recordes.UseCompatibleStateImageBehavior = false;
            this.lv_recordes.View = System.Windows.Forms.View.Details;
            this.lv_recordes.Visible = false;
            this.lv_recordes.SelectedIndexChanged += new System.EventHandler(this.lv_recordes_SelectedIndexChanged);
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
            // btn_StartStopwatch
            // 
            this.btn_StartStopwatch.BackColor = System.Drawing.Color.Transparent;
            this.btn_StartStopwatch.BackgroundImage = global::Clock.Properties.Resources.stopwatch_start;
            this.btn_StartStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_StartStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_StartStopwatch.Location = new System.Drawing.Point(241, 295);
            this.btn_StartStopwatch.Name = "btn_StartStopwatch";
            this.btn_StartStopwatch.Size = new System.Drawing.Size(75, 73);
            this.btn_StartStopwatch.TabIndex = 8;
            this.btn_StartStopwatch.Tag = "0";
            this.btn_StartStopwatch.Text = " ";
            this.btn_StartStopwatch.UseVisualStyleBackColor = false;
            this.btn_StartStopwatch.Click += new System.EventHandler(this.btn_StartStopwatch_Click);
            // 
            // btn_FlagStopwatch
            // 
            this.btn_FlagStopwatch.BackColor = System.Drawing.Color.Transparent;
            this.btn_FlagStopwatch.BackgroundImage = global::Clock.Properties.Resources.stopwatch_flag;
            this.btn_FlagStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FlagStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FlagStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FlagStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_FlagStopwatch.Location = new System.Drawing.Point(322, 295);
            this.btn_FlagStopwatch.Name = "btn_FlagStopwatch";
            this.btn_FlagStopwatch.Size = new System.Drawing.Size(75, 73);
            this.btn_FlagStopwatch.TabIndex = 9;
            this.btn_FlagStopwatch.Text = " ";
            this.btn_FlagStopwatch.UseVisualStyleBackColor = false;
            this.btn_FlagStopwatch.Click += new System.EventHandler(this.btn_FlagStopwatch_Click);
            // 
            // btn_ResetStopwatch
            // 
            this.btn_ResetStopwatch.BackColor = System.Drawing.Color.Transparent;
            this.btn_ResetStopwatch.BackgroundImage = global::Clock.Properties.Resources.stopwatch_reset;
            this.btn_ResetStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ResetStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_ResetStopwatch.Location = new System.Drawing.Point(403, 295);
            this.btn_ResetStopwatch.Name = "btn_ResetStopwatch";
            this.btn_ResetStopwatch.Size = new System.Drawing.Size(75, 73);
            this.btn_ResetStopwatch.TabIndex = 10;
            this.btn_ResetStopwatch.Text = " ";
            this.btn_ResetStopwatch.UseVisualStyleBackColor = false;
            this.btn_ResetStopwatch.Click += new System.EventHandler(this.btn_ResetStopwatch_Click);
            // 
            // tb_timer
            // 
            this.tb_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_timer.Controls.Add(this.label3);
            this.tb_timer.Location = new System.Drawing.Point(4, 25);
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Padding = new System.Windows.Forms.Padding(3);
            this.tb_timer.Size = new System.Drawing.Size(733, 646);
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
            // btn_tab_timer
            // 
            this.btn_tab_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_tab_timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tab_timer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_timer.Location = new System.Drawing.Point(2, 12);
            this.btn_tab_timer.Name = "btn_tab_timer";
            this.btn_tab_timer.Size = new System.Drawing.Size(269, 49);
            this.btn_tab_timer.TabIndex = 12;
            this.btn_tab_timer.Text = "     Timer";
            this.btn_tab_timer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_timer.UseVisualStyleBackColor = false;
            this.btn_tab_timer.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // btn_tab_alarm
            // 
            this.btn_tab_alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_tab_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tab_alarm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_alarm.Location = new System.Drawing.Point(2, 68);
            this.btn_tab_alarm.Name = "btn_tab_alarm";
            this.btn_tab_alarm.Size = new System.Drawing.Size(269, 49);
            this.btn_tab_alarm.TabIndex = 13;
            this.btn_tab_alarm.Text = "     Alarm";
            this.btn_tab_alarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_alarm.UseVisualStyleBackColor = false;
            this.btn_tab_alarm.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // btn_tab_stopwatch
            // 
            this.btn_tab_stopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_tab_stopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tab_stopwatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_stopwatch.Location = new System.Drawing.Point(2, 123);
            this.btn_tab_stopwatch.Name = "btn_tab_stopwatch";
            this.btn_tab_stopwatch.Size = new System.Drawing.Size(269, 49);
            this.btn_tab_stopwatch.TabIndex = 14;
            this.btn_tab_stopwatch.Text = "     Stopwatch";
            this.btn_tab_stopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_stopwatch.UseVisualStyleBackColor = false;
            this.btn_tab_stopwatch.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // btn_tab_clock
            // 
            this.btn_tab_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_tab_clock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tab_clock.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_clock.Location = new System.Drawing.Point(2, 178);
            this.btn_tab_clock.Name = "btn_tab_clock";
            this.btn_tab_clock.Size = new System.Drawing.Size(269, 49);
            this.btn_tab_clock.TabIndex = 15;
            this.btn_tab_clock.Text = "     Clock";
            this.btn_tab_clock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_clock.UseVisualStyleBackColor = false;
            this.btn_tab_clock.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // tp_alarm
            // 
            this.tp_alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tp_alarm.Location = new System.Drawing.Point(4, 25);
            this.tp_alarm.Name = "tp_alarm";
            this.tp_alarm.Padding = new System.Windows.Forms.Padding(3);
            this.tp_alarm.Size = new System.Drawing.Size(733, 646);
            this.tp_alarm.TabIndex = 2;
            this.tp_alarm.Text = "Alarm";
            // 
            // tp_clock
            // 
            this.tp_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tp_clock.Location = new System.Drawing.Point(4, 25);
            this.tp_clock.Name = "tp_clock";
            this.tp_clock.Padding = new System.Windows.Forms.Padding(3);
            this.tp_clock.Size = new System.Drawing.Size(733, 646);
            this.tp_clock.TabIndex = 3;
            this.tp_clock.Text = "Clock";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1010, 678);
            this.Controls.Add(this.tbc_main);
            this.Controls.Add(this.btn_tab_timer);
            this.Controls.Add(this.btn_tab_clock);
            this.Controls.Add(this.btn_tab_stopwatch);
            this.Controls.Add(this.btn_tab_alarm);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 183);
            this.Name = "main_form";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.Resize += new System.EventHandler(this.main_form_Resize);
            this.tbc_main.ResumeLayout(false);
            this.tp_Stopwatch.ResumeLayout(false);
            this.tp_Stopwatch.PerformLayout();
            this.tb_timer.ResumeLayout(false);
            this.tb_timer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Stopwatch_time;
        private System.Windows.Forms.Label lbl_stopwatch_hours_title;
        private System.Windows.Forms.Label lbl_stopwatch_mins_title;
        private System.Windows.Forms.Label lbl_stopwatch_secs_title;
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
        private System.Windows.Forms.Button btn_Fullscreen;
        private System.Windows.Forms.Button btn_Smallwindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tab_timer;
        private System.Windows.Forms.Button btn_tab_alarm;
        private System.Windows.Forms.Button btn_tab_stopwatch;
        private System.Windows.Forms.Button btn_tab_clock;
        private System.Windows.Forms.TabPage tp_alarm;
        private System.Windows.Forms.TabPage tp_clock;
    }
}

