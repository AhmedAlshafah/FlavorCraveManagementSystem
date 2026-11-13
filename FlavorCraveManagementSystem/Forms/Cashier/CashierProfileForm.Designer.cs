namespace FlavorCraveManagementSystem.Forms.Cashier
{
    partial class CashierProfileForm
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
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pnlHeader = new Panel();
            label9 = new Label();
            lblBrand = new Label();
            lblPageTitle = new Label();
            lblPageSubtitle = new Label();
            lblAccountInfo = new Label();
            lblPasswordSection = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(40, 240);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(380, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 310);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(40, 380);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(380, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(460, 240);
            txtCurrentPassword.Margin = new Padding(3, 4, 3, 4);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(380, 27);
            txtCurrentPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(460, 310);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(380, 27);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(460, 380);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(380, 27);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(214, 165, 70);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(40, 450);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 38);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(38, 48, 45);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(220, 450);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(305, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Back to Dashboard";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 215);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 9;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 285);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 355);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 11;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 215);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 12;
            label4.Text = "Current Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 285);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "New Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 355);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 14;
            label6.Text = "Confirm New Password";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 70, 55);
            pnlHeader.Controls.Add(label9);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(882, 74);
            pnlHeader.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(637, 21);
            label9.Name = "label9";
            label9.Size = new Size(200, 37);
            label9.TabIndex = 4;
            label9.Text = "MY PROFILE";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(20, 21);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(268, 42);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "FLAVOR CRAVE";
            lblBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.Location = new Point(40, 94);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(186, 46);
            lblPageTitle.TabIndex = 16;
            lblPageTitle.Text = "My Profile";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageSubtitle.Location = new Point(40, 138);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(298, 23);
            lblPageSubtitle.TabIndex = 17;
            lblPageSubtitle.Text = "View and update your account details";
            // 
            // lblAccountInfo
            // 
            lblAccountInfo.AutoSize = true;
            lblAccountInfo.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountInfo.Location = new Point(40, 180);
            lblAccountInfo.Name = "lblAccountInfo";
            lblAccountInfo.Size = new Size(239, 31);
            lblAccountInfo.TabIndex = 18;
            lblAccountInfo.Text = "Account Information";
            // 
            // lblPasswordSection
            // 
            lblPasswordSection.AutoSize = true;
            lblPasswordSection.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordSection.Location = new Point(460, 180);
            lblPasswordSection.Name = "lblPasswordSection";
            lblPasswordSection.Size = new Size(313, 31);
            lblPasswordSection.TabIndex = 19;
            lblPasswordSection.Text = "Change Password (optional)";
            // 
            // CashierProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(882, 628);
            Controls.Add(lblPasswordSection);
            Controls.Add(lblAccountInfo);
            Controls.Add(lblPageSubtitle);
            Controls.Add(lblPageTitle);
            Controls.Add(pnlHeader);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashierProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - My Profile";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel pnlHeader;
        private Label lblBrand;
        private Label label9;
        private Label lblPageTitle;
        private Label lblPageSubtitle;
        private Label lblAccountInfo;
        private Label lblPasswordSection;
    }
}