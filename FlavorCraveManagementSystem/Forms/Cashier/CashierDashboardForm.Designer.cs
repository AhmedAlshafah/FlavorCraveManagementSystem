namespace FlavorCraveManagementSystem.Forms.Cashier
{
    partial class CashierDashboardForm
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
            btnProcessPayment = new Button();
            btnWalletReport = new Button();
            btnProfile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 0;
            label1.Text = "Cashier Dashboard";
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.Location = new Point(246, 362);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(292, 33);
            btnProcessPayment.TabIndex = 1;
            btnProcessPayment.Text = "Process Payment";
            btnProcessPayment.UseVisualStyleBackColor = true;
            // 
            // btnWalletReport
            // 
            btnWalletReport.Location = new Point(246, 304);
            btnWalletReport.Name = "btnWalletReport";
            btnWalletReport.Size = new Size(292, 25);
            btnWalletReport.TabIndex = 2;
            btnWalletReport.Text = "Wallet Report";
            btnWalletReport.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(246, 243);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(292, 25);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // CashierDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(btnProfile);
            Controls.Add(btnWalletReport);
            Controls.Add(btnProcessPayment);
            Controls.Add(label1);
            Name = "CashierDashboardForm";
            Text = "Cashier Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProcessPayment;
        private Button btnWalletReport;
        private Button btnProfile;
    }
}