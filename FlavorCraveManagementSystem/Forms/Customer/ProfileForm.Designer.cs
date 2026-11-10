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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(617, 42);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Profile";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11F);
            lblFullName.Location = new Point(52, 174);
            lblFullName.Margin = new Padding(5, 0, 5, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(158, 41);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(315, 169);
            txtFullName.Margin = new Padding(5, 6, 5, 6);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(487, 47);
            txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(52, 291);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(95, 41);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(315, 285);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(487, 47);
            txtEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 11F);
            lblPhone.Location = new Point(52, 407);
            lblPhone.Margin = new Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(158, 41);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone No:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(315, 401);
            txtPhone.Margin = new Padding(5, 6, 5, 6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(487, 47);
            txtPhone.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 128);
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.Location = new Point(52, 562);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(315, 87);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 192, 128);
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(490, 562);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(315, 87);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
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
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 125);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 42);
            label1.Name = "label1";
            label1.Size = new Size(310, 54);
            label1.TabIndex = 1;
            label1.Text = "FLAVOR CRAVE";
            label1.Click += label1_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 736);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ProfileForm";
            Text = "My Profile";
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
    }
}