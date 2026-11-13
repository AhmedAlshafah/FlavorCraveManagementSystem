using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace FlavorCraveManagementSystem.Forms.Chef
{
    public partial class ChefDashboardForm : Form
    {
        private User loggedInUser;


        public ChefDashboardForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadOrders();
        }
        private void LoadOrders()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            SELECT
                o.OrderId,
                u.FullName AS Customer,
                o.OrderDate,
                o.Status,
                o.TotalAmount
            FROM Orders o
            INNER JOIN Users u
                ON o.CustomerId = u.UserId
            WHERE o.Status = 'Pending'
               OR o.Status = 'In Progress'
            ORDER BY o.OrderDate";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvOrders.DataSource = table;


                dgvOrders.Columns["OrderId"].HeaderText = "Order ID";
                dgvOrders.Columns["OrderDate"].HeaderText = "Order Date";
                dgvOrders.Columns["TotalAmount"].HeaderText = "Total Amount";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load orders:\n\n" +
                    ex.Message
                );
            }
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            try
            {
                int selectedOrderId =
                    Convert.ToInt32(
                        dgvOrders.SelectedRows[0]
                            .Cells["OrderId"].Value
                    );

                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            UPDATE Orders
            SET Status = 'In Progress',
                ChefId = @ChefId
            WHERE OrderId = @OrderId";

                using SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@ChefId",
                    loggedInUser.UserId
                );

                command.Parameters.AddWithValue(
                    "@OrderId",
                    selectedOrderId
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Order marked as In Progress."
                );

                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update order:\n\n" +
                    ex.Message
                );
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            try
            {
                int selectedOrderId =
                    Convert.ToInt32(
                        dgvOrders.SelectedRows[0]
                            .Cells["OrderId"].Value
                    );

                string currentStatus =
                    dgvOrders.SelectedRows[0]
                        .Cells["Status"].Value?.ToString() ?? "";

                if (currentStatus != "In Progress")
                {
                    MessageBox.Show(
                        "Only an order that is In Progress can be completed."
                    );

                    return;
                }

                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                using SqlTransaction transaction =
                    connection.BeginTransaction();

                try
                {
                    // Deduct the ingredients used by this order.
                    string deductIngredientsSql = @"
UPDATE i
SET i.QuantityInStock =
    i.QuantityInStock - UsedIngredients.QuantityUsed
FROM Ingredients i
INNER JOIN
(
    SELECT
        mi.IngredientId,
        SUM(mi.QuantityRequired * oi.Quantity) AS QuantityUsed
    FROM OrderItems oi
    INNER JOIN MenuIngredients mi
        ON oi.MenuItemId = mi.MenuItemId
    WHERE oi.OrderId = @OrderId
    GROUP BY mi.IngredientId
) AS UsedIngredients
    ON i.IngredientId =
       UsedIngredients.IngredientId;";

                    using SqlCommand deductCommand =
                        new SqlCommand(
                            deductIngredientsSql,
                            connection,
                            transaction
                        );

                    deductCommand.Parameters.AddWithValue(
                        "@OrderId",
                        selectedOrderId
                    );

                    deductCommand.ExecuteNonQuery();


                    // Mark the order as completed.
                    string completeOrderSql = @"
UPDATE Orders
SET Status = 'Completed'
WHERE OrderId = @OrderId
  AND Status = 'In Progress';";

                    using SqlCommand completeCommand =
                        new SqlCommand(
                            completeOrderSql,
                            connection,
                            transaction
                        );

                    completeCommand.Parameters.AddWithValue(
                        "@OrderId",
                        selectedOrderId
                    );

                    int rowsAffected =
                        completeCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "The order could not be completed."
                        );

                        return;
                    }

                    transaction.Commit();

                    MessageBox.Show(
                        "Order completed and ingredients deducted successfully."
                    );

                    LoadOrders();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to complete order:\n\n" +
                    ex.Message
                );
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            // Pass the loggedInUser to the new form and open it as a popup
            ChefProfileForm profileForm = new ChefProfileForm(loggedInUser);
            profileForm.ShowDialog();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "Are you sure you want to log out?",
    "Confirm Logout",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvOrders_CellFormatting(
    object sender,
    DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value?.ToString() ?? "";

                if (status == "Pending")
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status == "In Progress")
                {
                    e.CellStyle.BackColor = Color.SteelBlue;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "Completed")
                {
                    e.CellStyle.BackColor = Color.DarkGreen;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }


    }
}

            
        
        