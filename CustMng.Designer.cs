namespace Final_project
{
    partial class CustMng
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 339);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "<!>";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter email id or username";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(52, 284);
            button4.Name = "button4";
            button4.Size = new Size(98, 34);
            button4.TabIndex = 4;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(52, 141);
            button3.Name = "button3";
            button3.Size = new Size(98, 29);
            button3.TabIndex = 3;
            button3.Text = "View Class";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(52, 211);
            button2.Name = "button2";
            button2.Size = new Size(98, 31);
            button2.TabIndex = 2;
            button2.Text = "Applay for LL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(52, 66);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 1;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(212, 202);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(487, 128);
            dataGridView2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(212, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(487, 76);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 12);
            label1.Name = "label1";
            label1.Size = new Size(294, 30);
            label1.TabIndex = 4;
            label1.Text = "Welcome To Customer Login";
            // 
            // CustMng
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_24_113259;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(749, 363);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "CustMng";
            Text = "CustMng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
    }
}