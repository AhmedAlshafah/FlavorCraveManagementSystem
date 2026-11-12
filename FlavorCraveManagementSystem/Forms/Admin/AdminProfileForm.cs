using FlavorCraveManagementSystem.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Admin
{

    public partial class AdminProfileForm : Form
    {
        private int currentUserId;
        public AdminProfileForm()
        {
            InitializeComponent();

            Load += AdminProfileForm_Load;
        }

        public AdminProfileForm(User user) : this()
        {
            currentUserId = user.UserId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("No logged-in user found!");
                return;
            }

            if (txtName.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }

            string email = txtEmail.Text.Trim();

            if (!System.Net.Mail.MailAddress.TryCreate(
                email, out var address) || address.Address != email)
            {
                MessageBox.Show("Invalid email address!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE Users
                           SET FullName = @Name,
                               Email = @Email,
                               Phone = @Phone
                           WHERE UserId = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Name", txtName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Email", email);

                        cmd.Parameters.AddWithValue(
                            "@Phone", txtPhone.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Id", currentUserId);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("User not found!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Profile updated successfully!");
                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoadProfile()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT FullName, Email, Phone
                           FROM Users
                           WHERE UserId = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", currentUserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["FullName"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtPhone.Text = reader["Phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdminProfileForm_Load(object sender, EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("No logged-in user found.");
                return;
            }

            LoadProfile();
        }
    }
}
