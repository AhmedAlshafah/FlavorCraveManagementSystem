namespace practise55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int hourse;
            decimal rate;

            if (!int.TryParse(hoursTextBox.Text, out hourse))
            {
                MessageBox.Show("Please iner number");
                return;
            }

            if (!decimal.TryParse(rateTextBox.Text, out rate))
            {
                MessageBox.Show("Enter number");
                return;
            }

            decimal grossPay = CalculategrossPay(hourse, rate);

            resultLabel.Text = grossPay.ToString("N2");

        }

        private decimal CalculategrossPay(int hourse, decimal rate)
        {
            return hourse * rate;
        }
    }
}
