
using System;
using System.Drawing;
using System.Windows.Forms;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public partial class CashierProfileForm : Form
    {
        private readonly ProfileService _service =
            new ProfileService();

        private readonly User _user;

        public CashierProfileForm(User user)
        {
            InitializeComponent();
            _user = user;

            txtCurrentPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            txtFullName.MaxLength = 100;
            txtEmail.MaxLength = 100;
            txtPhone.MaxLength = 20;

            lblStatus.Text = "";

            btnSave.Click += (s, e) => SaveProfile();
            btnClose.Click += (s, e) => Close();
            Load += (s, e) => LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                var profile = _service.GetProfile(_user.UserId);

                txtFullName.Text = profile.FullName;
                txtEmail.Text = profile.Email;
                txtPhone.Text = profile.Phone;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Could not load profile.";
            }
        }

        private void SaveProfile()
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "";

            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate personal information
            if (fullName == "" || email == "")
            {
                lblStatus.Text =
                    "Full name and email are required.";
                return;
            }

            if (!System.Net.Mail.MailAddress.TryCreate(
                email, out var address) || address.Address != email)
            {
                lblStatus.Text = "Invalid email address.";
                return;
            }

            // Password change is optional
            bool changePassword =
                currentPassword != "" ||
                newPassword != "" ||
                confirmPassword != "";

            if (changePassword)
            {
                if (currentPassword == "")
                {
                    lblStatus.Text =
                        "Please enter your current password.";
                    return;
                }

                if (newPassword == "")
                {
                    lblStatus.Text =
                        "Please enter a new password.";
                    return;
                }

                if (confirmPassword == "")
                {
                    lblStatus.Text =
                        "Please confirm your new password.";
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    lblStatus.Text =
                        "New passwords do not match.";
                    return;
                }

                if (newPassword.Length < 8)
                {
                    lblStatus.Text =
                        "New password must be at least 8 characters.";
                    return;
                }
            }

            try
            {
                // Update using the existing ProfileService
                _service.UpdateProfile(
                    _user.UserId,
                    fullName,
                    email,
                    phone,
                    changePassword ? currentPassword : "",
                    changePassword ? newPassword : "",
                    changePassword ? confirmPassword : ""
                );

                // Update logged-in user details
                _user.FullName = fullName;
                _user.Email = email;

                // Clear password fields
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();

                // Refresh displayed profile information
                LoadProfile();

                // Show success inside the form
                lblStatus.ForeColor = Color.Green;

                if (changePassword)
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
            catch (InvalidOperationException ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Could not save profile.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
