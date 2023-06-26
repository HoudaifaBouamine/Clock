using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class clsAlarm
    {
        public string name;
        public string sound_name;

        public DateTime alarm_date_time;
        public TimeSpan duration_date_time;

        public byte days_flags;

        public bool on;


        public void setAlarm(int hour,int min)
        {
            this.alarm_date_time = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,hour,min,0);
            this.duration_date_time = this.alarm_date_time - DateTime.Now;
            this.update();

        }

        public void update()
        {
            this.duration_date_time = this.alarm_date_time - DateTime.Now + new TimeSpan(0,1,0);

            if(this.duration_date_time.TotalSeconds < 0)
            {
                this.duration_date_time += new TimeSpan(1, 0, 0, 0);
            }

        }

        public clsAlarm()
        {
            this.name = "Alarm";
            this.on = true;
            this.sound_name = "Ring";
            this.alarm_date_time = new DateTime();
            this.duration_date_time = new TimeSpan();
            this.days_flags = 0;

        }
        public clsAlarm(int hour, int min)
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
}
