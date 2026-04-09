namespace Swedbank
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(146, 214);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 23);
            dateTimePicker1.TabIndex = 99;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Location = new Point(533, 325);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(151, 26);
            button4.TabIndex = 98;
            button4.Text = "Visa Överföringar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Location = new Point(121, 325);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(162, 29);
            button3.TabIndex = 97;
            button3.Text = "Överför";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PeachPuff;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(342, 137);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(506, 165);
            dataGridView1.TabIndex = 96;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 182);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 251);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 93;
            label4.Text = "Belopp: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 217);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 92;
            label3.Text = "Datum: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 154);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 91;
            label2.Text = "Från Konto No: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 151);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(443, 37);
            label1.TabIndex = 90;
            label1.Text = "Överföring från konto till konto";
            // 
            // button2
            // 
            button2.Location = new Point(747, 44);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 31);
            button2.TabIndex = 89;
            button2.Text = "Logga ut";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(32, 44);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 88;
            button1.Text = "Tillbaka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 182);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 100;
            label5.Text = "Till Konto No: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 251);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 23);
            textBox3.TabIndex = 101;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(789, 358);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 103;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(705, 376);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 102;
            label7.Text = "Swedbank";
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 416);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form16";
            Text = "Överföring";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label7;
    }
}