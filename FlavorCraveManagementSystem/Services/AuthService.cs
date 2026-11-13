
using System;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Services
{
    public class AuthService
    {
        // Create a secure password hash
        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password, salt, 100000,
                HashAlgorithmName.SHA256, 32);

            return "PBKDF2$100000$" +
                Convert.ToBase64String(salt) + "$" +
                Convert.ToBase64String(hash);
        }

        // Check whether the entered password is correct
        public static bool VerifyPassword(string password, string stored)
        {
            string[] parts = stored.Split('$');

            if (parts.Length != 4 ||
                parts[0] != "PBKDF2" ||
                parts[1] != "100000")
                return false;

            try
            {
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] expected = Convert.FromBase64String(parts[3]);

                if (salt.Length != 16 || expected.Length != 32)
                    return false;

                byte[] actual = Rfc2898DeriveBytes.Pbkdf2(
                    password, salt, 100000,
                    HashAlgorithmName.SHA256, 32);

                return CryptographicOperations.FixedTimeEquals(
                    actual, expected);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // Log in using email and password
        public User? Login(string email, string password)
        {
            using SqlConnection conn = DatabaseHelper.GetConnection();
            conn.Open();

            string sql = @"
                SELECT u.UserId, u.RoleId, u.FullName,
                       u.Email, u.PasswordHash, r.RoleName
                FROM Users u
                INNER JOIN Roles r ON u.RoleId = r.RoleId
                WHERE u.Email = @Email";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);

            User user;
            string storedPassword;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.Read())
                    return null;

                storedPassword = reader["PasswordHash"].ToString() ?? "";

                user = new User
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    RoleId = Convert.ToInt32(reader["RoleId"]),
                    FullName = reader["FullName"].ToString() ?? "",
                    Email = reader["Email"].ToString() ?? "",
                    RoleName = reader["RoleName"].ToString() ?? ""
                };
            }



            if (storedPassword.StartsWith("PBKDF2$"))
            {
                if (!VerifyPassword(password, storedPassword))
                    return null;
            }
            else
            {
                // Temporary migration for old development accounts
                if (storedPassword != password)
                    return null;

                string newHash = HashPassword(password);

                string updateSql = @"
                    UPDATE Users
                    SET PasswordHash = @Hash
                    WHERE UserId = @Id AND PasswordHash = @Old";

                using SqlCommand update = new SqlCommand(updateSql, conn);
                update.Parameters.AddWithValue("@Hash", newHash);
                update.Parameters.AddWithValue("@Id", user.UserId);
                update.Parameters.AddWithValue("@Old", storedPassword);

                if (update.ExecuteNonQuery() != 1)
                    return null;
            }

            return user;
        }

        public bool VerifyPassword(
    int userId,
    string password)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        SELECT PasswordHash
        FROM Users
        WHERE UserId = @UserId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@UserId",
                userId
            );

            object? result =
                command.ExecuteScalar();

            if (result == null)
            {
                return false;
            }

            string storedPassword =
                result.ToString() ?? "";

            string enteredPasswordHash =
                HashPassword(password);

            return storedPassword ==
                   enteredPasswordHash;
        }


        public void UpdatePassword(
    int userId,
    string newPassword)
        {
            string newPasswordHash =
                HashPassword(newPassword);

            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        UPDATE Users
        SET PasswordHash = @PasswordHash
        WHERE UserId = @UserId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@PasswordHash",
                newPasswordHash
            );

            command.Parameters.AddWithValue(
                "@UserId",
                userId
            );

            command.ExecuteNonQuery();
        }
    }
}
