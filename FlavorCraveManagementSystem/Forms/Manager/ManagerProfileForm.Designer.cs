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
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(28, 22);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 136);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(32, 44);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(261, 23);
            txtFullName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(32, 154);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new Point(32, 206);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(93, 23);
            btnUpdateProfile.TabIndex = 6;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // ManagerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateProfile);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Name = "ManagerProfileForm";
            Text = "ManagerProfileForm";
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
    }
}