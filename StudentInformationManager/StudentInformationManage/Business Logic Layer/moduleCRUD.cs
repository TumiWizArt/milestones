using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManage.Business_Logic_Layer
{
    internal class moduleCRUD
    {
        //create
        public void CreateModule(string moduleCode, string moduleName, string description, string links, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand com = new SqlCommand("createModule", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@moduleCode", moduleCode);
                com.Parameters.AddWithValue("@name", moduleName);
                com.Parameters.AddWithValue("@description", description);
                com.Parameters.AddWithValue("@links", links);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand viewCom = new SqlCommand("viewModuleTable", conn);
                viewCom.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(viewCom))
                {
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    moduleDVG.DataSource = dataTable;
                }

            }
        }


        //view
        public void ReadModule(DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";

            try
            {
                using (SqlConnection conn = new SqlConnection(server))
                {
                    SqlCommand viewCom = new SqlCommand("viewModuleTable", conn);
                    viewCom.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(viewCom))
                    {
                        DataTable dataTable = new DataTable();

                        conn.Open();
                        adapter.Fill(dataTable);
                        conn.Close();

                        moduleDVG.DataSource = dataTable;
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //search
        public void SearchModule(string moduleCode, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";
            string query = $"SELECT * FROM Module WHERE ModuleCode LIKE '{moduleCode}%'";
            
            SqlDataAdapter d = new SqlDataAdapter(query,server);

            DataTable dataTable = new DataTable();

           
            d.Fill(dataTable);
            moduleDVG.DataSource= dataTable;
            
        }

        //update
        public void UpdateModule(string moduleCode, string moduleName, string description, string links, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand uCom = new SqlCommand("updateModule", conn);
                uCom.CommandType = CommandType.StoredProcedure;

                uCom.Parameters.AddWithValue("@moduleCode", moduleCode);
                uCom.Parameters.AddWithValue("@name", moduleName);
                uCom.Parameters.AddWithValue("@description", description);
                uCom.Parameters.AddWithValue("@links", links);

                conn.Open();
                uCom.ExecuteNonQuery();
                conn.Close();

            }

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand viewCom = new SqlCommand("viewModuleTable", conn);
                viewCom.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(viewCom))
                {
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    moduleDVG.DataSource = dataTable;
                }

            }

        }


        //DELETE
        public void DeleteModule(string moduleCode, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";



            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand uCom = new SqlCommand("deleteModule", conn);
                uCom.CommandType = CommandType.StoredProcedure;

                uCom.Parameters.AddWithValue("@moduleCode", moduleCode);

                conn.Open();
                uCom.ExecuteNonQuery();
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand viewCom = new SqlCommand("viewModuleTable", conn);
                viewCom.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(viewCom))
                {
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    moduleDVG.DataSource = dataTable;
                }

            }
        }



    }
}
