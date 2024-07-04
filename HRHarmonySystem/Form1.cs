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
    public partial class Form1 : Form
    {

        //SQL Connection
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ofentse\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegitserForm registerForm = new RegitserForm();
            registerForm.Show();
            this.Hide();

        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text.Trim() == "" || login_password.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                try
                {

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
