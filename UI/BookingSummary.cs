using HOTEL_MANAGEMENT_SYSTEM.Controllers;
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

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class BookingSummary : Form
    {
        // variable that will hold the parameters from the previous form
        private int selectedRoomId;
        private Guest guestInfo;
        private Booking newBooking;
        private Payment newPayment;
        private double valueAddedTax;
        private double localTax;
        private double serviceCharge;
        private double roomPrice;

        public BookingSummary(int roomId, Guest guest, Booking booking, Payment payment)
        {
            InitializeComponent();

            guestInfo = guest;
            newBooking = booking;
            newPayment = payment;

        }

        private void SRNavback_Click(object sender, EventArgs e)
        {

        }

        private void BookingSummary_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayData()
        {
            try
            {
                // get the selectedRoom to display the price
                using (var context = new DataContext())
                {
                    var selectedRoom = context.Rooms.Find(selectedRoomId);

                    // assign the room price to variable to be used for calculation
                    roomPrice = selectedRoom.RoomPrice;

                    // get and display the roomprice and room number
                    roomPriceLabel.Text = roomPrice.ToString();
                    roomNumberLabel.Text = selectedRoom.RoomNumber.ToString();
                }


                // display the room type
                roomTypeLabel.Text = newBooking.RoomType;


                valueAddedTax = roomPrice * 0.12;
                localTax = roomPrice * 0.03;
                serviceCharge = roomPrice * 0.10;

                // display the taxes
                VATAmount.Text = valueAddedTax.ToString();
                LTAmount.Text = localTax.ToString();
                SCAmount.Text = serviceCharge.ToString();

                // calculate the total amount
                totalAmountLabel.Text = CalculateTotalAmount().ToString();

                // display the data
                dateCheckin.Text = newBooking.CheckInDate.ToString();
                dateCheckout.Text = newBooking.CheckOutDate.ToString();
                numberOfGuestLabel.Text = newBooking.NumberOfGuest.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to calculate the total amount
        private double CalculateTotalAmount()
        {
            try
            {
                // return the sum
                return roomPrice + valueAddedTax + localTax + serviceCharge;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void CardConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // add the guest record to the database
                GuestController guestController = new GuestController();
                bool guestAdded = guestController.AddGuest(guestInfo);

                if (guestAdded)
                {
                    MessageBox.Show("Booking succesfully cancelled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    try
                    {
                        // Add Transaction for Guest
                        Transaction transaction = new Transaction();

                        transaction.TransactionType = "Add Guest";
                        transaction.TransactionDate = DateTime.Now;
                        transaction.TransactionTime = DateTime.Now.TimeOfDay;
                        transaction.EmployeeName = UserSession.EmployeeName;

                        TransactionController transactionController = new TransactionController();
                        bool result = transactionController.AddTransaction(transaction);

                        if (result)
                        {
                            MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        try
                        {
                            // add the guestid to the booking record
                            newBooking.GuestId = guestInfo.GuestId;

                            // add the paymentid to the booking record
                            newPayment.BookingId = newBooking.BookingId;

                            // add the booking record to the database
                            BookingController bookingController = new BookingController();
                            bool bookingAdded = bookingController.AddBooking(newBooking);

                            if (bookingAdded)
                            {
                                // Add Transaction for booking
                                Transaction transaction_1 = new Transaction();

                                transaction.TransactionType = "Add Booking";
                                transaction.TransactionDate = DateTime.Now;
                                transaction.TransactionTime = DateTime.Now.TimeOfDay;
                                transaction.EmployeeName = UserSession.EmployeeName;

                                TransactionController transactionController_1 = new TransactionController();
                                bool result_1 = transactionController.AddTransaction(transaction);

                                if (result_1)
                                {
                                    MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                // add the payment record to the database
                                PaymentController paymentController = new PaymentController();
                                bool paymentAdded = paymentController.AddPayment(newPayment);

                                if (paymentAdded)
                                {
                                    // Add Transaction for Payment
                                    Transaction transaction_2 = new Transaction();

                                    transaction.TransactionType = "Add Payment";
                                    transaction.TransactionDate = DateTime.Now;
                                    transaction.TransactionTime = DateTime.Now.TimeOfDay;
                                    transaction.EmployeeName = UserSession.EmployeeName;

                                    TransactionController transactionController_2 = new TransactionController();
                                    bool result_2 = transactionController.AddTransaction(transaction);

                                    if (result_2)
                                    {
                                        MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                    // update the status of the selected room to occupied
                                    RoomController roomController = new RoomController();
                                    roomController.UpdateRoomStatus(selectedRoomId);

                                    // show the success messsage
                                    successmessagebk bookingSuccess = new successmessagebk();
                                    bookingSuccess.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    throw new Exception("Booking failed. Please try again.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Booking not added successfully.","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch
                        {
                            throw new Exception("Payment failed. Please try again.");
                        }
                    }
                    catch
                    {
                        throw new Exception("Payment failed. Please try again.");
                    }
                }
                else
                {
                    throw new Exception("Guest failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}