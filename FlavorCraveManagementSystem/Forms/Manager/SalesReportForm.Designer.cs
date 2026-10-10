namespace FlavorCraveManagementSystem.Forms.Manager
{
    partial class SalesReportForm
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
            cmbMonth = new ComboBox();
            cmbYear = new ComboBox();
            cmbCategory = new ComboBox();
            cmbChef = new ComboBox();
            btnGenerateReport = new Button();
            btnClearFilters = new Button();
            dgvSalesReport = new DataGridView();
            lblTotalSales = new Label();
            lblTotalOrders = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            SuspendLayout();
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(12, 26);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(121, 23);
            cmbMonth.TabIndex = 0;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(184, 26);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(121, 23);
            cmbYear.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(370, 26);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 2;
            // 
            // cmbChef
            // 
            cmbChef.FormattingEnabled = true;
            cmbChef.Location = new Point(569, 26);
            cmbChef.Name = "cmbChef";
            cmbChef.Size = new Size(121, 23);
            cmbChef.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(12, 352);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(114, 23);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnClearFilters
            // 
            btnClearFilters.Location = new Point(586, 352);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(114, 23);
            btnClearFilters.TabIndex = 5;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = true;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.AllowUserToAddRows = false;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Location = new Point(0, 55);
            dgvSalesReport.MultiSelect = false;
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.ReadOnly = true;
            dgvSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesReport.Size = new Size(801, 284);
            dgvSalesReport.TabIndex = 6;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(13, 384);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(62, 15);
            lblTotalSales.TabIndex = 7;
            lblTotalSales.Text = "Total Sales";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Location = new Point(13, 411);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(71, 15);
            lblTotalOrders.TabIndex = 8;
            lblTotalOrders.Text = "Total Orders";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 5);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 10;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 4);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 11;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 8);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 12;
            label4.Text = "Chef";
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalOrders);
            Controls.Add(lblTotalSales);
            Controls.Add(dgvSalesReport);
            Controls.Add(btnClearFilters);
            Controls.Add(btnGenerateReport);
            Controls.Add(cmbChef);
            Controls.Add(cmbCategory);
            Controls.Add(cmbYear);
            Controls.Add(cmbMonth);
            Name = "SalesReportForm";
            Text = "SalesReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMonth;
        private ComboBox cmbYear;
        private ComboBox cmbCategory;
        private ComboBox cmbChef;
        private Button btnGenerateReport;
        private Button btnClearFilters;
        private DataGridView dgvSalesReport;
        private Label lblTotalSales;
        private Label lblTotalOrders;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}