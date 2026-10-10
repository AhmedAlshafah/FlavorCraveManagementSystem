namespace FlavorCraveManagementSystem.Forms.Manager
{
    partial class MenuManagementForm
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
            dgvMenuItems = new DataGridView();
            txtMenuName = new TextBox();
            cmbCategory = new ComboBox();
            nudPrice = new NumericUpDown();
            chkIsAvailable = new CheckBox();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnActivate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Location = new Point(23, 41);
            dgvMenuItems.MultiSelect = false;
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.Size = new Size(765, 196);
            dgvMenuItems.TabIndex = 0;
            dgvMenuItems.CellClick += dgvMenuItems_CellClick;
            // 
            // txtMenuName
            // 
            txtMenuName.Location = new Point(12, 268);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.ReadOnly = true;
            txtMenuName.Size = new Size(100, 23);
            txtMenuName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(141, 268);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 2;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(302, 267);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 23);
            nudPrice.TabIndex = 3;
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(446, 277);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(15, 14);
            chkIsAvailable.TabIndex = 4;
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(23, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Location = new Point(23, 393);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(75, 23);
            btnDeactivate.TabIndex = 6;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = true;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(23, 308);
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
            label1.Location = new Point(12, 250);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 8;
            label1.Text = "Menu Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 250);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 9;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 250);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 250);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 11;
            label4.Text = "Available";
            // 
            // btnActivate
            // 
            btnActivate.Location = new Point(141, 393);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(75, 23);
            btnActivate.TabIndex = 12;
            btnActivate.Text = "Active";
            btnActivate.UseVisualStyleBackColor = true;
            btnActivate.Click += btnActivate_Click;
            // 
            // MenuManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActivate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeactivate);
            Controls.Add(btnUpdate);
            Controls.Add(chkIsAvailable);
            Controls.Add(nudPrice);
            Controls.Add(cmbCategory);
            Controls.Add(txtMenuName);
            Controls.Add(dgvMenuItems);
            Name = "MenuManagementForm";
            Text = "MenuManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMenuItems;
        private TextBox txtMenuName;
        private ComboBox cmbCategory;
        private NumericUpDown nudPrice;
        private CheckBox chkIsAvailable;
        private Button btnUpdate;
        private Button btnDeactivate;
        private Button btnRefresh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnActivate;
    }
}