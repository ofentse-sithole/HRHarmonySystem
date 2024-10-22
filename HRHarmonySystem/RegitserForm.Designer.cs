﻿namespace HRHarmonySystem
{
    partial class RegitserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegitserForm));
            this.register_btn = new System.Windows.Forms.Button();
            this.register_showPassword = new System.Windows.Forms.CheckBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.register_signInBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(275, 338);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(76, 32);
            this.register_btn.TabIndex = 16;
            this.register_btn.Text = "SIGN UP";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_showPassword
            // 
            this.register_showPassword.AutoSize = true;
            this.register_showPassword.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPassword.Location = new System.Drawing.Point(442, 303);
            this.register_showPassword.Name = "register_showPassword";
            this.register_showPassword.Size = new System.Drawing.Size(120, 20);
            this.register_showPassword.TabIndex = 15;
            this.register_showPassword.Text = "Show Password";
            this.register_showPassword.UseVisualStyleBackColor = true;
            this.register_showPassword.CheckedChanged += new System.EventHandler(this.register_showPassword_CheckedChanged);
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(280, 258);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(296, 22);
            this.register_password.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // register_username
            // 
            this.register_username.Location = new System.Drawing.Point(284, 149);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(296, 22);
            this.register_username.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Register Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.register_signInBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 445);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRHarmonySystem.Properties.Resources.download_icon_employee_job_seeker_unemployee_work_icon_1320184368523588852_128;
            this.pictureBox1.Location = new System.Drawing.Point(38, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 155);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employee Management System";
            // 
            // register_signInBtn
            // 
            this.register_signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.register_signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_signInBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.register_signInBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.register_signInBtn.Location = new System.Drawing.Point(47, 335);
            this.register_signInBtn.Name = "register_signInBtn";
            this.register_signInBtn.Size = new System.Drawing.Size(123, 35);
            this.register_signInBtn.TabIndex = 1;
            this.register_signInBtn.Text = "SIGN IN";
            this.register_signInBtn.UseVisualStyleBackColor = false;
            this.register_signInBtn.Click += new System.EventHandler(this.register_signInBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(44, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login you Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(562, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 22);
            this.exit.TabIndex = 17;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // RegitserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 445);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.register_showPassword);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegitserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegitserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.CheckBox register_showPassword;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button register_signInBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exit;
    }
}