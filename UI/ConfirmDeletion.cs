using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class ConfirmDeletion : Form
    {
        private Booking bookingToDelete = new Booking();


        public ConfirmDeletion(Booking booking)
        {
            InitializeComponent();
            bookingToDelete = booking;
        }


        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete the booking record
                BookingController bookingController = new BookingController();
                bool successDelete = bookingController.DeleteBookingRecord(bookingToDelete);

                // check if success
                if (successDelete)
                {
                    // Add Transaction for booking
                    Transaction transaction = new Transaction();

                    transaction.TransactionType = "Cancel Booking";
                    transaction.TransactionDate = DateTime.Now;
                    transaction.TransactionTime = DateTime.Now.TimeOfDay;
                    transaction.EmployeeName = UserSession.EmployeeName;

                    TransactionController transactionController = new TransactionController();
                    bool result = transactionController.AddTransaction(transaction);

                    if (result)
                    {
                        MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Booking successfully cancelled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*

            ConfirmCancellation callConfirmCancellation = new ConfirmCancellation();
            callConfirmCancellation.Show();

            this.Close();
            */
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TermsandCondition termsandCondition = new TermsandCondition(bookingToDelete);
            termsandCondition.ShowDialog();
            
        }
    }
}
