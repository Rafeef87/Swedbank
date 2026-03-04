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
    public partial class Form15 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");

        public Form15()
        {
            InitializeComponent();
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
                int uttag = int.Parse(textBox2.Text.Trim());
                cn.Open();
                SqlCommand cmd = new SqlCommand("select saldo from Konto where kontonum = '" + kontonum + "'", cn);
                cmd.ExecuteNonQuery();

                int saldo = (int)cmd.ExecuteScalar();
                int saldoefter = saldo - uttag;


                string query = $"update Konto set saldo = '{saldoefter}' where kontonum = '{kontonum}'";
                SqlCommand cmd2 = new SqlCommand(query, cn);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand($"insert into Uttag(kontonum, datum, uttag, saldo)" +
                    $"values('{kontonum}', '{datum}', '{uttag}', '{saldoefter}')", cn);
                cmd3.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("select * from Uttag", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Uttag", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
