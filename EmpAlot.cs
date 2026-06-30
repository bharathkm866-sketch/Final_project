using Microsoft.Data.SqlClient;
using System.Data;

namespace Final_project
{
    public partial class EmpAlot : Form
    {
        public EmpAlot()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Data Source=bharathkm\SQLEXPRESS;Initial Catalog=NIRMITHA;Integrated Security=True;Trust Server Certificate=True
        //Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("please enter required fields");
            }
            else
            {


                SqlConnection conn = new SqlConnection("Data Source=bharathkm\\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string insertQuery = "INSERT INTO Emo_allo VALUES (@ename,@cname,@cdate,@ctime,@place)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@ename", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@cname", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@cdate", Convert.ToDateTime(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("ctime", comboBox2.SelectedItem.ToString());

                cmd.Parameters.AddWithValue("@place", comboBox1.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved succesfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from Emo_allo", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("please enter required fields");
            }
            else
            {


                if (MessageBox.Show("do you want to delete this class?", "confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string connectionString = @"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True";


                    //int empID = 5;   // record you want to delete

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string query = "DELETE FROM Emo_allo WHERE cname = @cname";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@cname", textBox2.Text);

                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(textBox2 + " class deleted", "info", MessageBoxButtons.OK);
                            textBox1.Clear();
                            textBox2.Clear();

                        }
                    }


                }
            }
        }
    }
}