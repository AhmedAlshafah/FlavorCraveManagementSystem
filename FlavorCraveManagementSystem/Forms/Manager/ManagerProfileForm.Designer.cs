namespace FlavorCraveManagementSystem.Forms.Manager
{
    partial class ManagerProfileForm
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
            lblFullName = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnUpdateProfile = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(32, 219);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(66, 17);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 292);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 355);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(32, 240);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(238, 25);
            txtFullName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 312);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 25);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(32, 375);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(238, 25);
            txtPhone.TabIndex = 5;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.FromArgb(214, 165, 70);
            btnUpdateProfile.FlatAppearance.BorderSize = 0;
            btnUpdateProfile.FlatStyle = FlatStyle.Flat;
            btnUpdateProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfile.Location = new Point(165, 461);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(128, 26);
            btnUpdateProfile.TabIndex = 6;
            btnUpdateProfile.Text = "Save Changes";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 74);
            panel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(667, 22);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 1;
            label7.Text = "MY PROFILE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(32, 22);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 0;
            label6.Text = "FLAVOR CRAVE";
            // 
            // button1
            // 
            button1.Location = new Point(399, 461);
            button1.Name = "button1";
            button1.Size = new Size(128, 26);
            button1.TabIndex = 8;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 77);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 8;
            label1.Text = "My Profile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(6, 119);
            label4.Name = "label4";
            label4.Size = new Size(227, 17);
            label4.TabIndex = 9;
            label4.Text = "View and update your account details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 179);
            label5.Name = "label5";
            label5.Size = new Size(169, 21);
            label5.TabIndex = 10;
            label5.Text = "Account Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(387, 182);
            label8.Name = "label8";
            label8.Size = new Size(208, 20);
            label8.TabIndex = 11;
            label8.Text = "Change Password (Optional)";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(398, 242);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(238, 25);
            txtCurrentPassword.TabIndex = 12;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(397, 316);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(239, 25);
            txtNewPassword.TabIndex = 13;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(397, 375);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(237, 25);
            txtConfirmNewPassword.TabIndex = 14;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(399, 219);
            label9.Name = "label9";
            label9.Size = new Size(111, 17);
            label9.TabIndex = 15;
            label9.Text = "Current Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(397, 292);
            label10.Name = "label10";
            label10.Size = new Size(94, 17);
            label10.TabIndex = 16;
            label10.Text = "New Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(399, 353);
            label11.Name = "label11";
            label11.Size = new Size(144, 17);
            label11.TabIndex = 17;
            label11.Text = "Confirm New Password";
            // 
            // ManagerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 636);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(btnUpdateProfile);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ManagerProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - My Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label label2;
        private Label label3;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnUpdateProfile;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label6;
        private Button button1;
        private Label label5;
        private Label label8;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmNewPassword;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}