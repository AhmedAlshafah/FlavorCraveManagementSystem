namespace FlavorCraveManagementSystem.Forms.Cashier
{
    partial class PaymentProcessingForm
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
            btnRefresh = new Button();
            btnPay = new Button();
            lblTotal = new Label();
            pnlHeader = new Panel();
            label2 = new Label();
            lblBrand = new Label();
            lblSelectedOrder = new Label();
            lblSelectedCustomer = new Label();
            lblPaymentStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(20, 94);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 45;
            dgvOrders.Size = new Size(1044, 360);
            dgvOrders.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(38, 48, 45);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 584);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 38);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(214, 165, 70);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.Black;
            btnPay.Location = new Point(190, 584);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(190, 38);
            btnPay.TabIndex = 2;
            btnPay.Text = "Process Payment";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(20, 510);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(88, 31);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: -";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 70, 55);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1082, 74);
            pnlHeader.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(772, 21);
            label2.Name = "label2";
            label2.Size = new Size(200, 37);
            label2.TabIndex = 3;
            label2.Text = "PAYMENTS";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(20, 21);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(268, 42);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "FLAVOR CRAVE";
            lblBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.AutoSize = true;
            lblSelectedOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedOrder.Location = new Point(20, 470);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(75, 23);
            lblSelectedOrder.TabIndex = 12;
            lblSelectedOrder.Text = "Order: -";
            // 
            // lblSelectedCustomer
            // 
            lblSelectedCustomer.AutoSize = true;
            lblSelectedCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedCustomer.Location = new Point(240, 470);
            lblSelectedCustomer.Name = "lblSelectedCustomer";
            lblSelectedCustomer.Size = new Size(110, 23);
            lblSelectedCustomer.TabIndex = 13;
            lblSelectedCustomer.Text = "Customer: - ";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentStatus.Location = new Point(560, 470);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(97, 23);
            lblPaymentStatus.TabIndex = 14;
            lblPaymentStatus.Text = "Payment: -";
            // 
            // PaymentProcessingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1082, 653);
            Controls.Add(lblPaymentStatus);
            Controls.Add(lblSelectedCustomer);
            Controls.Add(lblSelectedOrder);
            Controls.Add(pnlHeader);
            Controls.Add(lblTotal);
            Controls.Add(btnPay);
            Controls.Add(btnRefresh);
            Controls.Add(dgvOrders);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentProcessingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Payments";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnRefresh;
        private Button btnPay;
        private Label lblTotal;
        private Panel pnlHeader;
        private Label lblBrand;
        private Label label2;
        private Label lblSelectedOrder;
        private Label lblSelectedCustomer;
        private Label lblPaymentStatus;
    }
}