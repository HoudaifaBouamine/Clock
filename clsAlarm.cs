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

        }

        class clsAlarmClass
        {
            public string name;
            public string sound_name;

            public DateTime alarm_date_time;
            public TimeSpan duration_date_time;

            public byte days_flags;

            public bool on;

            clsAlarmClass()
            {
                this.name = "Alarm";
                this.on = true;
                this.sound_name = "Ring";
                this.alarm_date_time = new DateTime();
                this.duration_date_time = new TimeSpan();
                this.days_flags = 0;

            }
            clsAlarmClass(int hour, int min)
            {
                this.name = "Alarm";
                this.on = true;
                this.sound_name = "Ring";
                this.alarm_date_time = new DateTime();

                this.alarm_date_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, min, 0);

                this.duration_date_time = this.alarm_date_time - DateTime.Now;
                this.days_flags = 0;


            }

        }

        clsAlarmClass alarmInfo;

    }
}
