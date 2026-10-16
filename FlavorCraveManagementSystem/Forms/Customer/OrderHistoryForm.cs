using System;
using System.Data;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Customer
{
    public partial class OrderHistoryForm : Form
    {
        private User loggedInUser;

        public OrderHistoryForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                string sql = @"
                    SELECT OrderId, OrderDate, Status, TotalAmount
                    FROM Orders
                    WHERE CustomerId = @CustomerId
                    ORDER BY OrderDate DESC";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@CustomerId", loggedInUser.UserId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load orders: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Please select an order to cancel.");
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderId"].Value);
            string status = dgvOrders.CurrentRow.Cells["Status"].Value.ToString();

            if (status == "Completed" || status == "Cancelled")
            {
                MessageBox.Show("This order cannot be cancelled.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to cancel this order? Money will be refunded.", "Confirm Cancel", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string sqlGet = "SELECT TotalAmount FROM Orders WHERE OrderId = @OrderId AND CustomerId = @CustomerId";
                        SqlCommand cmdGet = new SqlCommand(sqlGet, conn, tran);
                        cmdGet.Parameters.AddWithValue("@OrderId", orderId);
                        cmdGet.Parameters.AddWithValue("@CustomerId", loggedInUser.UserId);
                        decimal total = Convert.ToDecimal(cmdGet.ExecuteScalar());

                        string sqlUpdateOrder = "UPDATE Orders SET Status = 'Cancelled' WHERE OrderId = @OrderId";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdateOrder, conn, tran);
                        cmdUpdate.Parameters.AddWithValue("@OrderId", orderId);
                        cmdUpdate.ExecuteNonQuery();

                        string sqlRefund = "UPDATE Wallets SET Balance = Balance + @Amount WHERE UserId = @UserId";
                        SqlCommand cmdRefund = new SqlCommand(sqlRefund, conn, tran);
                        cmdRefund.Parameters.AddWithValue("@Amount", total);
                        cmdRefund.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                        cmdRefund.ExecuteNonQuery();

                        string sqlTrans = @"INSERT INTO WalletTransactions (WalletId, OrderId, TransactionType, Amount) SELECT WalletId, @OrderId, 'Refund', @Amount FROM Wallets WHERE UserId = @UserId";
                        SqlCommand cmdTrans = new SqlCommand(sqlTrans, conn, tran);
                        cmdTrans.Parameters.AddWithValue("@OrderId", orderId);
                        cmdTrans.Parameters.AddWithValue("@Amount", total);
                        cmdTrans.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                        cmdTrans.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("Order cancelled and refunded successfully!");
                        LoadOrders();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancellation failed: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}