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
    public partial class IngredientManagementForm : Form
    {
        private int? selectedIngredientId = null;

        private void LoadIngredients()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "SELECT * FROM Ingredients";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvIngredients.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public IngredientManagementForm()
        {
            InitializeComponent();
            Load += IngredientManagementForm_Load;
        }
        private void IngredientManagementForm_Load(object sender, EventArgs e)
        {
            LoadIngredients();
        }

        private void dgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvIngredients.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            selectedIngredientId = Convert.ToInt32(
                row.Cells["IngredientId"].Value);

            txtIngName.Text =
                row.Cells["Name"].Value.ToString();

            txtUnit.Text =
                row.Cells["Unit"].Value.ToString();
        }



        private void btnAddIng_Click(object sender, EventArgs e)
        {
            if (txtIngName.Text.Trim() == "" ||
        txtUnit.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO Ingredients
                (Name, Unit, QuantityInStock, LowStockLevel)
                VALUES (@Name, @Unit, 0, 0)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Name", txtIngName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Unit", txtUnit.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ingredient added successfully!");

                LoadIngredients();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedIngredientId = null;

            txtIngName.Clear();
            txtUnit.Clear();

            dgvIngredients.ClearSelection();
            txtIngName.Focus();
        }

        private void btnUpdateIng_Click(object sender, EventArgs e)
        {
            if (selectedIngredientId == null)
            {
                MessageBox.Show("Please select an ingredient!");
                return;
            }

            if (txtIngName.Text.Trim() == "" ||
                txtUnit.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE Ingredients
                SET IngredientName = @Name,
                    Unit = @Unit
                WHERE IngredientId = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Name", txtIngName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Unit", txtUnit.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Id", selectedIngredientId.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Ingredient not found!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Ingredient updated successfully!");

                LoadIngredients();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadIngredients();
            btnClear_Click(sender, e);
        }

        private void btnRemoveIng_Click(object sender, EventArgs e)
        {
            if (selectedIngredientId == null)
            {
                MessageBox.Show("Please select an ingredient!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to remove this ingredient?",
                "Confirm Remove",
                MessageBoxButtons.YesNo);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                DELETE FROM Ingredients
                WHERE IngredientId = @Id
                AND NOT EXISTS
                (
                    SELECT 1 FROM MenuIngredients
                    WHERE MenuIngredients.IngredientId =
                          Ingredients.IngredientId
                )";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Id", selectedIngredientId.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show(
                                "Ingredient not found or used by a menu item!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Ingredient removed successfully!");

                LoadIngredients();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot remove ingredient: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IngredientManagementForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
