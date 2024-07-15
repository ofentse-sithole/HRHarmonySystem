using HRHarmonySystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRHarmonySystem
{
    public partial class Salary : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public Salary()
        {
            InitializeComponent();

            //GridView
            displayEmployeeData();
            displayEmployeeSalary();

            disableFields();
        }

        //Grid View Data that will display in the database
        public void displayEmployeeSalary()
        {
            SalaryData data = new SalaryData();
            List<SalaryData> employeeData = data.SalaryemployeeListData();

            dataGridView1.DataSource = employeeData;

            
        }

        //Employee Data
        public void displayEmployeeData()
        {
            EmployeeData employeeData1 = new EmployeeData();
            List<EmployeeData> listData = employeeData1.employeeListData();
            dataGridView1.DataSource = listData;
        }

        //updating the salary of the employee
        private void Salarybtn_Update_Click(object sender, EventArgs e)
        {
            if (Salarytxt_EmployeeID.Text == ""
                || Salarytxt_fullName.Text == ""
                || Salarytxt_position.Text == ""
                || Salarytxt_salary.Text == "" )
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update Employee ID:" + Salarytxt_EmployeeID.Text.Trim() + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {

                        DateTime date = DateTime.Today;
                        if(connect.State == ConnectionState.Closed)
                        {

                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE employee SET  Salary = @salary,  update_date = @update_date WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", Salarytxt_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@update_date", date);
                                cmd.Parameters.AddWithValue("@employeeID", Salarytxt_EmployeeID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                //will appear automatcically when you done updating on the GridView        
                                displayEmployeeSalary();

                                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
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
                    else
                    {
                        MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
        
            }

        }

        //clear all the fields
        private void clearFields()
        {
            Salarytxt_EmployeeID.Text = "";
            Salarytxt_fullName.Text = "";
            Salarytxt_position.Text = "";
            Salarytxt_salary.Text = "";
        }

        //disables the fields within the program
        private void disableFields()
        {
            Salarytxt_EmployeeID.Enabled = false;
            Salarytxt_fullName.Enabled = false;
            Salarytxt_position.Enabled = false;
        }

        //Gridview making the cells clickable
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Salarytxt_EmployeeID.Text = row.Cells[0].Value.ToString();
                Salarytxt_fullName.Text = row.Cells[1].Value.ToString();
                Salarytxt_position.Text = row.Cells[2].Value.ToString();
                Salarytxt_salary.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Salarybtn_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
