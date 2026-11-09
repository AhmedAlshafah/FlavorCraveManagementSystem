namespace practise55
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
            label1 = new Label();
            Label = new Label();
            label3 = new Label();
            hoursTextBox = new TextBox();
            rateTextBox = new TextBox();
            calculateButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 13);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Hours Worked";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(38, 80);
            Label.Name = "Label";
            Label.Size = new Size(66, 15);
            Label.TabIndex = 1;
            Label.Text = "Hourly rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 143);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Calculate";
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(38, 40);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(100, 23);
            hoursTextBox.TabIndex = 3;
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(38, 98);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(100, 23);
            rateTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(38, 164);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(200, 168);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(45, 15);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Result: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(calculateButton);
            Controls.Add(rateTextBox);
            Controls.Add(hoursTextBox);
            Controls.Add(label3);
            Controls.Add(Label);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Label;
        private Label label3;
        private TextBox hoursTextBox;
        private TextBox rateTextBox;
        private Button calculateButton;
        private Label resultLabel;
    }
}
