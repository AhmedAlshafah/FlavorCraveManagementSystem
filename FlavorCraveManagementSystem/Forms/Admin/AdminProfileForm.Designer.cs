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
            groupBox1 = new GroupBox();
            button1 = new Button();
            lblStatus = new Label();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnSave = new Button();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(1082, 74);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(962, 36);
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
            label3.Location = new Point(22, 19);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 13;
            label3.Text = "FLAVOR CRAVE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 4;
            label2.Text = "My Profile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 105);
            label5.Name = "label5";
            label5.Size = new Size(319, 20);
            label5.TabIndex = 5;
            label5.Text = "View and update your personal account details";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtCurrentPassword);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(22, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 310);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(647, 269);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(369, 198);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 13;
            lblStatus.Click += label12_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(369, 104);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(294, 27);
            txtNewPassword.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(369, 158);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(294, 27);
            txtConfirmPassword.TabIndex = 11;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(369, 46);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(294, 27);
            txtCurrentPassword.TabIndex = 10;
            txtCurrentPassword.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(369, 135);
            label9.Name = "label9";
            label9.Size = new Size(173, 20);
            label9.TabIndex = 9;
            label9.Text = "Confirm New Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(369, 81);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 8;
            label10.Text = "New Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(369, 23);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 7;
            label11.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(30, 70, 55);
            btnSave.Location = new Point(528, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(6, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(294, 27);
            txtPhone.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 27);
            txtName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 135);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 2;
            label8.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 81);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 1;
            label7.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 0;
            label6.Text = "Full Name";
            // 
            // AdminProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AdminProfileForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Button btnSave;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label label8;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtCurrentPassword;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblStatus;
        private Button button1;
    }
}