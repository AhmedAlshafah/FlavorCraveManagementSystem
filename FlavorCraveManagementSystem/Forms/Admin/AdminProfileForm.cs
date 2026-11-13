using FlavorCraveManagementSystem.Data;
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
using System.Xml.Linq;

namespace FlavorCraveManagementSystem.Forms.Admin
{

    public partial class AdminProfileForm : Form
    {
        private int currentUserId;
        public AdminProfileForm()
        {
            InitializeComponent();

            txtCurrentPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            lblStatus.Text = "";

            Load += AdminProfileForm_Load;
        }

        public AdminProfileForm(User user) : this()
        {
            currentUserId = user.UserId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "";

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (currentUserId == 0)
            {
                lblStatus.Text = "No logged-in user found.";
                return;
            }

            if (name == "" || email == "")
            {
                lblStatus.Text = "Name and email are required.";
                return;
            }

            if (!System.Net.Mail.MailAddress.TryCreate(
                email, out var address) || address.Address != email)
            {
                lblStatus.Text = "Invalid email address.";
                return;
            }

            if (currentPassword == "")
            {
                lblStatus.Text = "Enter your current password.";
                return;
            }

            bool changePassword =
                newPassword != "" || confirmPassword != "";

            if (changePassword)
            {
                if (newPassword.Length < 8)
                {
                    lblStatus.Text = "New password must be at least 8 characters.";
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    lblStatus.Text = "New passwords do not match.";
                    return;
                }
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string checkSql =
                        "SELECT PasswordHash FROM Users WHERE UserId = @Id";

                    string storedHash;

                    using (SqlCommand check = new SqlCommand(checkSql, conn))
                    {
                        check.Parameters.AddWithValue("@Id", currentUserId);

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

                    string sql = @"UPDATE Users
                           SET FullName = @Name,
                               Email = @Email,
                               Phone = @Phone";

                    if (changePassword)
                    {
                        sql += ", PasswordHash = @NewHash";
                    }

                    sql += @" WHERE UserId = @Id
                      AND PasswordHash = @OldHash";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Id", currentUserId);
                        cmd.Parameters.AddWithValue("@OldHash", storedHash);

                        if (changePassword)
                        {
                            cmd.Parameters.AddWithValue(
                                "@NewHash",
                                AuthService.HashPassword(newPassword));
                        }

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            lblStatus.Text = "Profile could not be updated.";
                            return;
                        }
                    }
                }

                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Profile updated successfully!";
            }
            catch (SqlException ex) when (
                ex.Number == 2601 || ex.Number == 2627)
            {
                lblStatus.Text = "Email already exists.";
            }
            catch (Exception)
            {
                lblStatus.Text = "Unable to update profile.";
            }
        }


        private void LoadProfile()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT FullName, Email, Phone
                           FROM Users
                           WHERE UserId = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", currentUserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["FullName"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtPhone.Text = reader["Phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdminProfileForm_Load(object sender, EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("No logged-in user found.");
                return;
            }

            LoadProfile();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
