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
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(53, 52);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(227, 25);
            txtFullName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(53, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 25);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(53, 161);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 25);
            txtPhone.TabIndex = 2;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(53, 220);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(227, 25);
            txtCurrentPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(53, 282);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(227, 25);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(53, 343);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(227, 25);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(53, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(267, 25);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(326, 394);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(267, 25);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 9;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 141);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 11;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 200);
            label4.Name = "label4";
            label4.Size = new Size(227, 17);
            label4.TabIndex = 12;
            label4.Text = "Current password (only if changing it)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 262);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 13;
            label5.Text = "New password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 323);
            label6.Name = "label6";
            label6.Size = new Size(142, 17);
            label6.TabIndex = 14;
            label6.Text = "Confirm new password";
            // 
            // CashierProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 452);
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
            Name = "CashierProfileForm";
            Text = "CashierProfileForm";
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
    }
}