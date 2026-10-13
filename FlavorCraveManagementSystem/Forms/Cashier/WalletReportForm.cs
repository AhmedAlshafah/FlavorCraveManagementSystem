using System;
using System.Globalization;
using System.Windows.Forms;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public partial class WalletReportForm : Form
    {
        private readonly WalletReportService _service = new WalletReportService();

        public WalletReportForm()
        {
            InitializeComponent();

            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvTransactions.ReadOnly = true;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnGenerateReport.Click += (s, e) => GenerateReport();
            btnClearFilters.Click += (s, e) => ClearFilters();

            Load += (s, e) =>
            {
                LoadFilters();
                GenerateReport();
            };
        }

        private void LoadFilters()
        {
            try
            {
                cmbCustomer.Items.Clear();
                cmbCustomer.Items.Add("All customers");
                foreach (var c in _service.GetCustomers())
                    cmbCustomer.Items.Add(c);

                cmbMonth.Items.Clear();
                cmbMonth.Items.Add("All months");
                var monthNames = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames;
                for (int i = 0; i < 12; i++)
                    cmbMonth.Items.Add(monthNames[i]);

                cmbYear.Items.Clear();
                cmbYear.Items.Add("All years");
                foreach (var y in _service.GetYears())
                    cmbYear.Items.Add(y);

                ClearFilters(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load filters:\n" + ex.Message);
            }
        }

        private void ClearFilters(bool regenerate = true)
        {
            cmbCustomer.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            if (regenerate) GenerateReport();
        }

        private void GenerateReport()
        {
            int? customerId = (cmbCustomer.SelectedItem as CustomerOption)?.UserId;
            int? month = cmbMonth.SelectedIndex > 0 ? cmbMonth.SelectedIndex : (int?)null;
            int? year = cmbYear.SelectedItem is int y ? y : (int?)null;

            try
            {
                var rows = _service.GetReport(customerId, month, year);
                dgvTransactions.DataSource = rows;
                FormatGrid();

                var summary = WalletReportSummary.From(rows);
                lblSummary.Text = summary.Count == 0
                    ? "No transactions match these filters."
                    : $"Transactions: {summary.Count}   |   Top-ups: RM {summary.TotalTopUps:F2}   |   " +
                      $"Usage (purchases): RM {summary.TotalUsage:F2}   |   Refunds: RM {summary.TotalRefunds:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not generate report:\n" + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvTransactions.Columns.Contains("Amount"))
                dgvTransactions.Columns["Amount"].DefaultCellStyle.Format = "F2";
            if (dgvTransactions.Columns.Contains("TransactionDate"))
                dgvTransactions.Columns["TransactionDate"].DefaultCellStyle.Format = "dd MMM yyyy HH:mm";
            if (dgvTransactions.Columns.Contains("TransactionId"))
                dgvTransactions.Columns["TransactionId"].HeaderText = "ID";
            if (dgvTransactions.Columns.Contains("CustomerName"))
                dgvTransactions.Columns["CustomerName"].HeaderText = "Customer";
            if (dgvTransactions.Columns.Contains("TransactionType"))
                dgvTransactions.Columns["TransactionType"].HeaderText = "Type";
            if (dgvTransactions.Columns.Contains("OrderId"))
                dgvTransactions.Columns["OrderId"].HeaderText = "Order";
            if (dgvTransactions.Columns.Contains("TransactionDate"))
                dgvTransactions.Columns["TransactionDate"].HeaderText = "Date";
        }
    }
}