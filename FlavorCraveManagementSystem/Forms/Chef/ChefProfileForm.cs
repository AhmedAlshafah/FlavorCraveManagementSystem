using FlavorCraveManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlavorCraveManagementSystem.Forms.Chef
{
    public partial class ChefProfileForm : Form
    {
        private User currentUser;
        public ChefProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            // Load existing data into the textboxes when the form opens
            txtName.Text = currentUser.FullName;
            txtEmail.Text = currentUser.Email;
            txtPhone.Text = currentUser.Email;


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Users SET FullName = @Name, Email = @Email, PhoneNumber = @Phone WHERE UserId = @UserId";

            /* Keep commented out until Ahmed provides the shared database details
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@UserId", currentUser.UserId);
                
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            */

            // Update the local user object so the app remembers the new details
            currentUser.FullName = txtName.Text;
            currentUser.Email = txtEmail.Text;
            currentUser.Email = txtPhone.Text;

            MessageBox.Show("Profile updated successfully!");
            this.Close(); // Closes the profile form and returns to the dashboard
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
