using FlavorCraveManagementSystem.Models;
using FlavorCraveManagementSystem.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace FlavorCraveManagementSystem.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        private User loggedInUser;

        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            UserManagementForm form = new UserManagementForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
     "Are you sure you want to log out?",
     "Log out",
     MessageBoxButtons.YesNo,
     MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private void brnManageMenu_Click(object sender, EventArgs e)
        {
            MenuItemManagementForm form = new MenuItemManagementForm();
            form.ShowDialog();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            IngredientManagementForm form = new IngredientManagementForm();
            form.ShowDialog();
        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
            MenuIngredientMappingForm form = new MenuIngredientMappingForm();
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AdminProfileForm form = new AdminProfileForm(loggedInUser);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    MessageBox.Show(
                        "Database connected successfully!",
                        "Connection Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Connection failed: " + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManagementForm form = new UserManagementForm();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MenuItemManagementForm form = new MenuItemManagementForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngredientManagementForm form = new IngredientManagementForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuIngredientMappingForm form = new MenuIngredientMappingForm();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminProfileForm form = new AdminProfileForm(loggedInUser);
            form.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}