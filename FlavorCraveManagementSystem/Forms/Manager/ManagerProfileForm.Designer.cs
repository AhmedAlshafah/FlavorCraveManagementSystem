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
            label1 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(16, 97);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(66, 17);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 172);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 232);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(16, 130);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(261, 25);
            txtFullName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 25);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(16, 252);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 25);
            txtPhone.TabIndex = 5;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.FromArgb(214, 165, 70);
            btnUpdateProfile.FlatAppearance.BorderSize = 0;
            btnUpdateProfile.FlatStyle = FlatStyle.Flat;
            btnUpdateProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfile.Location = new Point(126, 305);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnUpdateProfile);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Location = new Point(12, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 349);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(16, 45);
            label5.Name = "label5";
            label5.Size = new Size(267, 17);
            label5.TabIndex = 7;
            label5.Text = "You can update your personal details below.";
            // 
            // button1
            // 
            button1.Location = new Point(383, 305);
            button1.Name = "button1";
            button1.Size = new Size(128, 26);
            button1.TabIndex = 8;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManagerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 636);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ManagerProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - My Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button button1;
    }
}