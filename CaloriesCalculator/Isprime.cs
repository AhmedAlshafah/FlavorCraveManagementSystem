using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaloriesCalculator
{
    public partial class Isprime : Form
    {
        public Isprime()
        {
            InitializeComponent();
        }

        private void btnIsPrime_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtNumber.Text, out number))
            {
                if (prime(number))
                {
                    MessageBox.Show("Prime");
                }
                else { MessageBox.Show("Not Prime"); }


                  
            }

        }

        private bool prime(int n)

        {
            if (n <= 1)
            {
                return false;
            }




            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)

                {
                    return false;
                }

            }

                return true;

          

        }
    }
}
