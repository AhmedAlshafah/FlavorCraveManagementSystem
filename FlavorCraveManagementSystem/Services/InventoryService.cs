
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;
using Microsoft.Data.SqlClient;

namespace FlavorCraveManagementSystem.Services
{
    public class InventoryService
    {
        public List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredients =
                new List<Ingredient>();

            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                SELECT
                    IngredientId,
                    Name,
                    Unit,
                    QuantityInStock,
                    LowStockLevel,
                    IsActive,
                    CASE
                        WHEN QuantityInStock <= LowStockLevel
                            THEN 'LOW STOCK'
                        ELSE 'OK'
                    END AS StockStatus
                FROM Ingredients
                ORDER BY Name";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            using SqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                Ingredient ingredient =
                    new Ingredient();

                ingredient.IngredientId =
                    Convert.ToInt32(reader["IngredientId"]);

                ingredient.Name =
                    reader["Name"].ToString() ?? "";

                ingredient.Unit =
                    reader["Unit"].ToString() ?? "";

                ingredient.QuantityInStock =
                    Convert.ToDecimal(
                        reader["QuantityInStock"]
                    );

                ingredient.LowStockLevel =
                    Convert.ToDecimal(
                        reader["LowStockLevel"]
                    );

                ingredient.IsActive =
                    Convert.ToBoolean(
                        reader["IsActive"]
                    );

                ingredient.StockStatus =
                    reader["StockStatus"].ToString() ?? "";

                ingredients.Add(ingredient);
            }

            return ingredients;
        }


        public void UpdateInventory(
            int ingredientId,
            decimal quantityInStock,
            decimal lowStockLevel)
        {
            using SqlConnection connection =
                DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
                UPDATE Ingredients
                SET
                    QuantityInStock = @QuantityInStock,
                    LowStockLevel = @LowStockLevel
                WHERE IngredientId = @IngredientId";

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@QuantityInStock",
                quantityInStock
            );

            command.Parameters.AddWithValue(
                "@LowStockLevel",
                lowStockLevel
            );

            command.Parameters.AddWithValue(
                "@IngredientId",
                ingredientId
            );

            command.ExecuteNonQuery();
        }
    }
}