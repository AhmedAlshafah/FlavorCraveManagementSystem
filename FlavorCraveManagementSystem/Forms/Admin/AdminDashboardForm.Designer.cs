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
            brnManageMenu = new Button();
            label2 = new Label();
            btnLogout = new Button();
            btnProfile = new Button();
            btnMapping = new Button();
            panel1 = new Panel();
            lblWelcome = new Label();
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
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnManageUser = new Button();
            label8 = new Label();
            label11 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            label1.Location = new Point(206, 105);
            label1.Name = "label1";
            label1.Size = new Size(0, 13);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // brnManageMenu
            // 
            brnManageMenu.FlatAppearance.BorderSize = 0;
            brnManageMenu.FlatStyle = FlatStyle.Flat;
            brnManageMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnManageMenu.Location = new Point(54, 10);
            brnManageMenu.Margin = new Padding(3, 2, 3, 2);
            brnManageMenu.Name = "brnManageMenu";
            brnManageMenu.Size = new Size(131, 23);
            brnManageMenu.TabIndex = 2;
            brnManageMenu.Text = "Manage Menu";
            brnManageMenu.UseVisualStyleBackColor = true;
            brnManageMenu.Click += brnManageMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 58);
            label2.Name = "label2";
            label2.Size = new Size(280, 30);
            label2.TabIndex = 7;
            label2.Text = "System Admin Dashboard";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(10, 366);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(68, 36);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnProfile.Location = new Point(54, 2);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(131, 32);
            btnProfile.TabIndex = 9;
            btnProfile.Text = "Manage Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnMapping
            // 
            btnMapping.FlatAppearance.BorderSize = 0;
            btnMapping.FlatStyle = FlatStyle.Flat;
            btnMapping.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnMapping.Location = new Point(54, 2);
            btnMapping.Margin = new Padding(3, 2, 3, 2);
            btnMapping.Name = "btnMapping";
            btnMapping.Size = new Size(131, 38);
            btnMapping.TabIndex = 8;
            btnMapping.Text = "Map Ingredients";
            btnMapping.UseVisualStyleBackColor = true;
            btnMapping.Click += btnMapping_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 56);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(729, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 19);
            lblWelcome.TabIndex = 14;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(729, 7);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 13;
            label4.Text = "ADMIN ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(28, 14);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
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
            panel2.Location = new Point(0, 56);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 434);
            panel2.TabIndex = 12;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10.2F);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(10, 213);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(116, 26);
            button6.TabIndex = 14;
            button6.Text = "Manage Profile";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.2F);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(10, 183);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(116, 26);
            button5.TabIndex = 14;
            button5.Text = "Map Ingredients";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(10, 146);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(142, 26);
            button4.TabIndex = 14;
            button4.Text = "Manage Ingredients";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(10, 116);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(116, 26);
            button3.TabIndex = 14;
            button3.Text = "Manage Menu";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(10, 86);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 26);
            button2.TabIndex = 14;
            button2.Text = "Manage User's";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(28, 15);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 0;
            label5.Text = " ADMIN";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            button1.Location = new Point(827, 295);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnIngredients
            // 
            btnIngredients.FlatAppearance.BorderSize = 0;
            btnIngredients.FlatStyle = FlatStyle.Flat;
            btnIngredients.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnIngredients.Location = new Point(53, 2);
            btnIngredients.Margin = new Padding(3, 2, 3, 2);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(131, 35);
            btnIngredients.TabIndex = 3;
            btnIngredients.Text = "Manage Ingredients";
            btnIngredients.UseVisualStyleBackColor = true;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            label6.Location = new Point(279, 121);
            label6.Name = "label6";
            label6.Size = new Size(0, 13);
            label6.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(41, 67);
            label10.Name = "label10";
            label10.Size = new Size(144, 30);
            label10.TabIndex = 3;
            label10.Text = "Add, update, and remove \r\nitems from the menu";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(16, 44);
            label12.Name = "label12";
            label12.Size = new Size(211, 15);
            label12.TabIndex = 9;
            label12.Text = "Assign ingredient items to menu items";
            label12.TextAlign = ContentAlignment.TopCenter;
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(38, 44);
            label13.Name = "label13";
            label13.Size = new Size(159, 45);
            label13.TabIndex = 10;
            label13.Text = "Update personal information\r\n(Email, Phone Number, \r\nUsername, and Password";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnManageUser
            // 
            btnManageUser.BackColor = Color.FromArgb(245, 245, 242);
            btnManageUser.FlatAppearance.BorderSize = 0;
            btnManageUser.FlatStyle = FlatStyle.Flat;
            btnManageUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUser.Location = new Point(53, 2);
            btnManageUser.Margin = new Padding(3, 2, 3, 2);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(131, 40);
            btnManageUser.TabIndex = 1;
            btnManageUser.Text = "Manage User's";
            btnManageUser.UseVisualStyleBackColor = false;
            btnManageUser.Click += btnManageUser_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(53, 54);
            label8.Name = "label8";
            label8.Size = new Size(162, 60);
            label8.TabIndex = 1;
            label8.Text = "Create new account, Update \r\naccount details, and Remove \r\nAccount from the system\r\n\r\n";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(35, 44);
            label11.Name = "label11";
            label11.Size = new Size(160, 30);
            label11.TabIndex = 4;
            label11.Text = "Add, update, and remove \r\nitems from the Ingredient list";
            label11.TextAlign = ContentAlignment.TopCenter;
            label11.Click += label11_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnManageUser);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(232, 108);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 120);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(brnManageMenu);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(597, 107);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 121);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnMapping);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(597, 246);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(288, 108);
            panel5.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnIngredients);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(232, 246);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(296, 108);
            panel6.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label13);
            panel7.Controls.Add(btnProfile);
            panel7.Location = new Point(437, 374);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(249, 108);
            panel7.TabIndex = 17;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(947, 490);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Label label10;
        private Label label12;
        private Label label13;
        private Button btnManageUser;
        private Label label8;
        private Label label11;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lblWelcome;
    }
}