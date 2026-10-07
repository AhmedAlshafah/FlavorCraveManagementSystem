using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public partial class CashierDashboardForm : Form
    {
        private User loggedInUser;

        public CashierDashboardForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;
        }
    }
}