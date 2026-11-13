using System;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;
using FlavorCraveManagementSystem.Services;
namespace FlavorCraveManagementSystem.Forms.Customer
{
    public partial class ProfileForm : Form
    {
        private User loggedInUser;

        public ProfileForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;

            lblStatus.Text = "";

            txtCurrentPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConformNewPassword.UseSystemPasswordChar = true;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txtFullName.Text = loggedInUser.FullName;
            txtEmail.Text = loggedInUser.Email;

            try
            {
                // 保持你原来的写法：Phone
                string sql = "SELECT Phone FROM Users WHERE UserId = @UserId";
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        txtPhone.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "";

            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConformNewPassword.Text;

            // Validate personal information
            if (fullName == "" || email == "" || phone == "")
            {
                lblStatus.Text = "Please fill in all personal details.";
                return;
            }

            if (!System.Net.Mail.MailAddress.TryCreate(
                email, out var address) || address.Address != email)
            {
                lblStatus.Text = "Please enter a valid email address.";
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
                    lblStatus.Text = "New passwords do not match.";
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
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string storedHash = "";

                    // Verify password only when changing password
                    if (changePassword)
                    {
                        string checkSql =
                            "SELECT PasswordHash FROM Users WHERE UserId = @Id";

                        using (SqlCommand check =
                            new SqlCommand(checkSql, conn))
                        {
                            check.Parameters.AddWithValue(
                                "@Id", loggedInUser.UserId);

                            object? result = check.ExecuteScalar();

                            if (result == null || result == DBNull.Value)
                            {
                                lblStatus.Text = "User not found.";
                                return;
                            }

                            storedHash = result.ToString() ?? "";
                        }

                        if (!AuthService.VerifyPassword(
                            currentPassword, storedHash))
                        {
                            lblStatus.Text = "Current password is incorrect.";
                            return;
                        }
                    }

                    // Check whether another user has the same email
                    string emailSql = @"
                SELECT COUNT(*) FROM Users
                WHERE Email = @Email AND UserId <> @Id";

                    using (SqlCommand checkEmail =
                        new SqlCommand(emailSql, conn))
                    {
                        checkEmail.Parameters.AddWithValue("@Email", email);
                        checkEmail.Parameters.AddWithValue(
                            "@Id", loggedInUser.UserId);

                        if (Convert.ToInt32(checkEmail.ExecuteScalar()) > 0)
                        {
                            lblStatus.Text = "This email is already used.";
                            return;
                        }
                    }

                    // Update personal details
                    string sql = @"
                UPDATE Users
                SET FullName = @Name,
                    Email = @Email,
                    Phone = @Phone";

                    // Update password only if requested
                    if (changePassword)
                    {
                        sql += ", PasswordHash = @NewHash";
                    }

                    sql += " WHERE UserId = @Id";

                    if (changePassword)
                    {
                        sql += " AND PasswordHash = @OldHash";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue(
                            "@Id", loggedInUser.UserId);

                        if (changePassword)
                        {
                            cmd.Parameters.AddWithValue(
                                "@NewHash",
                                AuthService.HashPassword(newPassword));

                            cmd.Parameters.AddWithValue(
                                "@OldHash", storedHash);
                        }

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            lblStatus.Text =
                                "Profile could not be updated. Please try again.";
                            return;
                        }
                    }
                }

                // Update the user object
                loggedInUser.FullName = fullName;
                loggedInUser.Email = email;

                // Clear password fields
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConformNewPassword.Clear();

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
            catch (SqlException ex) when (
                ex.Number == 2601 || ex.Number == 2627)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "This email is already used.";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Failed to update profile.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 保留你原来生成的那些空事件，防止设计器报错
        private void label1_Click(object sender, EventArgs e) { }
        private void txtFullName_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void txtCurrentPassword_TextChanged(object sender, EventArgs e) { }
    }
}