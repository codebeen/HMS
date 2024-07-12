using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using HOTEL_MANAGEMENT_SYSTEM.UI;


namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class CardPayment : Form
    {
        private int selectedRoomId;
        private Guest guestInfo;
        private Booking newBooking;

        private string Account;
        private string month;
        private string year;
        private string cvv;


        private string bankName;

        public CardPayment(string bName, int roomId, Guest guest, Booking booking)
        {
            InitializeComponent();
            this.bankName = bName;
        }

        private void CardConfirmPayment_Click(object sender, EventArgs e)
        {
            //BookingSummary bookingSummary = new BookingSummary(selectedRoomId, guestInfo, newBooking);
            //bookingSummary.Show();

            // Close the parent form
            // Form parentForm = this.FindForm();
            // parentForm.Hide();

            Account = AccountNo.Text;
            month = expmon.Text;
            year = expyear.Text;
            cvv = cvc.Text;

            // Pass the arguments to pay with card

            // Perform validation
            if (ValidateAccountNumber(Account) && ValidateExpirationDate(month, year) && ValidateCVV(cvv))
            {
                // Valid inputs, proceed with payment
                E_wallet e_Wallet = new E_wallet(selectedRoomId, guestInfo, newBooking);
                e_Wallet.payWithCard(bankName, Account, month, year, cvv);
            }
            else
            {
                MessageBox.Show("Please enter valid card details.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SRNavback_Click(object sender, EventArgs e)
        {
            this.Hide();
            E_wallet e_Wallet = new E_wallet(selectedRoomId, guestInfo, newBooking);
            e_Wallet.Show();
        }

        private bool ValidateAccountNumber(string accountNumber)
        {
            // Check if account number is not empty and meets specific criteria (e.g., length)
            return !string.IsNullOrWhiteSpace(accountNumber) && accountNumber.Length >= 12 && accountNumber.Length <= 19;
        }

        private bool ValidateExpirationDate(string month, string year)
        {
            // Validate expiration month (1-12) and year (current year onwards)
            if (!int.TryParse(month, out int expMonth) || !int.TryParse(year, out int expYear))
            {
                return false;
            }

            int currentYear = DateTime.Today.Year;

            // Check if year is valid (current year onwards)
            if (expYear < currentYear) // Adjust 10 as per your business logic
            {
                return false;
            }

            // Check if month is valid (1-12)
            if (expMonth < 1 || expMonth > 12)
            {
                return false;
            }

            // Optional: You may want to check if the expiration date is in the future
            // DateTime expirationDate = new DateTime(expYear, expMonth, DateTime.DaysInMonth(expYear, expMonth));
            // if (expirationDate < DateTime.Today) return false;

            return true;
        }

        private bool ValidateCVV(string cvv)
        {
            // CVV should be numeric and 3 or 4 digits long
            return !string.IsNullOrWhiteSpace(cvv) && cvv.Length == 3 && int.TryParse(cvv, out _);
        }
    }
}
    