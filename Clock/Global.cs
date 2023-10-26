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


                _InnerForms[_CurrentScreen].Visible = false;
                _CurrentScreen = value;
                _InnerForms[_CurrentScreen].Visible = true;
            }
        }

        private static Dictionary<enCurrentScreen, Form> _InnerForms = new Dictionary<enCurrentScreen, Form>() 
        {
            {enCurrentScreen.FocusSessions,new frm_FocusSessions(){ Visible = false,TopLevel = false ,Dock = DockStyle.Fill} } ,
            {enCurrentScreen.Timer,new frm_Timer() {Visible = false,TopLevel = false ,Dock = DockStyle.Fill} } ,
            {enCurrentScreen.Alarm,new frm_Alarm()  {Visible = false,TopLevel = false,Dock = DockStyle.Fill }} ,
            {enCurrentScreen.Stopwatch,new frm_Stopwatch()  {Visible = false,TopLevel = false ,Dock = DockStyle.Fill}} ,
            {enCurrentScreen.WorldClock,new frm_WorldClock()  {Visible = false,TopLevel = false ,Dock = DockStyle.Fill}} ,
        };

        private static Panel? _Container = null;

        public static Panel ScreensContainer
        {
            get
            {
                return _Container;
            }

            set
            {
                if (_Container == value) return;

                _Container = value;
                _Container.Controls.Clear();
                _Container.Controls.Add(_InnerForms[enCurrentScreen.FocusSessions]);
                _Container.Controls.Add(_InnerForms[enCurrentScreen.Timer]);
                _Container.Controls.Add(_InnerForms[enCurrentScreen.Alarm]);
                _Container.Controls.Add(_InnerForms[enCurrentScreen.Stopwatch]);
                _Container.Controls.Add(_InnerForms[enCurrentScreen.WorldClock]);
                _InnerForms[_CurrentScreen].Visible = true;
                _InnerForms[_CurrentScreen].BringToFront();
                _InnerForms[_CurrentScreen].Select();

            }
        }
        
    }
}
