using System.Numerics;

namespace CaloriesCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double fatGrams;
            double carbGrams;

            if (double.TryParse(txtFatGrams.Text, out fatGrams) &&
                double.TryParse(txtCarbGrams.Text, out carbGrams) &&
                fatGrams >= 0 && carbGrams >= 0)
            {
                double fat = FatCalories(fatGrams);
                double carb = CarbCalories(carbGrams);

                lblFatCalories.Text = "Calroies from fat" + fat;

                lblCarbCalories.Text = "Calroies from carbs" + carb;

            }

            else
            {
                MessageBox.Show(
                    "Please enter valid, non-negative numbers",
                    "Invalid Input");
            }
        }



        // Method to calculate the Fat Calories

        private double FatCalories(double fatGrams)

        {
            return fatGrams * 9;
        }

        // Method to calculate the carb calories

        private double CarbCalories(double carbGrams)
        {
            return carbGrams * 4;
        }


    }
}
