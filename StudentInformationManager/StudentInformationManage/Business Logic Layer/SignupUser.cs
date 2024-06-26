using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationManage.Presentation_Layer;
using System.IO;

namespace StudentInformationManage.Business_Logic_Layer
{
    internal class SignupUser
    {
        string path = @"users.txt";

        public void SignUp(string username, string password)
        {
            string textToBeWritten = $"{username}, {password}\n";

            File.AppendAllText(path, textToBeWritten);

        }
    }
}
