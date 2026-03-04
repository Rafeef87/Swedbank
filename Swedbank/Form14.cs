using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Swedbank
{
    public partial class Form14 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inloggning fr1 = new Inloggning();
            fr1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kontonum = textBox1.Text.Trim();
            string datum = dateTimePicker1.Value.ToShortDateString();
            string insattningstr = textBox2.Text.Trim();

            MessageBox.Show(datum);

            if (kontonum == "" || insattningstr == "")
            {
                MessageBox.Show("Du måste fylla i alla rutor");
                return;
            }
            else
            {
                int insattning = int.Parse(textBox2.Text.Trim());
                cn.Open();
                SqlCommand cmd = new SqlCommand("select saldo from Konto where kontonum = '" + kontonum + "'", cn);
                cmd.ExecuteNonQuery();

                int saldo1 = (int)cmd.ExecuteScalar();
                int saldoefter = saldo1 + insattning;

                string query = $"update Konto set saldo = '{saldoefter}' where kontonum = '{kontonum}'";
                SqlCommand cmd2 = new SqlCommand(query, cn);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand($"insert into Insattning(kontonum, datum, insatt, saldo)" +
                    $"values('{kontonum}', '{datum}', '{insattning}', '{saldoefter}')", cn);
                cmd3.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("select * from Insattning", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Insattning", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
