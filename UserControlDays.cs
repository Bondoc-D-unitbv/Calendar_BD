using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_SQL
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday,int themeset)
        {
            if (themeset == 0)
            {
                BackColor = Color.DarkGray;
                label_day.BackColor = Color.LightGray;
            }
            else
            {
                BackColor = Color.White;
                label_day.BackColor = Color.White;
            }
            label_day.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {

        }

        private void button_event_new_Click(object sender, EventArgs e)
        {
            Form_Eveniment eveniment = new Form_Eveniment();
            eveniment.Show();
        }

    }
}
