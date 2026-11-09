
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;
using Microsoft.Data.SqlClient;

namespace FlavorCraveManagementSystem.Services
{
    public class SalesReportService
    {
        public List<int> GetYears()
        {
            List<int> years = new List<int>();

            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT DISTINCT YEAR(OrderDate) AS OrderYear
                FROM Orders
                ORDER BY OrderYear DESC";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            using SqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                years.Add(
                    Convert.ToInt32(reader["OrderYear"])
                );
            }

            return years;
        }


        public List<MenuCategory> GetCategories()
        {
            List<MenuCategory> categories =
                new List<MenuCategory>();

            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    CategoryId,
                    CategoryName
                FROM MenuCategories
                ORDER BY CategoryName";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            using SqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                MenuCategory category =
                    new MenuCategory();

                category.CategoryId =
                    Convert.ToInt32(reader["CategoryId"]);

                category.CategoryName =
                    reader["CategoryName"].ToString() ?? "";

                categories.Add(category);
            }

            return categories;
        }


        public List<ChefOption> GetChefs()
        {
            List<ChefOption> chefs =
                new List<ChefOption>();

            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    u.UserId,
                    u.FullName
                FROM Users u
                INNER JOIN Roles r
                    ON u.RoleId = r.RoleId
                WHERE r.RoleName = 'Chef'
                ORDER BY u.FullName";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            using SqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                ChefOption chef =
                    new ChefOption();

                chef.UserId =
                    Convert.ToInt32(reader["UserId"]);

                chef.FullName =
                    reader["FullName"].ToString() ?? "";

                chefs.Add(chef);
            }

            return chefs;
        }


        public List<SalesReportItem> GetSalesReport(
            int month,
            int year,
            int categoryId,
            int chefId)
        {
            List<SalesReportItem> reportItems =
                new List<SalesReportItem>();

            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    o.OrderId,
                    o.OrderDate,
                    u.FullName AS Chef,
                    c.CategoryName AS Category,
                    m.Name AS MenuItem,
                    oi.Quantity,
                    oi.UnitPrice,
                    (oi.Quantity * oi.UnitPrice) AS SaleAmount

                FROM Orders o

                INNER JOIN OrderItems oi
                    ON o.OrderId = oi.OrderId

                INNER JOIN MenuItems m
                    ON oi.MenuItemId = m.MenuItemId

                INNER JOIN MenuCategories c
                    ON m.CategoryId = c.CategoryId

                LEFT JOIN Users u
                    ON o.ChefId = u.UserId

                WHERE o.Status = 'Completed'

                AND (@Month = 0
                    OR MONTH(o.OrderDate) = @Month)

                AND (@Year = 0
                    OR YEAR(o.OrderDate) = @Year)

                AND (@CategoryId = 0
                    OR m.CategoryId = @CategoryId)

                AND (@ChefId = 0
                    OR o.ChefId = @ChefId)

                ORDER BY o.OrderDate DESC";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@Month",
                month
            );

            command.Parameters.AddWithValue(
                "@Year",
                year
            );

            command.Parameters.AddWithValue(
                "@CategoryId",
                categoryId
            );

            command.Parameters.AddWithValue(
                "@ChefId",
                chefId
            );

            using SqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                SalesReportItem item =
                    new SalesReportItem();

                item.OrderId =
                    Convert.ToInt32(reader["OrderId"]);

                item.OrderDate =
                    Convert.ToDateTime(reader["OrderDate"]);

                item.Chef =
                    reader["Chef"].ToString() ?? "";

                item.Category =
                    reader["Category"].ToString() ?? "";

                item.MenuItem =
                    reader["MenuItem"].ToString() ?? "";

                item.Quantity =
                    Convert.ToInt32(reader["Quantity"]);

                item.UnitPrice =
                    Convert.ToDecimal(reader["UnitPrice"]);

                item.SaleAmount =
                    Convert.ToDecimal(reader["SaleAmount"]);

                reportItems.Add(item);
            }

            return reportItems;
        }
    }
}