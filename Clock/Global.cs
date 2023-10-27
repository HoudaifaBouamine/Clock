using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clock.Forms_Librery;

namespace Clock
{
    static internal class clsGlobal
    {
        public enum enCurrentScreen { FocusSessions = 1, Timer, Alarm, Stopwatch, WorldClock };

        private static enCurrentScreen _CurrentScreen = enCurrentScreen.FocusSessions;
        public static enCurrentScreen CurrentScreen
        {
            get
            {
                return _CurrentScreen;
            }

            set
            {
                if (_CurrentScreen == value) return;


                UserControls[_CurrentScreen].Visible = false;
                _CurrentScreen = value;
                UserControls[_CurrentScreen].Visible = true;
            }
        }

        private static Dictionary<enCurrentScreen, UserControl> UserControls = new Dictionary<enCurrentScreen, UserControl>() 
        {
            {enCurrentScreen.FocusSessions,new ucFocusSessions(){ Visible = false ,Dock = DockStyle.Fill} } ,
            {enCurrentScreen.Timer,new ucTimer() {Visible = false,Dock = DockStyle.Fill} } ,
            {enCurrentScreen.Alarm,new ucAlarm()  {Visible = false,Dock = DockStyle.Fill }} ,
            {enCurrentScreen.Stopwatch,new ucStopwatch()  {Visible = false ,Dock = DockStyle.Fill}} ,
            {enCurrentScreen.WorldClock,new ucWorldClock()  {Visible = false,Dock = DockStyle.Fill}} ,
        };

        private static Panel? _Container = null;

        public static Panel? ScreensContainer
        {
            get
            {
                return _Container;
            }

            set
            {
                

                if (_Container == value) return;

                _Container = value;

                if (_Container == null) return;

                _Container.Controls.Clear();
                _Container.Controls.Add(UserControls[enCurrentScreen.FocusSessions]);
                _Container.Controls.Add(UserControls[enCurrentScreen.Timer]);
                _Container.Controls.Add(UserControls[enCurrentScreen.Alarm]);
                _Container.Controls.Add(UserControls[enCurrentScreen.Stopwatch]);
                _Container.Controls.Add(UserControls[enCurrentScreen.WorldClock]);
                UserControls[_CurrentScreen].Visible = true;
                UserControls[_CurrentScreen].BringToFront();
                UserControls[_CurrentScreen].Select();

            }
        }
        
    }
}
