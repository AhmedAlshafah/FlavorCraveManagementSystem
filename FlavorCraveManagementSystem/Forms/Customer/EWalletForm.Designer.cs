namespace FlavorCraveManagementSystem.Forms.Customer
{
    partial class EWalletForm
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
            lblCurrentBalance = new Label();
            lblAmount = new Label();
            txtAmount = new TextBox();
            btnTopUp = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(728, 45);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "E-Wallet Top Up";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 11F);
            lblCurrentBalance.Location = new Point(295, 360);
            lblCurrentBalance.Margin = new Padding(5, 0, 5, 0);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(349, 41);
            lblCurrentBalance.TabIndex = 1;
            lblCurrentBalance.Text = "Current Balance: RM 0.00";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 11F);
            lblAmount.Location = new Point(161, 228);
            lblAmount.Margin = new Padding(5, 0, 5, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(236, 41);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Top Up Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 11F);
            txtAmount.Location = new Point(530, 222);
            txtAmount.Margin = new Padding(5, 6, 5, 6);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(347, 47);
            txtAmount.TabIndex = 3;
            // 
            // btnTopUp
            // 
            btnTopUp.BackColor = Color.FromArgb(255, 192, 128);
            btnTopUp.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTopUp.Location = new Point(161, 477);
            btnTopUp.Margin = new Padding(5, 6, 5, 6);
            btnTopUp.Name = "btnTopUp";
            btnTopUp.Size = new Size(280, 87);
            btnTopUp.TabIndex = 4;
            btnTopUp.Text = "Confirm Top Up";
            btnTopUp.UseVisualStyleBackColor = false;
            btnTopUp.Click += btnTopUp_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 192, 128);
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(549, 477);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(280, 87);
            btnClose.TabIndex = 5;
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 132);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 34);
            label1.Name = "label1";
            label1.Size = new Size(335, 59);
            label1.TabIndex = 1;
            label1.Text = "FLAVOR CRAVE";
            // 
            // EWalletForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 679);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnTopUp);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(lblCurrentBalance);
            Margin = new Padding(5, 6, 5, 6);
            Name = "EWalletForm";
            Text = "E-Wallet";
            Load += EWalletForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Button btnClose;
        private Panel panel1;
        private Label label1;
    }
}