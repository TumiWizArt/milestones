using Microsoft.Win32;
using StudentInformationManage.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInformationManage.Business_Logic_Layer;

namespace StudentInformationManage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignupForm register = new SignupForm();

            this.Hide();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            LoginUser loginUser = new LoginUser();

            string username = usernameTXB.Text;
            string password = passwordTXB.Text;
            

            bool proceed = loginUser.Login(loginUser.CheckingUsernamePassword(username, password));
            

            if (proceed)
            {
                studentForm.Show();
                this.Hide();
            }
            else { errorLabel.Text = "The details you have entered are incorect"; }
            
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTXB_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = null;
        }

        private void usernameTXB_MouseClick(object sender, MouseEventArgs e)
        {
            errorLabel.Text = null;
            usernameTXB.Text = null;
            passwordTXB.Text = null;

        }
    }
}
