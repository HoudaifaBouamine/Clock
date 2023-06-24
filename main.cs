using CircularProgressBar;
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
using System.Xml;

namespace Clock
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();



        }

        clsRatio stopwatch_size_ratio;
        clsPositionRatio r;
        clsFlags stopwatchflags;
        long start_tick;
        long pause_tick;
        long last_recored_tick;
        private void main_form_Load(object sender, EventArgs e)
        {
            make_button_circle(btn_StartStopwatch);
            make_button_circle(btn_FlagStopwatch);
            make_button_circle(btn_ResetStopwatch);

            stopwatch_size_ratio = new clsRatio();
            stopwatchflags = new clsFlags();
            r = new clsPositionRatio();
            lv_recordes.Visible = false;
            btn_FlagStopwatch.Enabled = false;
            btn_ResetStopwatch.Enabled = false;
//            tbc_main.Location = new Point(tbc_main.Location.X, tbc_main.Location.Y - 30);


            save_ratio_of_size_stopwatch();
            save_ratio_of_position_stopwatch();

            resize_controls_stopwatch();

            load_timer();

            circularProgressBar.Value = 0;


        }



        public void save_ratio_of_size_stopwatch()
        {
            stopwatch_size_ratio.control.Width = (float)tbc_main.Width / (float)this.Width;
            stopwatch_size_ratio.control_original.Width = (float)tbc_main.Width / (float)this.Width;


            stopwatch_size_ratio.control.Height = stopwatch_size_ratio.control.Width;//stopwatch_ratio.control.Width (float)tp_Stopwatch.Height            / (float)this.Height          ;
            stopwatch_size_ratio.timer.Width = (float)lbl_Stopwatch_time.Font.Size / (float)tp_Stopwatch.Width;
            stopwatch_size_ratio.timer.Height = stopwatch_size_ratio.timer.Width;//(float)lbl_Stopwatch_time.Font.Size   / (float)tp_Stopwatch.Height  ;
            stopwatch_size_ratio.csec_timer.Width = (float)lbl_csecond.Font.Size / (float)tp_Stopwatch.Width;
            stopwatch_size_ratio.csec_timer.Height = stopwatch_size_ratio.csec_timer.Width;//(float)lbl_csecond.Font.Size          / (float)tp_Stopwatch.Height  ;
            stopwatch_size_ratio.circular_buttons.Width = (float)btn_StartStopwatch.Width / (float)tp_Stopwatch.Width;
            stopwatch_size_ratio.circular_buttons.Height = stopwatch_size_ratio.circular_buttons.Width;//(float)btn_StartStopwatch.Height      / (float)tp_Stopwatch.Height  ;
            stopwatch_size_ratio.screen_mode.Width = (float)btn_Smallwindow.Width / (float)tp_Stopwatch.Width;



            stopwatch_size_ratio.titles = (float)lbl_stopwatch_hours_title.Font.Size / (float)tp_Stopwatch.Width;

            stopwatch_size_ratio.listview = (float)lv_recordes.Width / (float)tp_Stopwatch.Width;


        }
        public void apply_ratio_to_size_stopwatch()
        {



            tbc_main.Width = (int)((float)this.Width * stopwatch_size_ratio.control.Width);
           // tp_Stopwatch.Height = (int)(this.Height * stopwatch_size_ratio.control.Width);


            lbl_Stopwatch_time.Font = new Font(lbl_Stopwatch_time.Font.FontFamily, (stopwatch_size_ratio.timer.Width * tp_Stopwatch.Width), lbl_Stopwatch_time.Font.Style);
            lbl_csecond.Font = new Font(lbl_csecond.Font.FontFamily, (stopwatch_size_ratio.csec_timer.Width * tp_Stopwatch.Width), lbl_csecond.Font.Style);
            lbl_stopwatch_hours_title.Font = new Font(lbl_stopwatch_hours_title.Font.FontFamily, (stopwatch_size_ratio.titles * tp_Stopwatch.Width), lbl_stopwatch_hours_title.Font.Style);
            lbl_stopwatch_mins_title.Font = new Font(lbl_stopwatch_mins_title.Font.FontFamily, (stopwatch_size_ratio.titles * tp_Stopwatch.Width), lbl_stopwatch_mins_title.Font.Style);
            lbl_stopwatch_secs_title.Font = new Font(lbl_stopwatch_secs_title.Font.FontFamily, (stopwatch_size_ratio.titles * tp_Stopwatch.Width), lbl_stopwatch_secs_title.Font.Style);


            btn_StartStopwatch.Width = (int)(stopwatch_size_ratio.circular_buttons.Width * tp_Stopwatch.Width);
            btn_StartStopwatch.Height = (int)(stopwatch_size_ratio.circular_buttons.Height * tp_Stopwatch.Width);
            btn_FlagStopwatch.Width = (int)(stopwatch_size_ratio.circular_buttons.Width * tp_Stopwatch.Width);
            btn_FlagStopwatch.Height = (int)(stopwatch_size_ratio.circular_buttons.Height * tp_Stopwatch.Width);
            btn_ResetStopwatch.Width = (int)(stopwatch_size_ratio.circular_buttons.Width * tp_Stopwatch.Width);
            btn_ResetStopwatch.Height = (int)(stopwatch_size_ratio.circular_buttons.Height * tp_Stopwatch.Width);

            btn_Smallwindow.Width = (int)(stopwatch_size_ratio.screen_mode.Width * tp_Stopwatch.Width);
            btn_Smallwindow.Height = (int)(stopwatch_size_ratio.screen_mode.Width * tp_Stopwatch.Width);

            btn_Fullscreen.Width = (int)(stopwatch_size_ratio.screen_mode.Width * tp_Stopwatch.Width);
            btn_Fullscreen.Height = (int)(stopwatch_size_ratio.screen_mode.Width * tp_Stopwatch.Width);


            lv_recordes.Width = (int)(stopwatch_size_ratio.listview * tp_Stopwatch.Width);
            //lv_recordes.Height = tp_Stopwatch.Height - lv_recordes.Location.X - 100;
            lv_recordes.Columns[0].Width = (int)((float)tbc_main.Width * 0.25f);
            lv_recordes.Columns[1].Width = (int)((float)tbc_main.Width * 0.32f);
            lv_recordes.Columns[2].Width = (int)((float)tbc_main.Width * 0.32f);
        }
        static public void make_button_circle(Button button)
        {
            GraphicsPath ButtonPath = new GraphicsPath();
            int def = 3;
            ButtonPath.AddEllipse(1, 1, button.Width - def, button.Height - def);
            button.Region = new Region(ButtonPath);
        }


        private void save_ratio_of_position_stopwatch()
        {


            r.tab_control_x =((float)tp_Stopwatch.Location.X / (float)this.Width);

            float origin = tp_Stopwatch.Size.Width;

            r.timer_x              = (float)lbl_Stopwatch_time.Location.X        / origin;
            r.csec_timer_x         = (float)lbl_csecond.Location.X               / origin;
            r.circular_button_x[0] = (float)btn_StartStopwatch.Location.X        / origin;
            r.circular_button_x[1] = (float)btn_FlagStopwatch.Location.X         / origin;
            r.circular_button_x[2] = (float)btn_ResetStopwatch.Location.X        / origin;
            r.screen_mode_x[0]     = (float)btn_Smallwindow.Location.X           / origin;
            r.screen_mode_x[1]     = (float)btn_Fullscreen.Location.X            / origin;
            r.titles_x[0]          = (float)lbl_stopwatch_hours_title.Location.X / origin;
            r.titles_x[1]          = (float)lbl_stopwatch_mins_title.Location.X  / origin;
            r.titles_x[2]          = (float)lbl_stopwatch_secs_title.Location.X  / origin;


            r.timer_y              = (float)lbl_Stopwatch_time.Location.Y        / origin;
            r.csec_timer_y         = (float)lbl_csecond.Location.Y               / origin;
            r.circular_button_y[0] = (float)btn_StartStopwatch.Location.Y        / origin;
            r.circular_button_y[1] = (float)btn_FlagStopwatch.Location.Y         / origin;
            r.circular_button_y[2] = (float)btn_ResetStopwatch.Location.Y        / origin;
            r.screen_mode_y[0]     = (float)btn_Smallwindow.Location.Y           / origin;
            r.screen_mode_y[1]     = (float)btn_Fullscreen.Location.Y            / origin;
            r.titles_y[0]          = (float)lbl_stopwatch_hours_title.Location.Y / origin;
            r.titles_y[1]          = (float)lbl_stopwatch_mins_title.Location.Y  / origin;
            r.titles_y[2]          = (float)lbl_stopwatch_secs_title.Location.Y  / origin;

            r.listview             = (float)lv_recordes.Location.Y / origin;

        }
        private void apply_ratio_to_position_stopwatch()
        {
            float origin = tp_Stopwatch.Size.Width;
            float origin2 = tp_Stopwatch.Size.Width;

            lbl_Stopwatch_time.Location = new Point((int)(r.timer_x*origin),(int)(r.timer_y* origin2));
            lbl_csecond.Location = new Point((int)(r.csec_timer_x * origin), (int)(r.csec_timer_y * origin2));
            lbl_stopwatch_hours_title.Location = new Point((int)(r.titles_x[0] * origin), (int)(r.titles_y[0] * origin2));
            lbl_stopwatch_mins_title.Location  = new Point((int)(r.titles_x[1] * origin), (int)(r.titles_y[1] * origin2));
            lbl_stopwatch_secs_title.Location  = new Point((int)(r.titles_x[2] * origin), (int)(r.titles_y[2] * origin2));

            btn_Smallwindow.Location = new Point((int)(r.screen_mode_x[0] * origin), (int)(r.screen_mode_y[0] * origin2));
            btn_Fullscreen.Location  = new Point((int)(r.screen_mode_x[1] * origin), (int)(r.screen_mode_y[1] * origin2));

            btn_StartStopwatch.Location = new Point((int)(r.circular_button_x[0] * origin), (int)(r.circular_button_y[0] * origin2));
            btn_FlagStopwatch .Location = new Point((int)(r.circular_button_x[1] * origin), (int)(r.circular_button_y[1] * origin2));
            btn_ResetStopwatch.Location = new Point((int)(r.circular_button_x[2] * origin), (int)(r.circular_button_y[2] * origin2));

            lv_recordes.Location = new Point((lv_recordes.Location.X), (int)(r.listview * origin2));
        }

        private void resize_controls_stopwatch()
        {

            if (this.Width / this.Height > stopwatch_size_ratio.hightest_ratio_between_screen_width_and_heigth)
            {
                this.Width = (int)((float)this.Height * stopwatch_size_ratio.hightest_ratio_between_screen_width_and_heigth);
            }


            lv_recordes.Size = new Size(lv_recordes.Size.Width, tp_Stopwatch.Height - lv_recordes.Location.Y);
            tbc_main.Size = new Size(tbc_main.Size.Width, this.Height - 25);
            tbc_main.Location = new Point(this.Width - tbc_main.Size.Width - 20, tbc_main.Location.Y);

            bool somthing_change = false;

            if (this.Width < 600 || stopwatchflags.fill_screen)
            {
                //stopwatch_size_ratio.control.Width = 0.99f;

                if (tbc_main.Dock == DockStyle.None)
                {
                    tbc_main.Dock = DockStyle.Bottom;

                    somthing_change = true;
                    //tbc_main.Size = new Size(tbc_main.Size.Width, this.Height - 10);

                }
            }
            else //if (tbc_main.Dock == DockStyle.Bottom)
            {
                stopwatch_size_ratio.control.Width = stopwatch_size_ratio.control_original.Width;
                tbc_main.Dock = DockStyle.None;
                //tbc_main.Location = new Point(tbc_main.Location.X, tbc_main.Location.Y - 25);
                tbc_main.Size = new Size(tbc_main.Size.Width, this.Height-25);

                if(tbc_main.Dock == DockStyle.Bottom)
                    somthing_change = true;

            }


             tbc_main.Size = new Size(tbc_main.Size.Width, this.Height - 25);

            

            apply_ratio_to_position_stopwatch();
            apply_ratio_to_size_stopwatch();
            make_button_circle(btn_StartStopwatch);
            make_button_circle(btn_FlagStopwatch);
            make_button_circle(btn_ResetStopwatch);

            tbc_main.Location = new Point(tbc_main.Location.X, -25);


            //



        }
        class clsRatio
        {
            public SizeF control_original;

            public SizeF control;
            public SizeF timer;
            public SizeF csec_timer;
            public SizeF circular_buttons;
            public float titles;
            public SizeF screen_mode;
            public float listview;
            public float listview_y;

            public float hightest_ratio_between_screen_width_and_heigth = 870.0f/ 455.0f;// width/hight
        }
        class clsPositionRatio{

            public float tab_control_x;
            public float timer_x;
            public float csec_timer_x;
            public float[] titles_x;
            public float[] screen_mode_x;
            public float[] circular_button_x;

            public float tab_control_y;
            public float timer_y;
            public float csec_timer_y;
            public float[] titles_y;
            public float[] screen_mode_y;
            public float[] circular_button_y;
            public float listview;


            public clsPositionRatio()
            {

                // 0 hours,1 mins,2 secs
                titles_y = new float[3];
                titles_x = new float[3];

                // 0 small ,1 full
                screen_mode_x = new float[2];
                screen_mode_y = new float[2];

                // 0 start , 1 Flag , 2 Reset
                circular_button_x = new float[3];
                circular_button_y = new float[3];
            }
        }
        

        private void btn_StartStopwatch_Click(object sender, EventArgs e)
        {
            if (btn_StartStopwatch.Tag.ToString() == "0") {

                stopwatchflags.running  = true;
                stopwatchflags.pause = false ;
                btn_FlagStopwatch.Enabled = true;
                btn_ResetStopwatch.Enabled = true;


                btn_StartStopwatch.BackgroundImage = Resources.stopwatch_pause;

                if (!stopwatchflags.started)
                {
                    start_tick = DateTime.Now.Ticks;
                    stopwatchflags.started = true;
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
                stopwatchflags.running = false;
                stopwatchflags.pause = true;
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
            stopwatchflags.started = false;
            btn_StartStopwatch.BackgroundImage = Resources.stopwatch_start;
            btn_StartStopwatch.Tag = "0";
            timer_fram.Stop();
            lbl_csecond.Text = "00";
            lbl_Stopwatch_time.Text = "00:00:00.";
            btn_ResetStopwatch.Enabled = false;

            lv_recordes.Items.Clear();
            lv_recordes.Visible = false;
            stopwatchflags.no_records = true;
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


            if (stopwatchflags.no_records)
            {
                lv_recordes.Visible          = true;
                lv_recordes.Columns[0].Width = (int)((float)tbc_main.Width * 0.25f);
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

        private void btn_Fullscreen_Click(object sender, EventArgs e)
        {


            if (stopwatchflags.mid_screen)
            {

                tp_Stopwatch.BackColor = Color.FromArgb(32, 32, 32);
                btn_Fullscreen.BackgroundImage = Resources.img_CancelFullScreen;

                btn_FlagStopwatch.Visible = false;
                btn_Smallwindow.Visible = false;
                lv_recordes.Visible = false;

                btn_StartStopwatch.Location = new Point(btn_StartStopwatch.Location.X + btn_FlagStopwatch.Width / 2, btn_StartStopwatch.Location.Y);
                btn_ResetStopwatch.Location = new Point(btn_ResetStopwatch.Location.X - btn_FlagStopwatch.Width / 2, btn_ResetStopwatch.Location.Y);
                btn_Fullscreen.Location = new Point(btn_Fullscreen.Location.X + btn_Smallwindow.Size.Width, btn_Fullscreen.Location.Y);



                stopwatchflags.mid_screen = false;
                stopwatchflags.fill_screen = true;
            }
            else if(stopwatchflags.fill_screen)
            {


                tp_Stopwatch.BackColor = Color.FromArgb(39, 39, 39);
                btn_Fullscreen.BackgroundImage = Resources.img_FullScreen1;



                btn_FlagStopwatch.Visible = true;
                btn_Smallwindow.Visible   = true;

                if(lv_recordes.Items.Count > 0)
                    lv_recordes.Visible = true;


                btn_StartStopwatch.Location = new Point(btn_StartStopwatch.Location.X - btn_FlagStopwatch.Width / 2, btn_StartStopwatch.Location.Y);
                btn_ResetStopwatch.Location = new Point(btn_ResetStopwatch.Location.X + btn_FlagStopwatch.Width / 2, btn_ResetStopwatch.Location.Y);
                btn_Fullscreen.Location = new Point(btn_Fullscreen.Location.X - btn_Smallwindow.Size.Width, btn_Fullscreen.Location.Y);



                stopwatchflags.fill_screen = false;
                stopwatchflags.mid_screen = true;
            }
            else
            {
                MessageBox.Show("Error , Imposible behaviour\nentring fill screen mode from smallscreen mode");
            }

            resize_controls_stopwatch();
            resize_controls_stopwatch();

        }


        private void main_form_Resize(object sender, EventArgs e)
        {
            if (tbc_main.SelectedIndex == 2)
            {
                resize_controls_stopwatch();
                resize_controls_stopwatch();
            }




            btn_tab_stopwatch.Width = this.Width - tbc_main.Width;
            btn_tab_timer.Width = this.Width - tbc_main.Width;
            btn_tab_alarm.Width = this.Width - tbc_main.Width;
            btn_tab_clock.Width = this.Width - tbc_main.Width;

        }

        private void lv_recordes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // 

        class clsFlags
        {
            public bool started;
            public bool running;
            public bool pause;
            public bool no_records;
            public bool mid_screen;
            public bool fill_screen;
            public bool small_screen;

            public clsFlags()
            {
                this.started = false;
                this.running = false;
                this.pause = false;
                this.no_records = true;
                this.fill_screen = false;
                this.mid_screen = true;
                this.small_screen = false;
                

            }
        }

        clsFlags timerflags = new clsFlags();

        private  void load_timer()
        {
            lbl_timer.Text = get_time(100*Convert.ToInt64(circularProgressBar.Tag.ToString())).Substring(0, 8);
        }

        private void btn_tab_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            btn_tab_stopwatch.BackColor = Color.FromArgb(32, 32, 32);
            btn_tab_timer.BackColor     = Color.FromArgb(32, 32, 32);
            btn_tab_alarm.BackColor     = Color.FromArgb(32, 32, 32);
            btn_tab_clock.BackColor     = Color.FromArgb(32, 32, 32);

            button.BackColor            = Color.FromArgb(50, 50, 50);

            if (button == btn_tab_timer)
            {

                tbc_main.SelectedIndex = 0;

            }
            else if (button == btn_tab_alarm)
            {

                tbc_main.SelectedIndex = 1;

            }
            else if (button == btn_tab_stopwatch)
            {

                tbc_main.SelectedIndex = 2;

            }
            else if (button == btn_tab_clock)
            {

                tbc_main.SelectedIndex = 3;

            }
        }

        private void p_Timer1_MouseEnter(object sender, EventArgs e)
        {
            circularProgressBar.InnerColor  =            Color.FromArgb(36, 36, 36);
            p_Timer1.BackColor              =            Color.FromArgb(36, 36, 36);



            Color.FromArgb(36, 36, 36);
        }

        private void p_Timer1_MouseLeave(object sender, EventArgs e)
        {
           Color.FromArgb(39, 39, 39);

           circularProgressBar.InnerColor   = Color.FromArgb(39, 39, 39);
            p_Timer1.BackColor              = Color.FromArgb(39, 39, 39);

        }

        private void p_Timer1_MouseClick(object sender, MouseEventArgs e)
        {
            //show_timer_settings(p_Timer1);
            
        }

        private void show_timer_settings(Panel panel)
        {
            if(!timerflags.running)
                 MessageBox.Show("hello");

        }



        long timer_seconds;
        private void btn_timer_start_timer_Click(object sender, EventArgs e)
        {

            if (!timerflags.running)
            {
                if (!timerflags.started)
                {
                    timer_seconds = Convert.ToInt64(circularProgressBar.Tag.ToString());
                    circularProgressBar.Maximum = (int)timer_seconds;
                    circularProgressBar.Step = 1;

                    circularProgressBar.Value = circularProgressBar.Maximum - circularProgressBar.Step;

                    lbl_timer.Text = get_time(--timer_seconds * 100).Substring(0, 8);
                    timerflags.started = true;
                }

                timer_timer_down.Start();
                btn_timer_start_timer.BackgroundImage = Resources.stopwatch_pause;

                timerflags.running = true;
                timerflags.pause = false;

            }
            else
            {
                btn_timer_start_timer.BackgroundImage = Resources.stopwatch_start;
                timer_timer_down.Stop();
                timerflags.running = false;
                timerflags.pause = true;

            }
        }

        private void timer_timer_down_Tick(object sender, EventArgs e)
        {
          
            if(circularProgressBar.Value - circularProgressBar.Step >=  0)
                circularProgressBar.Value -= circularProgressBar.Step ;

            timer_seconds--;
            lbl_timer.Text = get_time(timer_seconds * 100).Substring(0, 8);

            if (timer_seconds <= 0)
            {
                notification.Icon = SystemIcons.Application;
                
                notification.BalloonTipIcon = ToolTipIcon.Info;
                notification.BalloonTipTitle = "Timer [" + lbl_timer_title.Text + "] Done";
                notification.BalloonTipText = DateTime.Now.TimeOfDay.ToString().Substring(0,5); //DateTime.Now.ToString("hh:mm");
                notification.ShowBalloonTip(10000);
                timer_timer_down.Stop();
            }
        }



  

        private void p_Timer1_Click(object sender, EventArgs e)
        {
            show_timer_settings_window();
        }

        private void show_timer_settings_window()
        {
            if (!timerflags.running)
            {


                frm_TimerSettings frm = new frm_TimerSettings();
                frm.timer = new frm_TimerSettings.clsTimerInfo();
                frm.timer.set_time(Convert.ToInt32(circularProgressBar.Tag.ToString()));
                frm.timer.set_name(lbl_timer_title.Text);
                frm.ShowDialog();
                circularProgressBar.Tag = frm.timer.get_time().ToString();
                lbl_timer_title.Text = frm.timer.get_name();
                lbl_timer.Text = get_time(frm.timer.get_time() * 100).Substring(0, 8);

            }
        }

        private void circularProgressBar_Click(object sender, EventArgs e)
        {
            show_timer_settings_window();

        }

        private void lbl_timer_Click(object sender, EventArgs e)
        {
            show_timer_settings_window();

        }

       

        private void btn_timer_reset_timer_Click(object sender, EventArgs e)
        {
            if (timerflags.started)
            {
                timerflags.running = false;
                timerflags.pause = false;
                timerflags.started = false;
                timer_timer_down.Stop();

                btn_timer_start_timer.BackgroundImage = Resources.stopwatch_start;

                circularProgressBar.Value = 0;
                lbl_timer.Text = get_time(Convert.ToInt64(circularProgressBar.Tag.ToString()) * 100).Substring(0, 8);
            }
        }

        private void btn_timer_FullScreen_Click(object sender, EventArgs e)
        {
            if (timerflags.mid_screen)
            {
                btn_timer_FullScreen.BackgroundImage = Resources.img_CancelFullScreen;

                p_Timer1.Dock = DockStyle.Fill;
                tbc_main.Dock = DockStyle.Fill;

                timerflags.mid_screen = false;
                timerflags.fill_screen = true;
            }
            else if (timerflags.fill_screen)
            {

                btn_timer_FullScreen.BackgroundImage = Resources.img_FullScreen1;

                p_Timer1.Dock = DockStyle.None;
                tbc_main.Dock = DockStyle.None;


                timerflags.fill_screen = false;
                timerflags.mid_screen = true;

            }
        }

        private void p_Timer1_Paint(object sender, PaintEventArgs e)
        {

        }

        Size lastSize = new Size(0,0);

        private void btn_Smallwindow_Click(object sender, EventArgs e)
        {

            if(stopwatchflags.mid_screen)
            {

                tbc_main.Dock = DockStyle.Bottom;
                this.FormBorderStyle = FormBorderStyle.None;

                lastSize = this.Size;

                this.Size = new Size(300, 300);
                tbc_main.Size = this.Size + new Size(0,20);

                btn_FlagStopwatch.Visible = false;
                btn_Fullscreen.Visible    = false;

                btn_StartStopwatch.Size = new Size(50, 50);
                btn_ResetStopwatch.Size = new Size(50, 50);
                btn_Smallwindow   .Size = new Size(40, 40);

                btn_Smallwindow.Location = new Point(10, 10);

                make_button_circle(btn_StartStopwatch);
                make_button_circle(btn_ResetStopwatch);

                btn_StartStopwatch.Location = new Point(btn_StartStopwatch.Location.X , btn_StartStopwatch.Location.Y + 50);
                btn_ResetStopwatch.Location = new Point(btn_ResetStopwatch.Location.X, btn_ResetStopwatch.Location.Y + 50);

                lbl_stopwatch_hours_title.Font = new Font(lbl_stopwatch_hours_title.Font.FontFamily, 10);
                lbl_stopwatch_mins_title.Font  = new Font(lbl_stopwatch_hours_title.Font.FontFamily, 10);
                lbl_stopwatch_secs_title.Font  = new Font(lbl_stopwatch_hours_title.Font.FontFamily, 10);


                lbl_stopwatch_hours_title.Location = new Point(lbl_stopwatch_hours_title.Location .X - 10 , lbl_stopwatch_hours_title.Location.Y + 20);
                lbl_stopwatch_mins_title .Location = new Point (lbl_stopwatch_mins_title .Location.X - 10 , lbl_stopwatch_mins_title .Location.Y + 20);    
                lbl_stopwatch_secs_title .Location = new Point (lbl_stopwatch_secs_title .Location.X - 10 , lbl_stopwatch_secs_title .Location.Y + 20);


                lbl_Stopwatch_time.Location = new Point(lbl_Stopwatch_time.Location.X, lbl_Stopwatch_time.Location.Y + 20);
                lbl_csecond.Location        = new Point(lbl_csecond.Location       .X, lbl_csecond.Location       .Y + 20);

                btn_Close.Visible = true;

                stopwatchflags.mid_screen = false;
                stopwatchflags.small_screen = true;
            }
            else if (stopwatchflags.small_screen)
            {

                tbc_main.Dock = DockStyle.None;
                this.FormBorderStyle = FormBorderStyle.Sizable;

                this.Size = lastSize;


                btn_FlagStopwatch.Visible = true;
                btn_Fullscreen.Visible    = true;
                btn_Close.Visible         = false;

                stopwatchflags.mid_screen = true;
                stopwatchflags.small_screen = false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alarm1_Click(object sender, EventArgs e)
        {
            frm_AlarmSettings frm = new frm_AlarmSettings();
            frm.ShowDialog();
        }

        private void alarm1_Load(object sender, EventArgs e)
        {

        }


        
    }
}
