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
            object result = DatabaseHelper.ExecuteScalar(sql, new SqlParameter("@UserId", loggedInUser.UserId));
            if (result != null)
            {
                lblWalletBalance.Text = "Wallet Balance: RM " + Convert.ToDecimal(result).ToString("0.00");
            }
        }

        private void LoadCategories()
        {
            string sql = "SELECT CategoryId, CategoryName FROM MenuCategories";
            DataTable dt = DatabaseHelper.ExecuteQuery(sql);

            DataRow row = dt.NewRow();
            row["CategoryId"] = 0;
            row["CategoryName"] = "All Categories";
            dt.Rows.InsertAt(row, 0);

            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = 0;
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

            if (categoryId > 0)
            {
                sql += " AND m.CategoryId = @CategoryId";
                dgvMenuItems.DataSource = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@CategoryId", categoryId));
            }
            else
            {
                dgvMenuItems.DataSource = DatabaseHelper.ExecuteQuery(sql);
            }

            if (dgvMenuItems.Columns["MenuItemId"] != null) dgvMenuItems.Columns["MenuItemId"].Visible = false;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null && cmbCategory.SelectedValue is int)
            {
                LoadMenuItems((int)cmbCategory.SelectedValue);
            }
        }

        private void btnRefreshMenu_Click(object sender, EventArgs e)
        {
            LoadBalance();
            LoadMenuItems(cmbCategory.SelectedValue != null ? (int)cmbCategory.SelectedValue : 0);
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            // 暂未创建，创建后取消注释
            // OrderHistoryForm f = new OrderHistoryForm(loggedInUser);
            // f.ShowDialog();
            // LoadBalance();
        }

        private void btnEWallet_Click(object sender, EventArgs e)
        {
            // EWalletForm f = new EWalletForm(loggedInUser);
            // f.ShowDialog();
            // LoadBalance();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            // ProfileForm f = new ProfileForm(loggedInUser);
            // f.ShowDialog();
        }
    }
}