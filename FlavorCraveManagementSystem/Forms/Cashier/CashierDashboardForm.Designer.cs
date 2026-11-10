namespace FlavorCraveManagementSystem.Forms.Cashier
{
    partial class CashierDashboardForm
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
            btnProcessPayment = new Button();
            btnWalletReport = new Button();
            btnProfile = new Button();
            btnReceipts = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Cashier Dashboard";
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.Location = new Point(281, 426);
            btnProcessPayment.Margin = new Padding(3, 4, 3, 4);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(334, 39);
            btnProcessPayment.TabIndex = 1;
            btnProcessPayment.Text = "Process Payment";
            btnProcessPayment.UseVisualStyleBackColor = true;
            // 
            // btnWalletReport
            // 
            btnWalletReport.Location = new Point(281, 358);
            btnWalletReport.Margin = new Padding(3, 4, 3, 4);
            btnWalletReport.Name = "btnWalletReport";
            btnWalletReport.Size = new Size(334, 29);
            btnWalletReport.TabIndex = 2;
            btnWalletReport.Text = "Wallet Report";
            btnWalletReport.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(281, 286);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(334, 29);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnReceipts
            // 
            btnReceipts.Location = new Point(281, 506);
            btnReceipts.Name = "btnReceipts";
            btnReceipts.Size = new Size(334, 29);
            btnReceipts.TabIndex = 4;
            btnReceipts.Text = "Receipts";
            btnReceipts.UseVisualStyleBackColor = true;
            // 
            // CashierDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnReceipts);
            Controls.Add(btnProfile);
            Controls.Add(btnWalletReport);
            Controls.Add(btnProcessPayment);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashierDashboardForm";
            Text = "Cashier Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProcessPayment;
        private Button btnWalletReport;
        private Button btnProfile;
        private Button btnReceipts;
    }
}