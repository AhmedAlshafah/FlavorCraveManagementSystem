namespace FlavorCraveManagementSystem.Forms.Cashier
{
    partial class ReceiptForm
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
            dgvReceiptOrders = new DataGridView();
            btnRefreshReceipts = new Button();
            btnPreviewReceipt = new Button();
            btnPrintReceipt = new Button();
            pnlHeader = new Panel();
            lblFormName = new Label();
            lblBrand = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReceiptOrders).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReceiptOrders
            // 
            dgvReceiptOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReceiptOrders.BackgroundColor = Color.White;
            dgvReceiptOrders.BorderStyle = BorderStyle.None;
            dgvReceiptOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiptOrders.Location = new Point(20, 94);
            dgvReceiptOrders.Name = "dgvReceiptOrders";
            dgvReceiptOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvReceiptOrders.RowHeadersVisible = false;
            dgvReceiptOrders.RowHeadersWidth = 51;
            dgvReceiptOrders.Size = new Size(1044, 470);
            dgvReceiptOrders.TabIndex = 0;
            // 
            // btnRefreshReceipts
            // 
            btnRefreshReceipts.BackColor = Color.FromArgb(38, 48, 45);
            btnRefreshReceipts.FlatStyle = FlatStyle.Flat;
            btnRefreshReceipts.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshReceipts.ForeColor = Color.White;
            btnRefreshReceipts.Location = new Point(20, 584);
            btnRefreshReceipts.Name = "btnRefreshReceipts";
            btnRefreshReceipts.Size = new Size(150, 38);
            btnRefreshReceipts.TabIndex = 1;
            btnRefreshReceipts.Text = "Refresh";
            btnRefreshReceipts.UseVisualStyleBackColor = false;
            // 
            // btnPreviewReceipt
            // 
            btnPreviewReceipt.BackColor = Color.FromArgb(38, 48, 45);
            btnPreviewReceipt.FlatStyle = FlatStyle.Flat;
            btnPreviewReceipt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreviewReceipt.ForeColor = Color.White;
            btnPreviewReceipt.Location = new Point(190, 584);
            btnPreviewReceipt.Name = "btnPreviewReceipt";
            btnPreviewReceipt.Size = new Size(150, 38);
            btnPreviewReceipt.TabIndex = 2;
            btnPreviewReceipt.Text = "Preview Receipt";
            btnPreviewReceipt.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.FromArgb(214, 165, 70);
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReceipt.ForeColor = Color.Black;
            btnPrintReceipt.Location = new Point(360, 584);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(150, 38);
            btnPrintReceipt.TabIndex = 3;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 70, 55);
            pnlHeader.Controls.Add(lblFormName);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1082, 74);
            pnlHeader.TabIndex = 4;
            // 
            // lblFormName
            // 
            lblFormName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFormName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormName.ForeColor = Color.White;
            lblFormName.Location = new Point(864, 26);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(125, 27);
            lblFormName.TabIndex = 1;
            lblFormName.Text = "RECEIPTS";
            lblFormName.TextAlign = ContentAlignment.MiddleRight;
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
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1082, 653);
            Controls.Add(pnlHeader);
            Controls.Add(btnPrintReceipt);
            Controls.Add(btnPreviewReceipt);
            Controls.Add(btnRefreshReceipts);
            Controls.Add(dgvReceiptOrders);
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Receipts";
            ((System.ComponentModel.ISupportInitialize)dgvReceiptOrders).EndInit();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReceiptOrders;
        private Button btnRefreshReceipts;
        private Button btnPreviewReceipt;
        private Button btnPrintReceipt;
        private Panel pnlHeader;
        private Label lblBrand;
        private Label lblFormName;
    }
}