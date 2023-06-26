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
    public partial class frm_AlarmSettings : Form
    {
        public frm_AlarmSettings()
        {
            InitializeComponent();
        }

        private void lbl_Mins_Click(object sender, EventArgs e)
        {



        }

        private void frm_AlarmSettings_Load(object sender, EventArgs e)
        {

            main_form.make_button_circle(btn_week_friday);
            main_form.make_button_circle(btn_week_Monday);
            main_form.make_button_circle(btn_week_saturday);
            main_form.make_button_circle(btn_week_sunday);
            main_form.make_button_circle(btn_week_thersday);
            main_form.make_button_circle(btn_week_tusday);
            main_form.make_button_circle(btn_week_wednesday);

            lbl_Hours.Text = alarmInfo.alarm_date_time.Hour  .ToString();
            lbl_Mins.Text  = alarmInfo.alarm_date_time.Minute.ToString();
            tb_AlarmName.Text = alarmInfo.name;
        }

        public clsAlarm alarmInfo;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_down_hour_Click(object sender, EventArgs e)
        {
            lbl_Hours.Text  = ((Convert.ToInt16(lbl_Hours.Text) + 60 - 1) % 60).ToString("00");
        }

        private void btn_up_hour_Click(object sender, EventArgs e)
        {
            lbl_Hours.Text = ((Convert.ToInt16(lbl_Hours.Text)  + 1) % 60).ToString("00");

        }

        private void btn_up_min_Click(object sender, EventArgs e)
        {
            lbl_Mins.Text = ((Convert.ToInt16(lbl_Mins.Text) + 1) % 60).ToString("00");

        }

        private void btn_down_min_Click(object sender, EventArgs e)
        {
            lbl_Mins.Text = ((Convert.ToInt16(lbl_Mins.Text) + 60 - 1) % 60).ToString("00");

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            alarmInfo.setAlarm(Convert.ToInt16(lbl_Hours.Text), Convert.ToInt16(lbl_Mins.Text));
            alarmInfo.name = tb_AlarmName.Text;


            this.Close();
            this.Dispose();
        }
    }
}
