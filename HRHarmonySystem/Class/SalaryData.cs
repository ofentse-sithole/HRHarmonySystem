using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HRHarmonySystem.Class
{
    internal class SalaryData
    {
        public int EmployeeID { get; set; } //0
        public string FullName { get; set; } //1 
        public string Position { get; set; } //2
        public int Salary { get; set; } //3


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");


        //Salary Employee Data
        public List<SalaryData> SalaryemployeeListData()
        {
            List<SalaryData> employeeList = new List<SalaryData>();

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
                            SalaryData sd = new SalaryData();
                            sd.EmployeeID = (int)reader["employee_id"];
                            sd.FullName = reader["full_name"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Salary = (int)reader["salary"];

                            employeeList.Add(sd);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
