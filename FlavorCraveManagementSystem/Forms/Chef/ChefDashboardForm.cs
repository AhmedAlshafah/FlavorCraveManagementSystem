using FlavorCraveManagementSystem.Models;
using System.Data;
using Microsoft.Data.SqlClient;

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
            string query = @"
                SELECT o.OrderId, o.OrderDate, u.FullName AS Customer, o.Status 
                FROM Orders o 
                INNER JOIN Users u ON o.CustomerId = u.UserId 
                WHERE o.Status = 'Pending' OR o.Status = 'In Progress'";

            // Note: Keep the actual database connection part commented out 
            // until your team leader gives you the shared database credentials.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int selectedOrderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
                string query = "UPDATE Orders SET Status = 'In Progress', ChefId = @ChefId WHERE OrderId = @OrderId";
                // Keep this database connection part commented out until Ahmed provides the shared database details
                /*
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ChefId", loggedInUser.UserId);
                    cmd.Parameters.AddWithValue("@OrderId", selectedOrderId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                */
                MessageBox.Show("Order marked as In Progress.");
                LoadOrders(); // This refreshes the table to show the new status
            }
            else
            {
                MessageBox.Show("Please select an order first.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int selectedOrderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);

                string query = @"
            UPDATE i
            SET i.QuantityInStock = i.QuantityInStock - UsedIngredients.QuantityUsed
            FROM Ingredients i
            INNER JOIN (
                SELECT mi.IngredientId, SUM(mi.QuantityRequired * oi.Quantity) AS QuantityUsed
                FROM OrderItems oi
                INNER JOIN MenuIngredients mi ON oi.MenuItemId = mi.MenuItemId
                WHERE oi.OrderId = @OrderId
                GROUP BY mi.IngredientId
            ) AS UsedIngredients ON i.IngredientId = UsedIngredients.IngredientId;

            UPDATE Orders SET Status = 'Completed' WHERE OrderId = @OrderId;";

                /* Keep commented out for now
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderId", selectedOrderId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                */

                MessageBox.Show("Order completed and ingredients deducted successfully.");
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select an order first.");
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            // Pass the loggedInUser to the new form and open it as a popup
            ChefProfileForm profileForm = new ChefProfileForm(loggedInUser);
            profileForm.ShowDialog();/
        }
    }
}

            
        
        