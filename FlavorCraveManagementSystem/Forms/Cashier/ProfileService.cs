using System;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Services;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public class UserProfile
    {
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
    }

    public class ProfileService
    {
        public UserProfile GetProfile(int userId)
        {
            const string sql = "SELECT FullName, Email, Phone FROM Users WHERE UserId = @id";

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", userId);
            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                throw new InvalidOperationException("User not found.");

            return new UserProfile
            {
                FullName = reader.GetString(0),
                Email = reader.GetString(1),
                Phone = reader.IsDBNull(2) ? "" : reader.GetString(2)
            };
        }

        public void UpdateProfile(int userId, string fullName, string email, string phone,
                                  string currentPassword, string newPassword, string confirmPassword)
        {
            fullName = fullName.Trim();
            email = email.Trim();
            phone = phone.Trim();

            // ---- Validation (before touching the database) ----
            if (fullName.Length == 0)
                throw new InvalidOperationException("Full name is required.");
            if (email.Length == 0)
                throw new InvalidOperationException("Email is required.");
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new InvalidOperationException("Please enter a valid email address.");
            if (phone.Length == 0)
                throw new InvalidOperationException("Phone number is required.");
            if (!Regex.IsMatch(phone, @"^\+?[0-9]{8,15}$"))
                throw new InvalidOperationException("Phone must be 8 to 15 digits (a leading + is allowed).");

            bool changingPassword = newPassword.Length > 0 || confirmPassword.Length > 0 || currentPassword.Length > 0;
            if (changingPassword)
            {
                if (currentPassword.Length == 0)
                    throw new InvalidOperationException("Enter your current password to change it.");
                if (newPassword.Length < 6)
                    throw new InvalidOperationException("New password must be at least 6 characters.");
                if (newPassword != confirmPassword)
                    throw new InvalidOperationException("New password and confirmation do not match.");
            }

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            // Email must not belong to a different user
            using (var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE Email = @email AND UserId <> @id", conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", userId);
                if ((int)cmd.ExecuteScalar()! > 0)
                    throw new InvalidOperationException("That email is already used by another account.");
            }

            // Check the current password with the shared login logic,
            // so hashed and old plain-text passwords both work
            string? passwordHash = null;
            if (changingPassword)
            {
                string? currentEmail;
                using (var cmd = new SqlCommand("SELECT Email FROM Users WHERE UserId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    currentEmail = cmd.ExecuteScalar() as string;
                }

                if (currentEmail == null)
                    throw new InvalidOperationException("User not found.");

                if (new AuthService().Login(currentEmail, currentPassword) == null)
                    throw new InvalidOperationException("Current password is incorrect.");

                passwordHash = AuthService.HashPassword(newPassword);
            }

            string sql = changingPassword
                ? "UPDATE Users SET FullName=@name, Email=@email, Phone=@phone, PasswordHash=@pw WHERE UserId=@id"
                : "UPDATE Users SET FullName=@name, Email=@email, Phone=@phone WHERE UserId=@id";

            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", fullName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@id", userId);
                if (passwordHash != null)
                    cmd.Parameters.AddWithValue("@pw", passwordHash);
                cmd.ExecuteNonQuery();
            }
        }
    }
}