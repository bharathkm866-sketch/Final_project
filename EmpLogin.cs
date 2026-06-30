using Microsoft.Data.SqlClient;
using System.Data;
namespace Final_project
{
    public partial class EmpLogin : Form
    {
        public EmpLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox3.Clear();
            textBox4.Focus();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");

            if (textBox4.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("enter username and password");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("enter usrename");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Enter a password");
            }
            else
            {
                string EmpID, EmpNum;
                EmpID = textBox4.Text;
                EmpNum = textBox3.Text;

                try
                {
                    string qurry = "SELECT * FROM emp_login WHERE EmpID='" + textBox4.Text + "'AND EmpNum='" + textBox3.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(qurry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        EmpID = textBox4.Text;
                        EmpNum = textBox3.Text;
                        MessageBox.Show("login succesfully");

                       EmpMng e1=new EmpMng();
                        e1.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("invalid login details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox4.Clear();
                        textBox3.Clear();
                        textBox4.Focus();


                    }
                }
                catch
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    conn.Close();
                }

            }

        }
    }
}
