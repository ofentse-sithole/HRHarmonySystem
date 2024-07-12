namespace HRHarmonySystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.btn_signout = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salary1 = new HRHarmonySystem.Salary();
            this.add_Employee1 = new HRHarmonySystem.Add_Employee();
            this.dashboard1 = new HRHarmonySystem.Dashboard();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(1063, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(15, 16);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_signout);
            this.panel2.Controls.Add(this.btn_salary);
            this.panel2.Controls.Add(this.btn_employee);
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 564);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome, User";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_signout
            // 
            this.btn_signout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_signout.Image = global::HRHarmonySystem.Properties.Resources.download_icon_exit_to_icon_1320183325651831323_24;
            this.btn_signout.Location = new System.Drawing.Point(15, 516);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(44, 35);
            this.btn_signout.TabIndex = 6;
            this.btn_signout.UseVisualStyleBackColor = false;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salary.Image = global::HRHarmonySystem.Properties.Resources.download_icon_money_1319964824913825503_32;
            this.btn_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salary.Location = new System.Drawing.Point(12, 371);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(199, 53);
            this.btn_salary.TabIndex = 5;
            this.btn_salary.Text = "SALARY";
            this.btn_salary.UseVisualStyleBackColor = false;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_employee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.Image = global::HRHarmonySystem.Properties.Resources.download_icon_add_avatar_human_man_profile_icon_1320085876593184757_32;
            this.btn_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee.Location = new System.Drawing.Point(12, 296);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(199, 54);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "ADD EMPLOYEE";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Image = global::HRHarmonySystem.Properties.Resources.download_icon_dashboard_default_home_house_page_start_icon_1320166550253117697_32;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(12, 223);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(199, 53);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.Text = "DASHBOARD";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRHarmonySystem.Properties.Resources.download_icon_user_icon_1320191245971961880_128;
            this.pictureBox1.Location = new System.Drawing.Point(43, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // salary1
            // 
            this.salary1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salary1.Location = new System.Drawing.Point(225, 35);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(875, 565);
            this.salary1.TabIndex = 2;
            // 
            // add_Employee1
            // 
            this.add_Employee1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_Employee1.Location = new System.Drawing.Point(225, 35);
            this.add_Employee1.Name = "add_Employee1";
            this.add_Employee1.Size = new System.Drawing.Size(875, 565);
            this.add_Employee1.TabIndex = 3;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboard1.Location = new System.Drawing.Point(225, 35);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(875, 565);
            this.dashboard1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "SIGN OUT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.add_Employee1);
            this.Controls.Add(this.salary1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_signout;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Salary salary1;
        private Add_Employee add_Employee1;
        private Dashboard dashboard1;
        private System.Windows.Forms.Label label2;
    }
}