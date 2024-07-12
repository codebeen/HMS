using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class CashPayment : Form
    {
        // variable that will hold the parameters from the previous form
        private int selectedRoomId;
        private Guest guestInfo;
        private Booking newBooking;
        private double totalAmount;
        private double vat;
        private double localTax;
        private double serviceCharge;

        public CashPayment(int roomId, Guest guest, Booking booking)
        {
            InitializeComponent();
            selectedRoomId = roomId;
            guestInfo = guest;
            newBooking = booking;
        }

        private void transparentbg_Paint(object sender, PaintEventArgs e)
        {
            transparentbg.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, transparentbg.ClientRectangle);
            }
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            PaymentInfo paymentInfo = new PaymentInfo(selectedRoomId, guestInfo, newBooking);
            paymentInfo.Show();
            this.Hide();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DataContext(DatabaseHelper.GetDatabaseConnectionString()))
                {
                    var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == UserSession.EmployeeNumber);

                    if (!PasswordHasher.VerifyPassword(codetextbox.Text, user.Salt, user.SaltedPassword))
                    {
                        Validation.ShowErrorMessage("Current password is incorrect.");
                        return;
                    }

                    // create instance of payment to store the information from text box
                    Payment payment = new Payment();

                    payment.PaymentId = newBooking.BookingId;
                    payment.PaymentMethod = "Cash Payment";
                    payment.Amount = totalAmount;
                    payment.Currency = "PHP";
                    payment.Status = "Completed";
                    payment.PaymentDate = DateTime.Now;

                    payment.PayMongoTransactionId = "N/A";
                    payment.PayMongoPaymentIntentId = "N/A";
                    payment.PayMongoPaymentMethodId = "N/A";

                    this.Close();

                    // navigate to booking summary form
                    BookingSummary bookingSummary = new BookingSummary(selectedRoomId, guestInfo, newBooking, payment);
                    bookingSummary.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void CashPayment_Load(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                // get the room price of the selected roomId
                var roomPrice = context.Rooms.Where(r => r.RoomId == selectedRoomId).Select(r => r.RoomPrice).FirstOrDefault();

                vat = roomPrice * 0.12;
                localTax = roomPrice * 0.03;
                serviceCharge = roomPrice * 0.10;

                totalAmount = roomPrice + vat + localTax + serviceCharge;

                // display the room price
                totalAmountLabel.Text = totalAmount.ToString("C");
            }
        }
    }
}
