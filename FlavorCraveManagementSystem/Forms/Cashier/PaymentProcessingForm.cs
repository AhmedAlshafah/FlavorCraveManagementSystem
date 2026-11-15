using System;
using System.Windows.Forms;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public partial class PaymentProcessingForm : Form
    {
        private readonly PaymentService _paymentService = new PaymentService();
        private readonly int _cashierId;

        public PaymentProcessingForm(int cashierId)
        {
            InitializeComponent();
            _cashierId = cashierId;

            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnPay.Click += btnPay_Click;
            btnRefresh.Click += (s, e) => LoadOrders();
            dgvOrders.SelectionChanged += (s, e) => UpdateTotal();

            Load += (s, e) => LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                dgvOrders.DataSource = _paymentService.GetPayableOrders();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load orders:\n" + ex.Message);
            }
        }

        private void UpdateTotal()
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is PayableOrder o)
            {
                lblSelectedOrder.Text = $"Order: #{o.OrderId}";
                lblSelectedCustomer.Text = $"Customer: {o.CustomerName}";
                lblPaymentStatus.Text = "Payment: Unpaid";
                lblTotal.Text = $"Total: RM {o.TotalAmount:F2}";
            }
            else
            {
                lblSelectedOrder.Text = "Order: -";
                lblSelectedCustomer.Text = "Customer: -";
                lblPaymentStatus.Text = "Payment: -";
                lblTotal.Text = "Total: -";
            }
        }

        private void btnPay_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is not PayableOrder order)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Process payment of RM {order.TotalAmount:F2} for order #{order.OrderId}?",
                "Confirm payment", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _paymentService.ProcessPayment(order.OrderId, _cashierId);
                MessageBox.Show("Payment recorded.");
                LoadOrders();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment failed:\n" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}