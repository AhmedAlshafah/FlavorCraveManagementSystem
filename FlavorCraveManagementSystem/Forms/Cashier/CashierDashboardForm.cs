using System.Drawing;
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
            btnProfile.Click += btnProfile_Click;
            btnReceipts.Click += btnReceipts_Click;
            btnLogout.Click += btnLogout_Click;

            AddCard("PAYMENTS", "Process payments for customer orders", 250, 190, btnProcessPayment_Click);
            AddCard("WALLET REPORT", "View e-wallet top-ups and usage", 650, 190, btnWalletReport_Click);
            AddCard("RECEIPTS", "Preview and print order receipts", 250, 360, btnReceipts_Click);
            AddCard("MY PROFILE", "View and update your account details", 650, 360, btnProfile_Click);
        }

        private void AddCard(string title, string description, int x, int y, EventHandler onClick)
        {
            var card = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(380, 140),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 70, 55),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Location = new Point(10, 30),
                Size = new Size(358, 30),
                Cursor = Cursors.Hand
            };

            var lblDescription = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(90, 90, 90),
                TextAlign = ContentAlignment.TopCenter,
                AutoSize = false,
                Location = new Point(10, 72),
                Size = new Size(358, 40),
                Cursor = Cursors.Hand
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDescription);

            // Clicking anywhere on the card opens the screen
            card.Click += onClick;
            lblTitle.Click += onClick;
            lblDescription.Click += onClick;

            Controls.Add(card);
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

        private void btnProfile_Click(object? sender, EventArgs e)
        {
            using var profileForm = new CashierProfileForm(loggedInUser);
            profileForm.ShowDialog(this);
        }

        private void btnReceipts_Click(object? sender, EventArgs e)
        {
            using var receiptForm = new ReceiptForm();
            receiptForm.ShowDialog(this);
        }
        private void btnLogout_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Log out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private void CashierDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}