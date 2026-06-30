namespace Final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin a1 = new AdminLogin();
            a1.Show();
        }

        private void employeeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpLogin a1 = new EmpLogin();
            a1.Show();
        }

        private void cuctomerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustLogin c1 = new CustLogin();
            c1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustReg c1 = new CustReg();
            c1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmMng a1 = new AdmMng();
            a1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpMng e1 = new EmpMng();
            e1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustMng c1 = new CustMng();
            c1.Show();
        }
    }
}
