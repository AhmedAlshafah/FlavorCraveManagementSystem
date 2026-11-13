namespace FlavorCraveManagementSystem.Forms.Chef
{
    partial class ChefProfileForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            btnBackToDashbord = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 248);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 319);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 389);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 271);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(43, 341);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(43, 424);
            txtPhone.Margin = new Padding(2, 3, 2, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(265, 27);
            txtPhone.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(214, 165, 70);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(43, 519);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 74);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(863, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 1;
            label5.Text = "MY PROFILE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(9, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 41);
            label4.TabIndex = 0;
            label4.Text = "FLAVOR CRAVE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 77);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 32);
            label6.TabIndex = 8;
            label6.Text = "My Profile";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(9, 116);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(258, 20);
            label7.TabIndex = 9;
            label7.Text = "View and update your account details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 189);
            label8.Name = "label8";
            label8.Size = new Size(254, 32);
            label8.TabIndex = 10;
            label8.Text = "Account Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(394, 189);
            label9.Name = "label9";
            label9.Size = new Size(335, 32);
            label9.TabIndex = 11;
            label9.Text = "Change Password (optional)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(431, 253);
            label10.Name = "label10";
            label10.Size = new Size(122, 20);
            label10.TabIndex = 12;
            label10.Text = "Current Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(431, 324);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 13;
            label11.Text = "New Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(431, 395);
            label12.Name = "label12";
            label12.Size = new Size(161, 20);
            label12.TabIndex = 14;
            label12.Text = "Confirm New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(431, 277);
            txtCurrentPassword.Margin = new Padding(3, 4, 3, 4);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(276, 27);
            txtCurrentPassword.TabIndex = 15;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(431, 348);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(276, 27);
            txtNewPassword.TabIndex = 16;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(431, 429);
            txtConfirmNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(276, 27);
            txtConfirmNewPassword.TabIndex = 18;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btnBackToDashbord
            // 
            btnBackToDashbord.Location = new Point(568, 519);
            btnBackToDashbord.Margin = new Padding(3, 4, 3, 4);
            btnBackToDashbord.Name = "btnBackToDashbord";
            btnBackToDashbord.Size = new Size(139, 31);
            btnBackToDashbord.TabIndex = 19;
            btnBackToDashbord.Text = "Back to Dashbord";
            btnBackToDashbord.UseVisualStyleBackColor = true;
            btnBackToDashbord.Click += btnBackToDashbord_Click;
            // 
            // ChefProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 848);
            Controls.Add(btnBackToDashbord);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ChefProfileForm";
            Text = "Flavor Crave - My Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnSave;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmNewPassword;
        private Button btnBackToDashbord;
    }
}