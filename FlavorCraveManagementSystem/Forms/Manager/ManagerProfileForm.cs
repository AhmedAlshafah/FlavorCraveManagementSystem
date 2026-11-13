
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
            string fullName =
                txtFullName.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            string phone =
                txtPhone.Text.Trim();

            string currentPassword =
                txtCurrentPassword.Text;

            string newPassword =
                txtNewPassword.Text;

            string confirmPassword =
                txtConfirmNewPassword.Text;


            // -------------------------
            // Profile validation
            // -------------------------

            if (fullName == "")
            {
                MessageBox.Show(
                    "Please enter your full name."
                );

                return;
            }

            if (email == "")
            {
                MessageBox.Show(
                    "Please enter your email."
                );

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
                    MessageBox.Show(
                        "This email is already being used by another user."
                    );

                    return;
                }


                // -------------------------
                // Password validation
                // Only runs if the user
                // entered something in the
                // password section.
                // -------------------------

                bool wantsToChangePassword =
                    currentPassword != "" ||
                    newPassword != "" ||
                    confirmPassword != "";

                if (wantsToChangePassword)
                {
                    if (currentPassword == "")
                    {
                        MessageBox.Show(
                            "Please enter your current password."
                        );

                        return;
                    }

                    if (newPassword == "")
                    {
                        MessageBox.Show(
                            "Please enter a new password."
                        );

                        return;
                    }

                    if (confirmPassword == "")
                    {
                        MessageBox.Show(
                            "Please confirm your new password."
                        );

                        return;
                    }

                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show(
                            "The new passwords do not match."
                        );

                        return;
                    }

                    if (newPassword.Length < 6)
                    {
                        MessageBox.Show(
                            "The new password must be at least 6 characters."
                        );

                        return;
                    }


                    bool currentPasswordCorrect =
                        profileService.IsCurrentPasswordCorrect(
                            loggedInUser.UserId,
                            currentPassword
                        );

                    if (!currentPasswordCorrect)
                    {
                        MessageBox.Show(
                            "The current password is incorrect."
                        );

                        return;
                    }
                }


                // -------------------------
                // Update profile
                // -------------------------

                profileService.UpdateProfile(
                    loggedInUser.UserId,
                    fullName,
                    email,
                    phone
                );


                // -------------------------
                // Update password only
                // when requested
                // -------------------------

                if (wantsToChangePassword)
                {
                    profileService.UpdatePassword(
                        loggedInUser.UserId,
                        newPassword
                    );

                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmNewPassword.Clear();
                }


                MessageBox.Show(
                    wantsToChangePassword
                        ? "Profile and password updated successfully."
                        : "Profile updated successfully."
                );

                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update profile:\n\n" +
                    ex.Message
                );
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
