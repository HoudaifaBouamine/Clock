namespace Clock
{
    partial class MyAlarm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_on_off = new System.Windows.Forms.Button();
            this.timer_updateAlarm = new System.Windows.Forms.Timer(this.components);
            this.notify_alarm = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 54.8F, System.Drawing.FontStyle.Bold);
            this.lbl_time.Location = new System.Drawing.Point(3, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(225, 123);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "7:00";
            this.lbl_time.Click += new System.EventHandler(this.MyAlarm_Click);
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.lbl_duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lbl_duration.Location = new System.Drawing.Point(57, 112);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(226, 23);
            this.lbl_duration.TabIndex = 1;
            this.lbl_duration.Text = "in 6 hours and some minites";
            this.lbl_duration.Click += new System.EventHandler(this.MyAlarm_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lbl_name.Location = new System.Drawing.Point(26, 133);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(130, 38);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Alarm (1)";
            this.lbl_name.Click += new System.EventHandler(this.MyAlarm_Click);
            // 
            // btn_on_off
            // 
            this.btn_on_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_on_off.FlatAppearance.BorderSize = 0;
            this.btn_on_off.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_on_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_on_off.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_on_off.Location = new System.Drawing.Point(566, 20);
            this.btn_on_off.Name = "btn_on_off";
            this.btn_on_off.Size = new System.Drawing.Size(75, 40);
            this.btn_on_off.TabIndex = 3;
            this.btn_on_off.Text = "On";
            this.btn_on_off.UseVisualStyleBackColor = false;
            // 
            // timer_updateAlarm
            // 
            this.timer_updateAlarm.Interval = 1000;
            this.timer_updateAlarm.Tick += new System.EventHandler(this.timer_updateAlarm_Tick);
            // 
            // notify_alarm
            // 
            this.notify_alarm.Text = "Alarm Done";
            this.notify_alarm.Visible = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Clock.Properties.Resources.img_ring_duration3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.MyAlarm_Click);
            // 
            // MyAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_on_off);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_time);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MyAlarm";
            this.Size = new System.Drawing.Size(661, 243);
            this.Load += new System.EventHandler(this.MyAlarm_Load);
            this.Click += new System.EventHandler(this.MyAlarm_Click);
            this.Enter += new System.EventHandler(this.MyAlarm_Enter);
            this.Leave += new System.EventHandler(this.MyAlarm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_on_off;
        private System.Windows.Forms.Timer timer_updateAlarm;
        private System.Windows.Forms.NotifyIcon notify_alarm;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
