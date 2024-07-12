using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class EditProfile : Form
    {
        private static readonly ExceptionHandling exception = new ExceptionHandling();
        private System.Windows.Forms.Timer timer;
        private SavedChangesConfirmation savedChangesConfirmation;

        public EditProfile()
        {
            InitializeComponent();
            InitializeTimer();
            // EmailTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // IDNumberTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // PositionTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // ScheduleTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        /*
        // Event handler to check if all fields are not null or empty
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = !string.IsNullOrWhiteSpace(EmailTextBox.Text) &&
                                    !string.IsNullOrWhiteSpace(IDNumberTextBox.Text) &&
                                    !string.IsNullOrWhiteSpace(ScheduleTextBox.Text)&&
                                    !string.IsNullOrWhiteSpace(ScheduleTextBox.Text);
        }*/

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            if (savedChangesConfirmation != null)
            {
                savedChangesConfirmation.Close();
                savedChangesConfirmation = null;
            }

            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();

            this.Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!Validation.ValidateUserDetails(EmailTextBox.Text))
                {
                    // Validation failed, show error message
                    Validation.ShowErrorMessage("Invalid input. Please check the field.");
                    return;
                }

                // Update UserSession with new details
                UserSession.EmployeeName = EmailTextBox.Text;

                var controller = new UserController();

                var result = controller.EditUser();

                switch (result)
                {
                    case 0:
                        Validation.ShowErrorMessage("User not found.");
                        break;
                    case 1:
                        // Add Transaction for booking
                        Transaction transaction = new Transaction();

                        transaction.TransactionType = "Modify User Details";
                        transaction.TransactionDate = DateTime.Now;
                        transaction.TransactionTime = DateTime.Now.TimeOfDay;
                        transaction.EmployeeName = UserSession.EmployeeName;

                        TransactionController transactionController = new TransactionController();
                        bool result1 = transactionController.AddTransaction(transaction);

                        if (result1)
                        {
                            MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        savedChangesConfirmation = new SavedChangesConfirmation();
                        savedChangesConfirmation.Show();
                        timer.Start();
                        break;
                    case 2:
                        Validation.ShowErrorMessage("Failed to update user.");
                        break;
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            EmailTextBox.Text = UserSession.EmployeeName;
            labelforidnum.Text = UserSession.EmployeeNumber;
            labelforposition.Text = UserSession.JobPosition;
            labelforschedule.Text = UserSession.Schedule;
        }

        private void circilephotoprofile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Load the image from file
                    Image originalImage = Image.FromFile(filePath);

                    // Check if the image is square
                    if (originalImage.Width != originalImage.Height)
                    {
                        MessageBox.Show("Please upload a square image.");
                        return;
                    }

                    // Convert the image to byte array
                    byte[] imageBytes = ImageHelper.ImageToByteArray(originalImage);

                    // Assign the image byte array to UserSession.ProfilePicture
                    UserSession.ProfilePicture = imageBytes;

                    // Optional: display the image in a PictureBox
                    // pictureBox.Image = originalImage;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();

            this.Hide();
        }

        private void EditProfile_Load_1(object sender, EventArgs e)
        {
            EmailTextBox.Text = UserSession.EmployeeName;
            labelforidnum.Text = UserSession.EmployeeNumber;
            labelforposition.Text = UserSession.JobPosition;
            labelforschedule.Text = UserSession.Schedule;
        }
    }
}
