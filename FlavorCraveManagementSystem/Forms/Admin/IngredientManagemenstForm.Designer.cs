namespace FlavorCraveManagementSystem.Forms.Admin
{
    partial class IngredientManagementForm
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
            lblTitle = new Label();
            lblingname = new Label();
            label1 = new Label();
            lblUnit = new Label();
            txtIngName = new TextBox();
            btnAddIng = new Button();
            btnUpdateIng = new Button();
            btnRemoveIng = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            label2 = new Label();
            dgvIngredients = new DataGridView();
            txtUnit = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
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
            panel1.Size = new Size(800, 74);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(603, 36);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 14;
            label4.Text = "INGREDIENT INVENTORY";
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(22, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Ingredient Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblingname
            // 
            lblingname.AutoSize = true;
            lblingname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblingname.Location = new Point(22, 147);
            lblingname.Name = "lblingname";
            lblingname.Size = new Size(172, 28);
            lblingname.TabIndex = 2;
            lblingname.Text = "Ingredient Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 118);
            label1.Name = "label1";
            label1.Size = new Size(250, 20);
            label1.TabIndex = 3;
            label1.Text = "Manage Restaurant's Ingredients List";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnit.Location = new Point(442, 147);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(52, 28);
            lblUnit.TabIndex = 4;
            lblUnit.Text = "Unit";
            // 
            // txtIngName
            // 
            txtIngName.Location = new Point(22, 188);
            txtIngName.Name = "txtIngName";
            txtIngName.Size = new Size(397, 27);
            txtIngName.TabIndex = 5;
            // 
            // btnAddIng
            // 
            btnAddIng.Location = new Point(22, 221);
            btnAddIng.Name = "btnAddIng";
            btnAddIng.Size = new Size(119, 29);
            btnAddIng.TabIndex = 7;
            btnAddIng.Text = "Add Ingredient";
            btnAddIng.UseVisualStyleBackColor = true;
            btnAddIng.Click += btnAddIng_Click;
            // 
            // btnUpdateIng
            // 
            btnUpdateIng.Location = new Point(147, 221);
            btnUpdateIng.Name = "btnUpdateIng";
            btnUpdateIng.Size = new Size(138, 29);
            btnUpdateIng.TabIndex = 8;
            btnUpdateIng.Text = "Update Ingredient";
            btnUpdateIng.UseVisualStyleBackColor = true;
            btnUpdateIng.Click += btnUpdateIng_Click;
            // 
            // btnRemoveIng
            // 
            btnRemoveIng.Location = new Point(291, 221);
            btnRemoveIng.Name = "btnRemoveIng";
            btnRemoveIng.Size = new Size(94, 29);
            btnRemoveIng.TabIndex = 9;
            btnRemoveIng.Text = "Remove Ingredient";
            btnRemoveIng.UseVisualStyleBackColor = true;
            btnRemoveIng.Click += btnRemoveIng_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(391, 221);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(491, 221);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 253);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 12;
            label2.Text = "Register Menu Item";
            // 
            // dgvIngredients
            // 
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(22, 276);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.Size = new Size(756, 188);
            dgvIngredients.TabIndex = 15;
            dgvIngredients.CellClick += dgvIngredients_CellClick;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(442, 188);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(336, 27);
            txtUnit.TabIndex = 16;
            // 
            // IngredientManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUnit);
            Controls.Add(dgvIngredients);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnRemoveIng);
            Controls.Add(btnUpdateIng);
            Controls.Add(btnAddIng);
            Controls.Add(txtIngName);
            Controls.Add(lblUnit);
            Controls.Add(label1);
            Controls.Add(lblingname);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "IngredientManagementForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label lblTitle;
        private Label lblingname;
        private Label label1;
        private Label lblUnit;
        private TextBox txtIngName;
        private Button btnAddIng;
        private Button btnUpdateIng;
        private Button btnRemoveIng;
        private Button btnClear;
        private Button btnRefresh;
        private Label label2;
        private DataGridView dgvIngredients;
        private TextBox txtUnit;
    }
}