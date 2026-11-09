namespace CaloriesCalculator
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
            lblFatCalories = new Label();
            lblCarbCalories = new Label();
            txtFatGrams = new TextBox();
            txtCarbGrams = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblFatCalories
            // 
            lblFatCalories.AutoSize = true;
            lblFatCalories.Location = new Point(65, 31);
            lblFatCalories.Name = "lblFatCalories";
            lblFatCalories.Size = new Size(96, 15);
            lblFatCalories.TabIndex = 0;
            lblFatCalories.Text = "Enter fat grams:  ";
            // 
            // lblCarbCalories
            // 
            lblCarbCalories.AutoSize = true;
            lblCarbCalories.Location = new Point(65, 86);
            lblCarbCalories.Name = "lblCarbCalories";
            lblCarbCalories.Size = new Size(152, 15);
            lblCarbCalories.TabIndex = 1;
            lblCarbCalories.Text = "Enter carbohydrate grams:  ";
            // 
            // txtFatGrams
            // 
            txtFatGrams.Location = new Point(238, 23);
            txtFatGrams.Name = "txtFatGrams";
            txtFatGrams.Size = new Size(120, 23);
            txtFatGrams.TabIndex = 2;
            // 
            // txtCarbGrams
            // 
            txtCarbGrams.Location = new Point(238, 83);
            txtCarbGrams.Name = "txtCarbGrams";
            txtCarbGrams.Size = new Size(120, 23);
            txtCarbGrams.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(65, 155);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(147, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(218, 155);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtCarbGrams);
            Controls.Add(txtFatGrams);
            Controls.Add(lblCarbCalories);
            Controls.Add(lblFatCalories);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFatCalories;
        private Label lblCarbCalories;
        private TextBox txtFatGrams;
        private TextBox txtCarbGrams;
        private Button btnCalculate;
        private Button btnClear;
    }
}
