using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        private User loggedInUser;

        public AdminDashboardForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;
        }
    }
}