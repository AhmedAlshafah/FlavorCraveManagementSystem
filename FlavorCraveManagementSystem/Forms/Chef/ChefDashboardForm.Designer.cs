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
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(787, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 0;
            label1.Text = "CHEF";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(220, 95);
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
            btnInProgress.Location = new Point(306, 133);
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
            btnComplete.Location = new Point(306, 198);
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
            btnUpdateProfile.Location = new Point(306, 261);
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
            lblChefName.Location = new Point(367, 372);
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
            panel1.Size = new Size(877, 70);
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
            // ChefDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(877, 499);
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
    }
}