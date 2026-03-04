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

        // spara button
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
                float saldo =float.Parse(textBox3.Text.Trim());
                string bsekrivning = textBox4.Text.Trim();

                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Konto(kontonum, personnu, kontotyp, saldo, bsekrivning) " +
                    "VALUES('" + kontonum + "', '" + personnu + "', '" + kontotyp + "', '" + saldo + "', '" + bsekrivning + "')",
                    cn);

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Du har skapat ett konto.");
            }
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Konto", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }
        // Visa kundens konto button
        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Konto", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
