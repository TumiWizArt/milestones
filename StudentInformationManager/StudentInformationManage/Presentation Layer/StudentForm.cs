using StudentInformationManage.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManage.Presentation_Layer
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moduleBTN_Click(object sender, EventArgs e)
        {
            ModuleForm frm = new ModuleForm();
            frm.Show();
            this.Hide();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void readBTN_Click(object sender, EventArgs e)
        {
            studentCRUD crud = new studentCRUD();

            crud.ReadStudents(studentsDVG);
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            string studentName = nameTBX.Text;
            string studentSurname = surnameTBX.Text;
            string phone = phoneTBX.Text;
            string address = addressTBX.Text;
            string gender = null;
            string modules = null;
            // = moduleLBX.SelectedItem.ToString();

            if (maleRBX.Checked)
            {
                gender = "Male";
            }
            else if (femaleRBX.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "rather not say";
            }

            //MULTIPLE SELECTIONS

            if (moduleLBX.SelectedItems.Count > 0)
            {

                List<string> modulesList = new List<string>();

                foreach (var item in moduleLBX.SelectedItems)
                {
                    modulesList.Add(item.ToString());
                }

                string[] modulesArray = modulesList.ToArray();

                modules = string.Join(",", modulesArray);
            }


            //Date
            DateTime datePicked = dobDTP.Value;
            string DOB = datePicked.ToString("yyyy-MM-dd");
            //----------------------------------------------------------------------------------------------------------


            studentCRUD crud = new studentCRUD();
            try
            {
                crud.CreateStudent(studentName, studentSurname, DOB, gender, phone, address, modules, studentsDVG);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void studentsDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.studentsDVG.Rows[e.RowIndex];
            studentNumber.Text = row.Cells["StdNumber"].Value.ToString();
            nameTBX.Text = row.Cells["Name"].Value.ToString();
            surnameTBX.Text = row.Cells["Surname"].Value.ToString();
            phoneTBX.Text = row.Cells["Phone"].Value.ToString();
            addressTBX.Text = row.Cells["Address"].Value.ToString();

            if (row.Cells["Gender"].Value.ToString() == "Male")
            {
                femaleRBX.Checked = false;
                maleRBX.Checked = true;
            }

            else if (row.Cells["Gender"].Value.ToString() == "Female")
            {
                maleRBX.Checked = false;
                femaleRBX.Checked = true;
            }


            //List for storing all the modules
            List<string> moduleCodeStored = new List<string>();

            foreach (var item in row.Cells["ModuleCodes"].Value.ToString())
            {
                moduleCodeStored.Add(item.ToString());
            }

            //string[] separate = (row.Cells["ModuleCode"].Value.ToString()).Split(",");

            moduleLBX.SelectedItem = moduleCodeStored.ToArray();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            studentCRUD crud = new studentCRUD();

            string stdNumber = studentNumber.Text;
            crud.DeleteStudent(stdNumber, studentsDVG);
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            
            string stdNumber = studentNumber.Text;
            string studentName = nameTBX.Text;
            string studentSurname = surnameTBX.Text;
            string phone = phoneTBX.Text;
            string address = addressTBX.Text;
            string gender = null;
            string modules = null;
            // = moduleLBX.SelectedItem.ToString();

            if (maleRBX.Checked)
            {
                gender = "Male";
            }
            else if (femaleRBX.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "rather not say";
            }

            //MULTIPLE SELECTIONS

            if (moduleLBX.SelectedItems.Count > 0)
            {

                List<string> modulesList = new List<string>();

                foreach (var item in moduleLBX.SelectedItems)
                {
                    modulesList.Add(item.ToString());
                }

                string[] modulesArray = modulesList.ToArray();

                modules = string.Join(",", modulesArray);
            }


            //Date
            DateTime datePicked = dobDTP.Value;
            string DOB = datePicked.ToString("yyyy-MM-dd");
            //----------------------------------------------------------------------------------------------------------
            try
            {
                studentCRUD crud = new studentCRUD();
                crud.UpdateStudent(stdNumber, studentName, studentSurname, DOB, gender, phone, address, modules, studentsDVG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select a module before proceeding");
            }


        }

        private void studentSearchTBX_TextChanged(object sender, EventArgs e)
        {
            studentCRUD crud = new studentCRUD();
            string stNumber = studentNumber.Text;

            crud.SearchStudent(stNumber, studentsDVG);
        }
    }
}
