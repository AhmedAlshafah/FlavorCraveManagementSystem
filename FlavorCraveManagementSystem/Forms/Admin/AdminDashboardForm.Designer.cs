namespace FlavorCraveManagementSystem.Forms.Admin
{
    partial class AdminDashboardForm
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
            btnManageUser = new Button();
            brnManageMenu = new Button();
            label2 = new Label();
            btnLogout = new Button();
            btnProfile = new Button();
            btnMapping = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            button1 = new Button();
            btnIngredients = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 183);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // btnManageUser
            // 
            btnManageUser.Location = new Point(372, 247);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(162, 64);
            btnManageUser.TabIndex = 1;
            btnManageUser.Text = "Manage User's";
            btnManageUser.UseVisualStyleBackColor = true;
            btnManageUser.Click += btnManageUser_Click;
            // 
            // brnManageMenu
            // 
            brnManageMenu.Location = new Point(374, 317);
            brnManageMenu.Name = "brnManageMenu";
            brnManageMenu.Size = new Size(162, 64);
            brnManageMenu.TabIndex = 2;
            brnManageMenu.Text = "Manage Menu";
            brnManageMenu.UseVisualStyleBackColor = true;
            brnManageMenu.Click += brnManageMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(374, 123);
            label2.Name = "label2";
            label2.Size = new Size(431, 46);
            label2.TabIndex = 7;
            label2.Text = "System Admin Dashboard";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(12, 488);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(162, 64);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(629, 317);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(162, 64);
            btnProfile.TabIndex = 9;
            btnProfile.Text = "Manage Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnMapping
            // 
            btnMapping.Location = new Point(629, 247);
            btnMapping.Name = "btnMapping";
            btnMapping.Size = new Size(162, 64);
            btnMapping.TabIndex = 8;
            btnMapping.Text = "Map Ingredients";
            btnMapping.UseVisualStyleBackColor = true;
            btnMapping.Click += btnMapping_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 74);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(897, 29);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 13;
            label4.Text = "ADMIN DASHBOARD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(32, 19);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 12;
            label3.Text = "FLAVOR CRAVE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 48, 45);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 579);
            panel2.TabIndex = 12;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(12, 228);
            button6.Name = "button6";
            button6.Size = new Size(132, 34);
            button6.TabIndex = 14;
            button6.Text = "Manage Profile";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(12, 188);
            button5.Name = "button5";
            button5.Size = new Size(132, 34);
            button5.TabIndex = 14;
            button5.Text = "Map Ingredients";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(12, 149);
            button4.Name = "button4";
            button4.Size = new Size(162, 34);
            button4.TabIndex = 14;
            button4.Text = "Manage Ingredients";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(12, 109);
            button3.Name = "button3";
            button3.Size = new Size(132, 34);
            button3.TabIndex = 14;
            button3.Text = "Manage Menu";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(12, 69);
            button2.Name = "button2";
            button2.Size = new Size(132, 34);
            button2.TabIndex = 14;
            button2.Text = "Manage User's";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(32, 20);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 0;
            label5.Text = "ADMIN";
            // 
            // button1
            // 
            button1.Location = new Point(945, 393);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnIngredients
            // 
            btnIngredients.Location = new Point(372, 387);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(162, 64);
            btnIngredients.TabIndex = 3;
            btnIngredients.Text = "Manage Ingredients";
            btnIngredients.UseVisualStyleBackColor = true;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 190);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 14;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1082, 653);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(brnManageMenu);
            Controls.Add(btnManageUser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnProfile);
            Controls.Add(btnMapping);
            Controls.Add(label2);
            Controls.Add(btnIngredients);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnManageUser;
        private Button brnManageMenu;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button btnLogout;
        private Button btnProfile;
        private Button button1;
        private Button button2;
        private Button btnMapping;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Button button3;
        private Label label5;
        private Button btnIngredients;
        private Label label6;
    }
}