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
using StudentInformationManage.Presentation_Layer;

namespace StudentInformationManage.Presentation_Layer
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            SignupUser signupUser = new SignupUser();
            string username = registerUsernameTBX.Text;
            string password = registerPasswordTBX.Text;

            signupUser.SignUp(username, password);

            StudentForm studentForm = new StudentForm();

            studentForm.Show();
            this.Hide();
        }

        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
