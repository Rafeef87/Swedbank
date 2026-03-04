namespace Swedbank
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { " Lön", " Spara", " Bil " });
            comboBox1.Location = new Point(252, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 33);
            comboBox1.TabIndex = 52;
            comboBox1.Text = " Lön";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PeachPuff;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(587, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(767, 297);
            dataGridView1.TabIndex = 51;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 31);
            textBox2.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 282);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 47;
            label4.Text = "Konto type: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 216);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 46;
            label3.Text = "Kund ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 158);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 45;
            label2.Text = "Konto No: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 31);
            textBox1.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 56);
            label1.Name = "label1";
            label1.Size = new Size(267, 54);
            label1.TabIndex = 44;
            label1.Text = "Skapa konto";
            // 
            // button2
            // 
            button2.Location = new Point(1120, 56);
            button2.Name = "button2";
            button2.Size = new Size(116, 34);
            button2.TabIndex = 43;
            button2.Text = "Logga ut";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 56);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 42;
            button1.Text = "Tillbaka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(252, 342);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 31);
            textBox3.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 414);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 54;
            label5.Text = "Beskrivning: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 342);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 53;
            label6.Text = "Saldo: ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(252, 414);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(239, 119);
            textBox4.TabIndex = 55;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Location = new Point(252, 565);
            button3.Name = "button3";
            button3.Size = new Size(239, 34);
            button3.TabIndex = 57;
            button3.Text = "Spara";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Coral;
            button4.Location = new Point(832, 515);
            button4.Name = "button4";
            button4.Size = new Size(216, 44);
            button4.TabIndex = 58;
            button4.Text = "Visa kundens konto";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1270, 584);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(1150, 615);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 59;
            label7.Text = "Swedbank";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 675);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form13";
            Text = "Skapa konto";
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label7;
    }
}