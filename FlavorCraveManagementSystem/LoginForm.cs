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

                MessageBox.Show(
                    $"Welcome, {user.FullName}\nRole: {user.RoleName}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login failed:\n\n" + ex.Message
                );
            }
        }
    }
}
