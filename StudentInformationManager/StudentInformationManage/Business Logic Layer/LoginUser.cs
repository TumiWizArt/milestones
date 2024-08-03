using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using StudentInformationManage.Presentation_Layer;

namespace StudentInformationManage.Business_Logic_Layer
{
    internal class LoginUser
    {
        LoginForm loginForm = new LoginForm();
        string path = @"users.txt";


        public bool CheckingUsernamePassword(string username, string password)
        {

            bool cond = false;


            if (File.Exists(path))
            {
                using (StreamReader lineReader = new StreamReader(path))
                {
                    while (!lineReader.EndOfStream)
                    {
                        string line = lineReader.ReadLine();

                        //usename and password entered by the user
                        string usernamePasswordToBeChecked = $"{username}, {password}";
                        if (usernamePasswordToBeChecked == line)
                        {
                            cond = true;
                        }
                    }
                }
            }

            return cond;
        }

        public bool Login(bool cond)
        {
            bool proceed = false;

            if (cond)
            {
                proceed = true;

            }

           
            return proceed;
        }

    }
}
