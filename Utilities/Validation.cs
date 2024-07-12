using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    internal class Validation
    {
        public static bool ValidateLogin(string employeeNumber, string password)
        {
            if (string.IsNullOrWhiteSpace(employeeNumber) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return true;
        }

        public static int ValidateChangePassword(string currentPassword, string newPassword, string confirmNewPassword)
        {
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                ShowErrorMessage("All fields must be filled out.");
                return 0;
            }

            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[~`!@#$%^&*()_\-+={[}\]|\:;""'<,>.?/]).{8,}$";
            if (!Regex.IsMatch(newPassword, passwordPattern))
            {
                ShowErrorMessage("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.");
                return 2;
            }

            if (newPassword != confirmNewPassword)
            {
                ShowErrorMessage("New password and confirm new password do not match.");
                return 3;
            }

            if (currentPassword == newPassword)
            {
                ShowErrorMessage("New password must be different from the current password.");
                return 4;
            }

            return 1;
        }

        public static bool ValidateUserDetails(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                ShowErrorMessage("Employee name cannot be empty.");
                return false;
            }

            return true;
        }

        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
