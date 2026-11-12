using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;


namespace FlavorCraveManagementSystem.Services
{
    public class AuthService
    {
        public User? Login(string email, string password)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    u.UserId,
                    u.RoleId,
                    u.FullName,
                    u.Email,
                    r.RoleName
                FROM Users u
                INNER JOIN Roles r
                    ON u.RoleId = r.RoleId
                WHERE u.Email = @Email
                AND u.PasswordHash = @Password";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);

            using SqlDataReader reader =
                command.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    UserId =
                        Convert.ToInt32(reader["UserId"]),

                    RoleId =
                        Convert.ToInt32(reader["RoleId"]),

                    FullName =
                        reader["FullName"].ToString() ?? "",

                    Email =
                        reader["Email"].ToString() ?? "",

                    RoleName =
                        reader["RoleName"].ToString() ?? ""
                };
            }

            return null;
        }
    }
}
