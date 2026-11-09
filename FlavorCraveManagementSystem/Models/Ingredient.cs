namespace FlavorCraveManagementSystem.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }

        public string Name { get; set; } = "";

        public string Unit { get; set; } = "";

        public decimal QuantityInStock { get; set; }

        public decimal LowStockLevel { get; set; }

        public bool IsActive { get; set; }

        public string StockStatus { get; set; } = "";
    }
}