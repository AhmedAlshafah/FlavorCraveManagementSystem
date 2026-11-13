using FlavorCraveManagementSystem.Models;
using FlavorCraveManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace FlavorCraveManagementSystem.Forms.Chef
{
    public partial class ChefProfileForm : Form
    {
        

        private readonly User currentUser;

        private readonly FlavorCraveManagementSystem.Services.ProfileService profileService =
    new FlavorCraveManagementSystem.Services.ProfileService();
        public ChefProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            LoadProfile();


        }

        private void LoadProfile()
        {
            try
            {
                User? user =
                    profileService.GetUserById(
                        currentUser.UserId
                    );

                if (user != null)
                {
                    txtName.Text = user.FullName;
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName =
                txtName.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            string phone =
                txtPhone.Text.Trim();

            string currentPassword =
                txtCurrentPassword.Text.Trim();

            string newPassword =
                txtNewPassword.Text.Trim();

            string confirmPassword =
                txtConfirmNewPassword.Text.Trim();


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
                        currentUser.UserId
                    );

                if (emailUsed)
                {
                    MessageBox.Show(
                        "This email is already being used by another user."
                    );

                    return;
                }


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

                    AuthService authService =
                        new AuthService();

                    User? verifiedUser =
                        authService.Login(
                            currentUser.Email,
                            currentPassword
                        );

                    if (verifiedUser == null)
                    {
                        MessageBox.Show(
                            "The current password is incorrect."
                        );

                        return;
                    }

                }


                profileService.UpdateProfile(
                    currentUser.UserId,
                    fullName,
                    email,
                    phone
                );


                if (wantsToChangePassword)
                {
                    profileService.UpdatePassword(
                        currentUser.UserId,
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackToDashbord_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
