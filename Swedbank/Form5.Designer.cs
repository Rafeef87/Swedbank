namespace Swedbank
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(716, 319);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(632, 338);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 39;
            label7.Text = "Swedbank";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PeachPuff;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 101);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(367, 165);
            dataGridView1.TabIndex = 38;
            // 
            // button6
            // 
            button6.BackColor = Color.Coral;
            button6.Location = new Point(513, 283);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(155, 26);
            button6.TabIndex = 37;
            button6.Text = "Visa alla kunder";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(268, 283);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(78, 26);
            button5.TabIndex = 36;
            button5.Text = "Ta bort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(150, 283);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(78, 26);
            button4.TabIndex = 35;
            button4.Text = "Uppdatera";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(26, 283);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 26);
            button3.TabIndex = 34;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 190);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 145);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 194);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 26;
            label4.Text = "Telefonnummer: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 148);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 25;
            label3.Text = "Namn: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 24;
            label2.Text = "ID: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 101);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 23;
            label1.Text = "Hantera Kund";
            // 
            // button2
            // 
            button2.Location = new Point(679, 28);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 25);
            button2.TabIndex = 22;
            button2.Text = "Logga ut";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 28);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 25);
            button1.TabIndex = 21;
            button1.Text = "Tillbaka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "+46";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 190);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 23);
            comboBox1.TabIndex = 41;
            comboBox1.Text = "+46";
            comboBox1.ValueMember = "+46";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.OrangeRed;
            label10.Location = new Point(362, 198);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(362, 153);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(362, 105);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 42;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 411);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private ColorDialog colorDialog1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}