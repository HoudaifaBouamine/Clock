using Clock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();


        }


        clsFlags flags;
        long start_tick;
        long pause_tick;
        long last_recored_tick;
        private void main_form_Load(object sender, EventArgs e)
        {
            make_button_circle(btn_StartStopwatch);
            make_button_circle(btn_FlagStopwatch);
            make_button_circle(btn_ResetStopwatch);
            flags.started = false;
            flags.no_records = true;
            lv_recordes.Visible = false;
            btn_FlagStopwatch.Enabled = false;
            btn_ResetStopwatch.Enabled = false;
        }

        private void make_button_circle(Button button)
        {
            GraphicsPath ButtonPath = new GraphicsPath();
            int def = 3;
            ButtonPath.AddEllipse(1,1, button.Width - def, button.Height -def);
            button.Region = new Region(ButtonPath);
        }

       
        struct clsFlags
        {
            public bool started;
            public bool running;
            public bool pause ;
            public bool no_records;
        }

        private void btn_StartStopwatch_Click(object sender, EventArgs e)
        {
            if (btn_StartStopwatch.Tag.ToString() == "0") {

                flags.running  = true;
                flags.pause = false ;
                btn_FlagStopwatch.Enabled = true;
                btn_ResetStopwatch.Enabled = true;


                btn_StartStopwatch.BackgroundImage = Resources.stopwatch_pause;

                if (!flags.started)
                {
                    start_tick = DateTime.Now.Ticks;
                    flags.started = true;
                }
                else 
                {
                    start_tick +=  (DateTime.Now.Ticks - pause_tick);
                }
                timer_fram.Start();
                btn_StartStopwatch.Tag = "1";
                last_recored_tick = start_tick;
            }
            else
            {
                flags.running = false;
                flags.pause = true;
                btn_FlagStopwatch.Enabled = false;


                btn_StartStopwatch.BackgroundImage = Resources.stopwatch_start;
                pause_tick = DateTime.Now.Ticks;
                timer_fram.Stop();

                btn_StartStopwatch.Tag = "0";
            }

           
        }
        private void timer_fram_Tick(object sender, EventArgs e)
        {


            long time = (DateTime.Now.Ticks - start_tick)/100000;

            lbl_csecond.Text = (time%100).ToString();

            time /= 100;
            string hours = (time / 3600).ToString();
            if(hours.Length == 1) hours = "0" + hours;
            string minutes = (time / 60).ToString();
            if (minutes.Length == 1) minutes = "0" + minutes;
            string seconds = (time % 60).ToString();
            if (seconds.Length == 1) seconds = "0" + seconds;

            lbl_Stopwatch_time.Text = hours + ":" + minutes + ":" + seconds + ".";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ResetStopwatch_Click(object sender, EventArgs e)
        {
            flags.started = false;
            btn_StartStopwatch.BackgroundImage = Resources.stopwatch_start;
            btn_StartStopwatch.Tag = "0";
            timer_fram.Stop();
            lbl_csecond.Text = "00";
            lbl_Stopwatch_time.Text = "00:00:00.";
            btn_ResetStopwatch.Enabled = false;

            lv_recordes.Items.Clear();
            lv_recordes.Visible = false;
            flags.no_records = true;
            btn_FlagStopwatch.Enabled = false;

        }

        private string get_time(long time)
        {

            string csec = (time % 100).ToString();

            time /= 100;
            string hours = (time / 3600).ToString();
            if (hours.Length == 1) hours = "0" + hours;
            string minutes = (time / 60).ToString();
            if (minutes.Length == 1) minutes = "0" + minutes;
            string seconds = (time % 60).ToString();
            if (seconds.Length == 1) seconds = "0" + seconds;


            return hours + ":" + minutes + ":" + seconds + "." + csec;
        }

        int counter = 0;
        private void btn_FlagStopwatch_Click(object sender, EventArgs e)
        {


            if (flags.no_records)
            {
                lv_recordes.Visible = true;
                lv_recordes.Columns[0].Width = (int) ((float)tbc_main.Width * 0.25f);
                lv_recordes.Columns[1].Width = (int)((float)tbc_main.Width * 0.32f);
                lv_recordes.Columns[2].Width = (int)((float)tbc_main.Width * 0.32f);
            }



            long current_time = DateTime.Now.Ticks;

            ListViewItem item = new ListViewItem();
            item.Text = counter++.ToString();
            
            item.SubItems.Add(get_time((current_time  - last_recored_tick) / 100000));
            item.SubItems.Add(get_time((current_time - start_tick) / 100000));
            item.SubItems.Add((current_time - last_recored_tick).ToString());

            lv_recordes.Items.Insert(0, item);
                        
            long max_time = 0, min_time = long.MaxValue;
            int max_index = -1,min_index = -1;

            for(int i = 0;i < lv_recordes.Items.Count && lv_recordes.Items.Count > 1; i++)
            {

                if (Convert.ToInt64(lv_recordes.Items[i].SubItems[3].Text) > max_time)
                {
                    max_time = Convert.ToInt64(lv_recordes.Items[i].SubItems[3].Text);
                    max_index = i;
                }

                if (Convert.ToInt64(lv_recordes.Items[i].SubItems[3].Text) < min_time)
                {
                    min_time = Convert.ToInt64(lv_recordes.Items[i].SubItems[3].Text);
                    min_index = i;
                }

            }

            for (int i = 0; i < lv_recordes.Items.Count; i++)
            {
                if(i == max_index)
                {
                    lv_recordes.Items[i].Text = "Slowest";

                }
                else if (i == min_index)
                {
                    lv_recordes.Items[i].Text = "Fastest";

                }
                else
                {
                    lv_recordes.Items[i].Text = "";

                }
            }

            last_recored_tick = current_time;

            

            

        }
        
    }
}
