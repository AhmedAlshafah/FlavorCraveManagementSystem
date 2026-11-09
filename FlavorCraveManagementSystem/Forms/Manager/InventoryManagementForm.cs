
using System.Data;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Services;

namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class InventoryManagementForm : Form
    {
        private int selectedIngredientId = 0;

        private readonly InventoryService inventoryService =
    new InventoryService();
        public InventoryManagementForm()
        {
            InitializeComponent();
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            try
            {
                dgvIngredients.DataSource = null;

                dgvIngredients.DataSource =
                    inventoryService.GetIngredients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load ingredients:\n\n" +
                    ex.Message
                );
            }
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
                MessageBox.Show(
                    "Please select an ingredient first."
                );

                return;
            }

            try
            {
                inventoryService.UpdateInventory(
                    selectedIngredientId,
                    nudQuantityInStock.Value,
                    nudLowStockLevel.Value
                );

                MessageBox.Show(
                    "Ingredient inventory updated successfully."
                );

                LoadIngredients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update ingredient:\n\n" +
                    ex.Message
                );
            }
        }
    }
}
