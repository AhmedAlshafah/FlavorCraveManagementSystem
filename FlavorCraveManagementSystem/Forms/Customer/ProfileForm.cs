using System;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Data;
using FlavorCraveManagementSystem.Models;

namespace FlavorCraveManagementSystem.Forms.Customer
{
    public partial class ProfileForm : Form
    {
        private User loggedInUser;

        public ProfileForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txtFullName.Text = loggedInUser.FullName;
            txtEmail.Text = loggedInUser.Email;

            try
            {
                // 保持你原来的写法：Phone
                string sql = "SELECT Phone FROM Users WHERE UserId = @UserId";
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        txtPhone.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // 保持你原来的写法：Phone
                    string sql = @"
                        UPDATE Users
                        SET FullName = @FullName,
                        Email = @Email,
                        Phone = @Phone
                        WHERE UserId = @UserId";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        // ========================================================
                        // 这里开始插入密码修改逻辑！如果没填密码框就跳过。
                        // ========================================================
                        if (!string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                            !string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                            !string.IsNullOrWhiteSpace(txtConformNewPassword.Text))
                        {
                            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                                string.IsNullOrWhiteSpace(txtConformNewPassword.Text))
                            {
                                MessageBox.Show("Please fill in all password fields to change password.");
                                return;
                            }

                            if (txtNewPassword.Text != txtConformNewPassword.Text)
                            {
                                MessageBox.Show("New passwords do not match.");
                                return;
                            }

                            // 验证原密码（注意：如果你的数据库密码列叫 Password 而不是 PasswordHash，请把下面的 PasswordHash 改成 Password）
                            string verifySql = "SELECT COUNT(*) FROM Users WHERE UserId = @UserId AND PasswordHash = @CurrentPassword";
                            SqlCommand verifyCmd = new SqlCommand(verifySql, conn);
                            verifyCmd.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                            verifyCmd.Parameters.AddWithValue("@CurrentPassword", txtCurrentPassword.Text);

                            int isValid = Convert.ToInt32(verifyCmd.ExecuteScalar());

                            if (isValid == 0)
                            {
                                MessageBox.Show("Current password is incorrect.");
                                return;
                            }

                            // 更新密码
                            string updatePwdSql = "UPDATE Users SET PasswordHash = @NewPassword WHERE UserId = @UserId";
                            SqlCommand updatePwdCmd = new SqlCommand(updatePwdSql, conn);
                            updatePwdCmd.Parameters.AddWithValue("@NewPassword", txtNewPassword.Text);
                            updatePwdCmd.Parameters.AddWithValue("@UserId", loggedInUser.UserId);
                            updatePwdCmd.ExecuteNonQuery();
                        }
                        // ========================================================
                        // 密码修改逻辑结束
                        // ========================================================

                        // 更新内存里的姓名和邮箱
                        loggedInUser.FullName = txtFullName.Text.Trim();
                        loggedInUser.Email = txtEmail.Text.Trim();

                        // 清理密码框
                        txtCurrentPassword.Clear();
                        txtNewPassword.Clear();
                        txtConformNewPassword.Clear();

                        MessageBox.Show("Profile updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. User not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 保留你原来生成的那些空事件，防止设计器报错
        private void label1_Click(object sender, EventArgs e) { }
        private void txtFullName_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void txtCurrentPassword_TextChanged(object sender, EventArgs e) { }
    }
}