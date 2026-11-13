namespace FlavorCraveManagementSystem.Forms.Admin
{
    partial class MenuIngredientMappingForm
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
            lblMenuItem = new Label();
            lblIngredient = new Label();
            lblQuantity = new Label();
            cmbMenuItem = new ComboBox();
            cmbIngredient = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnMap = new Button();
            btnRemoveMapping = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            dgvMappings = new DataGridView();
            label5 = new Label();
            btncancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMappings).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(882, 36);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 14;
            label4.Text = "INGREDIENT MAPPING";
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 2;
            label1.Text = "Menu Ingredient Mapping";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(265, 17);
            label2.TabIndex = 3;
            label2.Text = "Assign ingredients to restaurant menu items";
            // 
            // lblMenuItem
            // 
            lblMenuItem.AutoSize = true;
            lblMenuItem.Font = new Font("Microsoft Sans Serif", 9F);
            lblMenuItem.Location = new Point(12, 132);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new Size(122, 18);
            lblMenuItem.TabIndex = 4;
            lblMenuItem.Text = "Select Menu Item";
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Font = new Font("Microsoft Sans Serif", 9F);
            lblIngredient.Location = new Point(12, 187);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(116, 18);
            lblIngredient.TabIndex = 5;
            lblIngredient.Text = "Select Ingredient";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 9F);
            lblQuantity.Location = new Point(12, 242);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(125, 18);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity Required";
            // 
            // cmbMenuItem
            // 
            cmbMenuItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuItem.Font = new Font("Microsoft Sans Serif", 9F);
            cmbMenuItem.FormattingEnabled = true;
            cmbMenuItem.Location = new Point(12, 155);
            cmbMenuItem.Name = "cmbMenuItem";
            cmbMenuItem.Size = new Size(445, 26);
            cmbMenuItem.TabIndex = 7;
            cmbMenuItem.SelectedIndexChanged += cmbMenuItem_SelectedIndexChanged;
            // 
            // cmbIngredient
            // 
            cmbIngredient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngredient.Font = new Font("Microsoft Sans Serif", 9F);
            cmbIngredient.FormattingEnabled = true;
            cmbIngredient.Location = new Point(12, 210);
            cmbIngredient.Name = "cmbIngredient";
            cmbIngredient.Size = new Size(445, 26);
            cmbIngredient.TabIndex = 8;
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 2;
            nudQuantity.Font = new Font("Microsoft Sans Serif", 9F);
            nudQuantity.Location = new Point(12, 265);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(137, 24);
            nudQuantity.TabIndex = 9;
            // 
            // btnMap
            // 
            btnMap.BackColor = Color.Gold;
            btnMap.FlatStyle = FlatStyle.Flat;
            btnMap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMap.ForeColor = Color.FromArgb(30, 70, 55);
            btnMap.Location = new Point(12, 298);
            btnMap.Name = "btnMap";
            btnMap.Size = new Size(131, 29);
            btnMap.TabIndex = 10;
            btnMap.Text = "Map Ingredients";
            btnMap.UseVisualStyleBackColor = false;
            btnMap.Click += btnMap_Click;
            // 
            // btnRemoveMapping
            // 
            btnRemoveMapping.Location = new Point(149, 298);
            btnRemoveMapping.Name = "btnRemoveMapping";
            btnRemoveMapping.Size = new Size(94, 29);
            btnRemoveMapping.TabIndex = 11;
            btnRemoveMapping.Text = "Remove";
            btnRemoveMapping.UseVisualStyleBackColor = true;
            btnRemoveMapping.Click += btnRemoveMapping_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(249, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(349, 298);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMappings
            // 
            dgvMappings.BackgroundColor = SystemColors.ControlLightLight;
            dgvMappings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMappings.Location = new Point(12, 365);
            dgvMappings.Name = "dgvMappings";
            dgvMappings.ReadOnly = true;
            dgvMappings.RowHeadersWidth = 51;
            dgvMappings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMappings.Size = new Size(1045, 325);
            dgvMappings.TabIndex = 14;
            dgvMappings.CellClick += dgvMappings_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 334);
            label5.Name = "label5";
            label5.Size = new Size(202, 28);
            label5.TabIndex = 15;
            label5.Text = "Mapped Ingredients";
            // 
            // btncancel
            // 
            btncancel.BackColor = SystemColors.ButtonHighlight;
            btncancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancel.ForeColor = SystemColors.ActiveCaptionText;
            btncancel.Location = new Point(907, 298);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(150, 29);
            btncancel.TabIndex = 16;
            btncancel.Text = "Back to Dashboard";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // MenuIngredientMappingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(btncancel);
            Controls.Add(label5);
            Controls.Add(dgvMappings);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnRemoveMapping);
            Controls.Add(btnMap);
            Controls.Add(nudQuantity);
            Controls.Add(cmbIngredient);
            Controls.Add(cmbMenuItem);
            Controls.Add(lblQuantity);
            Controls.Add(lblIngredient);
            Controls.Add(lblMenuItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "MenuIngredientMappingForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMappings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblMenuItem;
        private Label lblIngredient;
        private Label lblQuantity;
        private ComboBox cmbMenuItem;
        private ComboBox cmbIngredient;
        private NumericUpDown nudQuantity;
        private Button btnMap;
        private Button btnRemoveMapping;
        private Button btnClear;
        private Button btnRefresh;
        private DataGridView dgvMappings;
        private Label label5;
        private Button btncancel;
    }
}