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
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 30);
            label1.TabIndex = 0;
            label1.Text = "Chef Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(229, 62);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(427, 241);
            dgvOrders.TabIndex = 1;
            // 
            // btnInProgress
            // 
            btnInProgress.BackColor = Color.IndianRed;
            btnInProgress.FlatStyle = FlatStyle.Popup;
            btnInProgress.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInProgress.ForeColor = Color.Black;
            btnInProgress.Location = new Point(313, 100);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(262, 38);
            btnInProgress.TabIndex = 2;
            btnInProgress.Text = "Mark as In Progress";
            btnInProgress.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.IndianRed;
            btnComplete.FlatStyle = FlatStyle.Popup;
            btnComplete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplete.Location = new Point(313, 159);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(262, 34);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete Order";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.IndianRed;
            btnUpdateProfile.FlatStyle = FlatStyle.Popup;
            btnUpdateProfile.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfile.Location = new Point(313, 219);
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
            lblChefName.Location = new Point(367, 324);
            lblChefName.Name = "lblChefName";
            lblChefName.Size = new Size(130, 25);
            lblChefName.TabIndex = 5;
            lblChefName.Text = "Welcome, Chef";
            // 
            // ChefDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(892, 454);
            Controls.Add(lblChefName);
            Controls.Add(btnUpdateProfile);
            Controls.Add(btnComplete);
            Controls.Add(btnInProgress);
            Controls.Add(dgvOrders);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChefDashboardForm";
            Text = "Chef Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
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
    }
}