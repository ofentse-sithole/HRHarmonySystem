using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//database
using System.Data;
using System.Data.SqlClient;

namespace HRHarmonySystem
{
    internal class EmployeeData
    {

        public int ID { get; set; } //0
        public int EmployeeID { get; set; } //1
        public string FullName { get; set; } //2 
        public string Gender { get; set; } //3 
        public string Contact_Number { get; set; }//4
        public string Position { get; set; } //5
        public string Image { get; set; } //6
        public int Salary { get; set; } //7
        public string Status { get; set; } //8


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> employeeList = new List<EmployeeData>();

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
                            EmployeeData employeeData = new EmployeeData();
                            employeeData.ID = (int)reader["id"];
                            employeeData.EmployeeID = (int)reader["employee_id"];
                            employeeData.FullName = reader["full_name"].ToString();
                            employeeData.Gender = reader["gender"].ToString();
                            employeeData.Contact_Number = reader["contact_number"].ToString();
                            employeeData.Position = reader["position"].ToString();
                            employeeData.Image = reader["image"].ToString();
                            employeeData.Salary = (int)reader["salary"];
                            employeeData.Status = reader["status"].ToString();

                            employeeList.Add(employeeData);
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
