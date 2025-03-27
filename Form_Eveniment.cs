using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Remoting.Contexts;

namespace Calendar_SQL
{
    public partial class Form_Eveniment : Form
    {
        SqlConnection conn;
        DateTime now = DateTime.Now;
        int Id;
        public Form_Eveniment()
        {

            InitializeComponent();
            string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Calendar.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(connstring);
            string an = now.Year.ToString();
            string luna = now.Month.ToString();
            string zi = now.Day.ToString();
            textBox_Data_an.Text = an;
            textBox_Data_luna.Text= luna;
            textBox_Data_zi.Text = zi;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                try
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT MAX([Id]) FROM Calendar", conn);
                    Int32 id0 = (Int32)cmd1.ExecuteScalar();
                    Id = id0;
                }
                catch
                {
                    Id = 1;
                }
                Id += 1;
                int Zitxt = Convert.ToInt32(textBox_Data_zi.Text);
                int Lunatxt = Convert.ToInt32(textBox_Data_luna.Text);
                int Antxt = Convert.ToInt32(textBox_Data_an.Text);
                string Titlutxt = textBox_Titlu.Text;
                string Descrtxt = richTextBox_Descriere.Text;

                string comanda = "INSERT INTO Calendar (Id, Titlu, Descriere, An, Luna, Zi) VALUES (@Id_int, @Titlu_txt, @Descriere_txt, @An_txt, @Luna_txt, @Zi_txt)";
                SqlCommand cmd = new SqlCommand(comanda, conn);

                cmd.Parameters.AddWithValue("@Id_int", Id);
                cmd.Parameters.AddWithValue("@Zi_txt", Zitxt);
                cmd.Parameters.AddWithValue("@Luna_txt", Lunatxt);
                cmd.Parameters.AddWithValue("@An_txt", Antxt);
                cmd.Parameters.AddWithValue("@Titlu_txt", Titlutxt);
                cmd.Parameters.AddWithValue("@Descriere_txt", Descrtxt);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Evenimentul a fost salvat.");
                
                conn.Close();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Eroare_001 - Crearea evenimentului nu a fost efectuata");
            }
        }
    }
}
