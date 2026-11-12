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
    public partial class MenuIngredientMappingForm : Form
    {
        private void LoadMenuItems()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT MenuItemId, Name FROM MenuItems";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbMenuItem.DisplayMember = "Name";
                cmbMenuItem.ValueMember = "MenuItemId";
                cmbMenuItem.DataSource = table;
                cmbMenuItem.SelectedIndex = -1;
            }
        }


        private void LoadMappings()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"
            SELECT
                mi.MenuItemId,
                mi.IngredientId,
                m.Name AS MenuItem,
                i.Name AS Ingredient,
                mi.QuantityRequired,
                i.Unit
            FROM MenuIngredients mi
            JOIN MenuItems m ON mi.MenuItemId = m.MenuItemId
            JOIN Ingredients i ON mi.IngredientId = i.IngredientId";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvMappings.AutoGenerateColumns = true;
                dgvMappings.DataSource = table;

                dgvMappings.Columns["MenuItemId"].Visible = false;
                dgvMappings.Columns["IngredientId"].Visible = false;
                dgvMappings.ClearSelection();
            }
        }

        private void LoadIngredients()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT IngredientId, Name FROM Ingredients";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbIngredient.DisplayMember = "Name";
                cmbIngredient.ValueMember = "IngredientId";
                cmbIngredient.DataSource = table;
                cmbIngredient.SelectedIndex = -1;
            }
        }
        public MenuIngredientMappingForm()
        {
            InitializeComponent();
            Load += MenuIngredientMappingForm_Load;

        }
        private void MenuIngredientMappingForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMenuItems();
                LoadIngredients();
                LoadMappings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void cmbMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMenuItems();
                LoadIngredients();
                LoadMappings();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            if (cmbMenuItem.SelectedIndex == -1 ||
        cmbIngredient.SelectedIndex == -1 ||
        nudQuantity.Value <= 0)
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
                INSERT INTO MenuIngredients
                (MenuItemId, IngredientId, QuantityRequired)
                SELECT @MenuId, @IngredientId, @Quantity
                WHERE NOT EXISTS
                (
                    SELECT 1 FROM MenuIngredients
                    WHERE MenuItemId = @MenuId
                    AND IngredientId = @IngredientId
                )";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MenuId", cmbMenuItem.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@IngredientId", cmbIngredient.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@Quantity", nudQuantity.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Ingredient already mapped!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Ingredient mapped successfully!");
                LoadMappings();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int? selectedMenuItemId = null;
        private int? selectedIngredientId = null;
        private void btnRemoveMapping_Click(object sender, EventArgs e)
        {
            if (selectedMenuItemId == null ||
        selectedIngredientId == null)
            {
                MessageBox.Show("Please select a mapping!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Remove this ingredient mapping?",
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
                DELETE FROM MenuIngredients
                WHERE MenuItemId = @MenuId
                AND IngredientId = @IngredientId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MenuId", selectedMenuItemId.Value);

                        cmd.Parameters.AddWithValue(
                            "@IngredientId", selectedIngredientId.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Mapping not found!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Mapping removed successfully!");
                LoadMappings();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedMenuItemId = null;
            selectedIngredientId = null;

            cmbMenuItem.SelectedIndex = -1;
            cmbIngredient.SelectedIndex = -1;
            nudQuantity.Value = 1;

            dgvMappings.ClearSelection();
        }

        private void dgvMappings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvMappings.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            selectedMenuItemId = Convert.ToInt32(
                row.Cells["MenuItemId"].Value);

            selectedIngredientId = Convert.ToInt32(
                row.Cells["IngredientId"].Value);

            cmbMenuItem.SelectedValue = selectedMenuItemId.Value;
            cmbIngredient.SelectedValue = selectedIngredientId.Value;

            nudQuantity.Value = Convert.ToDecimal(
                row.Cells["QuantityRequired"].Value);
        }
    }
}
