using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MyAlarm : UserControl
    {
        public MyAlarm()
        {
            InitializeComponent();
        }

        private void MyAlarm_Load(object sender, EventArgs e)
        {

            alarmInfo = new clsAlarm();

            initializeAlarm();

            apply_alarm_info();

            timer_updateAlarm.Start();

        }

        private void initializeAlarm()
        {
            alarmInfo.setAlarm(17, 30);
            alarmInfo.name = "Alarm test";
        }



        public clsAlarm alarmInfo;



        private void MyAlarm_Click(object sender, EventArgs e)
        {
            frm_AlarmSettings window = new frm_AlarmSettings();
            window.alarmInfo = this.alarmInfo;
            window.ShowDialog();
            this.alarmInfo = window.alarmInfo;
            window.Dispose();

            apply_alarm_info();
        }

        private void apply_alarm_info()
        {

            lbl_name.Text = this.alarmInfo.name;
            lbl_time.Text = this.alarmInfo.alarm_date_time.ToString("HH:mm");


            string duration = "";

            if (this.alarmInfo.duration_date_time.Days != 0)
            {
                duration += (this.alarmInfo.duration_date_time.Days.ToString() + " days, ");
            }

            if (this.alarmInfo.duration_date_time.Hours != 0)
            {
                duration += this.alarmInfo.duration_date_time.Hours.ToString() + " hours, ";
            }

            if (this.alarmInfo.duration_date_time.Minutes != 0)
            {
                duration += this.alarmInfo.duration_date_time.Minutes.ToString() + " minutes.";
            }

            if(duration == "")
            {
                duration = "Now";
                isDone = true;
            }
            else
            {
                duration = "in " + duration;
            }

            

            lbl_duration .Text = duration;
        }


        bool isDone = false;

        private void timer_updateAlarm_Tick(object sender, EventArgs e)
        {
            alarmInfo.update();
            apply_alarm_info();

            if (isDone && lbl_duration.Text == "Now")
            {
                timer_updateAlarm.Stop();
                notify_alarm.Icon = SystemIcons.Application;
                notify_alarm.BalloonTipIcon = ToolTipIcon.Info;
                notify_alarm.Text = "";
                notify_alarm.BalloonTipText = lbl_time.Text;
                notify_alarm.BalloonTipTitle = "Alarm [" + alarmInfo.name + "] is Done";
                notify_alarm.ShowBalloonTip(5000);
                isDone = false;

                this.alarmInfo.alarm_date_time += new TimeSpan(1, 0, 0, 0);
            }
        }

        private void MyAlarm_Leave(object sender, EventArgs e)
        {
            alarmInfo.update();
            apply_alarm_info();
            timer_updateAlarm.Stop();


        }

        private void MyAlarm_Enter(object sender, EventArgs e)
        {
            alarmInfo.update();
            apply_alarm_info();
            timer_updateAlarm.Start();
        
        }
    }
}
