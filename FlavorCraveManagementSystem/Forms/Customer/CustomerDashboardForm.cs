using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        private User loggedInUser;

        public CustomerDashboardForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }
    }
}