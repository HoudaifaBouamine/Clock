
using Clock.Properties;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows;

namespace Clock
{
    public partial class frm_Main : Form
    {
        //public frm_Main()
        //{
        //    InitializeComponent();
        //}
        public frm_Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts

            clsGlobal.ScreensContainer = pnl_Main;
        }

        #region Resize Window
        protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            Brush brush = new SolidBrush(Color.FromArgb(255, 255, 255));
            e.Graphics.FillRectangle(new SolidBrush((clsSettings.MainContantBackGroundColor)), Top);
            e.Graphics.FillRectangle(new SolidBrush((clsSettings.SideMenuBackGroundColor)), Left);
            e.Graphics.FillRectangle(new SolidBrush((clsSettings.MainContantBackGroundColor)), Right);
            e.Graphics.FillRectangle(new SolidBrush((clsSettings.MainContantBackGroundColor)), Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int Thikness = 4; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, Thikness); } }
        Rectangle Left { get { return new Rectangle(0, 0, Thikness, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - Thikness, this.ClientSize.Width, Thikness); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - Thikness, 0, Thikness, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, Thikness, Thikness); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - Thikness, 0, Thikness, Thikness); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - Thikness, Thikness, Thikness); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - Thikness, this.ClientSize.Height - Thikness, Thikness, Thikness); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (WindowState == FormWindowState.Maximized) { return; }

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;

            }
        }

        #endregion

        #region Move Window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void pnl_MainContantHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void guna2Button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void btn_Close_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_Maximize_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_Maximize.BackgroundImage = Resources.img_Maximize2;
            }
            else
            {
                btn_Maximize.BackgroundImage = Resources.img_Maximize4;
            }
        }

        private void btn_Maximize_MouseLeave(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_Maximize.BackgroundImage = Resources.img_Maximize1;
            }
            else
            {
                btn_Maximize.BackgroundImage = Resources.img_Maximize3;
            }
        }

        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.BackgroundImage = Resources.img_Close2;

        }

        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.BackgroundImage = Resources.img_Close1;

        }

        private void btn_Minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimize.BackgroundImage = Resources.img_Minimize2;

        }

        private void btn_Minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimize.BackgroundImage = Resources.img_Minimize1;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {


            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btn_Maximize.BackgroundImage = Resources.img_Maximize3;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btn_Maximize.BackgroundImage = Resources.img_Maximize1;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void frm_Main_Resize(object sender, EventArgs e)
        {
            if (this.Width < 550)
            {
                pnl_SmallSideMenu.Visible = false;
                pnl_SideMenu.Visible = false;
            }
            else if (this.Width < 1000)
            {
                pnl_SideMenu.Visible = false;
                pnl_SmallSideMenu.Visible = true;
            }
            else
            {
                pnl_SideMenu.Visible = true;
                pnl_SmallSideMenu.Visible = false;
            }
        }

        private void btn_FocusSessions_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentScreen = clsGlobal.enCurrentScreen.FocusSessions;
        }

        private void btn_Timer_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentScreen = clsGlobal.enCurrentScreen.Timer;
        }

        private void btn_Alarm_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentScreen = clsGlobal.enCurrentScreen.Alarm;
        }

        private void btn_Stopwatch_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentScreen = clsGlobal.enCurrentScreen.Stopwatch;
        }

        private void btn_WorldClock_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentScreen = clsGlobal.enCurrentScreen.WorldClock;
        }
    }



}