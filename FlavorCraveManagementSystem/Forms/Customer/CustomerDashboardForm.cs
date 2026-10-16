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
        private void btnMyOrders_Click(object sender, EventArgs e) { }
        private void btnEWallet_Click(object sender, EventArgs e) { }
        private void btnMyProfile_Click(object sender, EventArgs e) { }
    }
}