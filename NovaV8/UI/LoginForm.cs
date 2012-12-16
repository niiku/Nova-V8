using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaV8
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = UserService.FindUserByName(username.Text);
            if (user != null)
            {
                if (user.rightPassword(password.Text))
                {
                    base.Hide();
                    Reports reports = new Reports();
                    reports.Visible = true;
                }
                else
                {
                    MessageBox.Show("Password is not correct for user " + username.Text, "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Username does not exist in Database", "Login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
