namespace HRHarmonySystem
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Salarybtn_Update = new System.Windows.Forms.Button();
            this.Salarybtn_Clear = new System.Windows.Forms.Button();
            this.Salarytxt_salary = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Salarytxt_position = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Salarytxt_fullName = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Salarytxt_EmployeeID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(363, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 505);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee\'s";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 414);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Salarybtn_Update);
            this.panel1.Controls.Add(this.Salarybtn_Clear);
            this.panel1.Controls.Add(this.Salarytxt_salary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Salarytxt_position);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Salarytxt_fullName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Salarytxt_EmployeeID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(35, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 505);
            this.panel1.TabIndex = 4;
            // 
            // Salarybtn_Update
            // 
            this.Salarybtn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Salarybtn_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salarybtn_Update.Location = new System.Drawing.Point(35, 356);
            this.Salarybtn_Update.Name = "Salarybtn_Update";
            this.Salarybtn_Update.Size = new System.Drawing.Size(85, 28);
            this.Salarybtn_Update.TabIndex = 11;
            this.Salarybtn_Update.Text = "Update";
            this.Salarybtn_Update.UseVisualStyleBackColor = false;
            this.Salarybtn_Update.Click += new System.EventHandler(this.Salarybtn_Update_Click);
            // 
            // Salarybtn_Clear
            // 
            this.Salarybtn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Salarybtn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salarybtn_Clear.Location = new System.Drawing.Point(160, 356);
            this.Salarybtn_Clear.Name = "Salarybtn_Clear";
            this.Salarybtn_Clear.Size = new System.Drawing.Size(85, 28);
            this.Salarybtn_Clear.TabIndex = 10;
            this.Salarybtn_Clear.Text = "Clear";
            this.Salarybtn_Clear.UseVisualStyleBackColor = false;
            this.Salarybtn_Clear.Click += new System.EventHandler(this.Salarybtn_Clear_Click);
            // 
            // Salarytxt_salary
            // 
            this.Salarytxt_salary.Location = new System.Drawing.Point(19, 285);
            this.Salarytxt_salary.Name = "Salarytxt_salary";
            this.Salarytxt_salary.Size = new System.Drawing.Size(239, 22);
            this.Salarytxt_salary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salary";
            // 
            // Salarytxt_position
            // 
            this.Salarytxt_position.Location = new System.Drawing.Point(19, 211);
            this.Salarytxt_position.Name = "Salarytxt_position";
            this.Salarytxt_position.Size = new System.Drawing.Size(239, 22);
            this.Salarytxt_position.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position";
            // 
            // Salarytxt_fullName
            // 
            this.Salarytxt_fullName.Location = new System.Drawing.Point(19, 129);
            this.Salarytxt_fullName.Name = "Salarytxt_fullName";
            this.Salarytxt_fullName.Size = new System.Drawing.Size(239, 22);
            this.Salarytxt_fullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // Salarytxt_EmployeeID
            // 
            this.Salarytxt_EmployeeID.Location = new System.Drawing.Point(19, 56);
            this.Salarytxt_EmployeeID.Name = "Salarytxt_EmployeeID";
            this.Salarytxt_EmployeeID.Size = new System.Drawing.Size(239, 22);
            this.Salarytxt_EmployeeID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(328, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 505);
            this.panel2.TabIndex = 1;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Salarybtn_Update;
        private System.Windows.Forms.Button Salarybtn_Clear;
        private System.Windows.Forms.MaskedTextBox Salarytxt_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Salarytxt_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Salarytxt_fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Salarytxt_EmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}
