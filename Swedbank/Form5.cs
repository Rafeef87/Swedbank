using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Swedbank
{
    public partial class Form5 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide(); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inloggning fr1 = new Inloggning();
            fr1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim().ToString() == "" || textBox2.Text.Trim().ToString() == "" || textBox3.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Du måste fylla i ett värde för obligatoriska värden");
                label8.Text = "*";
                label9.Text = "*";
                label10.Text = "*";
                return;
            }

            else
            {
                string personnu = textBox1.Text.Trim();
                string namn = textBox2.Text.Trim();
                int telefonnu = int.Parse(textBox3.Text.Trim());


                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kund(personnu, namn, telefonnu)" +
                    " VALUES('" + personnu + "','" + namn + "','" + telefonnu + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Du har adderat en ny person");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                label8.Text = "";
                label9.Text = "";
                label10.Text = "";

                Form4 fr4 = new Form4();
                fr4.Show();
                this.Hide();
            }
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kund", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string personnu = textBox1.Text.Trim();
            string namn = textBox2.Text.Trim();
            string telefonnu = textBox3.Text.Trim();
         

            if (namn != "")
            {
                cn.Open();
                string query = $"UPDATE Kund SET namn = '{namn}' WHERE personnu = '{personnu}'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            if (telefonnu != "")
            {
                cn.Open();
                string query = $"UPDATE Kund SET telefonnu = '{telefonnu}' WHERE personnu = '{personnu}'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
           

            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kund", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cn.Open();
            string personnu = textBox1.Text.Trim();
            SqlCommand cmd = new SqlCommand("DELETE FROM Kund WHERE personnu = '" + personnu + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

            textBox1.Text = "";

            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kund", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kund", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
