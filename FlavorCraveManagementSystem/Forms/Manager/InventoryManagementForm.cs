
using System.Data;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;

namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class InventoryManagementForm : Form
    {
        private int selectedIngredientId = 0;
        public InventoryManagementForm()
        {
            InitializeComponent();
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            using SqlConnection connection = DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        SELECT
        IngredientId,
        Name,
        Unit,
        QuantityInStock,
        LowStockLevel,
        IsActive,
        CASE
            WHEN QuantityInStock <= LowStockLevel
                THEN 'LOW STOCK'
            ELSE 'OK'
        END AS StockStatus
    FROM Ingredients
    ORDER BY Name";

            using SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvIngredients.DataSource = table;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadIngredients();
        }

        private void dgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvIngredients.Rows[e.RowIndex];

            selectedIngredientId =
                Convert.ToInt32(row.Cells["IngredientId"].Value);

            txtName.Text = row.Cells["Name"].Value.ToString();
            txtUnit.Text = row.Cells["Unit"].Value.ToString();

            nudQuantityInStock.Value =
                Convert.ToDecimal(row.Cells["QuantityInStock"].Value);

            nudLowStockLevel.Value =
                Convert.ToDecimal(row.Cells["LowStockLevel"].Value);

            chkIsActive.Checked =
                Convert.ToBoolean(row.Cells["IsActive"].Value);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIngredientId == 0)
            {
                MessageBox.Show("Please select an ingredient first.");
                return;
            }

            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            UPDATE Ingredients
            SET
                QuantityInStock = @QuantityInStock,
                LowStockLevel = @LowStockLevel
            WHERE IngredientId = @IngredientId";

                using SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@QuantityInStock",
                    nudQuantityInStock.Value
                );

                command.Parameters.AddWithValue(
                    "@LowStockLevel",
                    nudLowStockLevel.Value
                );

                command.Parameters.AddWithValue(
                    "@IngredientId",
                    selectedIngredientId
                );

                command.ExecuteNonQuery();

                MessageBox.Show("Ingredient inventory updated successfully.");

                LoadIngredients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update ingredient:\n\n" + ex.Message
                );
            }
        }
    }
}
