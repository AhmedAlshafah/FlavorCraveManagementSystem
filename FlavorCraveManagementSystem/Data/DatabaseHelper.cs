using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;



namespace FlavorCraveManagementSystem.Data
{
    public static class DatabaseHelper
    {
      
        public static SqlConnection GetConnection()
        {
            string? server =
                Environment.GetEnvironmentVariable("FLAVORCRAVE_DB_SERVER");

            string? password =
                Environment.GetEnvironmentVariable("FLAVORCRAVE_DB_PASSWORD");

            if (string.IsNullOrWhiteSpace(server) ||
                string.IsNullOrWhiteSpace(password))
            {
                throw new InvalidOperationException(
                    "Database environment variables are not configured.");
            }

            string connectionString =
                $"Server={server},1433;" +
                "Database=FlavorCraveDB;" +
                "User Id=sa;" +
                $"Password={password};" +
                "TrustServerCertificate=True;";

            return new SqlConnection(connectionString);
        }
    }
}
