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
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(780, 54);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(248, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "E-WALLET TOP UP";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(74, 422);
            lblCurrentBalance.Margin = new Padding(5, 0, 5, 0);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(408, 45);
            lblCurrentBalance.TabIndex = 1;
            lblCurrentBalance.Text = " Current Balance: RM 0.00";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 11F);
            lblAmount.Location = new Point(93, 563);
            lblAmount.Margin = new Padding(5, 0, 5, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(236, 41);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Top Up Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 11F);
            txtAmount.Location = new Point(93, 638);
            txtAmount.Margin = new Padding(5, 7, 5, 7);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(406, 47);
            txtAmount.TabIndex = 3;
            // 
            // btnTopUp
            // 
            btnTopUp.BackColor = Color.FromArgb(214, 165, 70);
            btnTopUp.FlatAppearance.BorderSize = 0;
            btnTopUp.FlatStyle = FlatStyle.Flat;
            btnTopUp.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTopUp.ForeColor = Color.Black;
            btnTopUp.Location = new Point(122, 751);
            btnTopUp.Margin = new Padding(5, 7, 5, 7);
            btnTopUp.Name = "btnTopUp";
            btnTopUp.Size = new Size(300, 48);
            btnTopUp.TabIndex = 4;
            btnTopUp.Text = "Confirm Top Up";
            btnTopUp.UseVisualStyleBackColor = false;
            btnTopUp.Click += btnTopUp_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(638, 729);
            btnClose.Margin = new Padding(5, 7, 5, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(300, 51);
            btnClose.TabIndex = 5;
            btnClose.Text = "Back to Dashboard";
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 158);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 41);
            label1.Name = "label1";
            label1.Size = new Size(335, 59);
            label1.TabIndex = 1;
            label1.Text = "FLAVOR CRAVE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 204);
            label2.Name = "label2";
            label2.Size = new Size(145, 45);
            label2.TabIndex = 7;
            label2.Text = "E-Wallet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(62, 277);
            label3.Name = "label3";
            label3.Size = new Size(437, 37);
            label3.TabIndex = 8;
            label3.Text = "Top up your wallet balance securely";
            // 
            // EWalletForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 864);
            Controls.Add(lblCurrentBalance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnTopUp);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 7, 5, 7);
            Name = "EWalletForm";
            Text = "Flavor Crave - E-Wallet";
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
        private Label label2;
        private Label label3;
    }
}