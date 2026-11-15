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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            lblMenuStatus = new Label();
            lblMenuStatusTitle = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuItems.BackgroundColor = Color.White;
            dgvMenuItems.BorderStyle = BorderStyle.None;
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Location = new Point(0, 138);
            dgvMenuItems.MultiSelect = false;
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.RowHeadersVisible = false;
            dgvMenuItems.RowHeadersWidth = 51;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.Size = new Size(934, 188);
            dgvMenuItems.TabIndex = 0;
            dgvMenuItems.CellClick += dgvMenuItems_CellClick;
            // 
            // txtMenuName
            // 
            txtMenuName.Location = new Point(85, 38);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.ReadOnly = true;
            txtMenuName.Size = new Size(204, 30);
            txtMenuName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(85, 79);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(204, 31);
            cmbCategory.TabIndex = 2;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(410, 52);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 30);
            nudPrice.TabIndex = 3;
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(410, 90);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(18, 17);
            chkIsAvailable.TabIndex = 4;
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(214, 165, 70);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(623, 119);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 32);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Menu";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.Firebrick;
            btnDeactivate.FlatAppearance.BorderSize = 0;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(623, 72);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(137, 26);
            btnDeactivate.TabIndex = 6;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(647, 502);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 36);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 8;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 9;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 52);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 10;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 85);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 11;
            label4.Text = "Available:";
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.FromArgb(30, 70, 55);
            btnActivate.FlatAppearance.BorderSize = 0;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.ForeColor = Color.White;
            btnActivate.Location = new Point(623, 24);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(137, 26);
            btnActivate.TabIndex = 12;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 65);
            panel1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(667, 19);
            label6.Name = "label6";
            label6.Size = new Size(230, 28);
            label6.TabIndex = 15;
            label6.Text = "MENU MANAGEMENT ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 19);
            label5.Name = "label5";
            label5.Size = new Size(234, 41);
            label5.TabIndex = 14;
            label5.Text = "FLAVOR CRAVE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 68);
            label7.Name = "label7";
            label7.Size = new Size(361, 46);
            label7.TabIndex = 14;
            label7.Text = "Menu Management   ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(12, 114);
            label8.Name = "label8";
            label8.Size = new Size(381, 23);
            label8.TabIndex = 15;
            label8.Text = "Manage menu pricing, category and availability  ";
            label8.Click += label8_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMenuStatus);
            groupBox1.Controls.Add(lblMenuStatusTitle);
            groupBox1.Controls.Add(txtMenuName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(btnActivate);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDeactivate);
            groupBox1.Controls.Add(nudPrice);
            groupBox1.Controls.Add(chkIsAvailable);
            groupBox1.Location = new Point(24, 332);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 164);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Menu Item  ";
            // 
            // lblMenuStatus
            // 
            lblMenuStatus.AutoSize = true;
            lblMenuStatus.Location = new Point(410, 128);
            lblMenuStatus.Name = "lblMenuStatus";
            lblMenuStatus.Size = new Size(0, 23);
            lblMenuStatus.TabIndex = 14;
            // 
            // lblMenuStatusTitle
            // 
            lblMenuStatusTitle.AutoSize = true;
            lblMenuStatusTitle.Location = new Point(326, 126);
            lblMenuStatusTitle.Name = "lblMenuStatusTitle";
            lblMenuStatusTitle.Size = new Size(60, 23);
            lblMenuStatusTitle.TabIndex = 13;
            lblMenuStatusTitle.Text = "Status:";
            // 
            // button1
            // 
            button1.Location = new Point(768, 502);
            button1.Name = "button1";
            button1.Size = new Size(166, 34);
            button1.TabIndex = 17;
            button1.Text = "Back to Dashbord";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuManagementForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(1082, 653);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvMenuItems);
            Font = new Font("Segoe UI", 10F);
            Name = "MenuManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flavor Crave - Menu Management";
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private Label lblMenuStatusTitle;
        private Label lblMenuStatus;
        private Button button1;
    }
}