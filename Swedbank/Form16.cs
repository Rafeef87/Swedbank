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
    public partial class Form16 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");

        public Form16()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
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
            string kontonum2 = textBox2.Text.Trim();
            string datum = dateTimePicker1.Value.ToShortDateString();
            int belopp = int.Parse(textBox3.Text.Trim());

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Saldo FROM Konto WHERE kontonum = '" + kontonum + "'", cn);
            cmd.ExecuteNonQuery();
            int saldo = (int)cmd.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("SELECT Saldo FROM Konto WHERE kontonum = '" + kontonum2 + "'", cn);
            cmd2.ExecuteNonQuery();
            int saldo2 = (int)cmd.ExecuteScalar();

            int saldoefter = saldo - belopp;
            int saldoefter2 = saldo2 + belopp;

            string query = $"UPDATE Konto SET saldo = '{saldoefter}' WHERE kontonum = '{kontonum}'";
            SqlCommand cmd3 = new SqlCommand(query, cn);
            cmd3.ExecuteNonQuery();

            string query2 = $"UPDATE Konto SET saldo = '{saldoefter2}' WHERE kontonum = '{kontonum2}'";
            SqlCommand cmd4 = new SqlCommand(query, cn);
            cmd3.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand($"INSERT INTO Overforing(konto1, konto2, datum, belopp) VALUES('{kontonum}', '{kontonum2}', '{datum}', '{belopp}')", cn);
            cmd5.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Overforing", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Overforing", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
