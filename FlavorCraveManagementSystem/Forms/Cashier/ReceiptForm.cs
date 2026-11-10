using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace FlavorCraveManagementSystem.Forms.Cashier
{
    public partial class ReceiptForm : Form
    {
        private readonly ReceiptService _service = new ReceiptService();
        private readonly PrintDocument _document = new PrintDocument();
        private List<string> _receiptLines = new List<string>();
        private int _lineIndex;

        public ReceiptForm()
        {
            InitializeComponent();

            dgvReceiptOrders.ReadOnly = true;
            dgvReceiptOrders.AllowUserToAddRows = false;
            dgvReceiptOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiptOrders.MultiSelect = false;
            dgvReceiptOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _document.BeginPrint += (s, e) => _lineIndex = 0;
            _document.PrintPage += Document_PrintPage;

            btnRefreshReceipts.Click += (s, e) => LoadOrders();
            btnPreviewReceipt.Click += (s, e) => PreviewReceipt();
            btnPrintReceipt.Click += (s, e) => PrintReceipt();

            Load += (s, e) => LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                dgvReceiptOrders.DataSource = _service.GetOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load orders:\n" + ex.Message);
            }
        }

        private bool PrepareReceipt()
        {
            if (dgvReceiptOrders.CurrentRow?.DataBoundItem is not ReceiptOrderRow order)
            {
                MessageBox.Show("Please select an order first.");
                return false;
            }

            try
            {
                _receiptLines = _service.GetReceipt(order.OrderId).ToLines();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create receipt:\n" + ex.Message);
                return false;
            }
        }

        private void PreviewReceipt()
        {
            if (!PrepareReceipt()) return;

            try
            {
                using var preview = new PrintPreviewDialog
                {
                    Document = _document,
                    Width = 700,
                    Height = 800
                };
                preview.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not show the preview:\n" + ex.Message);
            }
        }

        private void PrintReceipt()
        {
            if (!PrepareReceipt()) return;

            try
            {
                using var dialog = new PrintDialog { Document = _document };
                if (dialog.ShowDialog(this) == DialogResult.OK)
                    _document.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not print:\n" + ex.Message);
            }
        }

        private void Document_PrintPage(object? sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics!;
            using var font = new Font("Courier New", 10);
            float lineHeight = font.GetHeight(g);
            float y = e.MarginBounds.Top;

            while (_lineIndex < _receiptLines.Count)
            {
                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                g.DrawString(_receiptLines[_lineIndex], font, Brushes.Black, e.MarginBounds.Left, y);
                y += lineHeight;
                _lineIndex++;
            }

            e.HasMorePages = false;
        }
    }
}