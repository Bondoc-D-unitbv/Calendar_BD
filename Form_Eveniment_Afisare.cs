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

namespace Calendar_SQL
{
    public partial class Form_Eveniment_Afisare : Form
    {
        SqlConnection conn;
        SqlDataAdapter adaptor = new SqlDataAdapter();
        DataTable tabel = new DataTable();
        DateTime now = DateTime.Now;

        public Form_Eveniment_Afisare()
        {
            InitializeComponent();
            string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Calendar.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(connstring);
            textBox_Data_eveniment_an.Text = now.Year.ToString();
            textBox_Data_eveniment_luna.Text = now.Month.ToString();
            textBox_Data_eveniment_zi.Text = now.Day.ToString();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                tabel.Clear();
                tabel.Columns.Clear();
                dataGridView1.Columns.Clear();

                int Zi = Convert.ToInt32(textBox_Data_eveniment_zi.Text);
                int Luna = Convert.ToInt32(textBox_Data_eveniment_luna.Text);
                int An = Convert.ToInt32(textBox_Data_eveniment_an.Text);

                string comanda = "SELECT Titlu , Descriere , An , Luna , Zi FROM Calendar WHERE(Zi=@Zi_txt AND Luna=@Luna_txt AND An=@An_txt)";

                SqlCommand cmd = new SqlCommand(comanda, conn);
                cmd.Parameters.AddWithValue("@Zi_txt", Zi);
                cmd.Parameters.AddWithValue("@Luna_txt", Luna);
                cmd.Parameters.AddWithValue("@An_txt", An);
                adaptor.SelectCommand = cmd;
                adaptor.Fill(tabel);
                dataGridView1.DataSource = tabel;
            }
            catch
            {
                MessageBox.Show("Eroare 002 - Afisarea nu mere");
            }
        }
    }
}
