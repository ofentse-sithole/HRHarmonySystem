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
using HRHarmonySystem.Class;

namespace HRHarmonySystem
{
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Dashboard()
        {
            InitializeComponent();
            
            DashboardDisplayTE();
            DashboardDisplayAE();
            DashboardDisplayIE();
            DashboardDisplayINE();
            DashboardDisplayNIE();


        }

        //Refresh Data
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DashboardDisplayTE();
            DashboardDisplayAE();
            DashboardDisplayIE();
            DashboardDisplayINE();
            DashboardDisplayNIE();
        }

        //TOTAL EMPLOYEES
        public void DashboardDisplayTE()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employee WHERE delete_date IS NULL";

                    //used to count amount users
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TE.Text = count.ToString();

                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        //ACTIVE EMPLOYEES
        public void DashboardDisplayAE()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employee WHERE status = @status AND delete_date IS NULL";

                    //used to count amount users
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            

                            int count = Convert.ToInt32(reader[0]);
                            Dashboard_AE.Text = count.ToString();

                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        //INACTIVE EMPLOYEES
        public void DashboardDisplayIE()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employee WHERE status = @status AND delete_date IS NULL";

                    //used to count amount users
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            Dashboard_IE.Text = count.ToString();

                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        //Insured Employees
        public void DashboardDisplayINE()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employee WHERE insurance_cover = @insurance_cover AND delete_date IS NULL";

                    //used to count amount users
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@insurance_cover", "Yes");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            Insured_Employeetxt.Text = count.ToString();

                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        //Not Insured Employees
        public void DashboardDisplayNIE()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employee WHERE insurance_cover = @insurance_cover AND delete_date IS NULL";

                    //used to count amount users
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@insurance_cover", "No");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            NotInsured_Employeetxt.Text = count.ToString();

                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NotInsured_Employeetxt_Click(object sender, EventArgs e)
        {

        }
    }
}
