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
            ((System.ComponentModel.ISupportInitialize)dgvReceiptOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvReceiptOrders
            // 
            dgvReceiptOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiptOrders.Location = new Point(181, 99);
            dgvReceiptOrders.Name = "dgvReceiptOrders";
            dgvReceiptOrders.RowHeadersWidth = 51;
            dgvReceiptOrders.Size = new Size(300, 188);
            dgvReceiptOrders.TabIndex = 0;
            // 
            // btnRefreshReceipts
            // 
            btnRefreshReceipts.Location = new Point(87, 329);
            btnRefreshReceipts.Name = "btnRefreshReceipts";
            btnRefreshReceipts.Size = new Size(94, 29);
            btnRefreshReceipts.TabIndex = 1;
            btnRefreshReceipts.Text = "Refresh";
            btnRefreshReceipts.UseVisualStyleBackColor = true;
            // 
            // btnPreviewReceipt
            // 
            btnPreviewReceipt.Location = new Point(243, 337);
            btnPreviewReceipt.Name = "btnPreviewReceipt";
            btnPreviewReceipt.Size = new Size(94, 29);
            btnPreviewReceipt.TabIndex = 2;
            btnPreviewReceipt.Text = "Preview Receipt";
            btnPreviewReceipt.UseVisualStyleBackColor = true;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.Location = new Point(426, 337);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(94, 29);
            btnPrintReceipt.TabIndex = 3;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrintReceipt);
            Controls.Add(btnPreviewReceipt);
            Controls.Add(btnRefreshReceipts);
            Controls.Add(dgvReceiptOrders);
            Name = "ReceiptForm";
            Text = "ReceiptForm";
            ((System.ComponentModel.ISupportInitialize)dgvReceiptOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReceiptOrders;
        private Button btnRefreshReceipts;
        private Button btnPreviewReceipt;
        private Button btnPrintReceipt;
    }
}