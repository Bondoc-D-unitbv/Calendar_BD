using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_SQL
{
    public partial class Form1 : Form
    {
        int month, year;
        string monthnames;
        int themeset = 1;
        DateTime now = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displDays();
        }

        private void displDays()
        {
            button1.BackgroundImage = Resource1.DayMode;
            
            month = now.Month;
            year = now.Year;

            if (month == 1)
                monthnames = "Ianuarie";
            else
                if (month == 2)
                monthnames = "Februarie";
            else
                if (month == 3)
                monthnames = "Martie";
            else
                if (month == 4)
                monthnames = "Aprilie";
            else
                if (month == 5)
                monthnames = "Mai";
            else
                if (month == 6)
                monthnames = "Iunie";
            else
                if (month == 7)
                monthnames = "Iulie";
            else
                if (month == 8)
                monthnames = "August";
            else
                if (month == 9)
                monthnames = "Septembrie";
            else
                if (month == 10)
                monthnames = "Octombrie";
            else
                if (month == 11)
                monthnames = "Noiembrie";
            else
                if (month == 12)
                monthnames = "Decembrie";

            label_month_year.Text = monthnames + " - " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for(int i = 1 ; i <= dayoftheweek ; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                ucblank.theme(themeset);
                daycontainer.Controls.Add(ucblank);
            }
            for(int i=1;i<=days;i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i,themeset);
                daycontainer.Controls.Add(ucdays);
                if (year == now.Year && month == now.Month && i == now.Day)
                {
                    ucdays.BackColor = Color.LightBlue;
                }
                
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }

            if (month == 1)
                monthnames = "Ianuarie";
            else
                if (month == 2)
                monthnames = "Februarie";
            else
                if (month == 3)
                monthnames = "Martie";
            else
                if (month == 4)
                monthnames = "Aprilie";
            else
                if (month == 5)
                monthnames = "Mai";
            else
                if (month == 6)
                monthnames = "Iunie";
            else
                if (month == 7)
                monthnames = "Iulie";
            else
                if (month == 8)
                monthnames = "August";
            else
                if (month == 9)
                monthnames = "Septembrie";
            else
                if (month == 10)
                monthnames = "Octombrie";
            else
                if (month == 11)
                monthnames = "Noiembrie";
            else
                if (month == 12)
                monthnames = "Decembrie";

            label_month_year.Text = monthnames + " - " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                ucblank.theme(themeset);
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i,themeset);
                daycontainer.Controls.Add(ucdays);
                if (year==now.Year && month == now.Month && i == now.Day)
                {
                    ucdays.BackColor = Color.LightBlue;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (themeset == 1)
            {
                button1.BackgroundImage = Resource1.NightMode;
                daycontainer.BackColor = Color.Black;
                button_exit.BackColor = Color.Black;
                button_prev.BackColor = Color.Black;
                button_next.BackColor = Color.Black;
                themeset = 0; 
            }
            else
            {
                button1.BackgroundImage = Resource1.DayMode;
                daycontainer.BackColor = Color.LightGray;
                button_exit.BackColor = Color.White;
                button_prev.BackColor = Color.White;
                button_next.BackColor = Color.White;
                themeset = 1;
            }
        }

        private void button_afisare_eveniment_Click(object sender, EventArgs e)
        {
            Form_Eveniment_Afisare form = new Form_Eveniment_Afisare();
            form.Show();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if(month==13)
            {
                month = 1;
                year++;
            }

            if (month == 1)
                monthnames = "Ianuarie";
            else
                if (month == 2)
                monthnames = "Februarie";
            else
                if (month == 3)
                monthnames = "Martie";
            else
                if (month == 4)
                monthnames = "Aprilie";
            else
                if (month == 5)
                monthnames = "Mai";
            else
                if (month == 6)
                monthnames = "Iunie";
            else
                if (month == 7)
                monthnames = "Iulie";
            else
                if (month == 8)
                monthnames = "August";
            else
                if (month == 9)
                monthnames = "Septembrie";
            else
                if (month == 10)
                monthnames = "Octombrie";
            else
                if (month == 11)
                monthnames = "Noiembrie";
            else
                if (month == 12)
                monthnames = "Decembrie";

            label_month_year.Text = monthnames + " - " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                ucblank.theme(themeset);
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i,themeset);
                daycontainer.Controls.Add(ucdays);
                if (year == now.Year && month == now.Month && i == now.Day)
                {
                    ucdays.BackColor = Color.LightBlue;
                }
            }
        }
    }
}
