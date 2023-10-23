using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class clsSettings
    {
        public static Color MainContantBackGroundColor { get; private set; } = Color.FromArgb(39, 39, 39);
        public static Color MainContantForeColorEnable { get; private set; } = Color.FromArgb(255, 255, 255);
        public static Color MainContantForeColorDisable { get; private set; } = Color.FromArgb(207, 207, 207);

        public static Color SideMenuBackGroundColor { get; private set; } = Color.FromArgb(32, 32, 32);
        public static Color SideMenuForeColorEnable { get; private set; }  = Color.FromArgb(255, 255, 255);
        public static Color SideMenuForeColorDisable { get; private set; } = Color.FromArgb(207, 207, 207);

        public static Color SmallSideMenuBackGroundColor { get; private set; } = Color.FromArgb(32, 32, 32);
        public static Color SmallSideMenuForeColorEnable    { get; private set; } = Color.FromArgb(255, 255, 255);
        public static Color SmallSideMenuForeColorDisable   { get; private set; } = Color.FromArgb(207, 207, 207);

        public static Color RedEnable { get;private set;} = Color.FromArgb( 232, 17, 35);

        public static Color RedDisable { get; private set; } = Color.FromArgb(126, 30, 38);
    }
}
