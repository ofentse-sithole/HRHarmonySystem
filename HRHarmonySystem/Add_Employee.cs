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
using System.Runtime.InteropServices;

namespace HRHarmonySystem
{
    public partial class Add_Employee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

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

                            checkEmployee.Parameters.AddWithValue("@emID", addEmployee_id.Text.Trim());

                            int count = (int)checkEmployee.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO employee( employee_id, full_name, gender, contact_number, position, image, salary, insert_date, status)" +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum, @position, @image, @salary, @insertData, @status)";


                                DateTime date = DateTime.Today;

                                //addin an image in the directory folder
                                string path = Path.Combine(@"C:\Users\Ofentse\source\repos\HRHarmonySystem\HRHarmonySystem\Directory\"
                                                            + addEmployee_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_ImageBox.ImageLocation, path, true);

                                //cmd that adds within the database
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    

                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_Name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_Gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmployee_Phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertData", date);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_Status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayData();


                                    MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    ClearField();
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

        //Import image 
        private void addEmployee_ImportImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialogImages = new OpenFileDialog();
                dialogImages.Filter = "Image Files( *.jpg; *jpeg; *png;) | *.jpg; *jpeg; *png;";
                string imagePath = "";

                if (dialogImages.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialogImages.FileName;
                    addEmployee_ImageBox.ImageLocation = imagePath;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                addEmployee_id.Text = row.Cells[1].Value.ToString();
                addEmployee_Name.Text = row.Cells[2].Value.ToString();
                addEmployee_Gender.Text = row.Cells[3].Value.ToString();
                addEmployee_Phone.Text = row.Cells[4].Value.ToString();
                addEmployee_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if(imagePath != null)
                {

                   addEmployee_ImageBox.ImageLocation = imagePath;
                }
                else
                {
                    addEmployee_ImageBox.Image = null;
                }

                addEmployee_Status.Text = row.Cells[8].Value.ToString();
            }
        }


        //clear filed
        public void ClearField()
        {
            addEmployee_id.Text = "";
            addEmployee_Name.Text = "";
            addEmployee_Gender.SelectedIndex = -1;
            addEmployee_position.SelectedIndex = -1;
            addEmployee_Status.SelectedIndex = -1;
            addEmployee_Phone.Text = "";
            addEmployee_ImageBox.Image = null;

        }

        //update button
        private void addEmployee_Update_Click(object sender, EventArgs e)
        {

            if (addEmployee_id.Text == ""
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
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update Employee ID:" + addEmployee_id.Text.Trim() + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {

                    DateTime date = DateTime.Today;

                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE employee SET full_name = @fullName, gender = @gender, " +
                            "contact_number = @contactNum, position = @position,  update_date = @update_date,  status = @status" +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullName", addEmployee_Name.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmployee_Gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", addEmployee_Phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());

                            cmd.Parameters.AddWithValue("@update_date", date);
                            cmd.Parameters.AddWithValue("@status", addEmployee_Status.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayData();

                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearField();
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

                }
                
            }
        }

        //Delete button
        private void addEmployee_Delete_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
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
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Employee ID:" + addEmployee_id.Text.Trim() + " ?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {

                    DateTime date = DateTime.Today;

                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE employee SET delete_date = @delete_date" +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@delete", date);

                            cmd.ExecuteNonQuery();

                            displayData();

                            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearField();
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

                }
            }
        }

        private void addEmployee_Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
