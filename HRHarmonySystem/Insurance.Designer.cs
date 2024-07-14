namespace HRHarmonySystem
{
    partial class Insurance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insurance_employeeId = new System.Windows.Forms.TextBox();
            this.insurance_full_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insurance_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insurance_package = new System.Windows.Forms.ComboBox();
            this.insurance_updatebtn = new System.Windows.Forms.Button();
            this.insurance_clearbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insurance_cover = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(31, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.insurance_cover);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.insurance_clearbtn);
            this.panel2.Controls.Add(this.insurance_updatebtn);
            this.panel2.Controls.Add(this.insurance_package);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.insurance_phone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.insurance_full_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.insurance_employeeId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 452);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "HR  Harmony Insurance Cover";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // insurance_employeeId
            // 
            this.insurance_employeeId.Location = new System.Drawing.Point(30, 57);
            this.insurance_employeeId.Name = "insurance_employeeId";
            this.insurance_employeeId.Size = new System.Drawing.Size(199, 22);
            this.insurance_employeeId.TabIndex = 1;
            // 
            // insurance_full_name
            // 
            this.insurance_full_name.Location = new System.Drawing.Point(30, 130);
            this.insurance_full_name.Name = "insurance_full_name";
            this.insurance_full_name.Size = new System.Drawing.Size(199, 22);
            this.insurance_full_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // insurance_phone
            // 
            this.insurance_phone.Location = new System.Drawing.Point(30, 206);
            this.insurance_phone.Name = "insurance_phone";
            this.insurance_phone.Size = new System.Drawing.Size(199, 22);
            this.insurance_phone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Package:";
            // 
            // insurance_package
            // 
            this.insurance_package.FormattingEnabled = true;
            this.insurance_package.Items.AddRange(new object[] {
            "Basic Plan",
            "Standard Plan",
            "Premium Plan"});
            this.insurance_package.Location = new System.Drawing.Point(30, 352);
            this.insurance_package.Name = "insurance_package";
            this.insurance_package.Size = new System.Drawing.Size(199, 24);
            this.insurance_package.TabIndex = 7;
            // 
            // insurance_updatebtn
            // 
            this.insurance_updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insurance_updatebtn.Location = new System.Drawing.Point(30, 402);
            this.insurance_updatebtn.Name = "insurance_updatebtn";
            this.insurance_updatebtn.Size = new System.Drawing.Size(85, 32);
            this.insurance_updatebtn.TabIndex = 8;
            this.insurance_updatebtn.Text = "Update";
            this.insurance_updatebtn.UseVisualStyleBackColor = false;
            this.insurance_updatebtn.Click += new System.EventHandler(this.insurance_updatebtn_Click);
            // 
            // insurance_clearbtn
            // 
            this.insurance_clearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insurance_clearbtn.Location = new System.Drawing.Point(189, 402);
            this.insurance_clearbtn.Name = "insurance_clearbtn";
            this.insurance_clearbtn.Size = new System.Drawing.Size(85, 32);
            this.insurance_clearbtn.TabIndex = 9;
            this.insurance_clearbtn.Text = "Clear";
            this.insurance_clearbtn.UseVisualStyleBackColor = false;
            this.insurance_clearbtn.Click += new System.EventHandler(this.insurance_clearbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 383);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // insurance_cover
            // 
            this.insurance_cover.FormattingEnabled = true;
            this.insurance_cover.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.insurance_cover.Location = new System.Drawing.Point(30, 278);
            this.insurance_cover.Name = "insurance_cover";
            this.insurance_cover.Size = new System.Drawing.Size(199, 24);
            this.insurance_cover.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Insurance Cover:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRHarmonySystem.Properties.Resources.download_icon_hospital_1329858340992289917_32;
            this.pictureBox1.Location = new System.Drawing.Point(39, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Insurance";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox insurance_package;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox insurance_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insurance_full_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox insurance_employeeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insurance_clearbtn;
        private System.Windows.Forms.Button insurance_updatebtn;
        private System.Windows.Forms.ComboBox insurance_cover;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
