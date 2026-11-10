namespace FlavorCraveManagementSystem.Forms.Customer
{
    partial class CustomerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblDashboardTitle = new Label();
            btnBrowseMenu = new Button();
            lblWalletBalance = new Label();
            lblWelcomeMessage = new Label();
            btnMyOrders = new Button();
            btnEWallet = new Button();
            btnMyProfile = new Button();
            pnlMainContent = new Panel();
            btnRefreshMenu = new Button();
            btnViewDetails = new Button();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            dgvMenuItems = new DataGridView();
            nudQuantity = new NumericUpDown();
            btnPlaceOrder = new Button();
            pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Location = new Point(16, 33);
            lblDashboardTitle.Margin = new Padding(6, 0, 6, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(256, 31);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Customer Dashboard";
            // 
            // btnBrowseMenu
            // 
            btnBrowseMenu.Location = new Point(102, 264);
            btnBrowseMenu.Name = "btnBrowseMenu";
            btnBrowseMenu.Size = new Size(226, 80);
            btnBrowseMenu.TabIndex = 1;
            btnBrowseMenu.Text = "Browse Menu";
            btnBrowseMenu.UseVisualStyleBackColor = true;
            btnBrowseMenu.Click += btnBrowseMenu_Click;
            // 
            // lblWalletBalance
            // 
            lblWalletBalance.AutoSize = true;
            lblWalletBalance.Location = new Point(635, 127);
            lblWalletBalance.Name = "lblWalletBalance";
            lblWalletBalance.Size = new Size(288, 31);
            lblWalletBalance.TabIndex = 2;
            lblWalletBalance.Text = "Wallet Balance: RM 0.00";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Location = new Point(635, 68);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(308, 31);
            lblWelcomeMessage.TabIndex = 3;
            lblWelcomeMessage.Text = "Welcome to Flavor Crave!";
            // 
            // btnMyOrders
            // 
            btnMyOrders.Location = new Point(102, 412);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Size = new Size(226, 87);
            btnMyOrders.TabIndex = 4;
            btnMyOrders.Text = "My Orders";
            btnMyOrders.UseVisualStyleBackColor = true;
            btnMyOrders.Click += btnMyOrders_Click;
            // 
            // btnEWallet
            // 
            btnEWallet.Location = new Point(102, 556);
            btnEWallet.Name = "btnEWallet";
            btnEWallet.Size = new Size(226, 84);
            btnEWallet.TabIndex = 5;
            btnEWallet.Text = "E-Wallet";
            btnEWallet.UseVisualStyleBackColor = true;
            btnEWallet.Click += btnEWallet_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Location = new Point(102, 696);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(226, 105);
            btnMyProfile.TabIndex = 6;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Controls.Add(btnPlaceOrder);
            pnlMainContent.Controls.Add(nudQuantity);
            pnlMainContent.Controls.Add(btnRefreshMenu);
            pnlMainContent.Controls.Add(btnViewDetails);
            pnlMainContent.Controls.Add(lblCategory);
            pnlMainContent.Controls.Add(cboCategory);
            pnlMainContent.Controls.Add(dgvMenuItems);
            pnlMainContent.Location = new Point(544, 230);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(831, 795);
            pnlMainContent.TabIndex = 7;
            // 
            // btnRefreshMenu
            // 
            btnRefreshMenu.Location = new Point(572, 704);
            btnRefreshMenu.Name = "btnRefreshMenu";
            btnRefreshMenu.Size = new Size(199, 46);
            btnRefreshMenu.TabIndex = 4;
            btnRefreshMenu.Text = "Refresh Menu";
            btnRefreshMenu.UseVisualStyleBackColor = true;
            btnRefreshMenu.Click += btnRefreshMenu_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(72, 704);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(182, 46);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(46, 55);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(124, 31);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(228, 47);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(235, 39);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.AllowUserToDeleteRows = false;
            dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Location = new Point(0, 131);
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.RowHeadersVisible = false;
            dgvMenuItems.RowHeadersWidth = 82;
            dgvMenuItems.Size = new Size(831, 548);
            dgvMenuItems.TabIndex = 0;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(572, 47);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(240, 38);
            nudQuantity.TabIndex = 5;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(323, 704);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(204, 46);
            btnPlaceOrder.TabIndex = 6;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 1057);
            Controls.Add(pnlMainContent);
            Controls.Add(btnMyProfile);
            Controls.Add(btnEWallet);
            Controls.Add(btnMyOrders);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(lblWalletBalance);
            Controls.Add(btnBrowseMenu);
            Controls.Add(lblDashboardTitle);
            Margin = new Padding(6);
            Name = "CustomerDashboardForm";
            Text = "Customer Dashboard ";
            Load += CustomerDashboardForm_Load;
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboardTitle;
        private Button btnBrowseMenu;
        private Label lblWalletBalance;
        private Label lblWelcomeMessage;
        private Button btnMyOrders;
        private Button btnEWallet;
        private Button btnMyProfile;
        private Panel pnlMainContent;
        private DataGridView dgvMenuItems;
        private Button btnRefreshMenu;
        private Button btnViewDetails;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Button btnPlaceOrder;
        private NumericUpDown nudQuantity;
    }
}