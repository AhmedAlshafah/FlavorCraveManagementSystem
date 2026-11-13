

namespace FlavorCraveManagementSystem.Models
{
    public class SalesReportItem
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string Chef { get; set; } = "";

        public string Category { get; set; } = "";

        public string MenuItem { get; set; } = "";

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal SaleAmount { get; set; }
    }
}
