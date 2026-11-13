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
            label7 = new Label();
            label3 = new Label();
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
            label1.Location = new Point(542, 13);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "👩‍🍳 CHEF";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(222, 144);
            dgvOrders.Margin = new Padding(2);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(233, 150);
            dgvOrders.TabIndex = 1;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // btnInProgress
            // 
            btnInProgress.BackColor = Color.FromArgb(38, 48, 45);
            btnInProgress.FlatAppearance.BorderSize = 0;
            btnInProgress.FlatStyle = FlatStyle.Flat;
            btnInProgress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInProgress.ForeColor = Color.WhiteSmoke;
            btnInProgress.Location = new Point(-20, 78);
            btnInProgress.Margin = new Padding(2);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(172, 23);
            btnInProgress.TabIndex = 2;
            btnInProgress.Text = "Mark as In Progress";
            btnInProgress.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.FromArgb(38, 48, 45);
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.WhiteSmoke;
            btnComplete.Location = new Point(0, 115);
            btnComplete.Margin = new Padding(2);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(144, 34);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete Order";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.FromArgb(38, 48, 45);
            btnUpdateProfile.FlatAppearance.BorderSize = 0;
            btnUpdateProfile.FlatStyle = FlatStyle.Flat;
            btnUpdateProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateProfile.ForeColor = Color.WhiteSmoke;
            btnUpdateProfile.Location = new Point(2, 153);
            btnUpdateProfile.Margin = new Padding(2);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(142, 24);
            btnUpdateProfile.TabIndex = 4;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // lblChefName
            // 
            lblChefName.AutoSize = true;
            lblChefName.Location = new Point(300, 78);
            lblChefName.Margin = new Padding(2, 0, 2, 0);
            lblChefName.Name = "lblChefName";
            lblChefName.Size = new Size(88, 15);
            lblChefName.TabIndex = 5;
            lblChefName.Text = "Welcome, Chef";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 42);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(8, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 1;
            label2.Text = "FLAVOR CRAVE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 48, 45);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnInProgress);
            panel2.Controls.Add(btnUpdateProfile);
            panel2.Controls.Add(btnComplete);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 42);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 346);
            panel2.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 276);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 4;
            label7.Text = "Logout";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 0;
            label3.Text = "Chef";
            // 
            // ChefDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(640, 388);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblChefName);
            Controls.Add(dgvOrders);
            Cursor = Cursors.Hand;
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
        private Label label3;
    }
}