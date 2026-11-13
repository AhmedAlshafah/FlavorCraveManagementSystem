using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using FlavorCraveManagementSystem.Data;
using Microsoft.Data.SqlClient;
using FlavorCraveManagementSystem.Services;
namespace FlavorCraveManagementSystem.Forms.Admin
{
    public partial class UserManagementForm : Form
    {
        private string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password, salt, 100000,
                HashAlgorithmName.SHA256, 32);

            return "PBKDF2$100000$" +
                Convert.ToBase64String(salt) + "$" +
                Convert.ToBase64String(hash);
        }
        private void LoadRoles()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                SELECT
                    u.UserId,
                    u.FullName,
                    u.Email,
                    u.RoleId,
                    r.RoleName
                FROM Users u
                INNER JOIN Roles r
                    ON u.RoleId = r.RoleId
                ORDER BY u.UserId";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvUsers.DataSource = null;
                    dgvUsers.Columns.Clear();
                    dgvUsers.AutoGenerateColumns = true;
                    dgvUsers.DataSource = table;

                    // Keep RoleId for the code, but hide it from users
                    dgvUsers.Columns["RoleId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {

                string sql = "SELECT RoleId, RoleName FROM Roles";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                cmbRole.DataSource = table;
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleId";
                cmbRole.SelectedIndex = -1;
            }
        }

        private Panel panel1;
        private Label label2;
        private Button btnCancel;
        private int? selectedUserId = null;
        private void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                SELECT
                    u.UserId,
                    u.FullName,
                    u.Email,
                    u.Phone,
                    u.RoleId,
                    r.RoleName
                FROM Users u
                INNER JOIN Roles r ON u.RoleId = r.RoleId
                ORDER BY u.UserId";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvUsers.DataSource = null;
                    dgvUsers.Columns.Clear();
                    dgvUsers.AutoGenerateColumns = true;
                    dgvUsers.DataSource = table;

                    // Hide RoleId but keep it available in the data
                    dgvUsers.Columns["RoleId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadUsers();
        }

        public UserManagementForm()
        {

            InitializeComponent();

            Load += UserManagementForm_Load;
            btnRefresh.Click += btnRefresh_Click;

            txtPassword.UseSystemPasswordChar = true;
            cmbRole.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        private Label label1;
        private Label lblName;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblRole;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnAddUser;
        private Button btnUpdateUser;
        private Button btnRemoveUser;
        private Button btnClear;
        private Button btnRefresh;
        private Label label3;
        private DataGridView dgvUsers;

        private void InitializeComponent()
        {
            label1 = new Label();
            lblName = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblRole = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnRemoveUser = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            label3 = new Label();
            dgvUsers = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            btnCancel = new Button();
            ((ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(893, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblName.Location = new Point(22, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Full Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblPassword.Location = new Point(320, 98);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblEmail.Location = new Point(22, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(118, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email Address";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblRole.Location = new Point(320, 166);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(84, 20);
            lblRole.TabIndex = 5;
            lblRole.Text = "User Role";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtName.Location = new Point(22, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 27);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtPassword.Location = new Point(320, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 27);
            txtPassword.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(320, 201);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(185, 28);
            cmbRole.TabIndex = 9;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Gold;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.FromArgb(30, 70, 55);
            btnAddUser.Location = new Point(22, 281);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 29);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(122, 281);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(110, 29);
            btnUpdateUser.TabIndex = 11;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.Location = new Point(238, 281);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(110, 29);
            btnRemoveUser.TabIndex = 12;
            btnRemoveUser.Text = "Remove User";
            btnRemoveUser.UseVisualStyleBackColor = true;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(354, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(454, 281);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 333);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 15;
            label3.Text = "Registered Users";
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(22, 373);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1009, 311);
            dgvUsers.TabIndex = 16;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 70, 55);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 74);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(22, 19);
            label2.Name = "label2";
            label2.Size = new Size(234, 41);
            label2.TabIndex = 13;
            label2.Text = "FLAVOR CRAVE";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.BackgroundImageLayout = ImageLayout.Center;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(870, 281);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Back to Dashboard";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UserManagementForm
            // 
            ClientSize = new Size(1082, 653);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Controls.Add(dgvUsers);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnRemoveUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnAddUser);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblRole);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Name = "UserManagementForm";
            Load += UserManagementForm_Load_1;
            ((ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedUserId = null;

            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

            cmbRole.SelectedIndex = -1;
            dgvUsers.ClearSelection();

            txtName.Focus();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == null)
            {
                MessageBox.Show("Please select a user!");
                return;
            }

            if (txtName.Text.Trim() == "" ||
                !System.Net.Mail.MailAddress.TryCreate(
                    txtEmail.Text.Trim(), out _) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter valid user details!");
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
                               RoleId = @Role
                           WHERE UserId = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedValue);
                        cmd.Parameters.AddWithValue("@Id", selectedUserId.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("User not found!");
                            return;
                        }
                    }
                }

                MessageBox.Show("User updated successfully!");

                LoadUsers();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == null)
            {
                MessageBox.Show("Please select a user!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"DELETE FROM Users
                           WHERE UserId = @Id
                           AND NOT EXISTS (
                               SELECT 1 FROM Roles
                               WHERE Roles.RoleId = Users.RoleId
                               AND RoleName = 'System Admin'
                           )";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedUserId.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show(
                                "User not found or admin account protected.");
                            return;
                        }
                    }
                }

                MessageBox.Show("User removed successfully!");

                LoadUsers();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot remove user: " + ex.Message);
            }
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" ||
      txtEmail.Text.Trim() == "" ||
      txtPassword.Text == "" ||
      cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            string email = txtEmail.Text.Trim();

            if (!System.Net.Mail.MailAddress.TryCreate(
                email, out var address) || address.Address != email)
            {
                MessageBox.Show("Invalid email address!");
                return;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must have at least 8 characters.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string checkSql =
                        "SELECT COUNT(*) FROM Users WHERE Email = @Email";

                    using (SqlCommand check = new SqlCommand(checkSql, conn))
                    {
                        check.Parameters.AddWithValue("@Email", email);

                        if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Email already exists!");
                            return;
                        }
                    }

                    string hashedPassword =
                        AuthService.HashPassword(txtPassword.Text);

                    string sql = @"INSERT INTO Users
                (FullName, Email, PasswordHash, RoleId)
                VALUES (@Name, @Email, @Password, @Role)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Name", txtName.Text.Trim());

                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.Parameters.AddWithValue(
                            "@Password", hashedPassword);

                        cmd.Parameters.AddWithValue(
                            "@Role", cmbRole.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User added successfully!");

                LoadUsers();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            // Read directly from the SQL data
            if (row.DataBoundItem is not DataRowView data)
                return;

            selectedUserId = Convert.ToInt32(data["UserId"]);

            txtName.Text = data["FullName"].ToString();
            txtEmail.Text = data["Email"].ToString();

            cmbRole.SelectedValue =
                Convert.ToInt32(data["RoleId"]);

            txtPassword.Clear();
        }

        private void UserManagementForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

