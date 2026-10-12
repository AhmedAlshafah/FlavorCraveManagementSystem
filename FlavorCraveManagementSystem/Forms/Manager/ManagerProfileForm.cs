using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FlavorCraveManagementSystem.Models;
using FlavorCraveManagementSystem.Data;
using Microsoft.Data.SqlClient;

namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class ManagerProfileForm : Form
    {
        private User loggedInUser;
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
                using SqlConnection connection = DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            SELECT
                FullName,
                Email,
                Phone
            FROM Users
            WHERE UserId = @UserId";

                using SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@UserId",
                    loggedInUser.UserId
                );

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtFullName.Text =
                        reader["FullName"].ToString();

                    txtEmail.Text =
                        reader["Email"].ToString();

                    txtPhone.Text =
                        reader["Phone"].ToString();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ManagerProfileForm form =
                new ManagerProfileForm(loggedInUser);

            form.ShowDialog();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (fullName == "")
            {
                MessageBox.Show("Please enter your full name.");
                return;
            }

            if (email == "")
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();

                // Check whether another user already uses this email
                string checkEmailSql = @"
            SELECT COUNT(*)
            FROM Users
            WHERE Email = @Email
              AND UserId <> @UserId";

                using SqlCommand checkCommand =
                    new SqlCommand(checkEmailSql, connection);

                checkCommand.Parameters.AddWithValue(
                    "@Email",
                    email
                );

                checkCommand.Parameters.AddWithValue(
                    "@UserId",
                    loggedInUser.UserId
                );

                int emailCount =
                    Convert.ToInt32(checkCommand.ExecuteScalar());

                if (emailCount > 0)
                {
                    MessageBox.Show(
                        "This email is already being used by another user."
                    );

                    return;
                }


                string updateSql = @"
            UPDATE Users
            SET
                FullName = @FullName,
                Email = @Email,
                Phone = @Phone
            WHERE UserId = @UserId";

                using SqlCommand updateCommand =
                    new SqlCommand(updateSql, connection);

                updateCommand.Parameters.AddWithValue(
                    "@FullName",
                    fullName
                );

                updateCommand.Parameters.AddWithValue(
                    "@Email",
                    email
                );

                updateCommand.Parameters.AddWithValue(
                    "@Phone",
                    string.IsNullOrWhiteSpace(phone)
                        ? DBNull.Value
                        : phone
                );

                updateCommand.Parameters.AddWithValue(
                    "@UserId",
                    loggedInUser.UserId
                );

                updateCommand.ExecuteNonQuery();

                MessageBox.Show(
                    "Profile updated successfully."
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
    }
}
