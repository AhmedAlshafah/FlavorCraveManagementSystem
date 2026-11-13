namespace Array
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpView = new GroupBox();
            lblEmail = new Label();
            cboNames = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            grpAdd = new GroupBox();
            btnAddNew = new Button();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            grpView.SuspendLayout();
            grpAdd.SuspendLayout();
            SuspendLayout();
            // 
            // grpView
            // 
            grpView.Controls.Add(lblEmail);
            grpView.Controls.Add(cboNames);
            grpView.Controls.Add(label2);
            grpView.Controls.Add(label1);
            grpView.Location = new Point(91, 73);
            grpView.Name = "grpView";
            grpView.Size = new Size(258, 177);
            grpView.TabIndex = 0;
            grpView.TabStop = false;
            grpView.Text = "View Record";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(131, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "------------";
            // 
            // cboNames
            // 
            cboNames.FormattingEnabled = true;
            cboNames.Location = new Point(131, 28);
            cboNames.Name = "cboNames";
            cboNames.Size = new Size(90, 23);
            cboNames.TabIndex = 1;
            cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(btnAddNew);
            grpAdd.Controls.Add(txtEmail);
            grpAdd.Controls.Add(txtName);
            grpAdd.Controls.Add(label4);
            grpAdd.Controls.Add(label3);
            grpAdd.Location = new Point(478, 78);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(294, 197);
            grpAdd.TabIndex = 1;
            grpAdd.TabStop = false;
            grpAdd.Text = "Add New Record";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(85, 149);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 4;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 102);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 1;
            label4.Text = "New Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 31);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "New Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpAdd);
            Controls.Add(grpView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpView.ResumeLayout(false);
            grpView.PerformLayout();
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpView;
        private Label label2;
        private Label label1;
        private ComboBox cboNames;
        private GroupBox grpAdd;
        private Label label4;
        private Label label3;
        private Button btnAddNew;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lblEmail;
    }
}
