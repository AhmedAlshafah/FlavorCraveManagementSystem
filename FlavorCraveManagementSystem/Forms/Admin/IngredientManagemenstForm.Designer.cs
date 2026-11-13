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
            button1 = new Button();
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
            panel1.Size = new Size(1082, 74);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(855, 36);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 14;
            label4.Text = "INGREDIENT INVENTORY";
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
            lblingname.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblingname.Location = new Point(22, 147);
            lblingname.Name = "lblingname";
            lblingname.Size = new Size(131, 20);
            lblingname.TabIndex = 2;
            lblingname.Text = "Ingredient Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(26, 118);
            label1.Name = "label1";
            label1.Size = new Size(230, 16);
            label1.TabIndex = 3;
            label1.Text = " Manage Restaurant's Ingredients List";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblUnit.Location = new Point(442, 147);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(39, 20);
            lblUnit.TabIndex = 4;
            lblUnit.Text = "Unit";
            // 
            // txtIngName
            // 
            txtIngName.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtIngName.Location = new Point(22, 170);
            txtIngName.Name = "txtIngName";
            txtIngName.Size = new Size(397, 27);
            txtIngName.TabIndex = 5;
            // 
            // btnAddIng
            // 
            btnAddIng.BackColor = Color.Gold;
            btnAddIng.FlatStyle = FlatStyle.Flat;
            btnAddIng.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddIng.ForeColor = Color.FromArgb(30, 70, 55);
            btnAddIng.Location = new Point(23, 203);
            btnAddIng.Name = "btnAddIng";
            btnAddIng.Size = new Size(119, 29);
            btnAddIng.TabIndex = 7;
            btnAddIng.Text = "Add Ingredient";
            btnAddIng.UseVisualStyleBackColor = false;
            btnAddIng.Click += btnAddIng_Click;
            // 
            // btnUpdateIng
            // 
            btnUpdateIng.Location = new Point(148, 203);
            btnUpdateIng.Name = "btnUpdateIng";
            btnUpdateIng.Size = new Size(138, 29);
            btnUpdateIng.TabIndex = 8;
            btnUpdateIng.Text = "Update Ingredient";
            btnUpdateIng.UseVisualStyleBackColor = true;
            btnUpdateIng.Click += btnUpdateIng_Click;
            // 
            // btnRemoveIng
            // 
            btnRemoveIng.Location = new Point(292, 203);
            btnRemoveIng.Name = "btnRemoveIng";
            btnRemoveIng.Size = new Size(94, 29);
            btnRemoveIng.TabIndex = 9;
            btnRemoveIng.Text = "Remove Ingredient";
            btnRemoveIng.UseVisualStyleBackColor = true;
            btnRemoveIng.Click += btnRemoveIng_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(392, 203);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(492, 203);
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
            dgvIngredients.Size = new Size(1008, 379);
            dgvIngredients.TabIndex = 15;
            dgvIngredients.CellClick += dgvIngredients_CellClick;
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtUnit.Location = new Point(442, 170);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(336, 27);
            txtUnit.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(870, 203);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 17;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // IngredientManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(button1);
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
            Load += IngredientManagementForm_Load_1;
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
        private Button button1;
    }
}