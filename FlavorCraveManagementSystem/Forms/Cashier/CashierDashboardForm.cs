using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public partial class CashierDashboardForm : Form
    {
        private User loggedInUser;

        public CashierDashboardForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;

            btnProcessPayment.Click += btnProcessPayment_Click;
            btnWalletReport.Click += btnWalletReport_Click;
        }

        private void btnProcessPayment_Click(object? sender, EventArgs e)
        {
            using var paymentForm = new PaymentProcessingForm(loggedInUser.UserId);
            paymentForm.ShowDialog(this);
        }

        private void btnWalletReport_Click(object? sender, EventArgs e)
        {
            using var reportForm = new WalletReportForm();
            reportForm.ShowDialog(this);
        }
    }
}