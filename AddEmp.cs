using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Final_project
{
    public partial class AddEmp : Form
    {
        public AddEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please enter required fields", "message");
            }
            else
            {
                conn.Open();
                string checkQuery =
        "SELECT COUNT(*) FROM emp_login WHERE EmpID = @EmpID";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);

                checkCmd.Parameters.AddWithValue("@EmpID", textBox1.Text);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Employee already registered");
                    return;
                }

                if (MessageBox.Show("do you want to add this employee?", "confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

//                    conn.Open();
                    string insertQuery = "INSERT INTO emp_login VALUES (@EmpID, @EmpNum )";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@EmpID", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmpNum", textBox2.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added succesfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("not added");
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to logout from this page?", "confirm logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please enter required fields", "message");
            }
            else

            {
                if (MessageBox.Show("do you want to delete this employee?", "confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string connectionString = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";


                    //int empID = 5;   // record you want to delete

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string query = "DELETE FROM emp_login WHERE EmpID = @EmpID";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@EmpID", textBox1.Text);

                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee remover from company", "info", MessageBoxButtons.OK);
                            textBox1.Clear();
                            textBox2.Clear();

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Emplotee not deleted");
                }

            }
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from emp_login", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
