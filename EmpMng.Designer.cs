namespace Final_project
{
    partial class EmpMng
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
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(173, 288);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 45);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter email id to click profile";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 15;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(46, 224);
            button4.Name = "button4";
            button4.Size = new Size(75, 32);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(46, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 3;
            button2.Text = "View Class";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(46, 74);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(225, 175);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(561, 150);
            dataGridView2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(225, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(561, 68);
            dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orchid;
            label3.Location = new Point(326, 12);
            label3.Name = "label3";
            label3.Size = new Size(304, 25);
            label3.TabIndex = 10;
            label3.Text = "Welcome To Employee login";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(652, 57);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(111, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Fill the details here..";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(477, 57);
            label4.Name = "label4";
            label4.Size = new Size(179, 17);
            label4.TabIndex = 8;
            label4.Text = "if you are an new emplloyee...?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(225, 55);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 13;
            label1.Text = "Your Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(225, 156);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 14;
            label2.Text = "Classes";
            // 
            // EmpMng
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_24_110859;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 412);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Name = "EmpMng";
            Text = "EmpMng";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button button4;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label3;
        private LinkLabel linkLabel2;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}