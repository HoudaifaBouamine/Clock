using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Models
{
    internal class clsAlarm
    {
        public DateTime Time
        {

            get
            {
                _Time = new DateTime( DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,_Time.Hour,_Time.Minute,_Time.Second);
            
                return _Time;
            }
            set
            {
                _Time = value;  
            }
        
        }
        
        /// <summary>
        /// Represent the days when the alarm is active,you can set one or
        /// more values to it from <c>enDays</c> enum using <c>| (bitwise xor)</c> 
        /// operation between the selected values
        /// </summary>
        public int Days { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public TimeSpan SpanToNextAlarm { get { return Time - DateTime.Now; } }
        
        
        
        public bool isDaySelected(enDays day)
        {
            if (day == enDays.None && Days == 0) return true;

            return (Days & (int)day) != 0;
        }


        private DateTime _Time = DateTime.Now;
        
        public enum enDays
        {
            None = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }
    }
}
