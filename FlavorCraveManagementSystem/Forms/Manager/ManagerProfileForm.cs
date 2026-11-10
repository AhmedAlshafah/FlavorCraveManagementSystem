
using FlavorCraveManagementSystem.Services;

using FlavorCraveManagementSystem.Models;


namespace FlavorCraveManagementSystem.Forms.Manager
{
    public partial class ManagerProfileForm : Form
    {
        private User loggedInUser;
        private readonly ProfileService profileService =
          new ProfileService();
        public ManagerProfileForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;

            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                User? user =
                    profileService.GetUserById(
                        loggedInUser.UserId
                    );

                if (user != null)
                {
                    txtFullName.Text = user.FullName;
                    txtEmail.Text = user.Email;
                    txtPhone.Text = user.Phone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load profile:\n\n" +
                    ex.Message
                );
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ManagerProfileForm form =
                new ManagerProfileForm(loggedInUser);

            form.ShowDialog();
        }

        private void btnUpdateProfile_Click(
            object sender,
            EventArgs e)
        {
            string fullName =
                txtFullName.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            string phone =
                txtPhone.Text.Trim();


            if (fullName == "")
            {
                MessageBox.Show(
                    "Please enter your full name."
                );

                return;
            }


            if (email == "")
            {
                MessageBox.Show(
                    "Please enter your email."
                );

                return;
            }


            try
            {
                bool emailUsed =
                    profileService.IsEmailUsedByAnotherUser(
                        email,
                        loggedInUser.UserId
                    );

                if (emailUsed)
                {
                    MessageBox.Show(
                        "This email is already being used by another user."
                    );

                    return;
                }


                profileService.UpdateProfile(
                    loggedInUser.UserId,
                    fullName,
                    email,
                    phone
                );


                MessageBox.Show(
                    "Profile updated successfully."
                );

                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update profile:\n\n" +
                    ex.Message
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
