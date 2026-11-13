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
            lblPageTitle = new Label();
            btnProcessPayment = new Button();
            btnWalletReport = new Button();
            btnProfile = new Button();
            btnReceipts = new Button();
            pnlHeader = new Panel();
            label4 = new Label();
            lblBrand = new Label();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            lblMenuTitle = new Label();
            lblPageSubtitle = new Label();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.Location = new Point(246, 94);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(318, 46);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Cashier Dashboard";
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.BackColor = Color.FromArgb(38, 48, 45);
            btnProcessPayment.FlatAppearance.BorderSize = 0;
            btnProcessPayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 70, 55);
            btnProcessPayment.FlatStyle = FlatStyle.Flat;
            btnProcessPayment.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnProcessPayment.ForeColor = Color.White;
            btnProcessPayment.Location = new Point(0, 70);
            btnProcessPayment.Margin = new Padding(3, 4, 3, 4);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Padding = new Padding(20, 0, 0, 0);
            btnProcessPayment.Size = new Size(210, 44);
            btnProcessPayment.TabIndex = 1;
            btnProcessPayment.Text = "Payments";
            btnProcessPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnProcessPayment.UseVisualStyleBackColor = false;
            // 
            // btnWalletReport
            // 
            btnWalletReport.BackColor = Color.FromArgb(38, 48, 45);
            btnWalletReport.FlatAppearance.BorderSize = 0;
            btnWalletReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 70, 55);
            btnWalletReport.FlatStyle = FlatStyle.Flat;
            btnWalletReport.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnWalletReport.ForeColor = Color.White;
            btnWalletReport.Location = new Point(0, 114);
            btnWalletReport.Margin = new Padding(3, 4, 3, 4);
            btnWalletReport.Name = "btnWalletReport";
            btnWalletReport.Padding = new Padding(20, 0, 0, 0);
            btnWalletReport.Size = new Size(210, 44);
            btnWalletReport.TabIndex = 2;
            btnWalletReport.Text = "Wallet Report";
            btnWalletReport.TextAlign = ContentAlignment.MiddleLeft;
            btnWalletReport.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(38, 48, 45);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 70, 55);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(0, 202);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(20, 0, 0, 0);
            btnProfile.Size = new Size(210, 44);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "My Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnReceipts
            // 
            btnReceipts.BackColor = Color.FromArgb(38, 48, 45);
            btnReceipts.FlatAppearance.BorderSize = 0;
            btnReceipts.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 70, 55);
            btnReceipts.FlatStyle = FlatStyle.Flat;
            btnReceipts.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnReceipts.ForeColor = Color.White;
            btnReceipts.Location = new Point(0, 158);
            btnReceipts.Name = "btnReceipts";
            btnReceipts.Padding = new Padding(20, 0, 0, 0);
            btnReceipts.Size = new Size(210, 44);
            btnReceipts.TabIndex = 4;
            btnReceipts.Text = "Receipts";
            btnReceipts.TextAlign = ContentAlignment.MiddleLeft;
            btnReceipts.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 70, 55);
            pnlHeader.Controls.Add(label4);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1082, 74);
            pnlHeader.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(817, 21);
            label4.Name = "label4";
            label4.Size = new Size(200, 37);
            label4.TabIndex = 4;
            label4.Text = "CASHIER";
            label4.TextAlign = ContentAlignment.MiddleRight;
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
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(38, 48, 45);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Controls.Add(btnProcessPayment);
            pnlSidebar.Controls.Add(btnReceipts);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Controls.Add(btnWalletReport);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 74);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 579);
            pnlSidebar.TabIndex = 13;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 70, 55);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 535);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(210, 44);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTitle.ForeColor = Color.White;
            lblMenuTitle.Location = new Point(20, 24);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(120, 20);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "CASHIER MENU";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageSubtitle.ForeColor = Color.FromArgb(90, 90, 90);
            lblPageSubtitle.Location = new Point(250, 140);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(480, 23);
            lblPageSubtitle.TabIndex = 14;
            lblPageSubtitle.Text = "Process payments, review wallet activity and print receipts";
            // 
            // CashierDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1082, 653);
            Controls.Add(lblPageSubtitle);
            Controls.Add(pnlSidebar);
            Controls.Add(lblPageTitle);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashierDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Cashier";
            Load += CashierDashboardForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Button btnProcessPayment;
        private Button btnWalletReport;
        private Button btnProfile;
        private Button btnReceipts;
        private Panel pnlHeader;
        private Label lblBrand;
        private Label label4;
        private Panel pnlSidebar;
        private Label lblMenuTitle;
        private Label lblPageSubtitle;
        private Button btnLogout;
    }
}