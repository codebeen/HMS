using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class ChangePasswordPage : Form
    {
        private static readonly ExceptionHandling exception = new ExceptionHandling();
        private System.Windows.Forms.Timer timer;
        private PasswordChangeConfirmation passwordChangeConfirmation;

        public ChangePasswordPage()
        {
            InitializeComponent();
            InitializeTimer();
            // Attach the event handlers
            // CurrentPasswordTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // NewPasswordTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // ConfirmNewPasswordTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        /*
        // Event handler to check if all fields are not null or empty
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = !string.IsNullOrWhiteSpace(CurrentPasswordTextBox.Text) &&
                                   !string.IsNullOrWhiteSpace(NewPasswordTextBox.Text) &&
                                   !string.IsNullOrWhiteSpace(ConfirmNewPasswordTextBox.Text);
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
            if (passwordChangeConfirmation != null)
            {
                passwordChangeConfirmation.Close();
                passwordChangeConfirmation = null;
            }

            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();

            this.Hide();
        }


        private void CurrentPassSHow_Click(object sender, EventArgs e)
        {
            CurrentPassHide.BringToFront();
            CurrentPasswordTextBox.PasswordChar = '*';
        }

        private void CurrentPassHide_Click(object sender, EventArgs e)
        {
            CurrentPassSHow.BringToFront();
            CurrentPasswordTextBox.PasswordChar = '\0';
        }

        private void ConfirmPassShow_Click(object sender, EventArgs e)
        {
            ConfirmPassHide.BringToFront();
            ConfirmNewPasswordTextBox.PasswordChar = '*';
        }

        private void ConfirmPassHide_Click(object sender, EventArgs e)
        {
            ConfirmPassShow.BringToFront();
            ConfirmNewPasswordTextBox.PasswordChar = '\0';
        }

        private void NewPassShow_Click(object sender, EventArgs e)
        {
            NewPassHide.BringToFront();
            NewPasswordTextBox.PasswordChar = '*';
        }

        private void NewPassHide_Click(object sender, EventArgs e)
        {
            NewPassShow.BringToFront();
            NewPasswordTextBox.PasswordChar = '\0';
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = CurrentPasswordTextBox.Text;
                string newPassword = NewPasswordTextBox.Text;
                string confirmNewPassword = ConfirmNewPasswordTextBox.Text;

                var result = Validation.ValidateChangePassword(currentPassword, newPassword, confirmNewPassword);

                if (result == 0)
                {
                    Validation.ShowErrorMessage("All fields must be filled out.");
                    return;
                } 
                else if (result == 1)
                {
                    var controller = new UserController();  
                    var result1 = controller.ChangePassword(currentPassword, newPassword);
                    if (result1 == 0)
                    {
                        Validation.ShowErrorMessage("User not found.");
                    }
                    else if (result1 == 1)
                    {
                        // Add Transaction for booking
                        Transaction transaction = new Transaction();

                        transaction.TransactionType = "Delete Standard Room";
                        transaction.TransactionDate = DateTime.Now;
                        transaction.TransactionTime = DateTime.Now.TimeOfDay;
                        transaction.EmployeeName = UserSession.EmployeeName;

                        TransactionController transactionController = new TransactionController();
                        bool result2 = transactionController.AddTransaction(transaction);

                        if (result2)
                        {
                            MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        passwordChangeConfirmation = new PasswordChangeConfirmation();
                        passwordChangeConfirmation.Show();
                        timer.Start();
                    }
                    else if (result1 == 2)
                    {
                        Validation.ShowErrorMessage("Current password is incorrect.");
                    }
                    else if (result1 == 3)
                    {
                        Validation.ShowErrorMessage("Error");
                    }
                    else
                    {
                        Validation.ShowErrorMessage("Error");
                    }
                }
                else if (result == 2)
                {
                    Validation.ShowErrorMessage("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.");
                }
                else if (result == 3)
                {
                    Validation.ShowErrorMessage("New password and confirm new password do not match.");
                }
                else if (result == 4)
                {
                    Validation.ShowErrorMessage("New password must be different from the current password.");
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            this.Hide();
        }
    }
}
