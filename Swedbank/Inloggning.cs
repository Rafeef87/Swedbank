using System.Data;
using System.Data.SqlClient;

namespace Swedbank
{
    public partial class Inloggning : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafee\source\repos\Swedbank\Swedbank\Database1.mdf;Integrated Security=True");
        public Inloggning()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string an1 = textBox1.Text.Trim();
            string los1 = textBox2.Text.Trim();

            cn.Open();

            // HÄMTA lösenord för användaren
            SqlCommand cmd = new SqlCommand(
                "SELECT losenord FROM Anvandare WHERE anvnamn = @anv", cn);
            cmd.Parameters.AddWithValue("@anv", an1);

            object result = cmd.ExecuteScalar();

            if (result == null)
            {
                cn.Close();
                MessageBox.Show("Fel användarnamn eller lösenord.");
                return;
            }

            string dbLosen = result.ToString();

            if (dbLosen != los1)
            {
                cn.Close();
                MessageBox.Show("Fel användarnamn eller lösenord.");
                return;
            }

            cn.Close();

            // Logik: admin är anvnamn 123456789
            if (an1 == "123456789")
            {
                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
            else
            {
                Form7 fr7 = new Form7();
                fr7.Show();
                this.Hide();

            }
        }

    }
}
