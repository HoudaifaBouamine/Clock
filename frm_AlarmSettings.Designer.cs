namespace Clock
{
    partial class frm_AlarmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AlarmSettings));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Hours = new System.Windows.Forms.Label();
            this.lbl_Mins = new System.Windows.Forms.Label();
            this.lbl_doublePoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_up_min = new System.Windows.Forms.Button();
            this.btn_up_hour = new System.Windows.Forms.Button();
            this.btn_down_min = new System.Windows.Forms.Button();
            this.btn_down_hour = new System.Windows.Forms.Button();
            this.tb_AlarmName = new System.Windows.Forms.TextBox();
            this.cb_RepeatAlarm = new System.Windows.Forms.CheckBox();
            this.btn_week_Monday = new System.Windows.Forms.Button();
            this.btn_week_tusday = new System.Windows.Forms.Button();
            this.btn_week_wednesday = new System.Windows.Forms.Button();
            this.btn_week_thersday = new System.Windows.Forms.Button();
            this.btn_week_friday = new System.Windows.Forms.Button();
            this.btn_week_saturday = new System.Windows.Forms.Button();
            this.btn_week_sunday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Sound = new System.Windows.Forms.ComboBox();
            this.cb_SoundDuration = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pb_Name = new System.Windows.Forms.PictureBox();
            this.pb_Delay = new System.Windows.Forms.PictureBox();
            this.pb_Sound = new System.Windows.Forms.PictureBox();
            this.pb_Delete = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(80, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 31);
            this.label3.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lbl_Hours);
            this.panel1.Controls.Add(this.lbl_Mins);
            this.panel1.Controls.Add(this.lbl_doublePoints);
            this.panel1.Location = new System.Drawing.Point(47, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 99);
            this.panel1.TabIndex = 12;
            // 
            // lbl_Hours
            // 
            this.lbl_Hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_Hours.Font = new System.Drawing.Font("Segoe UI Semibold", 33F, System.Drawing.FontStyle.Bold);
            this.lbl_Hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Hours.Location = new System.Drawing.Point(56, 9);
            this.lbl_Hours.Name = "lbl_Hours";
            this.lbl_Hours.Size = new System.Drawing.Size(99, 80);
            this.lbl_Hours.TabIndex = 0;
            this.lbl_Hours.Text = "00";
            this.lbl_Hours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mins
            // 
            this.lbl_Mins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_Mins.Font = new System.Drawing.Font("Segoe UI Semibold", 33F, System.Drawing.FontStyle.Bold);
            this.lbl_Mins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Mins.Location = new System.Drawing.Point(181, 9);
            this.lbl_Mins.Name = "lbl_Mins";
            this.lbl_Mins.Size = new System.Drawing.Size(99, 80);
            this.lbl_Mins.TabIndex = 1;
            this.lbl_Mins.Text = "00";
            this.lbl_Mins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Mins.Click += new System.EventHandler(this.lbl_Mins_Click);
            // 
            // lbl_doublePoints
            // 
            this.lbl_doublePoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_doublePoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_doublePoints.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Bold);
            this.lbl_doublePoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_doublePoints.Location = new System.Drawing.Point(0, 0);
            this.lbl_doublePoints.Name = "lbl_doublePoints";
            this.lbl_doublePoints.Size = new System.Drawing.Size(327, 89);
            this.lbl_doublePoints.TabIndex = 3;
            this.lbl_doublePoints.Text = "         :";
            this.lbl_doublePoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(93, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 14;
            // 
            // btn_up_min
            // 
            this.btn_up_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_up_min.FlatAppearance.BorderSize = 0;
            this.btn_up_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_up_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up_min.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_up_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_up_min.Location = new System.Drawing.Point(229, 103);
            this.btn_up_min.Name = "btn_up_min";
            this.btn_up_min.Size = new System.Drawing.Size(71, 55);
            this.btn_up_min.TabIndex = 15;
            this.btn_up_min.Text = "︿";
            this.btn_up_min.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_up_min.UseVisualStyleBackColor = false;
            // 
            // btn_up_hour
            // 
            this.btn_up_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_up_hour.FlatAppearance.BorderSize = 0;
            this.btn_up_hour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_up_hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up_hour.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_up_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_up_hour.Location = new System.Drawing.Point(106, 103);
            this.btn_up_hour.Name = "btn_up_hour";
            this.btn_up_hour.Size = new System.Drawing.Size(71, 55);
            this.btn_up_hour.TabIndex = 13;
            this.btn_up_hour.Text = "︿";
            this.btn_up_hour.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_up_hour.UseVisualStyleBackColor = false;
            // 
            // btn_down_min
            // 
            this.btn_down_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_down_min.FlatAppearance.BorderSize = 0;
            this.btn_down_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_down_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down_min.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_down_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_down_min.Location = new System.Drawing.Point(229, 245);
            this.btn_down_min.Name = "btn_down_min";
            this.btn_down_min.Size = new System.Drawing.Size(71, 55);
            this.btn_down_min.TabIndex = 18;
            this.btn_down_min.Text = "﹀";
            this.btn_down_min.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_down_min.UseVisualStyleBackColor = false;
            // 
            // btn_down_hour
            // 
            this.btn_down_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_down_hour.FlatAppearance.BorderSize = 0;
            this.btn_down_hour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_down_hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down_hour.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_down_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_down_hour.Location = new System.Drawing.Point(106, 245);
            this.btn_down_hour.Name = "btn_down_hour";
            this.btn_down_hour.Size = new System.Drawing.Size(71, 55);
            this.btn_down_hour.TabIndex = 17;
            this.btn_down_hour.Text = "﹀";
            this.btn_down_hour.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_down_hour.UseVisualStyleBackColor = false;
            // 
            // tb_AlarmName
            // 
            this.tb_AlarmName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_AlarmName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.tb_AlarmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.tb_AlarmName.Location = new System.Drawing.Point(89, 320);
            this.tb_AlarmName.Name = "tb_AlarmName";
            this.tb_AlarmName.Size = new System.Drawing.Size(292, 39);
            this.tb_AlarmName.TabIndex = 21;
            this.tb_AlarmName.Text = "Alarm (1)";
            // 
            // cb_RepeatAlarm
            // 
            this.cb_RepeatAlarm.AutoSize = true;
            this.cb_RepeatAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.cb_RepeatAlarm.Location = new System.Drawing.Point(47, 386);
            this.cb_RepeatAlarm.Name = "cb_RepeatAlarm";
            this.cb_RepeatAlarm.Size = new System.Drawing.Size(155, 32);
            this.cb_RepeatAlarm.TabIndex = 22;
            this.cb_RepeatAlarm.Text = "Repeat Alarm";
            this.cb_RepeatAlarm.UseVisualStyleBackColor = true;
            // 
            // btn_week_Monday
            // 
            this.btn_week_Monday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_week_Monday.Location = new System.Drawing.Point(47, 436);
            this.btn_week_Monday.Name = "btn_week_Monday";
            this.btn_week_Monday.Size = new System.Drawing.Size(45, 41);
            this.btn_week_Monday.TabIndex = 23;
            this.btn_week_Monday.Text = "M";
            this.btn_week_Monday.UseVisualStyleBackColor = true;
            // 
            // btn_week_tusday
            // 
            this.btn_week_tusday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_week_tusday.Location = new System.Drawing.Point(94, 436);
            this.btn_week_tusday.Name = "btn_week_tusday";
            this.btn_week_tusday.Size = new System.Drawing.Size(45, 41);
            this.btn_week_tusday.TabIndex = 24;
            this.btn_week_tusday.Text = "Tu";
            this.btn_week_tusday.UseVisualStyleBackColor = true;
            // 
            // btn_week_wednesday
            // 
            this.btn_week_wednesday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_week_wednesday.Location = new System.Drawing.Point(141, 436);
            this.btn_week_wednesday.Name = "btn_week_wednesday";
            this.btn_week_wednesday.Size = new System.Drawing.Size(45, 41);
            this.btn_week_wednesday.TabIndex = 25;
            this.btn_week_wednesday.Text = "We";
            this.btn_week_wednesday.UseVisualStyleBackColor = true;
            // 
            // btn_week_thersday
            // 
            this.btn_week_thersday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_week_thersday.Location = new System.Drawing.Point(188, 436);
            this.btn_week_thersday.Name = "btn_week_thersday";
            this.btn_week_thersday.Size = new System.Drawing.Size(45, 41);
            this.btn_week_thersday.TabIndex = 26;
            this.btn_week_thersday.Text = "Th";
            this.btn_week_thersday.UseVisualStyleBackColor = true;
            // 
            // btn_week_friday
            // 
            this.btn_week_friday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_week_friday.Location = new System.Drawing.Point(235, 436);
            this.btn_week_friday.Name = "btn_week_friday";
            this.btn_week_friday.Size = new System.Drawing.Size(45, 41);
            this.btn_week_friday.TabIndex = 27;
            this.btn_week_friday.Text = "Fri";
            this.btn_week_friday.UseVisualStyleBackColor = true;
            // 
            // btn_week_saturday
            // 
            this.btn_week_saturday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_week_saturday.Location = new System.Drawing.Point(282, 436);
            this.btn_week_saturday.Name = "btn_week_saturday";
            this.btn_week_saturday.Size = new System.Drawing.Size(45, 41);
            this.btn_week_saturday.TabIndex = 28;
            this.btn_week_saturday.Text = "Sa";
            this.btn_week_saturday.UseVisualStyleBackColor = true;
            // 
            // btn_week_sunday
            // 
            this.btn_week_sunday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_week_sunday.Location = new System.Drawing.Point(329, 436);
            this.btn_week_sunday.Name = "btn_week_sunday";
            this.btn_week_sunday.Size = new System.Drawing.Size(45, 41);
            this.btn_week_sunday.TabIndex = 29;
            this.btn_week_sunday.Text = "Su";
            this.btn_week_sunday.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Edit Alarm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_Sound
            // 
            this.cb_Sound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cb_Sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Sound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.cb_Sound.FormattingEnabled = true;
            this.cb_Sound.Location = new System.Drawing.Point(89, 509);
            this.cb_Sound.Name = "cb_Sound";
            this.cb_Sound.Size = new System.Drawing.Size(285, 36);
            this.cb_Sound.TabIndex = 32;
            // 
            // cb_SoundDuration
            // 
            this.cb_SoundDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cb_SoundDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_SoundDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.cb_SoundDuration.FormattingEnabled = true;
            this.cb_SoundDuration.Location = new System.Drawing.Point(89, 566);
            this.cb_SoundDuration.Name = "cb_SoundDuration";
            this.cb_SoundDuration.Size = new System.Drawing.Size(285, 36);
            this.cb_SoundDuration.TabIndex = 34;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Green;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(47, 637);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(155, 38);
            this.btn_Save.TabIndex = 36;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(219, 637);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(155, 38);
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pb_Name
            // 
            this.pb_Name.BackgroundImage = global::Clock.Properties.Resources.img_pen_on_paper;
            this.pb_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Name.Location = new System.Drawing.Point(58, 325);
            this.pb_Name.Name = "pb_Name";
            this.pb_Name.Size = new System.Drawing.Size(25, 25);
            this.pb_Name.TabIndex = 38;
            this.pb_Name.TabStop = false;
            // 
            // pb_Delay
            // 
            this.pb_Delay.BackgroundImage = global::Clock.Properties.Resources.img_alarm_ring;
            this.pb_Delay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Delay.Location = new System.Drawing.Point(58, 571);
            this.pb_Delay.Name = "pb_Delay";
            this.pb_Delay.Size = new System.Drawing.Size(25, 25);
            this.pb_Delay.TabIndex = 35;
            this.pb_Delay.TabStop = false;
            // 
            // pb_Sound
            // 
            this.pb_Sound.BackgroundImage = global::Clock.Properties.Resources.img_alarm_sound;
            this.pb_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Sound.Location = new System.Drawing.Point(58, 514);
            this.pb_Sound.Name = "pb_Sound";
            this.pb_Sound.Size = new System.Drawing.Size(25, 25);
            this.pb_Sound.TabIndex = 33;
            this.pb_Sound.TabStop = false;
            // 
            // pb_Delete
            // 
            this.pb_Delete.BackgroundImage = global::Clock.Properties.Resources.img_Delete;
            this.pb_Delete.Location = new System.Drawing.Point(342, 37);
            this.pb_Delete.Name = "pb_Delete";
            this.pb_Delete.Size = new System.Drawing.Size(36, 39);
            this.pb_Delete.TabIndex = 31;
            this.pb_Delete.TabStop = false;
            // 
            // frm_AlarmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(425, 702);
            this.Controls.Add(this.pb_Name);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pb_Delay);
            this.Controls.Add(this.cb_SoundDuration);
            this.Controls.Add(this.pb_Sound);
            this.Controls.Add(this.cb_Sound);
            this.Controls.Add(this.pb_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_week_sunday);
            this.Controls.Add(this.btn_week_saturday);
            this.Controls.Add(this.btn_week_friday);
            this.Controls.Add(this.btn_week_thersday);
            this.Controls.Add(this.btn_week_wednesday);
            this.Controls.Add(this.btn_week_tusday);
            this.Controls.Add(this.btn_week_Monday);
            this.Controls.Add(this.cb_RepeatAlarm);
            this.Controls.Add(this.tb_AlarmName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_up_min);
            this.Controls.Add(this.btn_up_hour);
            this.Controls.Add(this.btn_down_min);
            this.Controls.Add(this.btn_down_hour);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_AlarmSettings";
            this.Load += new System.EventHandler(this.frm_AlarmSettings_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Hours;
        private System.Windows.Forms.Label lbl_Mins;
        private System.Windows.Forms.Label lbl_doublePoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_up_min;
        private System.Windows.Forms.Button btn_up_hour;
        private System.Windows.Forms.Button btn_down_min;
        private System.Windows.Forms.Button btn_down_hour;
        private System.Windows.Forms.TextBox tb_AlarmName;
        private System.Windows.Forms.CheckBox cb_RepeatAlarm;
        private System.Windows.Forms.Button btn_week_Monday;
        private System.Windows.Forms.Button btn_week_tusday;
        private System.Windows.Forms.Button btn_week_wednesday;
        private System.Windows.Forms.Button btn_week_thersday;
        private System.Windows.Forms.Button btn_week_friday;
        private System.Windows.Forms.Button btn_week_saturday;
        private System.Windows.Forms.Button btn_week_sunday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Delete;
        private System.Windows.Forms.ComboBox cb_Sound;
        private System.Windows.Forms.PictureBox pb_Sound;
        private System.Windows.Forms.PictureBox pb_Delay;
        private System.Windows.Forms.ComboBox cb_SoundDuration;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.PictureBox pb_Name;
    }
}