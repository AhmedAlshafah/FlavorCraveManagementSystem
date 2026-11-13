namespace FlavorCraveManagementSystem.Forms.Customer
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConformNewPassword = new TextBox();
            lblStatus = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(918, 31);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MY PROFILE";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(27, 211);
            lblFullName.Margin = new Padding(6, 0, 6, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 23);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(27, 241);
            txtFullName.Margin = new Padding(6, 7, 6, 7);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(410, 32);
            txtFullName.TabIndex = 2;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(27, 281);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(27, 311);
            txtEmail.Margin = new Padding(6, 7, 6, 7);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(410, 32);
            txtEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(28, 360);
            lblPhone.Margin = new Padding(6, 0, 6, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(131, 23);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(28, 390);
            txtPhone.Margin = new Padding(6, 7, 6, 7);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(409, 32);
            txtPhone.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(214, 165, 70);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(27, 497);
            btnSave.Margin = new Padding(6, 7, 6, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(771, 497);
            btnClose.Margin = new Padding(6, 7, 6, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 35);
            btnClose.TabIndex = 8;
            btnClose.Text = "Back to Dashboard";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 74);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(197, 35);
            label1.TabIndex = 1;
            label1.Text = "FLAVOR CRAVE";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(28, 150);
            label3.Name = "label3";
            label3.Size = new Size(298, 23);
            label3.TabIndex = 11;
            label3.Text = "View and update your account details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 96);
            label4.Name = "label4";
            label4.Size = new Size(186, 46);
            label4.TabIndex = 12;
            label4.Text = "My Profile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 173);
            label5.Name = "label5";
            label5.Size = new Size(215, 28);
            label5.TabIndex = 13;
            label5.Text = "Account  Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(489, 173);
            label6.Name = "label6";
            label6.Size = new Size(279, 28);
            label6.TabIndex = 14;
            label6.Text = "Change Password (Optional)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(489, 211);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 15;
            label7.Text = "Current  Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(489, 281);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 16;
            label8.Text = "New Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(489, 362);
            label9.Name = "label9";
            label9.Size = new Size(191, 23);
            label9.TabIndex = 17;
            label9.Text = "Conform New Password";
            label9.Click += label9_Click;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(489, 243);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(410, 30);
            txtCurrentPassword.TabIndex = 18;
            txtCurrentPassword.TextChanged += txtCurrentPassword_TextChanged;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(489, 313);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(410, 30);
            txtNewPassword.TabIndex = 19;
            txtNewPassword.TextChanged += textBox2_TextChanged;
            // 
            // txtConformNewPassword
            // 
            txtConformNewPassword.Location = new Point(489, 392);
            txtConformNewPassword.Name = "txtConformNewPassword";
            txtConformNewPassword.Size = new Size(410, 30);
            txtConformNewPassword.TabIndex = 20;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(489, 425);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 23);
            lblStatus.TabIndex = 21;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(lblStatus);
            Controls.Add(txtConformNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(lblEmail);
            Controls.Add(btnClose);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(lblFullName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "ProfileForm";
            Text = "Flavor crave My Profile";
            Load += ProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConformNewPassword;
        private Label lblStatus;
    }
}