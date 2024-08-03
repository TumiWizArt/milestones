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

namespace StudentInformationManage.Presentation_Layer
{
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }

        private void ModuleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MLoginBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void MStudentBTN_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }

        private void MReadBTN_Click(object sender, EventArgs e)
        {
            moduleCRUD crud = new moduleCRUD();

            crud.ReadModule(moduleDVG);
        }

        private void MDeleteBTN_Click(object sender, EventArgs e)
        {
            string moduleCodeEntered = moduleCodeTBX.Text;

            moduleCRUD crud = new moduleCRUD();

            crud.DeleteModule(moduleCodeEntered ,moduleDVG);
        }

        private void MCreateBTN_Click(object sender, EventArgs e)
        {
            string moduleCodeEntered = moduleCodeTBX.Text;
            string moduleNameEntered = moduleNameTBX.Text;
            string moduleDescriptionE = descriptionTBX.Text;
            string linksEntered = linkTBX.Text;

            moduleCRUD crud = new moduleCRUD();

            crud.CreateModule(moduleCodeEntered, moduleNameEntered, moduleDescriptionE, linksEntered, moduleDVG);
        }

        private void MUpdateBTN_Click(object sender, EventArgs e)
        {
            string moduleCodeEntered = moduleCodeTBX.Text;
            string moduleNameEntered = moduleNameTBX.Text;
            string moduleDescriptionE = descriptionTBX.Text;
            string linksEntered = linkTBX.Text;

            moduleCRUD crud = new moduleCRUD();

            crud.UpdateModule(moduleCodeEntered, moduleNameEntered, moduleDescriptionE, linksEntered, moduleDVG);
        }

        private void searchTBX_TextChanged(object sender, EventArgs e)
        {
            string searchEntered = searchTBX.Text;

            moduleCRUD crud = new moduleCRUD();

            crud.SearchModule(searchEntered, moduleDVG);
        }

        private void moduleDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.moduleDVG.Rows[e.RowIndex];
            moduleCodeTBX.Text = row.Cells["ModuleCode"].Value.ToString();
            moduleNameTBX.Text = row.Cells["Name"].Value.ToString();
            descriptionTBX.Text = row.Cells["Description"].Value.ToString();
            linkTBX.Text = row.Cells["Links"].Value.ToString();
        }
    }
}
