using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public class PayableOrder
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = "";
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = "";
        public decimal TotalAmount { get; set; }
    }

    public class PaymentService
    {
        public List<PayableOrder> GetPayableOrders()
        {
            var orders = new List<PayableOrder>();

            const string sql = @"
                SELECT o.OrderId, u.FullName, o.OrderDate, o.Status, o.TotalAmount
                FROM Orders o
                JOIN Users u ON u.UserId = o.CustomerId
                WHERE o.Status <> 'Cancelled'
                  AND NOT EXISTS (SELECT 1 FROM Payments p
                                  WHERE p.OrderId = o.OrderId
                                    AND p.PaymentStatus = 'Paid')
                ORDER BY o.OrderDate;";

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new PayableOrder
                {
                    OrderId = reader.GetInt32(0),
                    CustomerName = reader.GetString(1),
                    OrderDate = reader.GetDateTime(2),
                    Status = reader.GetString(3),
                    TotalAmount = reader.GetDecimal(4)
                });
            }
            return orders;
        }

        public void ProcessPayment(int orderId, int cashierId)
        {
            if (orderId <= 0)
                throw new InvalidOperationException("Please select an order.");

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();

            try
            {
                // Lock the order row so two cashiers can't pay it at once
                string status;
                decimal total;
                using (var cmd = new SqlCommand(
                    "SELECT Status, TotalAmount FROM Orders WITH (UPDLOCK, HOLDLOCK) WHERE OrderId = @id",
                    conn, tx))
                {
                    cmd.Parameters.AddWithValue("@id", orderId);
                    using var r = cmd.ExecuteReader();
                    if (!r.Read())
                        throw new InvalidOperationException("Order not found.");
                    status = r.GetString(0);
                    total = r.GetDecimal(1);
                }

                if (status == "Cancelled")
                    throw new InvalidOperationException("A cancelled order cannot be paid.");

                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Payments WHERE OrderId = @id AND PaymentStatus = 'Paid'",
                    conn, tx))
                {
                    cmd.Parameters.AddWithValue("@id", orderId);
                    if ((int)cmd.ExecuteScalar()! > 0)
                        throw new InvalidOperationException("This order has already been paid.");
                }

                using (var cmd = new SqlCommand(@"
                    INSERT INTO Payments (OrderId, CashierId, Amount, PaymentDate, PaymentStatus)
                    VALUES (@order, @cashier, @amount, SYSDATETIME(), 'Paid')", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@order", orderId);
                    cmd.Parameters.AddWithValue("@cashier", cashierId);
                    cmd.Parameters.AddWithValue("@amount", total); // from the database, not user input
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
    }
}