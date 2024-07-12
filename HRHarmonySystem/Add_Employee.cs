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
    public partial class Add_Employee : UserControl
    {
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

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
