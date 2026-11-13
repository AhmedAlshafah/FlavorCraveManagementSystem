namespace FlavorCraveManagementSystem.Forms.Chef
{
    partial class ChefDashboardForm
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
            dgvOrders = new DataGridView();
            btnInProgress = new Button();
            btnComplete = new Button();
            btnUpdateProfile = new Button();
            lblChefName = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(774, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 34);
            label1.TabIndex = 0;
            label1.Text = "👩‍🍳 CHEF";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(297, 95);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(427, 241);
            dgvOrders.TabIndex = 1;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // btnInProgress
            // 
            btnInProgress.BackColor = Color.FromArgb(30, 70, 55);
            btnInProgress.FlatStyle = FlatStyle.Popup;
            btnInProgress.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInProgress.ForeColor = Color.WhiteSmoke;
            btnInProgress.Location = new Point(389, 128);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(262, 38);
            btnInProgress.TabIndex = 2;
            btnInProgress.Text = "Mark as In Progress";
            btnInProgress.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.FromArgb(30, 70, 55);
            btnComplete.FlatStyle = FlatStyle.Popup;
            btnComplete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.WhiteSmoke;
            btnComplete.Location = new Point(389, 196);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(262, 34);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete Order";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.FromArgb(30, 70, 55);
            btnUpdateProfile.FlatStyle = FlatStyle.Popup;
            btnUpdateProfile.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfile.ForeColor = Color.WhiteSmoke;
            btnUpdateProfile.Location = new Point(389, 261);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(262, 34);
            btnUpdateProfile.TabIndex = 4;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // lblChefName
            // 
            lblChefName.AutoSize = true;
            lblChefName.Location = new Point(460, 389);
            lblChefName.Name = "lblChefName";
            lblChefName.Size = new Size(130, 25);
            lblChefName.TabIndex = 5;
            lblChefName.Text = "Welcome, Chef";
            lblChefName.Click += lblChefName_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 70);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(278, 48);
            label2.TabIndex = 1;
            label2.Text = "FLAVOR CRAVE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 48, 45);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 452);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 25);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 0;
            label3.Text = "Chef";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 83);
            label4.Name = "label4";
            label4.Size = new Size(184, 28);
            label4.TabIndex = 1;
            label4.Text = "Mark As In Progress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 128);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 2;
            label5.Text = "Complete Order";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 176);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 3;
            label6.Text = "Update Profile";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 332);
            label7.Name = "label7";
            label7.Size = new Size(83, 28);
            label7.TabIndex = 4;
            label7.Text = "Log Out";
            // 
            // ChefDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(915, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblChefName);
            Controls.Add(btnUpdateProfile);
            Controls.Add(btnComplete);
            Controls.Add(btnInProgress);
            Controls.Add(dgvOrders);
            Cursor = Cursors.Hand;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChefDashboardForm";
            Text = "Chef Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvOrders;
        private Button btnInProgress;
        private Button btnComplete;
        private Button btnUpdateProfile;
        private Label lblChefName;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}