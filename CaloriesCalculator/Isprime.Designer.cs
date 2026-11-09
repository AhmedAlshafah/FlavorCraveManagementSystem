namespace CaloriesCalculator
{
    partial class Isprime
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
            lblReuslt = new Label();
            txtNumber = new TextBox();
            btnIsPrime = new Button();
            SuspendLayout();
            // 
            // lblReuslt
            // 
            lblReuslt.AutoSize = true;
            lblReuslt.Location = new Point(203, 53);
            lblReuslt.Name = "lblReuslt";
            lblReuslt.Size = new Size(39, 15);
            lblReuslt.TabIndex = 0;
            lblReuslt.Text = "Result";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(293, 50);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(157, 23);
            txtNumber.TabIndex = 1;
            // 
            // btnIsPrime
            // 
            btnIsPrime.Location = new Point(293, 105);
            btnIsPrime.Name = "btnIsPrime";
            btnIsPrime.Size = new Size(151, 23);
            btnIsPrime.TabIndex = 2;
            btnIsPrime.Text = "Check if the numer prime";
            btnIsPrime.UseVisualStyleBackColor = true;
            btnIsPrime.Click += btnIsPrime_Click;
            // 
            // Isprime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIsPrime);
            Controls.Add(txtNumber);
            Controls.Add(lblReuslt);
            Name = "Isprime";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReuslt;
        private TextBox txtNumber;
        private Button btnIsPrime;
    }
}