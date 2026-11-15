namespace FlavorCraveManagementSystem.Forms.Cashier
{
    partial class WalletReportForm
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
            cmbCustomer = new ComboBox();
            cmbMonth = new ComboBox();
            cmbYear = new ComboBox();
            btnGenerateReport = new Button();
            btnClearFilters = new Button();
            dgvTransactions = new DataGridView();
            lblSummary = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlHeader = new Panel();
            label1 = new Label();
            lblBrand = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(20, 120);
            cmbCustomer.Margin = new Padding(3, 4, 3, 4);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(240, 28);
            cmbCustomer.TabIndex = 0;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(280, 120);
            cmbMonth.Margin = new Padding(3, 4, 3, 4);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(180, 28);
            cmbMonth.TabIndex = 1;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(480, 120);
            cmbYear.Margin = new Padding(3, 4, 3, 4);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(140, 28);
            cmbYear.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(214, 165, 70);
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.Black;
            btnGenerateReport.Location = new Point(640, 116);
            btnGenerateReport.Margin = new Padding(3, 4, 3, 4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 34);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FromArgb(38, 48, 45);
            btnClearFilters.FlatAppearance.BorderSize = 0;
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilters.ForeColor = Color.White;
            btnClearFilters.Location = new Point(810, 116);
            btnClearFilters.Margin = new Padding(3, 4, 3, 4);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(130, 34);
            btnClearFilters.TabIndex = 4;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = false;
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(20, 170);
            dgvTransactions.Margin = new Padding(3, 4, 3, 4);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 45;
            dgvTransactions.Size = new Size(1044, 420);
            dgvTransactions.TabIndex = 5;
            // 
            // lblSummary
            // 
            lblSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(20, 608);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(88, 23);
            lblSummary.TabIndex = 6;
            lblSummary.Text = "Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 96);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 7;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 96);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 8;
            label3.Text = "Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(480, 96);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 9;
            label4.Text = "Year";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 70, 55);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1082, 74);
            pnlHeader.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(864, 26);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 2;
            label1.Text = "WALLET REPORT";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 10.2F);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(901, 608);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(163, 38);
            btnClose.TabIndex = 17;
            btnClose.Text = "Back to Dashboard";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // WalletReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1082, 653);
            Controls.Add(btnClose);
            Controls.Add(pnlHeader);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSummary);
            Controls.Add(dgvTransactions);
            Controls.Add(btnClearFilters);
            Controls.Add(btnGenerateReport);
            Controls.Add(cmbYear);
            Controls.Add(cmbMonth);
            Controls.Add(cmbCustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WalletReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Wallet Report";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomer;
        private ComboBox cmbMonth;
        private ComboBox cmbYear;
        private Button btnGenerateReport;
        private Button btnClearFilters;
        private DataGridView dgvTransactions;
        private Label lblSummary;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pnlHeader;
        private Label lblBrand;
        private Label label1;
        private Button btnClose;
    }
}