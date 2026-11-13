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
            AuthService authService =
                new AuthService();

            return authService.VerifyPassword(
                userId,
                currentPassword
            );
        }





        public void UpdatePassword(
            int userId,
            string newPassword)
        {
            AuthService authService =
                new AuthService();

            authService.UpdatePassword(
                userId,
                newPassword
            );
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