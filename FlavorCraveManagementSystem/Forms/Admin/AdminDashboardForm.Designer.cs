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
            label2 = new Label();
            btnLogout = new Button();
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
            label6 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label8 = new Label();
            label11 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            label9 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
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
            label1.Location = new Point(235, 140);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(462, 77);
            label2.Name = "label2";
            label2.Size = new Size(357, 38);
            label2.TabIndex = 7;
            label2.Text = "System Admin Dashboard";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(0, 534);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(210, 44);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 75);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(833, 37);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 23);
            lblWelcome.TabIndex = 14;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(833, 9);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 13;
            label4.Text = "ADMIN ";
            label4.Click += label4_Click;
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
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 578);
            panel2.TabIndex = 12;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.2F);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(11, 277);
            button6.Name = "button6";
            button6.Size = new Size(133, 35);
            button6.TabIndex = 14;
            button6.Text = "My Profile";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(12, 236);
            button5.Name = "button5";
            button5.Size = new Size(133, 35);
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
            button4.Font = new Font("Segoe UI", 10.2F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(11, 195);
            button4.Name = "button4";
            button4.Size = new Size(196, 35);
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
            button3.Font = new Font("Segoe UI", 10.2F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(11, 155);
            button3.Name = "button3";
            button3.Size = new Size(133, 35);
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
            button2.Font = new Font("Segoe UI", 10.2F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(11, 115);
            button2.Name = "button2";
            button2.Size = new Size(133, 35);
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
            label5.Location = new Point(32, 20);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 0;
            label5.Text = " ADMIN";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            button1.Location = new Point(945, 393);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            label6.Location = new Point(319, 161);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(71, 64);
            label10.Name = "label10";
            label10.Size = new Size(181, 40);
            label10.TabIndex = 3;
            label10.Text = "Add, update, and remove \r\nitems from the menu";
            label10.TextAlign = ContentAlignment.TopCenter;
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(29, 54);
            label12.Name = "label12";
            label12.Size = new Size(263, 20);
            label12.TabIndex = 9;
            label12.Text = "Assign ingredient items to menu items";
            label12.TextAlign = ContentAlignment.TopCenter;
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(43, 59);
            label13.Name = "label13";
            label13.Size = new Size(201, 60);
            label13.TabIndex = 10;
            label13.Text = "Update personal information\r\n(Email, Phone Number, \r\nUsername, and Password";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(61, 63);
            label8.Name = "label8";
            label8.Size = new Size(203, 80);
            label8.TabIndex = 1;
            label8.Text = "Create new account, Update \r\naccount details, and Remove \r\nAccount from the system\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(63, 54);
            label11.Name = "label11";
            label11.Size = new Size(201, 40);
            label11.TabIndex = 4;
            label11.Text = "Add, update, and remove \r\nitems from the Ingredient list";
            label11.TextAlign = ContentAlignment.TopCenter;
            label11.Click += label11_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(265, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 159);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(682, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 161);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(682, 328);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 143);
            panel5.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(265, 328);
            panel6.Name = "panel6";
            panel6.Size = new Size(338, 143);
            panel6.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(499, 499);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 143);
            panel7.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(106, 21);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 2;
            label7.Text = "Manage User";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(104, 22);
            label9.Name = "label9";
            label9.Size = new Size(124, 23);
            label9.TabIndex = 4;
            label9.Text = "Manage Menu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(81, 15);
            label14.Name = "label14";
            label14.Size = new Size(170, 23);
            label14.TabIndex = 5;
            label14.Text = "Manage Ingredients";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(86, 15);
            label15.Name = "label15";
            label15.Size = new Size(142, 23);
            label15.TabIndex = 10;
            label15.Text = "Map Ingredients";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(92, 18);
            label16.Name = "label16";
            label16.Size = new Size(93, 23);
            label16.TabIndex = 11;
            label16.Text = "My Profile";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1082, 653);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button btnLogout;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label8;
        private Label label11;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lblWelcome;
        private Label label7;
        private Label label9;
        private Label label15;
        private Label label14;
        private Label label16;
    }
}