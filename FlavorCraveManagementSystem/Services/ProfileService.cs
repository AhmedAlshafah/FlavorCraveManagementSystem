using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;
using Microsoft.Data.SqlClient;

namespace FlavorCraveManagementSystem.Services
{
    public class ProfileService
    {
        public User? GetUserById(int userId)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    UserId,
                    FullName,
                    Email,
                    Phone
                FROM Users
                WHERE UserId = @UserId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@UserId",
                userId
            );

            using SqlDataReader reader =
                command.ExecuteReader();

            if (reader.Read())
            {
                User user = new User();

                user.UserId =
                    Convert.ToInt32(reader["UserId"]);

                user.FullName =
                    reader["FullName"].ToString() ?? "";

                user.Email =
                    reader["Email"].ToString() ?? "";

                user.Phone =
                    reader["Phone"] == DBNull.Value
                        ? ""
                        : reader["Phone"].ToString() ?? "";

                return user;
            }

            return null;
        }


        public bool IsEmailUsedByAnotherUser(
            string email,
            int userId)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT COUNT(*)
                FROM Users
                WHERE Email = @Email
                  AND UserId <> @UserId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@Email",
                email
            );

            command.Parameters.AddWithValue(
                "@UserId",
                userId
            );

            int count =
                Convert.ToInt32(command.ExecuteScalar());

            return count > 0;
        }

        public bool IsCurrentPasswordCorrect(
    int userId,
    string currentPassword)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        SELECT COUNT(*)
        FROM Users
        WHERE UserId = @UserId
          AND PasswordHash = @Password";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@UserId",
                userId
            );

            command.Parameters.AddWithValue(
                "@Password",
                currentPassword
            );

            int count =
                Convert.ToInt32(command.ExecuteScalar());

            return count > 0;
        }


        public void UpdatePassword(
            int userId,
            string newPassword)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        UPDATE Users
        SET PasswordHash = @Password
        WHERE UserId = @UserId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@Password",
                newPassword
            );

            command.Parameters.AddWithValue(
                "@UserId",
                userId
            );

            command.ExecuteNonQuery();
        }

        public void UpdateProfile(
            int userId,
            string fullName,
            string email,
            string phone)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE Users
                SET
                    FullName = @FullName,
                    Email = @Email,
                    Phone = @Phone
                WHERE UserId = @UserId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@FullName",
                fullName
            );

            command.Parameters.AddWithValue(
                "@Email",
                email
            );

            command.Parameters.AddWithValue(
                "@Phone",
                string.IsNullOrWhiteSpace(phone)
                    ? DBNull.Value
                    : phone
            );

            command.Parameters.AddWithValue(
                "@UserId",
                userId
            );

            command.ExecuteNonQuery();
        }
    }
}