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
    public partial class Form4 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToString() == "" || textBox2.Text.Trim().ToString() == "")
            {

                MessageBox.Show("Du måste fylla i användarnamn och lösenord");
            }
            else
            {
                string anvnamn = textBox1.Text.Trim();
                string loseord = textBox2.Text.Trim();
                cn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Anvandare (anvnamn, losenord) VALUES ('" + anvnamn + "', '" + loseord + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Du har adderat en ny person");
                textBox1.Text = "";
                textBox2.Text = "";

                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
