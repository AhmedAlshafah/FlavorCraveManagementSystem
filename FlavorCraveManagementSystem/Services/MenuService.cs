using System;
using System.Collections.Generic;
using System.Text;

using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;
using Microsoft.Data.SqlClient;

namespace FlavorCraveManagementSystem.Services
{
    public class MenuService
    {
        public List<MenuItemModel> GetMenuItems()
        {
            List<MenuItemModel> menuItems = new List<MenuItemModel>();

            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    m.MenuItemId,
                    m.Name,
                    m.CategoryId,
                    c.CategoryName,
                    m.Price,
                    m.IsAvailable,
                    m.IsActive
                FROM MenuItems m
                INNER JOIN MenuCategories c
                    ON m.CategoryId = c.CategoryId
                ORDER BY m.Name";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            using SqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                MenuItemModel menuItem = new MenuItemModel();

                menuItem.MenuItemId =
                    Convert.ToInt32(reader["MenuItemId"]);

                menuItem.Name =
                    reader["Name"].ToString() ?? "";

                menuItem.CategoryId =
                    Convert.ToInt32(reader["CategoryId"]);

                menuItem.CategoryName =
                    reader["CategoryName"].ToString() ?? "";

                menuItem.Price =
                    Convert.ToDecimal(reader["Price"]);

                menuItem.IsAvailable =
                    Convert.ToBoolean(reader["IsAvailable"]);

                menuItem.IsActive =
                    Convert.ToBoolean(reader["IsActive"]);

                menuItems.Add(menuItem);
            }

            return menuItems;
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


        public void UpdateMenuItem(
            int menuItemId,
            int categoryId,
            decimal price,
            bool isAvailable)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE MenuItems
                SET
                    CategoryId = @CategoryId,
                    Price = @Price,
                    IsAvailable = @IsAvailable
                WHERE MenuItemId = @MenuItemId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@CategoryId",
                categoryId
            );

            command.Parameters.AddWithValue(
                "@Price",
                price
            );

            command.Parameters.AddWithValue(
                "@IsAvailable",
                isAvailable
            );

            command.Parameters.AddWithValue(
                "@MenuItemId",
                menuItemId
            );

            command.ExecuteNonQuery();
        }


        public void DeactivateMenuItem(int menuItemId)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE MenuItems
                SET
                    IsActive = 0,
                    IsAvailable = 0
                WHERE MenuItemId = @MenuItemId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@MenuItemId",
                menuItemId
            );

            command.ExecuteNonQuery();
        }


        public void ActivateMenuItem(
            int menuItemId,
            int categoryId,
            decimal price)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE MenuItems
                SET
                    IsActive = 1,
                    IsAvailable = 1,
                    CategoryId = @CategoryId,
                    Price = @Price
                WHERE MenuItemId = @MenuItemId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@CategoryId",
                categoryId
            );

            command.Parameters.AddWithValue(
                "@Price",
                price
            );

            command.Parameters.AddWithValue(
                "@MenuItemId",
                menuItemId
            );

            command.ExecuteNonQuery();
        }
    }
}