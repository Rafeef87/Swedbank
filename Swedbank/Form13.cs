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
    public partial class Form13 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
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
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Du måste fylla i ett värde.");
                return;
            }
            else
            {
                int kontonum = int.Parse(textBox1.Text.Trim());
                int personnu = int.Parse(textBox2.Text.Trim());
                string kontotyp = comboBox1.Text.Trim();
                float saldo = float.Parse(textBox3.Text.Trim());
                string bsekrivning = textBox4.Text.Trim();

                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Konto(kontonum, personnu, kontotyp, saldo, bsekrivning) " +
                    "VALUES('" + kontonum + "', '" + personnu + "', '" + kontotyp + "', '" + saldo + "', '" + bsekrivning + "')",
                    cn);

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Du har skapat ett konto.");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Konto", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Konto", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kontonum = textBox1.Text.Trim();
            string personnu = textBox2.Text.Trim();
            string kontotyp = comboBox1.Text.Trim();
            string saldo = textBox3.Text.Trim();
            string beskrivning = textBox4.Text.Trim();

            if (personnu != "")
            {
                cn.Open();
                string query = $"UPDATE Konto SET personnu = '{personnu}' WHERE kontonum = '{kontonum}'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            if (kontotyp != "")
            {
                cn.Open();
                string query = $"UPDATE Konto SET kontotyp = '{kontotyp}' WHERE kontonum = '{kontonum}'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            if (saldo != "")
            {
                cn.Open();
                string query = $"UPDATE Konto SET saldo = '{saldo}' WHERE kontonum = '{kontonum}'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            if (beskrivning != "")
            {
                cn.Open();
                string query = $"UPDATE Konto SET beskrivning = '{beskrivning}' WHERE kontonum = '{kontonum}'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Konto", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            string kontonum = textBox1.Text.Trim();

            SqlCommand cmd = new SqlCommand("DELETE FROM Konto WHERE kontonum = '" + kontonum + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

            textBox1.Text = "";

            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Konto", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
