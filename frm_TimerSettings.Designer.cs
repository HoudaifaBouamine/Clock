namespace Clock
{
    partial class frm_TimerSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Hours = new System.Windows.Forms.Label();
            this.lbl_Secs = new System.Windows.Forms.Label();
            this.lbl_Mins = new System.Windows.Forms.Label();
            this.lbl_doublePoints = new System.Windows.Forms.Label();
            this.btn_up_hour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_up_min = new System.Windows.Forms.Button();
            this.btn_up_sec = new System.Windows.Forms.Button();
            this.btn_down_sec = new System.Windows.Forms.Button();
            this.btn_down_min = new System.Windows.Forms.Button();
            this.btn_down_hour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Timer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button1.BackgroundImage = global::Clock.Properties.Resources.img_Delete;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(368, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lbl_Hours);
            this.panel1.Controls.Add(this.lbl_Secs);
            this.panel1.Controls.Add(this.lbl_Mins);
            this.panel1.Controls.Add(this.lbl_doublePoints);
            this.panel1.Location = new System.Drawing.Point(30, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 99);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Hours
            // 
            this.lbl_Hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_Hours.Font = new System.Drawing.Font("Segoe UI Semibold", 33F, System.Drawing.FontStyle.Bold);
            this.lbl_Hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Hours.Location = new System.Drawing.Point(10, 9);
            this.lbl_Hours.Name = "lbl_Hours";
            this.lbl_Hours.Size = new System.Drawing.Size(99, 80);
            this.lbl_Hours.TabIndex = 0;
            this.lbl_Hours.Text = "00";
            this.lbl_Hours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Hours.MouseEnter += new System.EventHandler(this.lbl_Hours_MouseEnter);
            this.lbl_Hours.MouseLeave += new System.EventHandler(this.lbl_Hours_MouseLeave);
            // 
            // lbl_Secs
            // 
            this.lbl_Secs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_Secs.Font = new System.Drawing.Font("Segoe UI Semibold", 33F, System.Drawing.FontStyle.Bold);
            this.lbl_Secs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Secs.Location = new System.Drawing.Point(257, 9);
            this.lbl_Secs.Name = "lbl_Secs";
            this.lbl_Secs.Size = new System.Drawing.Size(104, 80);
            this.lbl_Secs.TabIndex = 2;
            this.lbl_Secs.Text = "00";
            this.lbl_Secs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Secs.MouseEnter += new System.EventHandler(this.lbl_Hours_MouseEnter);
            this.lbl_Secs.MouseLeave += new System.EventHandler(this.lbl_Hours_MouseLeave);
            // 
            // lbl_Mins
            // 
            this.lbl_Mins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_Mins.Font = new System.Drawing.Font("Segoe UI Semibold", 33F, System.Drawing.FontStyle.Bold);
            this.lbl_Mins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Mins.Location = new System.Drawing.Point(135, 9);
            this.lbl_Mins.Name = "lbl_Mins";
            this.lbl_Mins.Size = new System.Drawing.Size(99, 80);
            this.lbl_Mins.TabIndex = 1;
            this.lbl_Mins.Text = "00";
            this.lbl_Mins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Mins.MouseEnter += new System.EventHandler(this.lbl_Hours_MouseEnter);
            this.lbl_Mins.MouseLeave += new System.EventHandler(this.lbl_Hours_MouseLeave);
            // 
            // lbl_doublePoints
            // 
            this.lbl_doublePoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_doublePoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_doublePoints.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Bold);
            this.lbl_doublePoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_doublePoints.Location = new System.Drawing.Point(0, 0);
            this.lbl_doublePoints.Name = "lbl_doublePoints";
            this.lbl_doublePoints.Size = new System.Drawing.Size(361, 89);
            this.lbl_doublePoints.TabIndex = 3;
            this.lbl_doublePoints.Text = "      :       :";
            this.lbl_doublePoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_up_hour
            // 
            this.btn_up_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_up_hour.FlatAppearance.BorderSize = 0;
            this.btn_up_hour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_up_hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up_hour.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_up_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_up_hour.Location = new System.Drawing.Point(51, 82);
            this.btn_up_hour.Name = "btn_up_hour";
            this.btn_up_hour.Size = new System.Drawing.Size(71, 55);
            this.btn_up_hour.TabIndex = 3;
            this.btn_up_hour.Text = "︿";
            this.btn_up_hour.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_up_hour.UseVisualStyleBackColor = false;
            this.btn_up_hour.Click += new System.EventHandler(this.btn_up_hour_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 22);
            this.label2.TabIndex = 4;
            // 
            // btn_up_min
            // 
            this.btn_up_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_up_min.FlatAppearance.BorderSize = 0;
            this.btn_up_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_up_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up_min.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_up_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_up_min.Location = new System.Drawing.Point(174, 82);
            this.btn_up_min.Name = "btn_up_min";
            this.btn_up_min.Size = new System.Drawing.Size(71, 55);
            this.btn_up_min.TabIndex = 5;
            this.btn_up_min.Text = "︿";
            this.btn_up_min.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_up_min.UseVisualStyleBackColor = false;
            this.btn_up_min.Click += new System.EventHandler(this.btn_up_min_Click);
            // 
            // btn_up_sec
            // 
            this.btn_up_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_up_sec.FlatAppearance.BorderSize = 0;
            this.btn_up_sec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_up_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up_sec.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_up_sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_up_sec.Location = new System.Drawing.Point(297, 82);
            this.btn_up_sec.Name = "btn_up_sec";
            this.btn_up_sec.Size = new System.Drawing.Size(71, 55);
            this.btn_up_sec.TabIndex = 6;
            this.btn_up_sec.Text = "︿";
            this.btn_up_sec.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_up_sec.UseVisualStyleBackColor = false;
            this.btn_up_sec.Click += new System.EventHandler(this.btn_up_sec_Click);
            // 
            // btn_down_sec
            // 
            this.btn_down_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_down_sec.FlatAppearance.BorderSize = 0;
            this.btn_down_sec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_down_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down_sec.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_down_sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_down_sec.Location = new System.Drawing.Point(297, 230);
            this.btn_down_sec.Name = "btn_down_sec";
            this.btn_down_sec.Size = new System.Drawing.Size(71, 55);
            this.btn_down_sec.TabIndex = 10;
            this.btn_down_sec.Text = "﹀";
            this.btn_down_sec.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_down_sec.UseVisualStyleBackColor = false;
            this.btn_down_sec.Click += new System.EventHandler(this.btn_down_sec_Click);
            // 
            // btn_down_min
            // 
            this.btn_down_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_down_min.FlatAppearance.BorderSize = 0;
            this.btn_down_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_down_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down_min.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_down_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_down_min.Location = new System.Drawing.Point(174, 230);
            this.btn_down_min.Name = "btn_down_min";
            this.btn_down_min.Size = new System.Drawing.Size(71, 55);
            this.btn_down_min.TabIndex = 9;
            this.btn_down_min.Text = "﹀";
            this.btn_down_min.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_down_min.UseVisualStyleBackColor = false;
            this.btn_down_min.Click += new System.EventHandler(this.btn_down_min_Click);
            // 
            // btn_down_hour
            // 
            this.btn_down_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_down_hour.FlatAppearance.BorderSize = 0;
            this.btn_down_hour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_down_hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down_hour.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.btn_down_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_down_hour.Location = new System.Drawing.Point(51, 230);
            this.btn_down_hour.Name = "btn_down_hour";
            this.btn_down_hour.Size = new System.Drawing.Size(71, 55);
            this.btn_down_hour.TabIndex = 7;
            this.btn_down_hour.Text = "﹀";
            this.btn_down_hour.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_down_hour.UseVisualStyleBackColor = false;
            this.btn_down_hour.Click += new System.EventHandler(this.btn_down_hour_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 31);
            this.label3.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.textBox1.Location = new System.Drawing.Point(30, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 34);
            this.textBox1.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(30, 406);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(176, 45);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(212, 406);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(176, 45);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_TimerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(425, 483);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_up_sec);
            this.Controls.Add(this.btn_up_min);
            this.Controls.Add(this.btn_up_hour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_down_sec);
            this.Controls.Add(this.btn_down_min);
            this.Controls.Add(this.btn_down_hour);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_TimerSettings";
            this.Text = "frm_TimerSettings";
            this.Load += new System.EventHandler(this.frm_TimerSettings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Hours;
        private System.Windows.Forms.Label lbl_Secs;
        private System.Windows.Forms.Label lbl_Mins;
        private System.Windows.Forms.Label lbl_doublePoints;
        private System.Windows.Forms.Button btn_up_hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_up_min;
        private System.Windows.Forms.Button btn_up_sec;
        private System.Windows.Forms.Button btn_down_sec;
        private System.Windows.Forms.Button btn_down_min;
        private System.Windows.Forms.Button btn_down_hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}