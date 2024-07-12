using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.UI;
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
    public partial class ModifyPage : Form
    {
        // instance of booking to store the booking to edit
        private Booking bookingToEdit = new Booking();

        // variable that will hold the new check in and check out date
        private DateTime newCheckInDate;
        private DateTime newCheckOutDate;

        public ModifyPage(Booking booking)
        {
            InitializeComponent();
            bookingToEdit = booking;
        }



        private void SaveChangesBttn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if user make changes
                if (newCheckInDate != bookingToEdit.CheckInDate || newCheckOutDate != bookingToEdit.CheckOutDate)
                {
                    // assign the new checkin and checkout date to the booking instance
                    bookingToEdit.CheckInDate = newCheckInDate;
                    bookingToEdit.CheckOutDate = newCheckOutDate;

                    // update the booking record
                    BookingController bookingController = new BookingController();
                    bool successEdit = bookingController.UpdateBookingRecord(bookingToEdit);

                    if (successEdit)
                    {
                        MessageBox.Show("Booking record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        throw new Exception("Failed to update booking record");
                    }
                }
                // check if checkout date is greater than checkin date
                else if (newCheckOutDate <= newCheckInDate)
                {
                    throw new Exception("Checkout date must be greater than checkin date.");
                }
                else
                {
                    throw new Exception("No changes made");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            /*

            ChangesSaved callChangesSaved = new ChangesSaved();
            callChangesSaved.FormClosed += ChangesSaved_FormClosed;
            callChangesSaved.Show();

            //this.Hide();
            */




            //Form changesformbg = new Form();
            //try
            //{
            //    using (ChangesSaved savebttn = new ChangesSaved())
            //    {
            //        changesformbg.StartPosition = FormStartPosition.Manual;
            //        changesformbg.FormBorderStyle = FormBorderStyle.None;
            //        changesformbg.Opacity = .70d;
            //        changesformbg.BackColor = Color.Black;
            //        //formbg.WindowState = FormWindowState.Maximized;
            //        changesformbg.TopMost = true;
            //        changesformbg.Location = this.Location;
            //        changesformbg.ShowInTaskbar = false;



            //        savebttn.Owner = changesformbg;
            //        savebttn.ShowDialog();

            //        changesformbg.Dispose();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    changesformbg.Dispose();
            //}



        }

        private void ChangesSaved_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the ModifyPage form
            this.Close();
        }

        private void ModifyPage_Load(object sender, EventArgs e)
        {
            try
            {

                // display the data from the bookingToEdit instance
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayData()
        {
            try
            {
                // display the data, assign it to their appropriate label
                bookingIdTxt.Text = bookingToEdit.BookingId.ToString();
                roomIdTxt.Text = bookingToEdit.RoomId.ToString();
                guestIdTxt.Text = bookingToEdit.GuestId.ToString();
                emailTxt.Text = GetGuestEmail();
                nameTxt.Text = bookingToEdit.Guest.FirstName;
                addressTxt.Text = GetGuestAddress();
                phoneTxt.Text = GetGuestPhoneNumber();
                roomNumberTxt.Text = bookingToEdit.Room.RoomNumber.ToString();
                roomTypeTxt.Text = bookingToEdit.RoomType;
                noOfOccupantsTxt.Text = bookingToEdit.NumberOfGuest.ToString();
                modePaymentTxt.Text = bookingToEdit.ModeOfPayment;
                CheckInDatePicker.Value = bookingToEdit.CheckInDate;
                CheckOutDatePicker.Value = bookingToEdit.CheckOutDate;
                isCancelledTxt.Text = bookingToEdit.Status.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method to get guest email
        private string GetGuestEmail()
        {
            // get the email of the guest
            var guestEmail = new DataContext().Guests.Where(g => g.GuestId == bookingToEdit.GuestId).Select(g => g.Email).FirstOrDefault();
            return guestEmail;
        }

        // method to get guest phone number
        private string GetGuestPhoneNumber()
        {
            // get the phone number of the guest
            var guestPhoneNumber = new DataContext().Guests.Where(g => g.GuestId == bookingToEdit.GuestId).Select(g => g.PhoneNumber).FirstOrDefault();
            return guestPhoneNumber.ToString();
        }

        // method to get guest address
        private string GetGuestAddress()
        {
            using (var context = new DataContext())
            {
                // Get the address of the guest
                var guestAddress = context.Guests
                    .Where(g => g.GuestId == bookingToEdit.GuestId)
                    .Select(g => String.Concat(g.HouseAddress, ", ", g.City, ", ", g.Country, ", ", g.ZipCode.ToString()))
                    .FirstOrDefault();

                return guestAddress;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the ModifyPage form
        }

        private void CheckInDatePicker_ValueChanged(object sender, EventArgs e)
        {
            newCheckInDate = CheckInDatePicker.Value;
        }

        private void CheckOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            newCheckOutDate = CheckOutDatePicker.Value;
        }
    }
}