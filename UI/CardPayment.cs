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

        private PaymentUtility paymentUtility;
        private string bankName;

        public CardPayment(string bName, int roomId, Guest guest, Booking booking)
        {
            InitializeComponent();
            paymentUtility = new PaymentUtility();
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

            E_wallet e_Wallet = new E_wallet(selectedRoomId, guestInfo, newBooking);
            e_Wallet.payWithCard(bankName, Account, month, year, cvv);
        }

        private void SRNavback_Click(object sender, EventArgs e)
        {
            this.Hide();
            E_wallet e_Wallet = new E_wallet(selectedRoomId, guestInfo, newBooking);
            e_Wallet.Show();
        }
    }
}
