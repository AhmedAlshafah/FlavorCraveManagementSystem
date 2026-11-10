using System;
using System.Data;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        private User loggedInUser;

        public CustomerDashboardForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = "Welcome, " + loggedInUser.FullName + "!";
            LoadBalance();
            LoadCategories();
            LoadMenuItems(0);
        }

        private void LoadBalance()
        {
            string sql = "SELECT Balance FROM Wallets WHERE UserId = @UserId";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    lblWalletBalance.Text = "Wallet Balance: RM " + Convert.ToDecimal(result).ToString("0.00");
                }
            }
        }

        private void LoadCategories()
        {
            string sql = "SELECT CategoryId, CategoryName FROM MenuCategories";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["CategoryId"] = 0;
                row["CategoryName"] = "All Categories";
                dt.Rows.InsertAt(row, 0);

                cboCategory.DataSource = dt;
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryId";
                cboCategory.SelectedIndex = 0;
            }
        }

        private void LoadMenuItems(int categoryId)
        {
            string sql = @"
                SELECT m.MenuItemId, m.Name, c.CategoryName, m.Price,
                CASE WHEN EXISTS (
                    SELECT 1 FROM MenuIngredients mi
                    JOIN Ingredients i ON mi.IngredientId = i.IngredientId
                    WHERE mi.MenuItemId = m.MenuItemId AND i.QuantityInStock < mi.QuantityRequired
                ) THEN 'No' ELSE 'Yes' END AS CanOrder
                FROM MenuItems m
                JOIN MenuCategories c ON m.CategoryId = c.CategoryId
                WHERE m.IsAvailable = 1";

            if (categoryId > 0) sql += " AND m.CategoryId = @CategoryId";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                if (categoryId > 0) da.SelectCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMenuItems.DataSource = dt;
            }

            if (dgvMenuItems.Columns["MenuItemId"] != null)
                dgvMenuItems.Columns["MenuItemId"]!.Visible = false;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue != null && cboCategory.SelectedValue is int)
                LoadMenuItems((int)cboCategory.SelectedValue);
        }

        private void btnRefreshMenu_Click(object sender, EventArgs e)
        {
            LoadBalance();
            LoadMenuItems(cboCategory.SelectedValue != null ? (int)cboCategory.SelectedValue : 0);
        }

        // 占位事件，等建好子窗体再去掉注释
        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            OrderHistoryForm f = new OrderHistoryForm(loggedInUser);
            f.ShowDialog();
            LoadBalance();
        }
        private void btnEWallet_Click(object sender, EventArgs e)
        {
            EWalletForm f = new EWalletForm(loggedInUser);
            f.ShowDialog();
            LoadBalance();
        }
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            ProfileForm f = new ProfileForm(loggedInUser);
            f.ShowDialog();
        }

        private void btnBrowseMenu_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
            LoadMenuItems(0);
            LoadBalance();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.CurrentRow == null)
            {
                MessageBox.Show("Please select a menu item to view details.");
                return;
            }
            string name = dgvMenuItems.CurrentRow.Cells["Name"].Value.ToString();
            // You can now use the 'name' variable to display details or perform other actions
            string price = dgvMenuItems.CurrentRow.Cells["Price"].Value.ToString();
            string category = dgvMenuItems.CurrentRow.Cells["CategoryName"].Value.ToString();
            MessageBox.Show($"Name: {name}\nPrice: RM {price}\nCategory: {category}", "Menu Item Details");
        }

        private void F(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {


            if (dgvMenuItems.CurrentRow == null ||
                dgvMenuItems.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            if (!int.TryParse(
                Convert.ToString(
                    dgvMenuItems.CurrentRow.Cells["MenuItemId"].Value),
                out int menuItemId))
            {
                MessageBox.Show("Unable to read the selected menu item.");
                return;
            }

            int quantity = Decimal.ToInt32(nudQuantity.Value);
            int orderId = 0;
            decimal totalAmount = 0m;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Recheck menu availability and ingredient stock.
                            string menuSql = @"
                        SELECT m.Price,
                               CASE
                                   WHEN m.IsAvailable = 1
                                    AND NOT EXISTS (
                                        SELECT 1
                                        FROM MenuIngredients mi
                                        JOIN Ingredients i
                                            ON mi.IngredientId = i.IngredientId
                                        WHERE mi.MenuItemId = m.MenuItemId
                                          AND i.QuantityInStock <
                                              mi.QuantityRequired * @Quantity
                                    )
                                   THEN 1
                                   ELSE 0
                               END AS CanOrder
                        FROM MenuItems m
                        WHERE m.MenuItemId = @MenuItemId";

                            decimal unitPrice;
                            bool canOrder;

                            using (SqlCommand cmdMenu =
                                   new SqlCommand(menuSql, conn, tran))
                            {
                                cmdMenu.Parameters.AddWithValue(
                                    "@MenuItemId", menuItemId);
                                cmdMenu.Parameters.AddWithValue(
                                    "@Quantity", quantity);

                                using (SqlDataReader reader =
                                       cmdMenu.ExecuteReader())
                                {
                                    if (!reader.Read())
                                    {
                                        throw new InvalidOperationException(
                                            "Menu item not found.");
                                    }

                                    unitPrice = reader.GetDecimal(0);
                                    canOrder = Convert.ToInt32(reader[1]) == 1;
                                }
                            }

                            if (!canOrder)
                            {
                                throw new InvalidOperationException(
                                    "This menu item is unavailable or there are not enough ingredients.");
                            }

                            totalAmount = unitPrice * quantity;

                            // 2. Read and lock the customer's wallet.
                            int walletId;
                            decimal balance;

                            string walletSql = @"
                        SELECT WalletId, Balance
                        FROM Wallets WITH (UPDLOCK, HOLDLOCK)
                        WHERE UserId = @UserId";

                            using (SqlCommand cmdWallet =
                                   new SqlCommand(walletSql, conn, tran))
                            {
                                cmdWallet.Parameters.AddWithValue(
                                    "@UserId", loggedInUser.UserId);

                                using (SqlDataReader reader =
                                       cmdWallet.ExecuteReader())
                                {
                                    if (!reader.Read())
                                    {
                                        throw new InvalidOperationException(
                                            "Wallet account not found.");
                                    }

                                    walletId = reader.GetInt32(0);
                                    balance = reader.GetDecimal(1);
                                }
                            }

                            if (balance < totalAmount)
                            {
                                throw new InvalidOperationException(
                                    "Insufficient wallet balance.");
                            }

                            // 3. Create the order.
                            string orderSql = @"
                        INSERT INTO Orders
                            (CustomerId, TotalAmount)
                        VALUES
                            (@CustomerId, @TotalAmount);

                        SELECT CAST(SCOPE_IDENTITY() AS int);";

                            using (SqlCommand cmdOrder =
                                   new SqlCommand(orderSql, conn, tran))
                            {
                                cmdOrder.Parameters.AddWithValue(
                                    "@CustomerId", loggedInUser.UserId);
                                cmdOrder.Parameters.AddWithValue(
                                    "@TotalAmount", totalAmount);

                                orderId = Convert.ToInt32(
                                    cmdOrder.ExecuteScalar());
                            }

                            // 4. Save the order item.
                            string itemSql = @"
                        INSERT INTO OrderItems
                            (OrderId, MenuItemId, Quantity, UnitPrice)
                        VALUES
                            (@OrderId, @MenuItemId, @Quantity, @UnitPrice)";

                            using (SqlCommand cmdItem =
                                   new SqlCommand(itemSql, conn, tran))
                            {
                                cmdItem.Parameters.AddWithValue(
                                    "@OrderId", orderId);
                                cmdItem.Parameters.AddWithValue(
                                    "@MenuItemId", menuItemId);
                                cmdItem.Parameters.AddWithValue(
                                    "@Quantity", quantity);
                                cmdItem.Parameters.AddWithValue(
                                    "@UnitPrice", unitPrice);

                                cmdItem.ExecuteNonQuery();
                            }

                            // 5. Deduct the wallet balance.
                            string debitSql = @"
                        UPDATE Wallets
                        SET Balance = Balance - @Amount
                        WHERE WalletId = @WalletId
                          AND UserId = @UserId
                          AND Balance >= @Amount";

                            using (SqlCommand cmdDebit =
                                   new SqlCommand(debitSql, conn, tran))
                            {
                                cmdDebit.Parameters.AddWithValue(
                                    "@Amount", totalAmount);
                                cmdDebit.Parameters.AddWithValue(
                                    "@WalletId", walletId);
                                cmdDebit.Parameters.AddWithValue(
                                    "@UserId", loggedInUser.UserId);

                                if (cmdDebit.ExecuteNonQuery() != 1)
                                {
                                    throw new InvalidOperationException(
                                        "Payment failed. Please try again.");
                                }
                            }

                            // 6. Record the wallet transaction.
                            string transactionSql = @"
                        INSERT INTO WalletTransactions
                            (WalletId, OrderId, TransactionType,
                             Amount, TransactionDate)
                        VALUES
                            (@WalletId, @OrderId, 'Purchase',
                             @Amount, SYSDATETIME())";

                            using (SqlCommand cmdTransaction =
                                   new SqlCommand(transactionSql, conn, tran))
                            {
                                cmdTransaction.Parameters.AddWithValue(
                                    "@WalletId", walletId);
                                cmdTransaction.Parameters.AddWithValue(
                                    "@OrderId", orderId);
                                cmdTransaction.Parameters.AddWithValue(
                                    "@Amount", totalAmount);

                                cmdTransaction.ExecuteNonQuery();
                            }

                            // Commit all database changes together.
                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }

                LoadBalance();

                MessageBox.Show(
                    $"Order #{orderId} placed successfully!\n" +
                    $"Total paid: RM {totalAmount:0.00}",
                    "Order Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to place order: " + ex.Message,
                    "Order Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void labe_Click(object sender, EventArgs e)
        {

        }

        private void lblWalletBalance_Click(object sender, EventArgs e)
        {

        }

        private void dgvMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
