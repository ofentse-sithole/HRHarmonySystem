using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HRHarmonySystem.Class
{
    internal class InsuranceData
    {
        public int EmployeeID { get; set; } //0
        public string FullName { get; set; } //1 
        public string Phone_Number { get; set; } //2
        public string Insurance_Cover { get; set; }//3
        public string insurance_Package { get; set; } //4


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<InsuranceData> insurnaceData()
        {
            List<InsuranceData> employeeList = new List<InsuranceData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM employee WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            //reads from the database
                            InsuranceData insurnace_data = new InsuranceData();
                            insurnace_data.EmployeeID = (int)reader["employee_id"];
                            insurnace_data.FullName = reader["full_name"].ToString();
                            insurnace_data.Phone_Number = reader["contact_number"].ToString();
                            insurnace_data.Insurance_Cover = reader["insurance_cover"].ToString();
                            insurnace_data.insurance_Package = reader["insurance_package"].ToString();

                            employeeList.Add(insurnace_data);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
            return employeeList;
        }
    }
}
