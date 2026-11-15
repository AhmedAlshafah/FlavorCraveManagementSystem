namespace FlavorCraveManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlHeader = new Panel();
            label9 = new Label();
            lblBrand = new Label();
            chkShowPassword = new CheckBox();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(396, 229);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(396, 316);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(30, 70, 55);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(483, 367);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.Control;
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Image = (Image)resources.GetObject("lblEmail.Image");
            lblEmail.Location = new Point(396, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Image = (Image)resources.GetObject("lblPassword.Image");
            lblPassword.Location = new Point(396, 292);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 65);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 123);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 175);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 70, 55);
            pnlHeader.Controls.Add(label9);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1082, 85);
            pnlHeader.TabIndex = 16;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1519, 21);
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
            // chkShowPassword
            // 
            chkShowPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.FlatAppearance.BorderColor = Color.Black;
            chkShowPassword.FlatAppearance.BorderSize = 0;
            chkShowPassword.FlatAppearance.CheckedBackColor = Color.Black;
            chkShowPassword.FlatStyle = FlatStyle.Flat;
            chkShowPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.White;
            chkShowPassword.Location = new Point(671, 318);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(117, 21);
            chkShowPassword.TabIndex = 17;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 653);
            Controls.Add(chkShowPassword);
            Controls.Add(pnlHeader);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Login ";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private Button btnLogin;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlHeader;
        private Label label9;
        private Label lblBrand;
        private CheckBox chkShowPassword;
    }
}
