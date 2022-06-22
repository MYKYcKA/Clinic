using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicApp
{
    public partial class LoginPage : Form
    {

        private const string adminLogin = "admin";
        private const string adminPassword = "admin123";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_SignIn_Click(object sender, EventArgs e)
        {
            if (t_password.Text.ToString().Equals(adminPassword) && t_login.Text.ToString().Equals(adminLogin))
            {
                var menu = new ClinicAppMain();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter correct login and password");
                t_password.Text = null;
            }
        }
    }
}
