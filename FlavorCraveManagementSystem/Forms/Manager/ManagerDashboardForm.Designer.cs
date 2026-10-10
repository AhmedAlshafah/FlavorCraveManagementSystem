namespace FlavorCraveManagementSystem.Forms.Manager
{
    partial class ManagerDashboardForm
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
            label1 = new Label();
            btnManageInventory = new Button();
            btnManageMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 22);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Manager Dashboard";
            // 
            // btnManageInventory
            // 
            btnManageInventory.Location = new Point(298, 94);
            btnManageInventory.Name = "btnManageInventory";
            btnManageInventory.Size = new Size(143, 23);
            btnManageInventory.TabIndex = 1;
            btnManageInventory.Text = "Manage Inventory";
            btnManageInventory.UseVisualStyleBackColor = true;
            btnManageInventory.Click += btnManageInventory_Click;
            // 
            // btnManageMenu
            // 
            btnManageMenu.Location = new Point(330, 181);
            btnManageMenu.Name = "btnManageMenu";
            btnManageMenu.Size = new Size(75, 23);
            btnManageMenu.TabIndex = 2;
            btnManageMenu.Text = "Manage Menu";
            btnManageMenu.UseVisualStyleBackColor = true;
            btnManageMenu.Click += btnManageMenu_Click;
            // 
            // ManagerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnManageMenu);
            Controls.Add(btnManageInventory);
            Controls.Add(label1);
            Name = "ManagerDashboardForm";
            Text = "Manager Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnManageInventory;
        private Button btnManageMenu;
    }
}