using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//database
using System.Data;
using System.Data.SqlClient;

//
using System.IO;

namespace HRHarmonySystem
{
    public partial class Add_Employee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ofentse\\OneDrive\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public Add_Employee()
        {
            InitializeComponent();

            //to display data from database to gridview data
            displayData();
        }

        public void displayData() 
        {
            EmployeeData employeeData = new EmployeeData();
            List<EmployeeData> listData = employeeData.employeeListData();

            dataGridView1.DataSource = listData;

        }

        private void addEmployee_Add_Click(object sender, EventArgs e)
        {
            if(addEmployee_id.Text == "" 
                || addEmployee_Name.Text == "" 
                || addEmployee_Gender.Text == ""  
                || addEmployee_Phone.Text == "" 
                || addEmployee_position.Text == "" 
                || addEmployee_Status.Text == ""
                || addEmployee_ImportImage.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string checkEmployeeID = "SELECT COUNT(*) FROM employee WHERE employee_id = @emID";
                        using (SqlCommand checkEmployee = new SqlCommand(checkEmployeeID, connect))
                        {
                            int count = (int)checkEmployee.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO employee( employee_id, full_name, gender, contact_number, position, image, salary, insert_date, status)" +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum, @position, @image, @insertData, @status)";


                                DateTime date = DateTime.Today;

                                string path = Path.Combine(@"C:\Users\Ofentse\source\repos\HRHarmonySystem\HRHarmonySystem\Directory\");

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_Name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_Gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmployee_Phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertData", date);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_Status.Text.Trim());

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
