using System;
using System.Windows.Forms;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public partial class CashierProfileForm : Form
    {
        private readonly ProfileService _service = new ProfileService();
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
                MessageBox.Show("Could not load profile:\n" + ex.Message);
            }
        }

        private void SaveProfile()
        {
            try
            {
                _service.UpdateProfile(
                    _user.UserId,
                    txtFullName.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    txtCurrentPassword.Text,
                    txtNewPassword.Text,
                    txtConfirmPassword.Text);

                // Keep the logged-in user object in sync with the database
                _user.FullName = txtFullName.Text.Trim();
                _user.Email = txtEmail.Text.Trim();

                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();

                MessageBox.Show("Profile updated.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Please check your input");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save profile:\n" + ex.Message);
            }
        }
    }
}