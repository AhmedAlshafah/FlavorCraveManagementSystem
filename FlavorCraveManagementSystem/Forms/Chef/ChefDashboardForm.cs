using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Chef
{
    public partial class ChefDashboardForm : Form
    {
        private User loggedInUser;

        public ChefDashboardForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }
    }
}