using lab8_student.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_student
{
    public partial class frmLogin : Form
    {
        private CanBoController canBoController = new CanBoController();

        public frmLogin()
        {
            InitializeComponent();
            tbUserName.Text = "001";
            tbPwd.Text = "123";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbUserName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Length == 0 || tbPwd.Text.Length == 0)
            {
                MessageBox.Show("User name and password are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                LoginController loginController = new LoginController();
                SqlDataReader reader = loginController.Login(tbUserName.Text, tbPwd.Text);
                if (reader == null)
                {
                    MessageBox.Show("Error when retriving data login");
                }
                else if (reader.HasRows)
                {
                    this.Hide();
                    frmStudent mainForm = new frmStudent();
                    mainForm.Closed += (s, args) => this.Close(); 
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPwd.Clear();
                }
            }
        }
    }
}
