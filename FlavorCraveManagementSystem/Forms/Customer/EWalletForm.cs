using System;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Customer
{
    public partial class EWalletForm : Form
    {
        private User loggedInUser;

        public EWalletForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void EWalletForm_Load(object sender, EventArgs e)
        {
            LoadBalance();
        }

        private void LoadBalance()
        {
            try
            {
                string sql = "SELECT Balance FROM Wallets WHERE UserId = @UserId";
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        lblCurrentBalance.Text = "Current Balance: RM " + Convert.ToDecimal(result).ToString("0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                lblCurrentBalance.Text = "Current Balance: (DB not available)";
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter top-up amount.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string updateWalletSql = "UPDATE Wallets SET Balance = Balance + @Amount WHERE UserId = @UserId";
                        SqlCommand cmdUpdate = new SqlCommand(updateWalletSql, conn, tran);
                        cmdUpdate.Parameters.AddWithValue("@Amount", amount);
                        cmdUpdate.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                        cmdUpdate.ExecuteNonQuery();

                        string insertTransSql = @"
                            INSERT INTO WalletTransactions (WalletId, TransactionType, Amount)
                            SELECT WalletId, 'TopUp', @Amount FROM Wallets WHERE UserId = @UserId";
                        SqlCommand cmdTrans = new SqlCommand(insertTransSql, conn, tran);
                        cmdTrans.Parameters.AddWithValue("@Amount", amount);
                        cmdTrans.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                        cmdTrans.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("Top up successful!");
                        LoadBalance();
                        txtAmount.Clear();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Top up failed: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}