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
    public partial class frm_TimerSettings : Form
    {
        public frm_TimerSettings()
        {
            InitializeComponent();
        }

        public class clsTimerInfo
        {

            public string name;
            public int sec, min, hour;

            public void set_time(int time_sec)
            {
                sec  = (time_sec % 60);
                min  = (time_sec / 60)%60;
                hour = (time_sec / 3600);
            }

            public void set_name(string name)
            {
                this.name = name;
            }

            public int get_time()
            {
                return this.sec + this.min * 60  + this.hour * 3600;
            }

           
            public string get_name()
            {
                return this.name;
            }
        }

        public clsTimerInfo timer;

        

        private void lbl_Hours_MouseEnter(object sender, EventArgs e)
        {
            Label Label = sender as Label;

            Label.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void lbl_Hours_MouseLeave(object sender, EventArgs e)
        {
            Label Label = sender as Label;

            Label.BackColor = Color.FromArgb(32, 32, 32);
        }

        private string to2num(int num)
        {
            string s = num.ToString();

            if(s.Length == 1)
            {
                s = "0" + s;
            }

            return s;
        }

        private void frm_TimerSettings_Load(object sender, EventArgs e)
        {
            textBox1.Text = timer.name;
            lbl_Hours.Text = to2num(timer.hour);
            lbl_Mins.Text  = to2num(timer.min);
            lbl_Secs.Text  = to2num(timer.sec);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_up_hour_Click(object sender, EventArgs e)
        {
            
            lbl_Hours.Text = to2num(Convert.ToInt32(lbl_Hours.Text)  +  1);

            if (lbl_Hours.Text == 99.ToString())
            {
                lbl_Hours.Text = "00";
            }
        }

        private void btn_down_hour_Click(object sender, EventArgs e)
        {
            lbl_Hours.Text = to2num(Convert.ToInt32(lbl_Hours.Text) - 1);

            if (Convert.ToInt16(lbl_Hours.Text) < 0)
            {
                lbl_Hours.Text = "99";
            }
        }

        private void btn_up_min_Click(object sender, EventArgs e)
        {
            lbl_Mins.Text = to2num(Convert.ToInt32(lbl_Mins.Text) + 1);

            if(lbl_Mins.Text == 60.ToString())
            {
                lbl_Mins.Text = "00";
            }
        }

        private void btn_down_sec_Click(object sender, EventArgs e)
        {
            lbl_Secs.Text = to2num(Convert.ToInt32(lbl_Secs.Text) - 1);

            if (Convert.ToInt16(lbl_Secs.Text) < 0)
            {
                lbl_Secs.Text = "59";
            }
        }

        private void btn_up_sec_Click(object sender, EventArgs e)
        {
            lbl_Secs.Text = to2num(Convert.ToInt32(lbl_Secs.Text) + 1);

            if (lbl_Secs.Text == 60.ToString())
            {
                lbl_Secs.Text = "00";
            }
        }

        private void btn_down_min_Click(object sender, EventArgs e)
        {
            lbl_Mins.Text = to2num(Convert.ToInt32(lbl_Mins.Text) -1);

            if (Convert.ToInt16(lbl_Mins.Text) < 0)
            {
                lbl_Mins.Text = "59";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            timer.name = textBox1.Text;
            timer.sec  = Convert.ToInt16( lbl_Secs.Text);
            timer.min  = Convert.ToInt16( lbl_Mins.Text);
            timer.hour = Convert.ToInt16(lbl_Hours.Text);

            this.Close();
        }
    }
}
