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
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();

            LoadMonths();
            LoadYears();
            LoadCategories();
            LoadChefs();
        }

        private void LoadMonths()
        {
            cmbMonth.Items.Clear();

            cmbMonth.Items.Add("All");
            cmbMonth.Items.Add("January");
            cmbMonth.Items.Add("February");
            cmbMonth.Items.Add("March");
            cmbMonth.Items.Add("April");
            cmbMonth.Items.Add("May");
            cmbMonth.Items.Add("June");
            cmbMonth.Items.Add("July");
            cmbMonth.Items.Add("August");
            cmbMonth.Items.Add("September");
            cmbMonth.Items.Add("October");
            cmbMonth.Items.Add("November");
            cmbMonth.Items.Add("December");

            cmbMonth.SelectedIndex = 0;
        }

        private void LoadYears()
        {
            using SqlConnection connection = DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        SELECT DISTINCT YEAR(OrderDate) AS OrderYear
        FROM Orders
        ORDER BY OrderYear DESC";

            using SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();

            cmbYear.Items.Clear();
            cmbYear.Items.Add("All");

            while (reader.Read())
            {
                cmbYear.Items.Add(reader["OrderYear"].ToString());
            }

            cmbYear.SelectedIndex = 0;
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

            DataRow allRow = table.NewRow();

            allRow["CategoryId"] = 0;
            allRow["CategoryName"] = "All";

            table.Rows.InsertAt(allRow, 0);

            cmbCategory.DataSource = table;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void LoadChefs()
        {
            using SqlConnection connection = DatabaseHelper.GetConnection();

            connection.Open();

            string sql = @"
        SELECT
            u.UserId,
            u.FullName
        FROM Users u
        INNER JOIN Roles r
            ON u.RoleId = r.RoleId
        WHERE r.RoleName = 'Chef'
        ORDER BY u.FullName";

            using SqlDataAdapter adapter =
                new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            DataRow allRow = table.NewRow();

            allRow["UserId"] = 0;
            allRow["FullName"] = "All";

            table.Rows.InsertAt(allRow, 0);

            cmbChef.DataSource = table;
            cmbChef.DisplayMember = "FullName";
            cmbChef.ValueMember = "UserId";
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                int month = cmbMonth.SelectedIndex;

                int year = 0;

                if (cmbYear.SelectedItem != null &&
                    cmbYear.SelectedItem.ToString() != "All")
                {
                    year = Convert.ToInt32(cmbYear.SelectedItem);
                }

                int categoryId =
                    Convert.ToInt32(cmbCategory.SelectedValue);

                int chefId =
                    Convert.ToInt32(cmbChef.SelectedValue);


                using SqlConnection connection = DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            SELECT
                o.OrderId,
                o.OrderDate,
                u.FullName AS Chef,
                c.CategoryName AS Category,
                m.Name AS MenuItem,
                oi.Quantity,
                oi.UnitPrice,
                (oi.Quantity * oi.UnitPrice) AS SaleAmount
            FROM Orders o

            INNER JOIN OrderItems oi
                ON o.OrderId = oi.OrderId

            INNER JOIN MenuItems m
                ON oi.MenuItemId = m.MenuItemId

            INNER JOIN MenuCategories c
                ON m.CategoryId = c.CategoryId

            LEFT JOIN Users u
                ON o.ChefId = u.UserId

            WHERE o.Status = 'Completed'

            AND (@Month = 0
                OR MONTH(o.OrderDate) = @Month)

            AND (@Year = 0
                OR YEAR(o.OrderDate) = @Year)

            AND (@CategoryId = 0
                OR m.CategoryId = @CategoryId)

            AND (@ChefId = 0
                OR o.ChefId = @ChefId)

            ORDER BY o.OrderDate DESC";

                using SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@Month", month);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@ChefId", chefId);

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvSalesReport.DataSource = table;

                decimal totalSales = 0;
                int totalOrders = 0;

                List<int> countedOrders = new List<int>();

                foreach (DataRow row in table.Rows)
                {
                    totalSales +=
                        Convert.ToDecimal(row["SaleAmount"]);

                    int orderId =
                        Convert.ToInt32(row["OrderId"]);

                    if (!countedOrders.Contains(orderId))
                    {
                        countedOrders.Add(orderId);
                        totalOrders++;
                    }
                }

                lblTotalSales.Text =
                    $"Total Sales: RM {totalSales:N2}";

                lblTotalOrders.Text =
                    $"Total Orders: {totalOrders}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to generate sales report:\n\n" +
                    ex.Message
                );
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbCategory.SelectedValue = 0;
            cmbChef.SelectedValue = 0;

            dgvSalesReport.DataSource = null;

            lblTotalSales.Text = "Total Sales: RM 0.00";
            lblTotalOrders.Text = "Total Orders: 0";
        }
    }
}
