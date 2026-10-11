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
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(49, 29);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 45;
            dgvOrders.Size = new Size(522, 227);
            dgvOrders.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(49, 305);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 25);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(49, 336);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(136, 25);
            btnPay.TabIndex = 2;
            btnPay.Text = "Process Payment";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(79, 272);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 17);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: -";
            // 
            // PaymentProcessingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 433);
            Controls.Add(lblTotal);
            Controls.Add(btnPay);
            Controls.Add(btnRefresh);
            Controls.Add(dgvOrders);
            Name = "PaymentProcessingForm";
            Text = "PaymentProcessingForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnRefresh;
        private Button btnPay;
        private Label lblTotal;
    }
}