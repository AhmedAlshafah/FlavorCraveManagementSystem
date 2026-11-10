namespace FlavorCraveManagementSystem.Forms.Manager
{
    partial class InventoryManagementForm
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
            dgvIngredients = new DataGridView();
            txtName = new TextBox();
            txtUnit = new TextBox();
            nudQuantityInStock = new NumericUpDown();
            nudLowStockLevel = new NumericUpDown();
            btnUpdate = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            lblStockStatus = new Label();
            lblStockStatusTitle = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLowStockLevel).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.BackgroundColor = Color.White;
            dgvIngredients.BorderStyle = BorderStyle.None;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(0, 127);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersVisible = false;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.Size = new Size(934, 188);
            dgvIngredients.TabIndex = 0;
            dgvIngredients.CellClick += dgvIngredients_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 53);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(100, 25);
            txtName.TabIndex = 1;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(52, 95);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(100, 25);
            txtUnit.TabIndex = 2;
            // 
            // nudQuantityInStock
            // 
            nudQuantityInStock.DecimalPlaces = 2;
            nudQuantityInStock.Location = new Point(297, 59);
            nudQuantityInStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQuantityInStock.Name = "nudQuantityInStock";
            nudQuantityInStock.ReadOnly = true;
            nudQuantityInStock.Size = new Size(120, 25);
            nudQuantityInStock.TabIndex = 3;
            // 
            // nudLowStockLevel
            // 
            nudLowStockLevel.DecimalPlaces = 2;
            nudLowStockLevel.Location = new Point(297, 99);
            nudLowStockLevel.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudLowStockLevel.Name = "nudLowStockLevel";
            nudLowStockLevel.ReadOnly = true;
            nudLowStockLevel.Size = new Size(120, 25);
            nudLowStockLevel.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(214, 165, 70);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(606, 123);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 26);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Inventory";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.ForeColor = SystemColors.Desktop;
            btnRefresh.Location = new Point(618, 496);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 26);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 95);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 9;
            label2.Text = "Unit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 59);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 10;
            label3.Text = "Quantity In Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 95);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 11;
            label4.Text = "Low Stock Level";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 65);
            panel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(667, 19);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 1;
            label7.Text = "INVENTORY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(32, 19);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 0;
            label6.Text = "FLAVOR CRAVE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 68);
            label8.Name = "label8";
            label8.Size = new Size(285, 37);
            label8.TabIndex = 14;
            label8.Text = "Ingredient Inventory";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(0, 105);
            label9.Name = "label9";
            label9.Size = new Size(272, 19);
            label9.TabIndex = 15;
            label9.Text = "Monitor and update ingredient stock levels";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStockStatus);
            groupBox1.Controls.Add(lblStockStatusTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(nudQuantityInStock);
            groupBox1.Controls.Add(nudLowStockLevel);
            groupBox1.Location = new Point(12, 333);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 164);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Ingredient";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Location = new Point(297, 130);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(0, 19);
            lblStockStatus.TabIndex = 13;
            // 
            // lblStockStatusTitle
            // 
            lblStockStatusTitle.AutoSize = true;
            lblStockStatusTitle.Location = new Point(175, 130);
            lblStockStatusTitle.Name = "lblStockStatusTitle";
            lblStockStatusTitle.Size = new Size(91, 19);
            lblStockStatusTitle.TabIndex = 12;
            lblStockStatusTitle.Text = "Stock Status: ";
            // 
            // button1
            // 
            button1.Location = new Point(766, 499);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 17;
            button1.Text = "Back to Dashbord";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(934, 534);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvIngredients);
            Font = new Font("Segoe UI", 10F);
            Name = "InventoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Inventory Management";
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLowStockLevel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIngredients;
        private TextBox txtName;
        private TextBox txtUnit;
        private NumericUpDown nudQuantityInStock;
        private NumericUpDown nudLowStockLevel;
        private Button btnUpdate;
        private Button btnRefresh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private Label lblStockStatusTitle;
        private Label lblStockStatus;
        private Button button1;
    }
}