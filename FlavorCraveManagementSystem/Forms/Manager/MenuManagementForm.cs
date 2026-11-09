
using FlavorCraveManagementSystem.Services;

namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class MenuManagementForm : Form
    {

        private int selectedMenuItemId = 0;

        private readonly MenuService menuService =
    new MenuService();
        public MenuManagementForm()
        {
            InitializeComponent();

            LoadCategories();
            LoadMenuItems();
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.DataSource = null;

                cmbCategory.DataSource =
                    menuService.GetCategories();

                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load categories:\n\n" +
                    ex.Message
                );
            }
        }

        private void LoadMenuItems()
        {
            try
            {
                dgvMenuItems.DataSource = null;

                dgvMenuItems.DataSource =
                    menuService.GetMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load menu items:\n\n" +
                    ex.Message
                );
            }
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
                MessageBox.Show(
                    "Please select a menu item first."
                );

                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a category."
                );

                return;
            }

            if (nudPrice.Value <= 0)
            {
                MessageBox.Show(
                    "Price must be greater than 0."
                );

                return;
            }

            try
            {
                menuService.UpdateMenuItem(
                    selectedMenuItemId,
                    Convert.ToInt32(cmbCategory.SelectedValue),
                    nudPrice.Value,
                    chkIsAvailable.Checked
                );

                MessageBox.Show(
                    "Menu item updated successfully."
                );

                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update menu item:\n\n" +
                    ex.Message
                );
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (selectedMenuItemId == 0)
            {
                MessageBox.Show(
                    "Please select a menu item first."
                );

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
                menuService.DeactivateMenuItem(
                    selectedMenuItemId
                );

                MessageBox.Show(
                    "Menu item deactivated successfully."
                );

                selectedMenuItemId = 0;

                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to deactivate menu item:\n\n" +
                    ex.Message
                );
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (selectedMenuItemId == 0)
            {
                MessageBox.Show(
                    "Please select a menu item first."
                );

                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a category."
                );

                return;
            }

            if (nudPrice.Value <= 0)
            {
                MessageBox.Show(
                    "Price must be greater than 0."
                );

                return;
            }

            try
            {
                menuService.ActivateMenuItem(
                    selectedMenuItemId,
                    Convert.ToInt32(cmbCategory.SelectedValue),
                    nudPrice.Value
                );

                MessageBox.Show(
                    "Menu item activated successfully."
                );

                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to activate menu item:\n\n" +
                    ex.Message
                );
            }
        }
    }
}
