using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class ManagerDashboardForm : Form
    {
        private User loggedInUser;

        public ManagerDashboardForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;
        }
    }
}