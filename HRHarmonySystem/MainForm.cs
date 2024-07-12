using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRHarmonySystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //exit employee button
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //signout button
        private void btn_signout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();

            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            add_Employee1.Visible = false;
            salary1.Visible = false;
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            add_Employee1.Visible = true;
            salary1.Visible = false;
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            add_Employee1.Visible = false;
            salary1.Visible = true;
        }
    }
}
