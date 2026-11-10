namespace FlavorCraveManagementSystem.Forms.Customer
{
    partial class OrderHistoryForm
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
            lblTitle = new Label();
            dgvOrders = new DataGridView();
            btnCancelOrder = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(1340, 73);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Order History";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(180, 203);
            dgvOrders.Margin = new Padding(5, 6, 5, 6);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(1400, 822);
            dgvOrders.TabIndex = 1;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.BackColor = Color.FromArgb(255, 192, 128);
            btnCancelOrder.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelOrder.Location = new Point(148, 1064);
            btnCancelOrder.Margin = new Padding(5, 6, 5, 6);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(350, 87);
            btnCancelOrder.TabIndex = 2;
            btnCancelOrder.Text = "Cancel Selected Order";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 192, 128);
            btnRefresh.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(746, 1064);
            btnRefresh.Margin = new Padding(5, 6, 5, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(262, 87);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 192, 128);
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(1292, 1064);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(262, 87);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1779, 194);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 73);
            label1.Name = "label1";
            label1.Size = new Size(310, 54);
            label1.TabIndex = 1;
            label1.Text = "FLAVOR CRAVE";
            label1.Click += label1_Click;
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 1182);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnCancelOrder);
            Controls.Add(dgvOrders);
            Margin = new Padding(5, 6, 5, 6);
            Name = "OrderHistoryForm";
            Text = "My Orders";
            Load += OrderHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private Panel panel1;
        private Label label1;
    }
}