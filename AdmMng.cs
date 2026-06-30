using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sql;

using Microsoft.Data.SqlClient;

namespace Final_project
{
    public partial class AdmMng : Form
    {
        public AdmMng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpAlot e1 = new EmpAlot();
            e1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmp a1 = new AddEmp();
            a1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to logout from this page?", "confirm logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from Emp_details", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["password"].Visible = false;
                dataGridView1.Columns["conPassword"].Visible = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from registration", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                dataGridView2.DataSource = dt;
                dataGridView2.Columns["username"].Visible = false;
                dataGridView2.Columns["Password"].Visible = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
