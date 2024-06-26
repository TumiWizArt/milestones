using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace StudentInformationManage.Business_Logic_Layer
{
    internal class studentCRUD
    {
        //VIEW
        public void ReadStudents(DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";


            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand viewCom = new SqlCommand("viewStudentTable", conn);
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


        //CREATE
        public void CreateStudent(string name, string surname, string dob, string gender, string phone, string address, string moduleCode, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand com = new SqlCommand("StoreStudent", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@surname", surname);
                com.Parameters.AddWithValue("@dob", dob);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@phone", phone);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@moduleCodes", moduleCode);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand viewCom = new SqlCommand("viewStudentTable", conn);
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
        public void DeleteStudent(string StdNumber, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";



            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand uCom = new SqlCommand("deleteStudentTable", conn);
                uCom.CommandType = CommandType.StoredProcedure;

                uCom.Parameters.AddWithValue("@stdNumber", StdNumber);

                conn.Open();
                uCom.ExecuteNonQuery();
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand viewCom = new SqlCommand("viewStudentTable", conn);
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


        //UPDATE

        public void UpdateStudent(string StdNumber, string name, string surname, string dob, string gender, string phone, string address, string moduleCode, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";

            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand com = new SqlCommand("updateStudentTable", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@stdNumber", StdNumber);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@surname", surname);
                com.Parameters.AddWithValue("@dob", dob);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@phone", phone);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@moduleCodes", moduleCode);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }



            using (SqlConnection conn = new SqlConnection(server))
            {
                SqlCommand viewCom = new SqlCommand("viewStudentTable", conn);
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

        //SEARCH
        public void SearchStudent(string stdNumber, DataGridView moduleDVG)
        {
            string server = "Server = .; Initial Catalog = BelgiumCampusData; Integrated Security = SSPI";
            string query = $"SELECT * FROM Student WHERE StdNumber LIKE '{stdNumber}%'";

            SqlDataAdapter d = new SqlDataAdapter(query, server);

            DataTable dataTable = new DataTable();


            d.Fill(dataTable);
            moduleDVG.DataSource = dataTable;

        }



    }
}
