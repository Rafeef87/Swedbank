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
    public partial class Form6 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
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
            string anvnamn = textBox1.Text.Trim();
            string losenord = textBox3.Text.Trim();



            if (losenord != "")
            {
                cn.Open();
                string query = $"UPDATE Anvandare SET losenord = '{losenord}' WHERE anvnamn = '{anvnamn}'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Lösenordet har uppdaterats");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Fyll i nytt lösenord");
                label9.Text = "*";
                label11.Text = "*";
                label12.Text = "*";
                label13.Text = "*";
            }
        }

     
    }
}
