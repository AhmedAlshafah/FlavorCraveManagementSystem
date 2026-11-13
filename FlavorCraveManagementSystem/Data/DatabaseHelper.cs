using Microsoft.Data.SqlClient;


namespace FlavorCraveManagementSystem.Data
{
    public static class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            string? server =
                Environment.GetEnvironmentVariable("FLAVORCRAVE_DB_SERVER");

            string? authMode =
                Environment.GetEnvironmentVariable("FLAVORCRAVE_DB_AUTH");

            if (string.IsNullOrWhiteSpace(server))
            {
                throw new InvalidOperationException(
                    "FLAVORCRAVE_DB_SERVER is not configured.");
            }

            string connectionString;

            if (authMode == "Windows")
            {
                connectionString =
                    $"Server={server};" +
                    "Database=FlavorCraveDB;" +
                    "Integrated Security=True;" +
                    "TrustServerCertificate=True;";
            }
            else
            {
                string? password =
                    Environment.GetEnvironmentVariable(
                        "FLAVORCRAVE_DB_PASSWORD");

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new InvalidOperationException(
                        "FLAVORCRAVE_DB_PASSWORD is not configured.");
                }

                connectionString =
                    $"Server={server},1433;" +
                    "Database=FlavorCraveDB;" +
                    "User Id=sa;" +
                    $"Password={password};" +
                    "TrustServerCertificate=True;";
            }

            return new SqlConnection(connectionString);
        }
    }
}