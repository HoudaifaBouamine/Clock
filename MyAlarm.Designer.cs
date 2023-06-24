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
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_ON_OFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI Semibold", 48.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Time.Location = new System.Drawing.Point(3, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(198, 108);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "7:00";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lbl_Duration.Location = new System.Drawing.Point(40, 108);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(255, 25);
            this.lbl_Duration.TabIndex = 1;
            this.lbl_Duration.Text = "in 3 days, 15 hours, 6 minutes";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lbl_Name.Location = new System.Drawing.Point(15, 145);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(136, 40);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Alarm (1)";
            // 
            // btn_ON_OFF
            // 
            this.btn_ON_OFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_ON_OFF.FlatAppearance.BorderSize = 0;
            this.btn_ON_OFF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btn_ON_OFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ON_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ON_OFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_ON_OFF.Location = new System.Drawing.Point(529, 16);
            this.btn_ON_OFF.Name = "btn_ON_OFF";
            this.btn_ON_OFF.Size = new System.Drawing.Size(66, 29);
            this.btn_ON_OFF.TabIndex = 3;
            this.btn_ON_OFF.Text = "ON";
            this.btn_ON_OFF.UseVisualStyleBackColor = false;
            // 
            // MyAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btn_ON_OFF);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_Time);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MyAlarm";
            this.Size = new System.Drawing.Size(623, 252);
            this.Load += new System.EventHandler(this.MyAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_ON_OFF;
    }
}
