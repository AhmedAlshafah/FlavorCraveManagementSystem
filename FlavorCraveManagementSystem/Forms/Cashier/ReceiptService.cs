using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public class ReceiptOrderRow
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = "";
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = "";
        public decimal TotalAmount { get; set; }
    }

    public class ReceiptLine
    {
        public string ItemName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal => Quantity * UnitPrice;
    }

    public class Receipt
    {
        private const int Width = 41;

        public int OrderId { get; set; }
        public string CustomerName { get; set; } = "";
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = "";
        public decimal TotalAmount { get; set; }
        public decimal? WalletAmount { get; set; }
        public decimal? CashierAmount { get; set; }
        public string CashierName { get; set; } = "";
        public List<ReceiptLine> Lines { get; set; } = new List<ReceiptLine>();

        public List<string> ToLines()
        {
            var text = new List<string>();
            string rule = new string('-', Width);

            text.Add(Center("FLAVOR CRAVE"));
            text.Add(Center("Receipt #" + OrderId));
            text.Add(rule);
            text.Add("Date:     " + OrderDate.ToString("dd MMM yyyy HH:mm"));
            text.Add("Customer: " + CustomerName);
            text.Add("Status:   " + Status);
            text.Add(rule);
            text.Add($"{"Item",-20} {"Qty",3} {"Price",7} {"Total",8}");

            foreach (var line in Lines)
            {
                string name = line.ItemName.Length > 20 ? line.ItemName.Substring(0, 20) : line.ItemName;
                text.Add($"{name,-20} {line.Quantity,3} {line.UnitPrice,7:F2} {line.LineTotal,8:F2}");
            }

            text.Add(rule);
            text.Add($"{"TOTAL (RM)",-20} {"",3} {"",7} {TotalAmount,8:F2}");
            text.Add(rule);

            if (WalletAmount.HasValue)
                text.Add($"Paid by e-wallet: RM {WalletAmount.Value:F2}");
            if (CashierAmount.HasValue)
                text.Add($"Confirmed by cashier: {CashierName}");
            if (!WalletAmount.HasValue && !CashierAmount.HasValue)
                text.Add("Payment: not recorded");

            text.Add(rule);
            text.Add(Center("Thank you!"));
            return text;
        }

        private static string Center(string s)
        {
            int pad = Math.Max(0, (Width - s.Length) / 2);
            return new string(' ', pad) + s;
        }
    }

    public class ReceiptService
    {
        public List<ReceiptOrderRow> GetOrders()
        {
            var list = new List<ReceiptOrderRow>();
            const string sql = @"
                SELECT o.OrderId, u.FullName, o.OrderDate, o.Status, o.TotalAmount
                FROM Orders o
                JOIN Users u ON u.UserId = o.CustomerId
                WHERE o.Status <> 'Cancelled'
                ORDER BY o.OrderDate DESC;";

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ReceiptOrderRow
                {
                    OrderId = reader.GetInt32(0),
                    CustomerName = reader.GetString(1),
                    OrderDate = reader.GetDateTime(2),
                    Status = reader.GetString(3),
                    TotalAmount = reader.GetDecimal(4)
                });
            }
            return list;
        }

        public Receipt GetReceipt(int orderId)
        {
            if (orderId <= 0)
                throw new InvalidOperationException("Please select an order.");

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            var receipt = new Receipt();

            using (var cmd = new SqlCommand(@"
                SELECT o.OrderId, u.FullName, o.OrderDate, o.Status, o.TotalAmount
                FROM Orders o
                JOIN Users u ON u.UserId = o.CustomerId
                WHERE o.OrderId = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                using var r = cmd.ExecuteReader();
                if (!r.Read())
                    throw new InvalidOperationException("Order not found.");
                receipt.OrderId = r.GetInt32(0);
                receipt.CustomerName = r.GetString(1);
                receipt.OrderDate = r.GetDateTime(2);
                receipt.Status = r.GetString(3);
                receipt.TotalAmount = r.GetDecimal(4);
            }

            using (var cmd = new SqlCommand(@"
                SELECT mi.Name, oi.Quantity, oi.UnitPrice
                FROM OrderItems oi
                JOIN MenuItems mi ON mi.MenuItemId = oi.MenuItemId
                WHERE oi.OrderId = @id
                ORDER BY oi.OrderItemId", conn))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    receipt.Lines.Add(new ReceiptLine
                    {
                        ItemName = r.GetString(0),
                        Quantity = r.GetInt32(1),
                        UnitPrice = r.GetDecimal(2)
                    });
                }
            }

            using (var cmd = new SqlCommand(@"
                SELECT TOP 1 Amount
                FROM WalletTransactions
                WHERE OrderId = @id AND TransactionType = 'Purchase'
                ORDER BY TransactionDate DESC", conn))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                object? result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    receipt.WalletAmount = Convert.ToDecimal(result);
            }

            using (var cmd = new SqlCommand(@"
                SELECT TOP 1 p.Amount, u.FullName
                FROM Payments p
                JOIN Users u ON u.UserId = p.CashierId
                WHERE p.OrderId = @id AND p.PaymentStatus = 'Paid'
                ORDER BY p.PaymentDate DESC", conn))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    receipt.CashierAmount = r.GetDecimal(0);
                    receipt.CashierName = r.GetString(1);
                }
            }

            return receipt;
        }
    }
}