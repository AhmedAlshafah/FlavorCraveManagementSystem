using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;

namespace FlavorCraveManagementSystem.Forms.Admin
{
    public partial class MenuItemManagementForm : Form
    {
        private int? selectedMenuId = null;
        public MenuItemManagementForm()
        {
            InitializeComponent();

            Load += MenuItemManagementForm_Load;
        }

        private void MenuItemManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategories();
                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadMenuItems()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "SELECT * FROM MenuItems";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvMenuItems.Columns.Clear();
                    dgvMenuItems.AutoGenerateColumns = true;
                    dgvMenuItems.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu: " + ex.Message);
            }
        }


        private void LoadCategories()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM MenuCategories";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                string nameColumn = "Name";

                if (table.Columns.Contains("CategoryName"))
                {
                    nameColumn = "CategoryName";
                }

                cmbCategory.DisplayMember = nameColumn;
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.DataSource = table;
                cmbCategory.SelectedIndex = -1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            if (txtMenuName.Text.Trim() == "" ||
        cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO MenuItems
                (Name, CategoryId, Price, IsAvailable, IsActive)
                SELECT @Name, @Category, 0, 0, 1
                WHERE NOT EXISTS
                (
                    SELECT 1 FROM MenuItems
                    WHERE Name = @Name
                    AND CategoryId = @Category
                    AND IsActive = 1
                )";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Name", txtMenuName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Category", cmbCategory.SelectedValue);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Menu item already exists!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Menu added successfully!");

                LoadMenuItems();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            if (selectedMenuId == null)
            {
                MessageBox.Show("Please select a menu item!");
                return;
            }

            if (txtMenuName.Text.Trim() == "" ||
                cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all fields!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                UPDATE MenuItems
                SET Name = @Name,
                    CategoryId = @Category
                WHERE MenuItemId = @Id
                AND IsActive = 1";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Name", txtMenuName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Category", cmbCategory.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@Id", selectedMenuId.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Menu item not found!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Menu updated successfully!");

                LoadMenuItems();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemoveMenu_Click(object sender, EventArgs e)
        {
            if (selectedMenuId == null)
            {
                MessageBox.Show("Please select a menu item!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Remove this menu item?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                UPDATE MenuItems
                SET IsActive = 0,
                    IsAvailable = 0
                WHERE MenuItemId = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Id", selectedMenuId.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Menu item not found!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Menu removed from active list!");

                LoadMenuItems();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedMenuId = null;

            txtMenuName.Clear();
            cmbCategory.SelectedIndex = -1;

            dgvMenuItems.ClearSelection();
            txtMenuName.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCategories();
                LoadMenuItems();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvMenuItems.Rows[e.RowIndex];

            selectedMenuId = Convert.ToInt32(
                row.Cells["MenuItemId"].Value);

            txtMenuName.Text =
                row.Cells["Name"].Value.ToString();

            cmbCategory.SelectedValue =
                Convert.ToInt32(row.Cells["CategoryId"].Value);
        }
    }
}
