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
            label5 = new Label();
            chkIsActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLowStockLevel).BeginInit();
            SuspendLayout();
            // 
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(12, 138);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.Size = new Size(761, 274);
            dgvIngredients.TabIndex = 0;
            dgvIngredients.CellClick += dgvIngredients_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(148, 28);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(100, 23);
            txtUnit.TabIndex = 2;
            // 
            // nudQuantityInStock
            // 
            nudQuantityInStock.DecimalPlaces = 2;
            nudQuantityInStock.Location = new Point(640, 28);
            nudQuantityInStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQuantityInStock.Name = "nudQuantityInStock";
            nudQuantityInStock.ReadOnly = true;
            nudQuantityInStock.Size = new Size(120, 23);
            nudQuantityInStock.TabIndex = 3;
            // 
            // nudLowStockLevel
            // 
            nudLowStockLevel.DecimalPlaces = 2;
            nudLowStockLevel.Location = new Point(640, 99);
            nudLowStockLevel.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudLowStockLevel.Name = "nudLowStockLevel";
            nudLowStockLevel.ReadOnly = true;
            nudLowStockLevel.Size = new Size(120, 23);
            nudLowStockLevel.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(35, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(663, 418);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 9;
            label2.Text = "Unit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(640, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 10;
            label3.Text = "Quantity In Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 74);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 11;
            label4.Text = "Low Stock Level";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 74);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 12;
            label5.Text = "Active";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(20, 74);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(15, 14);
            chkIsActive.TabIndex = 5;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(chkIsActive);
            Controls.Add(nudLowStockLevel);
            Controls.Add(nudQuantityInStock);
            Controls.Add(txtUnit);
            Controls.Add(txtName);
            Controls.Add(dgvIngredients);
            Name = "InventoryManagementForm";
            Text = "InventoryManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLowStockLevel).EndInit();
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
        private Label label5;
        private CheckBox chkIsActive;
    }
}