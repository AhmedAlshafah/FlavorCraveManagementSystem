
using FlavorCraveManagementSystem.Services;

using FlavorCraveManagementSystem.Models;


namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class ManagerProfileForm : Form
    {
        private User loggedInUser;
        private readonly ProfileService profileService =
          new ProfileService();
        public ManagerProfileForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;

            lblStatus.Text = "";

            txtCurrentPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmNewPassword.UseSystemPasswordChar = true;

            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                User? user =
                    profileService.GetUserById(
                        loggedInUser.UserId
                    );

                if (user != null)
                {
                    txtFullName.Text = user.FullName;
                    txtEmail.Text = user.Email;
                    txtPhone.Text = user.Phone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load profile:\n\n" +
                    ex.Message
                );
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "";

            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmNewPassword.Text;

            // Validate profile information
            if (fullName == "")
            {
                lblStatus.Text = "Please enter your full name.";
                return;
            }

            if (email == "")
            {
                lblStatus.Text = "Please enter your email.";
                return;
            }

            try
            {
                bool emailUsed =
                    profileService.IsEmailUsedByAnotherUser(
                        email,
                        loggedInUser.UserId
                    );

                if (emailUsed)
                {
                    lblStatus.Text = "This email is already being used.";
                    return;
                }

                // Password change is optional
                bool wantsToChangePassword =
                    newPassword != "" || confirmPassword != "";

                if (wantsToChangePassword)
                {
                    if (currentPassword == "")
                    {
                        lblStatus.Text = "Please enter your current password.";
                        return;
                    }

                    if (newPassword == "")
                    {
                        lblStatus.Text = "Please enter a new password.";
                        return;
                    }

                    if (confirmPassword == "")
                    {
                        lblStatus.Text = "Please confirm your new password.";
                        return;
                    }

                    if (newPassword != confirmPassword)
                    {
                        lblStatus.Text = "The new passwords do not match.";
                        return;
                    }

                    if (newPassword.Length < 6)
                    {
                        lblStatus.Text =
                            "New password must be at least 6 characters.";
                        return;
                    }

                    AuthService authService = new AuthService();
                    User? verifiedUser =
                        authService.Login(loggedInUser.Email,currentPassword);

                    if (verifiedUser == null)
                    {
                        lblStatus.Text = "Current password is incorrect.";
                        return;
                    }
                }

                // Update name, email and phone
                profileService.UpdateProfile(
                    loggedInUser.UserId,
                    fullName,
                    email,
                    phone
                );

                // Only update password if requested
                if (wantsToChangePassword)
                {
                    profileService.UpdatePassword(
                        loggedInUser.UserId,
                        newPassword
                    );
                }

                // Clear password fields
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmNewPassword.Clear();

                // Refresh profile
                LoadProfile();

                // Display success inside the form
                lblStatus.ForeColor = Color.Green;

                if (wantsToChangePassword)
                {
                    lblStatus.Text =
                        "Profile and password updated successfully!";
                }
                else
                {
                    lblStatus.Text =
                        "Profile updated successfully!";
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Failed to update profile: " + ex.Message;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
