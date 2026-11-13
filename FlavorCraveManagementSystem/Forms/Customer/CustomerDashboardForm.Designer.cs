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
            btnBrowseMenu = new Button();
            lblWalletBalance = new Label();
            lblWelcomeMessage = new Label();
            btnMyOrders = new Button();
            btnEWallet = new Button();
            btnMyProfile = new Button();
            pnlMainContent = new Panel();
            groupBox1 = new GroupBox();
            lblSelectedFoodPrice = new Label();
            lblSelectedFoodName = new Label();
            picFood = new PictureBox();
            label3 = new Label();
            btnPlaceOrder = new Button();
            nudQuantity = new NumericUpDown();
            btnRefreshMenu = new Button();
            btnViewDetails = new Button();
            dgvMenuItems = new DataGridView();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            labe = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            label1 = new Label();
            pnlMainContent.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowseMenu
            // 
            btnBrowseMenu.FlatAppearance.BorderSize = 0;
            btnBrowseMenu.FlatStyle = FlatStyle.Flat;
            btnBrowseMenu.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseMenu.ForeColor = Color.White;
            btnBrowseMenu.Location = new Point(30, 189);
            btnBrowseMenu.Margin = new Padding(3, 4, 3, 4);
            btnBrowseMenu.Name = "btnBrowseMenu";
            btnBrowseMenu.Size = new Size(242, 70);
            btnBrowseMenu.TabIndex = 1;
            btnBrowseMenu.Text = "Browse Menu";
            btnBrowseMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnBrowseMenu.UseVisualStyleBackColor = true;
            btnBrowseMenu.Click += btnBrowseMenu_Click;
            // 
            // lblWalletBalance
            // 
            lblWalletBalance.AutoSize = true;
            lblWalletBalance.Location = new Point(1300, 298);
            lblWalletBalance.Name = "lblWalletBalance";
            lblWalletBalance.Size = new Size(155, 19);
            lblWalletBalance.TabIndex = 2;
            lblWalletBalance.Text = "Wallet Balance: RM 0.00";
            lblWalletBalance.Click += lblWalletBalance_Click;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeMessage.Location = new Point(609, 186);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(205, 21);
            lblWelcomeMessage.TabIndex = 3;
            lblWelcomeMessage.Text = "Welcome to Flavor Crave!";
            lblWelcomeMessage.Click += lblWelcomeMessage_Click;
            // 
            // btnMyOrders
            // 
            btnMyOrders.FlatAppearance.BorderSize = 0;
            btnMyOrders.FlatStyle = FlatStyle.Flat;
            btnMyOrders.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyOrders.ForeColor = Color.White;
            btnMyOrders.Location = new Point(30, 301);
            btnMyOrders.Margin = new Padding(3, 4, 3, 4);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Size = new Size(242, 70);
            btnMyOrders.TabIndex = 4;
            btnMyOrders.Text = "My Orders";
            btnMyOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyOrders.UseVisualStyleBackColor = true;
            btnMyOrders.Click += btnMyOrders_Click;
            // 
            // btnEWallet
            // 
            btnEWallet.FlatAppearance.BorderSize = 0;
            btnEWallet.FlatStyle = FlatStyle.Flat;
            btnEWallet.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEWallet.ForeColor = Color.White;
            btnEWallet.Location = new Point(30, 391);
            btnEWallet.Margin = new Padding(3, 4, 3, 4);
            btnEWallet.Name = "btnEWallet";
            btnEWallet.Size = new Size(242, 70);
            btnEWallet.TabIndex = 5;
            btnEWallet.Text = "E-Wallet";
            btnEWallet.TextAlign = ContentAlignment.MiddleLeft;
            btnEWallet.UseVisualStyleBackColor = true;
            btnEWallet.Click += btnEWallet_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.FlatAppearance.BorderSize = 0;
            btnMyProfile.FlatStyle = FlatStyle.Flat;
            btnMyProfile.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyProfile.ForeColor = Color.White;
            btnMyProfile.Location = new Point(30, 504);
            btnMyProfile.Margin = new Padding(3, 4, 3, 4);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(242, 70);
            btnMyProfile.TabIndex = 6;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Controls.Add(groupBox1);
            pnlMainContent.Controls.Add(label3);
            pnlMainContent.Controls.Add(btnPlaceOrder);
            pnlMainContent.Controls.Add(nudQuantity);
            pnlMainContent.Controls.Add(btnRefreshMenu);
            pnlMainContent.Controls.Add(btnViewDetails);
            pnlMainContent.Controls.Add(dgvMenuItems);
            pnlMainContent.Controls.Add(lblCategory);
            pnlMainContent.Controls.Add(cboCategory);
            pnlMainContent.Location = new Point(418, 360);
            pnlMainContent.Margin = new Padding(3, 4, 3, 4);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1289, 911);
            pnlMainContent.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSelectedFoodPrice);
            groupBox1.Controls.Add(lblSelectedFoodName);
            groupBox1.Controls.Add(picFood);
            groupBox1.Location = new Point(893, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 563);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Item Preview";
            // 
            // lblSelectedFoodPrice
            // 
            lblSelectedFoodPrice.AutoSize = true;
            lblSelectedFoodPrice.Location = new Point(6, 523);
            lblSelectedFoodPrice.Name = "lblSelectedFoodPrice";
            lblSelectedFoodPrice.Size = new Size(0, 19);
            lblSelectedFoodPrice.TabIndex = 13;
            // 
            // lblSelectedFoodName
            // 
            lblSelectedFoodName.AutoSize = true;
            lblSelectedFoodName.Location = new Point(6, 472);
            lblSelectedFoodName.Name = "lblSelectedFoodName";
            lblSelectedFoodName.Size = new Size(0, 19);
            lblSelectedFoodName.TabIndex = 12;
            // 
            // picFood
            // 
            picFood.BorderStyle = BorderStyle.FixedSingle;
            picFood.Location = new Point(0, 98);
            picFood.Name = "picFood";
            picFood.Size = new Size(393, 351);
            picFood.SizeMode = PictureBoxSizeMode.Zoom;
            picFood.TabIndex = 11;
            picFood.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 56);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 7;
            label3.Text = "Quantity:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(214, 165, 70);
            btnPlaceOrder.FlatAppearance.BorderSize = 0;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrder.Location = new Point(398, 840);
            btnPlaceOrder.Margin = new Padding(3, 4, 3, 4);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(218, 55);
            btnPlaceOrder.TabIndex = 6;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(632, 54);
            nudQuantity.Margin = new Padding(3, 4, 3, 4);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(257, 25);
            nudQuantity.TabIndex = 5;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRefreshMenu
            // 
            btnRefreshMenu.BackColor = Color.White;
            btnRefreshMenu.Location = new Point(737, 840);
            btnRefreshMenu.Margin = new Padding(3, 4, 3, 4);
            btnRefreshMenu.Name = "btnRefreshMenu";
            btnRefreshMenu.Size = new Size(213, 55);
            btnRefreshMenu.TabIndex = 4;
            btnRefreshMenu.Text = "Refresh Menu";
            btnRefreshMenu.UseVisualStyleBackColor = false;
            btnRefreshMenu.Click += btnRefreshMenu_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.White;
            btnViewDetails.Location = new Point(77, 840);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(195, 55);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.AllowUserToDeleteRows = false;
            dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuItems.BackgroundColor = Color.White;
            dgvMenuItems.BorderStyle = BorderStyle.None;
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Location = new Point(0, 139);
            dgvMenuItems.Margin = new Padding(3, 4, 3, 4);
            dgvMenuItems.MultiSelect = false;
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.RowHeadersVisible = false;
            dgvMenuItems.RowHeadersWidth = 82;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.Size = new Size(887, 676);
            dgvMenuItems.TabIndex = 0;
            dgvMenuItems.CellClick += dgvMenuItems_CellClick;
            dgvMenuItems.CellContentClick += dgvMenuItems_CellContentClick;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(48, 56);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 19);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(198, 48);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(252, 27);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labe);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1707, 171);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1460, 77);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "CUSTMOER";
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labe.ForeColor = Color.White;
            labe.Location = new Point(83, 66);
            labe.Name = "labe";
            labe.Size = new Size(188, 32);
            labe.TabIndex = 0;
            labe.Text = "FLAVOR CRAVE";
            labe.Click += labe_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 48, 45);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnBrowseMenu);
            panel2.Controls.Add(btnMyOrders);
            panel2.Controls.Add(btnEWallet);
            panel2.Controls.Add(btnMyProfile);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 171);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 1100);
            panel2.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(30, 696);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 46);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(563, 249);
            label1.Name = "label1";
            label1.Size = new Size(359, 19);
            label1.TabIndex = 10;
            label1.Text = "Browse our menu, place your order, and enjoy your meal.";
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1474, 904);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(panel1);
            Controls.Add(pnlMainContent);
            Controls.Add(lblWalletBalance);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Customer ";
            Load += CustomerDashboardForm_Load;
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel panel1;
        private Label label2;
        private Label labe;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private PictureBox picFood;
        private GroupBox groupBox1;
        private Label lblSelectedFoodPrice;
        private Label lblSelectedFoodName;
        private Button btnLogout;
    }
}