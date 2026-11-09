
using FlavorCraveManagementSystem.Models;
using FlavorCraveManagementSystem.Services;


namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class SalesReportForm : Form
    {
        private readonly SalesReportService salesReportService =
           new SalesReportService();
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
            try
            {
                cmbYear.Items.Clear();

                cmbYear.Items.Add("All");

                List<int> years =
                    salesReportService.GetYears();

                foreach (int year in years)
                {
                    cmbYear.Items.Add(year);
                }

                cmbYear.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load years:\n\n" +
                    ex.Message
                );
            }
        }

        private void LoadCategories()
        {
            try
            {
                List<MenuCategory> categories =
                    salesReportService.GetCategories();

                categories.Insert(
                    0,
                    new MenuCategory
                    {
                        CategoryId = 0,
                        CategoryName = "All"
                    }
                );

                cmbCategory.DataSource = null;

                cmbCategory.DataSource = categories;

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

        private void LoadChefs()
        {
            try
            {
                List<ChefOption> chefs =
                    salesReportService.GetChefs();

                chefs.Insert(
                    0,
                    new ChefOption
                    {
                        UserId = 0,
                        FullName = "All"
                    }
                );

                cmbChef.DataSource = null;

                cmbChef.DataSource = chefs;

                cmbChef.DisplayMember = "FullName";
                cmbChef.ValueMember = "UserId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load chefs:\n\n" +
                    ex.Message
                );
            }
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


        List<SalesReportItem> reportItems =
            salesReportService.GetSalesReport(
                month,
                year,
                categoryId,
                chefId
            );


        dgvSalesReport.DataSource = null;
        dgvSalesReport.DataSource = reportItems;

        dgvSalesReport.Columns["OrderId"].HeaderText = "Order ID";
        dgvSalesReport.Columns["OrderDate"].HeaderText = "Order Date";
        dgvSalesReport.Columns["MenuItem"].HeaderText = "Menu Item";
        dgvSalesReport.Columns["UnitPrice"].HeaderText = "Unit Price";
        dgvSalesReport.Columns["SaleAmount"].HeaderText = "Sale Amount";

        dgvSalesReport.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
        dgvSalesReport.Columns["SaleAmount"].DefaultCellStyle.Format = "N2";


                decimal totalSales = 0;

        int totalOrders = 0;

        List<int> countedOrders =
            new List<int>();


        foreach (SalesReportItem item in reportItems)
        {
            totalSales += item.SaleAmount;

            if (!countedOrders.Contains(item.OrderId))
            {
                countedOrders.Add(item.OrderId);

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
