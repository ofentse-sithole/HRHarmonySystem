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
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Dashboard()
        {
            InitializeComponent();
        }

        //TOTAL EMPLOYEES
        public void DashboardDisplayTE()
        {
            if (connect.State != ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL";

                    //used to count amount users
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            Dashboard_TE.Text = count.ToString();

                        }
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
            if (connect.State != ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

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
            if (connect.State != ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

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
    }
}
