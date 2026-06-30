using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_project
{
    public partial class CustMng : Form
    {
        public CustMng()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplayLL a1 = new ApplayLL();
            a1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to logout from this page?", "confirm logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connstr = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";

            string connectionString =
     @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM registration WHERE email = @email or username=@username";

                SqlCommand cmd = new SqlCommand(query, con);

                // User entered value
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Show single selected record in grid
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record not found");
                    dataGridView1.DataSource = null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from Emo_allo", conn);
                DataTable dt2 = new DataTable();
                sqlda.Fill(dt2);

                dataGridView2.DataSource = dt2;
            }
        }
    }
}
