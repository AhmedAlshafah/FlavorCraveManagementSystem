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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(6, 53);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(121, 25);
            cmbMonth.TabIndex = 0;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(143, 53);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(121, 25);
            cmbYear.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(282, 53);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 25);
            cmbCategory.TabIndex = 2;
            // 
            // cmbChef
            // 
            cmbChef.FormattingEnabled = true;
            cmbChef.Location = new Point(448, 53);
            cmbChef.Name = "cmbChef";
            cmbChef.Size = new Size(121, 25);
            cmbChef.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(214, 165, 70);
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(414, 103);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(128, 26);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnClearFilters
            // 
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Location = new Point(598, 103);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(93, 26);
            btnClearFilters.TabIndex = 5;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = true;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.AllowUserToAddRows = false;
            dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesReport.BackgroundColor = Color.White;
            dgvSalesReport.BorderStyle = BorderStyle.None;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Location = new Point(0, 399);
            dgvSalesReport.MultiSelect = false;
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.ReadOnly = true;
            dgvSalesReport.RowHeadersVisible = false;
            dgvSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesReport.Size = new Size(934, 175);
            dgvSalesReport.TabIndex = 6;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(12, 322);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(73, 17);
            lblTotalSales.TabIndex = 7;
            lblTotalSales.Text = "Total Sales:";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Location = new Point(149, 322);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(84, 17);
            lblTotalOrders.TabIndex = 8;
            lblTotalOrders.Text = "Total Orders:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 9;
            label1.Text = "Month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 33);
            label2.Name = "label2";
            label2.Size = new Size(33, 17);
            label2.TabIndex = 10;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 33);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 11;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 33);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 12;
            label4.Text = "Chef";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 74);
            panel1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(667, 22);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 15;
            label6.Text = "SALES REPORT ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 22);
            label5.Name = "label5";
            label5.Size = new Size(188, 32);
            label5.TabIndex = 14;
            label5.Text = "FLAVOR CRAVE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 77);
            label7.Name = "label7";
            label7.Size = new Size(178, 37);
            label7.TabIndex = 14;
            label7.Text = "Sales Report";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(6, 119);
            label8.Name = "label8";
            label8.Size = new Size(269, 17);
            label8.TabIndex = 15;
            label8.Text = "Filter and review completed restaurant sales ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbMonth);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnClearFilters);
            groupBox1.Controls.Add(cmbChef);
            groupBox1.Controls.Add(btnGenerateReport);
            groupBox1.Location = new Point(6, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 152);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Report Filters";
            // 
            // button1
            // 
            button1.Location = new Point(577, 327);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 17;
            button1.Text = "Back to Dashbord";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 605);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(lblTotalOrders);
            Controls.Add(lblTotalSales);
            Controls.Add(dgvSalesReport);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SalesReportForm";
            Text = "Flavor Crave - Sales Report";
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private Button button1;
    }
}