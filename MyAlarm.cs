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



        class Ratio
        {
            public class LocationRatio
            {
                public float X, Y;

                public void set(float x, float y)
                {
                    this.X = x;
                    this.Y = y;
                }
            }

            public class SizeRatio
            {

                public float W, H;

                public void set(float w, float h)
                {
                    this.W = w;
                    this.H = h;
                }
            }


            public LocationRatio Location;
            public SizeRatio Size;
            public Control Owner;
            public Rectangle Background;

            public Ratio(Rectangle background, Control owner)
            {
                this.Background = background;
                this.Owner = owner;
                this.Size = new SizeRatio();
                this.Location = new LocationRatio();
            }

            public Ratio()
            {

                this.Size = new SizeRatio();
                this.Location = new LocationRatio();
            }

            public void applyRatio()
            {
                this.Owner.Size = new Size((int)(this.Size.W * this.Background.Size.Width), (int)(this.Size.H * this.Background.Size.Height));
                this.Owner.Location = new Point((int)((this.Location.X * this.Background.Width) + this.Background.Location.X), (int)((this.Location.Y * this.Background.Size.Height) + this.Background.Location.Y));

            }
        }


        class AllRatios
        {

            public AllRatios()
            {

            }


            public Ratio lbl_Time;
            public Ratio lbl_Duration;
            public Ratio lbl_Name;
            public Ratio lbl_wDays;
            public Ratio btn_ON_OFF;
            public Ratio btn_Background;
        }
    }
}
