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
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(96, 82);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(134, 25);
            cmbCustomer.TabIndex = 0;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(249, 82);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(134, 25);
            cmbMonth.TabIndex = 1;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(411, 82);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(134, 25);
            cmbYear.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(96, 155);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(134, 25);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            btnClearFilters.Location = new Point(411, 155);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(134, 25);
            btnClearFilters.TabIndex = 4;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(96, 226);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 45;
            dgvTransactions.Size = new Size(449, 166);
            dgvTransactions.TabIndex = 5;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(42, 419);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(62, 17);
            lblSummary.TabIndex = 6;
            lblSummary.Text = "Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 36);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 7;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 36);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 8;
            label3.Text = "Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 36);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 9;
            label4.Text = "Year";
            // 
            // WalletReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 533);
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
            Name = "WalletReportForm";
            Text = "WalletReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
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
    }
}