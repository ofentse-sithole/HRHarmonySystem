using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add for database
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;

namespace HRHarmonySystem
{
    public partial class RegitserForm : Form
    {
        //SQL Connection
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public RegitserForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_signInBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            

            if(register_username.Text == "" || register_password.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        //connect to the database
                        connect.Open();

                        //checks if user already exists in the database
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", register_username.Text.Trim());
                            int count = (int)checkUser.ExecuteNonQuery();

                            if (count >=1)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " is already taken", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                DateTime today = DateTime.Today;

                                //add variables
                                string insertData = "INSERT INTO users " +
                                    " (username, password, date_register) " +
                                    "VALUES(@username, @password, @dateReg)";

                                //connect to the database
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //After registration is successful you go to next page
                                    Form1 loginform = new Form1();
                                    loginform.Show();
                                    this.Hide();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
