using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Swedbank
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Inloggning fr1 = new Inloggning();
            fr1.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 fr13 = new Form13();
            fr13.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 fr14 = new Form14();
            fr14.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 fr15 = new Form15();
            fr15.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form16 fr16 = new Form16();
            fr16.Show(); this.Hide();
        }

       
    }
}
