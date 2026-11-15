namespace FlavorCraveManagementSystem.Forms.Admin
{
    partial class MenuItemManagementForm
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblName = new Label();
            lblCategory = new Label();
            txtMenuName = new TextBox();
            cmbCategory = new ComboBox();
            btnAddMenu = new Button();
            btnUpdateMenu = new Button();
            btnRemoveMenu = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            dgvMenuItems = new DataGridView();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            nudPrice = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 74);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(936, 36);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 14;
            label4.Text = "MENU ITEM";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(22, 19);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 13;
            label3.Text = "FLAVOR CRAVE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 77);
            label1.Name = "label1";
            label1.Size = new Size(291, 29);
            label1.TabIndex = 3;
            label1.Text = "Menu Item Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(22, 105);
            label2.Name = "label2";
            label2.Size = new Size(283, 16);
            label2.TabIndex = 4;
            label2.Text = "Manage the restaurant's approved menu items";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblName.Location = new Point(22, 131);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Menu Item Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblCategory.Location = new Point(527, 131);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // txtMenuName
            // 
            txtMenuName.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMenuName.Location = new Point(22, 154);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.Size = new Size(499, 27);
            txtMenuName.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Microsoft Sans Serif", 10.2F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(527, 154);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(503, 28);
            cmbCategory.TabIndex = 8;
            // 
            // btnAddMenu
            // 
            btnAddMenu.BackColor = Color.Gold;
            btnAddMenu.FlatStyle = FlatStyle.Flat;
            btnAddMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMenu.ForeColor = Color.FromArgb(30, 70, 55);
            btnAddMenu.Location = new Point(22, 255);
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new Size(94, 29);
            btnAddMenu.TabIndex = 9;
            btnAddMenu.Text = "Add Menu";
            btnAddMenu.UseVisualStyleBackColor = false;
            btnAddMenu.Click += btnAddMenu_Click;
            // 
            // btnUpdateMenu
            // 
            btnUpdateMenu.Location = new Point(122, 255);
            btnUpdateMenu.Name = "btnUpdateMenu";
            btnUpdateMenu.Size = new Size(110, 29);
            btnUpdateMenu.TabIndex = 10;
            btnUpdateMenu.Text = "Update Menu";
            btnUpdateMenu.UseVisualStyleBackColor = true;
            btnUpdateMenu.Click += btnUpdateMenu_Click;
            // 
            // btnRemoveMenu
            // 
            btnRemoveMenu.Location = new Point(238, 255);
            btnRemoveMenu.Name = "btnRemoveMenu";
            btnRemoveMenu.Size = new Size(94, 29);
            btnRemoveMenu.TabIndex = 11;
            btnRemoveMenu.Text = "Remove";
            btnRemoveMenu.UseVisualStyleBackColor = true;
            btnRemoveMenu.Click += btnRemoveMenu_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(338, 255);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(438, 255);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuItems.BackgroundColor = Color.White;
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Location = new Point(22, 335);
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.RowHeadersWidth = 51;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.Size = new Size(1008, 354);
            dgvMenuItems.TabIndex = 14;
            dgvMenuItems.CellClick += dgvMenuItems_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 291);
            label5.Name = "label5";
            label5.Size = new Size(208, 28);
            label5.TabIndex = 15;
            label5.Text = "Register Menu Items";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(883, 255);
            button1.Name = "button1";
            button1.Size = new Size(147, 29);
            button1.TabIndex = 16;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 201);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 18;
            label6.Text = "Price:";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(76, 199);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 27);
            nudPrice.TabIndex = 17;
            // 
            // MenuItemManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(label6);
            Controls.Add(nudPrice);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(dgvMenuItems);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnRemoveMenu);
            Controls.Add(btnUpdateMenu);
            Controls.Add(btnAddMenu);
            Controls.Add(cmbCategory);
            Controls.Add(txtMenuName);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "MenuItemManagementForm";
            Text = "Form1";
            Click += btnAddMenu_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblName;
        private Label lblCategory;
        private TextBox txtMenuName;
        private ComboBox cmbCategory;
        private Button btnAddMenu;
        private Button btnUpdateMenu;
        private Button btnRemoveMenu;
        private Button btnClear;
        private Button btnRefresh;
        private DataGridView dgvMenuItems;
        private Label label5;
        private Button button1;
        private Label label6;
        private NumericUpDown nudPrice;
    }
}