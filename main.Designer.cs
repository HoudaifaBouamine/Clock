using System;
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
            this.tb_timer = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_Timer1 = new System.Windows.Forms.Panel();
            this.btn_timer_start_timer = new System.Windows.Forms.Button();
            this.btn_timer_reset_timer = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_timer_small_screen = new System.Windows.Forms.Button();
            this.btn_timer_FullScreen = new System.Windows.Forms.Button();
            this.lbl_timer_title = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.tp_alarm = new System.Windows.Forms.TabPage();
            this.alarm1 = new Clock.MyAlarm();
            this.tp_Stopwatch = new System.Windows.Forms.TabPage();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Smallwindow = new System.Windows.Forms.Button();
            this.btn_Fullscreen = new System.Windows.Forms.Button();
            this.lv_recordes = new System.Windows.Forms.ListView();
            this.lvc_stopwatch_laps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvc_stopwatch_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvc_stopwatch_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_StartStopwatch = new System.Windows.Forms.Button();
            this.btn_FlagStopwatch = new System.Windows.Forms.Button();
            this.btn_ResetStopwatch = new System.Windows.Forms.Button();
            this.tp_clock = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_tab_timer = new System.Windows.Forms.Button();
            this.btn_tab_alarm = new System.Windows.Forms.Button();
            this.btn_tab_stopwatch = new System.Windows.Forms.Button();
            this.btn_tab_clock = new System.Windows.Forms.Button();
            this.timer_timer_down = new System.Windows.Forms.Timer(this.components);
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbc_main.SuspendLayout();
            this.tb_timer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.p_Timer1.SuspendLayout();
            this.tp_alarm.SuspendLayout();
            this.tp_Stopwatch.SuspendLayout();
            this.tp_clock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Stopwatch_time
            // 
            this.lbl_Stopwatch_time.AutoSize = true;
            this.lbl_Stopwatch_time.Font = new System.Drawing.Font("Segoe UI", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stopwatch_time.Location = new System.Drawing.Point(46, 69);
            this.lbl_Stopwatch_time.Name = "lbl_Stopwatch_time";
            this.lbl_Stopwatch_time.Size = new System.Drawing.Size(593, 175);
            this.lbl_Stopwatch_time.TabIndex = 2;
            this.lbl_Stopwatch_time.Text = "00:00:00.";
            // 
            // lbl_stopwatch_hours_title
            // 
            this.lbl_stopwatch_hours_title.AutoSize = true;
            this.lbl_stopwatch_hours_title.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stopwatch_hours_title.Location = new System.Drawing.Point(131, 227);
            this.lbl_stopwatch_hours_title.Name = "lbl_stopwatch_hours_title";
            this.lbl_stopwatch_hours_title.Size = new System.Drawing.Size(36, 31);
            this.lbl_stopwatch_hours_title.TabIndex = 4;
            this.lbl_stopwatch_hours_title.Text = "hr";
            // 
            // lbl_stopwatch_mins_title
            // 
            this.lbl_stopwatch_mins_title.AutoSize = true;
            this.lbl_stopwatch_mins_title.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stopwatch_mins_title.Location = new System.Drawing.Point(297, 227);
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
            this.lbl_stopwatch_secs_title.Location = new System.Drawing.Point(473, 227);
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
            this.lbl_csecond.Location = new System.Drawing.Point(595, 111);
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
            this.tbc_main.Controls.Add(this.tb_timer);
            this.tbc_main.Controls.Add(this.tp_alarm);
            this.tbc_main.Controls.Add(this.tp_Stopwatch);
            this.tbc_main.Controls.Add(this.tp_clock);
            this.tbc_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbc_main.Location = new System.Drawing.Point(259, 0);
            this.tbc_main.Name = "tbc_main";
            this.tbc_main.SelectedIndex = 0;
            this.tbc_main.Size = new System.Drawing.Size(801, 664);
            this.tbc_main.TabIndex = 11;
            // 
            // tb_timer
            // 
            this.tb_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_timer.Controls.Add(this.panel1);
            this.tb_timer.Location = new System.Drawing.Point(4, 25);
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Padding = new System.Windows.Forms.Padding(3);
            this.tb_timer.Size = new System.Drawing.Size(793, 635);
            this.tb_timer.TabIndex = 1;
            this.tb_timer.Text = "Timer";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.p_Timer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 629);
            this.panel1.TabIndex = 0;
            // 
            // p_Timer1
            // 
            this.p_Timer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.p_Timer1.Controls.Add(this.btn_timer_start_timer);
            this.p_Timer1.Controls.Add(this.btn_timer_reset_timer);
            this.p_Timer1.Controls.Add(this.lbl_timer);
            this.p_Timer1.Controls.Add(this.btn_timer_small_screen);
            this.p_Timer1.Controls.Add(this.btn_timer_FullScreen);
            this.p_Timer1.Controls.Add(this.lbl_timer_title);
            this.p_Timer1.Controls.Add(this.circularProgressBar);
            this.p_Timer1.Location = new System.Drawing.Point(34, 30);
            this.p_Timer1.Name = "p_Timer1";
            this.p_Timer1.Size = new System.Drawing.Size(723, 333);
            this.p_Timer1.TabIndex = 16;
            this.p_Timer1.Tag = "60";
            this.p_Timer1.Click += new System.EventHandler(this.p_Timer1_Click);
            this.p_Timer1.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Timer1_Paint);
            this.p_Timer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.p_Timer1.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.p_Timer1.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // btn_timer_start_timer
            // 
            this.btn_timer_start_timer.BackColor = System.Drawing.Color.Transparent;
            this.btn_timer_start_timer.BackgroundImage = global::Clock.Properties.Resources.stopwatch_start;
            this.btn_timer_start_timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timer_start_timer.FlatAppearance.BorderSize = 0;
            this.btn_timer_start_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timer_start_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timer_start_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_timer_start_timer.Location = new System.Drawing.Point(321, 274);
            this.btn_timer_start_timer.Name = "btn_timer_start_timer";
            this.btn_timer_start_timer.Size = new System.Drawing.Size(38, 38);
            this.btn_timer_start_timer.TabIndex = 18;
            this.btn_timer_start_timer.Tag = "0";
            this.btn_timer_start_timer.Text = " ";
            this.btn_timer_start_timer.UseVisualStyleBackColor = false;
            this.btn_timer_start_timer.Click += new System.EventHandler(this.btn_timer_start_timer_Click);
            this.btn_timer_start_timer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.btn_timer_start_timer.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.btn_timer_start_timer.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // btn_timer_reset_timer
            // 
            this.btn_timer_reset_timer.BackColor = System.Drawing.Color.Transparent;
            this.btn_timer_reset_timer.BackgroundImage = global::Clock.Properties.Resources.stopwatch_reset;
            this.btn_timer_reset_timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timer_reset_timer.FlatAppearance.BorderSize = 0;
            this.btn_timer_reset_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timer_reset_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timer_reset_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_timer_reset_timer.Location = new System.Drawing.Point(365, 274);
            this.btn_timer_reset_timer.Name = "btn_timer_reset_timer";
            this.btn_timer_reset_timer.Size = new System.Drawing.Size(38, 38);
            this.btn_timer_reset_timer.TabIndex = 20;
            this.btn_timer_reset_timer.Text = " ";
            this.btn_timer_reset_timer.UseVisualStyleBackColor = false;
            this.btn_timer_reset_timer.Click += new System.EventHandler(this.btn_timer_reset_timer_Click);
            this.btn_timer_reset_timer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.btn_timer_reset_timer.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.btn_timer_reset_timer.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Segoe UI Semibold", 23.8F, System.Drawing.FontStyle.Bold);
            this.lbl_timer.Location = new System.Drawing.Point(277, 114);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(175, 54);
            this.lbl_timer.TabIndex = 17;
            this.lbl_timer.Text = "00:00:00";
            this.lbl_timer.Click += new System.EventHandler(this.lbl_timer_Click);
            this.lbl_timer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.lbl_timer.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.lbl_timer.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // btn_timer_small_screen
            // 
            this.btn_timer_small_screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_timer_small_screen.BackgroundImage = global::Clock.Properties.Resources.img_smallwindow;
            this.btn_timer_small_screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timer_small_screen.FlatAppearance.BorderSize = 0;
            this.btn_timer_small_screen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_timer_small_screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timer_small_screen.Location = new System.Drawing.Point(661, 15);
            this.btn_timer_small_screen.Name = "btn_timer_small_screen";
            this.btn_timer_small_screen.Size = new System.Drawing.Size(29, 30);
            this.btn_timer_small_screen.TabIndex = 15;
            this.btn_timer_small_screen.UseVisualStyleBackColor = false;
            this.btn_timer_small_screen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.btn_timer_small_screen.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.btn_timer_small_screen.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // btn_timer_FullScreen
            // 
            this.btn_timer_FullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_timer_FullScreen.BackgroundImage = global::Clock.Properties.Resources.img_FullScreen1;
            this.btn_timer_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timer_FullScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_timer_FullScreen.FlatAppearance.BorderSize = 0;
            this.btn_timer_FullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_timer_FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timer_FullScreen.Location = new System.Drawing.Point(614, 15);
            this.btn_timer_FullScreen.Name = "btn_timer_FullScreen";
            this.btn_timer_FullScreen.Size = new System.Drawing.Size(29, 30);
            this.btn_timer_FullScreen.TabIndex = 14;
            this.btn_timer_FullScreen.UseVisualStyleBackColor = false;
            this.btn_timer_FullScreen.Click += new System.EventHandler(this.btn_timer_FullScreen_Click);
            this.btn_timer_FullScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.btn_timer_FullScreen.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.btn_timer_FullScreen.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // lbl_timer_title
            // 
            this.lbl_timer_title.AutoSize = true;
            this.lbl_timer_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_timer_title.Location = new System.Drawing.Point(19, 23);
            this.lbl_timer_title.Name = "lbl_timer_title";
            this.lbl_timer_title.Size = new System.Drawing.Size(58, 22);
            this.lbl_timer_title.TabIndex = 0;
            this.lbl_timer_title.Text = "1 min";
            this.lbl_timer_title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.lbl_timer_title.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.lbl_timer_title.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 0;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(244, 23);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 25;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.ForestGreen;
            this.circularProgressBar.ProgressWidth = 15;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.circularProgressBar.Size = new System.Drawing.Size(235, 239);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = ".23";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 16;
            this.circularProgressBar.Tag = "60";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 68;
            this.circularProgressBar.Click += new System.EventHandler(this.circularProgressBar_Click);
            this.circularProgressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Timer1_MouseClick);
            this.circularProgressBar.MouseEnter += new System.EventHandler(this.p_Timer1_MouseEnter);
            this.circularProgressBar.MouseLeave += new System.EventHandler(this.p_Timer1_MouseLeave);
            // 
            // tp_alarm
            // 
            this.tp_alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tp_alarm.Controls.Add(this.alarm1);
            this.tp_alarm.Location = new System.Drawing.Point(4, 25);
            this.tp_alarm.Name = "tp_alarm";
            this.tp_alarm.Padding = new System.Windows.Forms.Padding(3);
            this.tp_alarm.Size = new System.Drawing.Size(793, 635);
            this.tp_alarm.TabIndex = 2;
            this.tp_alarm.Text = "Alarm";
            // 
            // alarm1
            // 
            this.alarm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.alarm1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.alarm1.Location = new System.Drawing.Point(59, 25);
            this.alarm1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.alarm1.Name = "alarm1";
            this.alarm1.Size = new System.Drawing.Size(661, 243);
            this.alarm1.TabIndex = 0;
            this.alarm1.Load += new System.EventHandler(this.alarm1_Load);
            this.alarm1.Click += new System.EventHandler(this.alarm1_Click);
            // 
            // tp_Stopwatch
            // 
            this.tp_Stopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tp_Stopwatch.Controls.Add(this.btn_Close);
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
            this.tp_Stopwatch.Size = new System.Drawing.Size(793, 635);
            this.tp_Stopwatch.TabIndex = 0;
            this.tp_Stopwatch.Text = "Stopwatch";
            this.tp_Stopwatch.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btn_Close.Location = new System.Drawing.Point(738, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(55, 36);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Visible = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Smallwindow
            // 
            this.btn_Smallwindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Smallwindow.BackgroundImage = global::Clock.Properties.Resources.img_smallwindow;
            this.btn_Smallwindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Smallwindow.FlatAppearance.BorderSize = 0;
            this.btn_Smallwindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Smallwindow.Location = new System.Drawing.Point(683, 69);
            this.btn_Smallwindow.Name = "btn_Smallwindow";
            this.btn_Smallwindow.Size = new System.Drawing.Size(29, 30);
            this.btn_Smallwindow.TabIndex = 13;
            this.btn_Smallwindow.UseVisualStyleBackColor = false;
            this.btn_Smallwindow.Click += new System.EventHandler(this.btn_Smallwindow_Click);
            // 
            // btn_Fullscreen
            // 
            this.btn_Fullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Fullscreen.BackgroundImage = global::Clock.Properties.Resources.img_FullScreen1;
            this.btn_Fullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Fullscreen.FlatAppearance.BorderSize = 0;
            this.btn_Fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fullscreen.Location = new System.Drawing.Point(649, 69);
            this.btn_Fullscreen.Name = "btn_Fullscreen";
            this.btn_Fullscreen.Size = new System.Drawing.Size(29, 30);
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
            this.lv_recordes.Location = new System.Drawing.Point(57, 421);
            this.lv_recordes.Name = "lv_recordes";
            this.lv_recordes.Size = new System.Drawing.Size(669, 239);
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
            this.btn_StartStopwatch.Location = new System.Drawing.Point(271, 299);
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
            this.btn_FlagStopwatch.Location = new System.Drawing.Point(353, 299);
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
            this.btn_ResetStopwatch.Location = new System.Drawing.Point(433, 299);
            this.btn_ResetStopwatch.Name = "btn_ResetStopwatch";
            this.btn_ResetStopwatch.Size = new System.Drawing.Size(75, 73);
            this.btn_ResetStopwatch.TabIndex = 10;
            this.btn_ResetStopwatch.Text = " ";
            this.btn_ResetStopwatch.UseVisualStyleBackColor = false;
            this.btn_ResetStopwatch.Click += new System.EventHandler(this.btn_ResetStopwatch_Click);
            // 
            // tp_clock
            // 
            this.tp_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tp_clock.Controls.Add(this.label4);
            this.tp_clock.Location = new System.Drawing.Point(4, 25);
            this.tp_clock.Name = "tp_clock";
            this.tp_clock.Padding = new System.Windows.Forms.Padding(3);
            this.tp_clock.Size = new System.Drawing.Size(793, 635);
            this.tp_clock.TabIndex = 3;
            this.tp_clock.Text = "Clock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.8F);
            this.label4.Location = new System.Drawing.Point(47, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(625, 96);
            this.label4.TabIndex = 1;
            this.label4.Text = "Comming Soon";
            // 
            // btn_tab_timer
            // 
            this.btn_tab_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_tab_timer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_tab_timer.FlatAppearance.BorderSize = 0;
            this.btn_tab_timer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_tab_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_timer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_timer.Location = new System.Drawing.Point(3, 12);
            this.btn_tab_timer.Name = "btn_tab_timer";
            this.btn_tab_timer.Size = new System.Drawing.Size(269, 44);
            this.btn_tab_timer.TabIndex = 12;
            this.btn_tab_timer.Text = "     Timer";
            this.btn_tab_timer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_timer.UseVisualStyleBackColor = false;
            this.btn_tab_timer.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // btn_tab_alarm
            // 
            this.btn_tab_alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_tab_alarm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_tab_alarm.FlatAppearance.BorderSize = 0;
            this.btn_tab_alarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_tab_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_alarm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_alarm.Location = new System.Drawing.Point(3, 65);
            this.btn_tab_alarm.Name = "btn_tab_alarm";
            this.btn_tab_alarm.Size = new System.Drawing.Size(269, 44);
            this.btn_tab_alarm.TabIndex = 13;
            this.btn_tab_alarm.Text = "     Alarm";
            this.btn_tab_alarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_alarm.UseVisualStyleBackColor = false;
            this.btn_tab_alarm.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // btn_tab_stopwatch
            // 
            this.btn_tab_stopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_tab_stopwatch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_tab_stopwatch.FlatAppearance.BorderSize = 0;
            this.btn_tab_stopwatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_tab_stopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_stopwatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_stopwatch.Location = new System.Drawing.Point(3, 118);
            this.btn_tab_stopwatch.Name = "btn_tab_stopwatch";
            this.btn_tab_stopwatch.Size = new System.Drawing.Size(269, 44);
            this.btn_tab_stopwatch.TabIndex = 14;
            this.btn_tab_stopwatch.Text = "     Stopwatch";
            this.btn_tab_stopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_stopwatch.UseVisualStyleBackColor = false;
            this.btn_tab_stopwatch.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // btn_tab_clock
            // 
            this.btn_tab_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_tab_clock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_tab_clock.FlatAppearance.BorderSize = 0;
            this.btn_tab_clock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_tab_clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_clock.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_tab_clock.Location = new System.Drawing.Point(3, 171);
            this.btn_tab_clock.Name = "btn_tab_clock";
            this.btn_tab_clock.Size = new System.Drawing.Size(269, 44);
            this.btn_tab_clock.TabIndex = 15;
            this.btn_tab_clock.Text = "     Clock";
            this.btn_tab_clock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_clock.UseVisualStyleBackColor = false;
            this.btn_tab_clock.Click += new System.EventHandler(this.btn_tab_Clicked);
            // 
            // timer_timer_down
            // 
            this.timer_timer_down.Interval = 1000;
            this.timer_timer_down.Tick += new System.EventHandler(this.timer_timer_down_Tick);
            // 
            // notification
            // 
            this.notification.Text = "notifyIcon1";
            this.notification.Visible = true;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1060, 664);
            this.Controls.Add(this.tbc_main);
            this.Controls.Add(this.btn_tab_timer);
            this.Controls.Add(this.btn_tab_clock);
            this.Controls.Add(this.btn_tab_stopwatch);
            this.Controls.Add(this.btn_tab_alarm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 183);
            this.Name = "main_form";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.Resize += new System.EventHandler(this.main_form_Resize);
            this.tbc_main.ResumeLayout(false);
            this.tb_timer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.p_Timer1.ResumeLayout(false);
            this.p_Timer1.PerformLayout();
            this.tp_alarm.ResumeLayout(false);
            this.tp_Stopwatch.ResumeLayout(false);
            this.tp_Stopwatch.PerformLayout();
            this.tp_clock.ResumeLayout(false);
            this.tp_clock.PerformLayout();
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
        private System.Windows.Forms.Button btn_Fullscreen;
        private System.Windows.Forms.Button btn_Smallwindow;
        private System.Windows.Forms.Button btn_tab_timer;
        private System.Windows.Forms.Button btn_tab_alarm;
        private System.Windows.Forms.Button btn_tab_stopwatch;
        private System.Windows.Forms.Button btn_tab_clock;
        private System.Windows.Forms.TabPage tp_clock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_Timer1;
        private System.Windows.Forms.Label lbl_timer_title;
        private System.Windows.Forms.Button btn_timer_small_screen;
        private System.Windows.Forms.Button btn_timer_FullScreen;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_timer_start_timer;
        private System.Windows.Forms.Button btn_timer_reset_timer;
        private System.Windows.Forms.Timer timer_timer_down;
        private System.Windows.Forms.NotifyIcon notification;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TabPage tp_alarm;
        private MyAlarm alarm1;
    }
}

