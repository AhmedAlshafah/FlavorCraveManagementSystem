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
            dgvOrders = new DataGridView();
            btnInProgress = new Button();
            btnComplete = new Button();
            btnUpdateProfile = new Button();
            panel1 = new Panel();
            lblWelcome = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnLogout = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(217, 244);
            dgvOrders.Margin = new Padding(2, 3, 2, 3);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(661, 339);
            dgvOrders.TabIndex = 1;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            dgvOrders.CellFormatting += dgvOrders_CellFormatting;
            // 
            // btnInProgress
            // 
            btnInProgress.BackColor = Color.FromArgb(214, 165, 70);
            btnInProgress.FlatAppearance.BorderSize = 0;
            btnInProgress.FlatStyle = FlatStyle.Flat;
            btnInProgress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInProgress.ForeColor = Color.Black;
            btnInProgress.Location = new Point(504, 617);
            btnInProgress.Margin = new Padding(2, 3, 2, 3);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(197, 57);
            btnInProgress.TabIndex = 2;
            btnInProgress.Text = "Mark as In Progress";
            btnInProgress.UseVisualStyleBackColor = false;
            btnInProgress.Click += btnInProgress_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.DarkGreen;
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.White;
            btnComplete.Location = new Point(217, 617);
            btnComplete.Margin = new Padding(2, 3, 2, 3);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(206, 57);
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
            btnUpdateProfile.Location = new Point(2, 303);
            btnUpdateProfile.Margin = new Padding(2, 3, 2, 3);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(174, 100);
            btnUpdateProfile.TabIndex = 4;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 93);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(817, 63);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 23);
            lblWelcome.TabIndex = 9;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(822, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 8;
            label1.Text = "CHEF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(34, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 41);
            label2.TabIndex = 1;
            label2.Text = "FLAVOR CRAVE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 48, 45);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnUpdateProfile);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 93);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 760);
            panel2.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 737);
            btnLogout.Margin = new Padding(2, 0, 2, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(64, 23);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 0;
            label3.Text = "CHEF";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 119);
            label4.Name = "label4";
            label4.Size = new Size(227, 41);
            label4.TabIndex = 8;
            label4.Text = "Kitchen Orders";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(197, 169);
            label5.Name = "label5";
            label5.Size = new Size(438, 23);
            label5.TabIndex = 9;
            label5.Text = "Manage incoming orders and update preparation status";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(763, 617);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 57);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ChefDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(981, 853);
            Controls.Add(btnRefresh);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnInProgress);
            Controls.Add(btnComplete);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvOrders);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChefDashboardForm";
            Text = "Flavor Crave - Chef";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOrders;
        private Button btnInProgress;
        private Button btnComplete;
        private Button btnUpdateProfile;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label btnLogout;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnRefresh;
        private Label lblWelcome;
    }
}