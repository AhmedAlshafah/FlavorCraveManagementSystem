namespace FlavorCraveManagementSystem.Forms.Admin
{
    partial class AdminProfileForm
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
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtCurrentPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            lblStatus = new Label();
            button1 = new Button();
            label4 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1217, 74);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1082, 36);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 15;
            label1.Text = "PROFILE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(25, 19);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 13;
            label3.Text = "FLAVOR CRAVE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 77);
            label2.Name = "label2";
            label2.Size = new Size(126, 31);
            label2.TabIndex = 4;
            label2.Text = "My Profile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 105);
            label5.Name = "label5";
            label5.Size = new Size(335, 20);
            label5.TabIndex = 5;
            label5.Text = "View and update your personal account details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(27, 187);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 0;
            label6.Text = "Full Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(27, 245);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 1;
            label7.Text = "Email Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.Location = new Point(27, 299);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 2;
            label8.Text = "Phone Number";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtName.Location = new Point(27, 210);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtPhone.Location = new Point(27, 322);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(330, 27);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEmail.Location = new Point(27, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(30, 70, 55);
            btnSave.Location = new Point(27, 445);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F);
            label11.Location = new Point(435, 187);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 7;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F);
            label10.Location = new Point(435, 245);
            label10.Name = "label10";
            label10.Size = new Size(121, 20);
            label10.TabIndex = 8;
            label10.Text = "New Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F);
            label9.Location = new Point(435, 299);
            label9.Name = "label9";
            label9.Size = new Size(185, 20);
            label9.TabIndex = 9;
            label9.Text = "Confirm New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtCurrentPassword.Location = new Point(435, 210);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(330, 27);
            txtCurrentPassword.TabIndex = 10;
            txtCurrentPassword.TextChanged += textBox3_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtConfirmPassword.Location = new Point(435, 322);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(330, 27);
            txtConfirmPassword.TabIndex = 11;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtNewPassword.Location = new Point(435, 268);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(330, 27);
            txtNewPassword.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblStatus.Location = new Point(435, 362);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 13;
            lblStatus.Click += label12_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(585, 435);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 14;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 146);
            label4.Name = "label4";
            label4.Size = new Size(239, 31);
            label4.TabIndex = 15;
            label4.Text = "Account Information";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(435, 146);
            label12.Name = "label12";
            label12.Size = new Size(313, 31);
            label12.TabIndex = 16;
            label12.Text = "Change Password (optional)";
            // 
            // AdminProfileForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 653);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(lblStatus);
            Controls.Add(label5);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(txtConfirmPassword);
            Controls.Add(panel1);
            Controls.Add(txtCurrentPassword);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "AdminProfileForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnSave;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtCurrentPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private Label lblStatus;
        private Button button1;
        private Label label4;
        private Label label12;
    }
}