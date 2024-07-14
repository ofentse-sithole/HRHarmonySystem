using HRHarmonySystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRHarmonySystem
{
    public partial class Insurance : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public Insurance()
        {
            InitializeComponent();

            DisplayInsuranceData();

            disableFields();
        }

        public void DisplayInsuranceData()
        {

            //Grid View Data that will display in the database
            InsuranceData insurance_data = new InsuranceData();
            List<InsuranceData> employeeData = insurance_data.insurnaceData();
            dataGridView1.DataSource = employeeData;
        }


        private void disableFields()
        {
            insurance_employeeId.Enabled = false;
            insurance_full_name.Enabled = false;
            insurance_phone.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                insurance_employeeId.Text = row.Cells[0].Value.ToString();
                insurance_full_name.Text = row.Cells[1].Value.ToString();
                insurance_phone.Text = row.Cells[2].Value.ToString();
                insurance_cover.Text = row.Cells[3].Value.ToString();
                insurance_package.Text = row.Cells[4].Value.ToString();
            }
        }

        private void clearFields()
        {
            insurance_employeeId.Text = "";
            insurance_full_name.Text = "";
            insurance_phone.Text = "";
            insurance_package.Text = "";
            insurance_cover.Text = "";
        }

        //clear button
        private void insurance_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //updating 
        private void insurance_updatebtn_Click(object sender, EventArgs e)
        {
            if (insurance_employeeId.Text == ""
               || insurance_full_name.Text == ""
               || insurance_phone.Text == ""
               || insurance_cover.Text == ""
               || insurance_package.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update Employee ID:" + insurance_employeeId.Text.Trim() + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {

                    DateTime date = DateTime.Today;
                    if (connect.State == ConnectionState.Closed)
                    {

                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE employee SET  insurance_cover = @insurance_cover, insurance_package = @insurance_cover, update_date = @update_date WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@insurance_cover", insurance_cover.Text.Trim());
                                cmd.Parameters.AddWithValue("@insurance_package", insurance_package.Text.Trim());
                                cmd.Parameters.AddWithValue("@update_date", date);
                                cmd.Parameters.AddWithValue("@employeeID", insurance_employeeId.Text.Trim());

                                cmd.ExecuteNonQuery();

                                //will appear automatcically when you done updating on the GridView        
                                DisplayInsuranceData();

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
    }
}
