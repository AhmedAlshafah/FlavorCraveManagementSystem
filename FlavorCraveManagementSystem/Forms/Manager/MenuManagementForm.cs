using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using System.Data;

namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class MenuManagementForm : Form
    {

        private int selectedMenuItemId = 0;
        public MenuManagementForm()
        {
            InitializeComponent();

            LoadCategories();
            LoadMenuItems();
        }

        private void LoadCategories()
        {
            using SqlConnection connection = DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        SELECT
            CategoryId,
            CategoryName
        FROM MenuCategories
        ORDER BY CategoryName";

            using SqlDataAdapter adapter =
                new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            cmbCategory.DataSource = table;

            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void LoadMenuItems()
        {
            using SqlConnection connection = DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        SELECT
            m.MenuItemId,
            m.Name,
            m.CategoryId,
            c.CategoryName,
            m.Price,
            m.IsAvailable,
            m.IsActive
        FROM MenuItems m
        INNER JOIN MenuCategories c
            ON m.CategoryId = c.CategoryId
        ORDER BY m.Name";

            using SqlDataAdapter adapter =
                new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvMenuItems.DataSource = table;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMenuItems();
        }

        private void dgvMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvMenuItems.Rows[e.RowIndex];

            selectedMenuItemId =
                Convert.ToInt32(row.Cells["MenuItemId"].Value);

            txtMenuName.Text =
                row.Cells["Name"].Value.ToString();

            cmbCategory.SelectedValue =
                Convert.ToInt32(row.Cells["CategoryId"].Value);

            nudPrice.Value =
                Convert.ToDecimal(row.Cells["Price"].Value);

            chkIsAvailable.Checked =
                Convert.ToBoolean(row.Cells["IsAvailable"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMenuItemId == 0)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (nudPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");
                return;
            }

            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            UPDATE MenuItems
            SET
                CategoryId = @CategoryId,
                Price = @Price,
                IsAvailable = @IsAvailable
            WHERE MenuItemId = @MenuItemId";

                using SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@CategoryId",
                    Convert.ToInt32(cmbCategory.SelectedValue)
                );

                command.Parameters.AddWithValue(
                    "@Price",
                    nudPrice.Value
                );

                command.Parameters.AddWithValue(
                    "@IsAvailable",
                    chkIsAvailable.Checked
                );

                command.Parameters.AddWithValue(
                    "@MenuItemId",
                    selectedMenuItemId
                );

                command.ExecuteNonQuery();

                MessageBox.Show("Menu item updated successfully.");

                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update menu item:\n\n" + ex.Message
                );
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (selectedMenuItemId == 0)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this menu item?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            UPDATE MenuItems
            SET
                IsActive = 0,
                IsAvailable = 0
            WHERE MenuItemId = @MenuItemId";

                using SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@MenuItemId",
                    selectedMenuItemId
                );

                command.ExecuteNonQuery();

                MessageBox.Show("Menu item deactivated successfully.");

                selectedMenuItemId = 0;

                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to deactivate menu item:\n\n" + ex.Message
                );
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (selectedMenuItemId == 0)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            if (nudPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");
                return;
            }

            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            UPDATE MenuItems
            SET
                IsActive = 1,
                IsAvailable = 1,
                CategoryId = @CategoryId,
                Price = @Price
            WHERE MenuItemId = @MenuItemId";

                using SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@CategoryId",
                    Convert.ToInt32(cmbCategory.SelectedValue)
                );

                command.Parameters.AddWithValue(
                    "@Price",
                    nudPrice.Value
                );

                command.Parameters.AddWithValue(
                    "@MenuItemId",
                    selectedMenuItemId
                );

                command.ExecuteNonQuery();

                MessageBox.Show("Menu item activated successfully.");

                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to activate menu item:\n\n" + ex.Message
                );
            }
        }
    }
}
