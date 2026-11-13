using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public class CustomerOption
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = "";
        public override string ToString() => FullName;
    }

    public class WalletReportRow
    {
        public int TransactionId { get; set; }
        public string CustomerName { get; set; } = "";
        public string TransactionType { get; set; } = "";
        public decimal Amount { get; set; }
        public int? OrderId { get; set; }
        public DateTime TransactionDate { get; set; }
    }

    public class WalletReportSummary
    {
        public int Count { get; set; }
        public decimal TotalTopUps { get; set; }
        public decimal TotalUsage { get; set; }
        public decimal TotalRefunds { get; set; }

        public static WalletReportSummary From(List<WalletReportRow> rows)
        {
            return new WalletReportSummary
            {
                Count = rows.Count,
                TotalTopUps = rows.Where(r => r.TransactionType == "TopUp").Sum(r => r.Amount),
                TotalUsage = rows.Where(r => r.TransactionType == "Purchase").Sum(r => r.Amount),
                TotalRefunds = rows.Where(r => r.TransactionType == "Refund").Sum(r => r.Amount)
            };
        }
    }

    public class WalletReportService
    {
        public List<CustomerOption> GetCustomers()
        {
            var list = new List<CustomerOption>();
            const string sql = @"
                SELECT DISTINCT u.UserId, u.FullName
                FROM Users u
                JOIN Wallets w ON w.UserId = u.UserId
                ORDER BY u.FullName;";

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new CustomerOption
                {
                    UserId = reader.GetInt32(0),
                    FullName = reader.GetString(1)
                });
            }
            return list;
        }

        public List<int> GetYears()
        {
            var years = new List<int>();
            const string sql = @"
                SELECT DISTINCT YEAR(TransactionDate)
                FROM WalletTransactions
                ORDER BY 1 DESC;";

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                years.Add(reader.GetInt32(0));
            return years;
        }

        public List<WalletReportRow> GetReport(int? customerId, int? month, int? year)
        {
            if (month.HasValue && (month < 1 || month > 12))
                throw new InvalidOperationException("Month must be between 1 and 12.");
            if (year.HasValue && (year < 2000 || year > 2100))
                throw new InvalidOperationException("Year is not valid.");

            var rows = new List<WalletReportRow>();
            const string sql = @"
                SELECT wt.TransactionId, u.FullName, wt.TransactionType,
                       wt.Amount, wt.OrderId, wt.TransactionDate
                FROM WalletTransactions wt
                JOIN Wallets w ON w.WalletId = wt.WalletId
                JOIN Users u ON u.UserId = w.UserId
                WHERE (@customer IS NULL OR u.UserId = @customer)
                  AND (@month IS NULL OR MONTH(wt.TransactionDate) = @month)
                  AND (@year IS NULL OR YEAR(wt.TransactionDate) = @year)
                ORDER BY wt.TransactionDate DESC;";

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@customer", SqlDbType.Int).Value = (object?)customerId ?? DBNull.Value;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = (object?)month ?? DBNull.Value;
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = (object?)year ?? DBNull.Value;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rows.Add(new WalletReportRow
                {
                    TransactionId = reader.GetInt32(0),
                    CustomerName = reader.GetString(1),
                    TransactionType = reader.GetString(2),
                    Amount = reader.GetDecimal(3),
                    OrderId = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
                    TransactionDate = reader.GetDateTime(5)
                });
            }
            return rows;
        }
    }
}