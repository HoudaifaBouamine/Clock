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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
