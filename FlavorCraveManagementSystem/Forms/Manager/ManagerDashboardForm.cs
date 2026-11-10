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

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            InventoryManagementForm form = new InventoryManagementForm();
            form.ShowDialog();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            MenuManagementForm form = new MenuManagementForm();
            form.ShowDialog();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm form = new SalesReportForm();
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ManagerProfileForm form =
    new ManagerProfileForm(loggedInUser);

            form.ShowDialog();
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to log out?",
               "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                                            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            lblWelcome.Text =
    $"Welcome, {loggedInUser.FullName}";
        }
    }
}