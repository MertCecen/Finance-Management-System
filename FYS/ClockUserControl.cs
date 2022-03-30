using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYS
{
    public partial class ClockUserControl : UserControl
    {
        public ClockUserControl()
        {
            InitializeComponent();
            getDay();
        }
        private void getDay()
        {
            if (DateTime.Today.DayOfWeek.ToString().Equals("Monday"))
            {
                labelDay.Text = "Pazartesi";
            }
            else if (DateTime.Today.DayOfWeek.ToString().Equals("Tuesday"))
            {
                labelDay.Text = "Salı";
            }
            else if (DateTime.Today.DayOfWeek.ToString().Equals("Wednesday"))
            {
                labelDay.Text = "Çarşamba";
            }
            else if (DateTime.Today.DayOfWeek.ToString().Equals("Thursday"))
            {
                labelDay.Text = "Perşembe";
            }
            else if (DateTime.Today.DayOfWeek.ToString().Equals("Friday"))
            {
                labelDay.Text = "Cuma";
            }
            else if (DateTime.Today.DayOfWeek.ToString().Equals("Saturday"))
            {
                labelDay.Text = "Cumartesi";
            }
            else
            {
                labelDay.Text = "Pazar";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
