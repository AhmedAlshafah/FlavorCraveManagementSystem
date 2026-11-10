namespace FlavorCraveManagementSystem.Forms.Manager
{
    partial class ManagerDashboardForm
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
            btnManageInventory = new Button();
            btnManageMenu = new Button();
            btnSalesReport = new Button();
            btnProfile = new Button();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            lblRole = new Label();
            lblAppName = new Label();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            pnlMain = new Panel();
            panel4 = new Panel();
            label11 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 35, 35);
            label1.Location = new Point(263, 25);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 0;
            label1.Text = "Manager Dashboard";
            // 
            // btnManageInventory
            // 
            btnManageInventory.FlatAppearance.BorderSize = 0;
            btnManageInventory.FlatStyle = FlatStyle.Flat;
            btnManageInventory.ForeColor = Color.White;
            btnManageInventory.Location = new Point(3, 83);
            btnManageInventory.Name = "btnManageInventory";
            btnManageInventory.Size = new Size(190, 48);
            btnManageInventory.TabIndex = 1;
            btnManageInventory.Text = "Inventory";
            btnManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnManageInventory.UseVisualStyleBackColor = true;
            btnManageInventory.Click += btnManageInventory_Click;
            // 
            // btnManageMenu
            // 
            btnManageMenu.BackColor = Color.FromArgb(38, 48, 45);
            btnManageMenu.FlatAppearance.BorderSize = 0;
            btnManageMenu.FlatStyle = FlatStyle.Flat;
            btnManageMenu.ForeColor = Color.White;
            btnManageMenu.Location = new Point(0, 125);
            btnManageMenu.Name = "btnManageMenu";
            btnManageMenu.Size = new Size(190, 48);
            btnManageMenu.TabIndex = 2;
            btnManageMenu.Text = "Menu Management";
            btnManageMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnManageMenu.UseVisualStyleBackColor = false;
            btnManageMenu.Click += btnManageMenu_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackColor = Color.FromArgb(38, 48, 45);
            btnSalesReport.FlatAppearance.BorderSize = 0;
            btnSalesReport.FlatStyle = FlatStyle.Flat;
            btnSalesReport.Font = new Font("Segoe UI", 10F);
            btnSalesReport.ForeColor = Color.White;
            btnSalesReport.Location = new Point(0, 166);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(190, 48);
            btnSalesReport.TabIndex = 3;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(38, 48, 45);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10F);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(0, 209);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(190, 48);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "My Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 70, 55);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Font = new Font("Segoe UI", 10F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1084, 70);
            pnlHeader.TabIndex = 5;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(779, 50);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 17);
            lblWelcome.TabIndex = 2;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(761, 19);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(86, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "MANAGER";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(32, 19);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(188, 32);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "FLAVOR CRAVE";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(38, 48, 45);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(btnManageInventory);
            pnlSidebar.Controls.Add(btnManageMenu);
            pnlSidebar.Controls.Add(btnSalesReport);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 70);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 679);
            pnlSidebar.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(3, 349);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 48);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 7;
            label2.Text = "MANAGEMENT";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel4);
            pnlMain.Controls.Add(panel3);
            pnlMain.Controls.Add(panel2);
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(label1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(210, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(874, 679);
            pnlMain.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(406, 257);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 130);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(48, 64);
            label11.Name = "label11";
            label11.Size = new Size(227, 17);
            label11.TabIndex = 1;
            label11.Text = "View and update your account details";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(35, 35, 35);
            label10.Location = new Point(84, 10);
            label10.Name = "label10";
            label10.Size = new Size(121, 25);
            label10.TabIndex = 0;
            label10.Text = "MY PROFILE";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(26, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 130);
            panel3.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(34, 64);
            label9.Name = "label9";
            label9.Size = new Size(228, 17);
            label9.TabIndex = 1;
            label9.Text = "View sales by date, category and chef";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(35, 35, 35);
            label8.Location = new Point(74, 10);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 0;
            label8.Text = "SALES REPORT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(406, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 130);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(39, 71);
            label7.Name = "label7";
            label7.Size = new Size(226, 17);
            label7.TabIndex = 1;
            label7.Text = "Manage pricing and menu availability";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(35, 35, 35);
            label6.Location = new Point(39, 21);
            label6.Name = "label6";
            label6.Size = new Size(211, 25);
            label6.TabIndex = 0;
            label6.Text = "MENU MANAGEMENT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(26, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 130);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(272, 19);
            label5.TabIndex = 1;
            label5.Text = "Monitor and update ingredient stock levels";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(35, 35, 35);
            label4.Location = new Point(74, 21);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 0;
            label4.Text = "INVENTORY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(211, 46);
            label3.Name = "label3";
            label3.Size = new Size(270, 19);
            label3.TabIndex = 1;
            label3.Text = "Manage restaurant operations and reports";
            // 
            // ManagerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1084, 749);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ManagerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Manager";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnManageInventory;
        private Button btnManageMenu;
        private Button btnSalesReport;
        private Button btnProfile;
        private Panel pnlHeader;
        private Label lblRole;
        private Label lblAppName;
        private Panel pnlSidebar;
        private Label label2;
        private Panel pnlMain;
        private Label label3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnLogout;
        private Label lblWelcome;
    }
}