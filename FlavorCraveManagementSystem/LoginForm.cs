using FlavorCraveManagementSystem.Forms.Admin;
using FlavorCraveManagementSystem.Forms.Manager;
using FlavorCraveManagementSystem.Forms.Cashier;
using FlavorCraveManagementSystem.Forms.Chef;
using FlavorCraveManagementSystem.Forms.Customer;
using FlavorCraveManagementSystem.Models;
using FlavorCraveManagementSystem.Services;



namespace FlavorCraveManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter your email and password.");
                return;
            }

            try
            {
                AuthService authService = new AuthService();

                User? user = authService.Login(email, password);

                if (user == null)
                {
                    MessageBox.Show("Invalid email or password.");
                    return;
                }

                this.Hide();

                if (user.RoleName == "SystemAdmin")
                {
                    AdminDashboardForm dashboard = new AdminDashboardForm(user);
                    dashboard.ShowDialog();
                }
                else if (user.RoleName == "Manager")
                {
                    ManagerDashboardForm dashboard = new ManagerDashboardForm(user);
                    dashboard.ShowDialog();
                }
                else if (user.RoleName == "Cashier")
                {
                    CashierDashboardForm dashboard = new CashierDashboardForm(user);
                    dashboard.ShowDialog();
                }
                else if (user.RoleName == "Chef")
                {
                    ChefDashboardForm dashboard = new ChefDashboardForm(user);
                    dashboard.ShowDialog();
                }
                else if (user.RoleName == "Customer")
                {
                    CustomerDashboardForm dashboard = new CustomerDashboardForm(user);
                    dashboard.ShowDialog();
                }

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login failed:\n\n" + ex.Message
                );
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
