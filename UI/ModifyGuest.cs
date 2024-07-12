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

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class ModifyGuest : Form
    {
        private Form_receptionist parentForm;
        private Booking bookingToEdit = new Booking();
        private DateTime newCheckoutDate;

        public ModifyGuest(Booking booking)
        {
            InitializeComponent();
            bookingToEdit = booking;
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void NavBack_Click(object sender, EventArgs e)
        {
            Guest_recep guest_Recep = new Guest_recep();
            guest_Recep.Show();
            this.Hide();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // check if changes have been made
                if (newCheckoutDate != bookingToEdit.CheckOutDate && newCheckoutDate > bookingToEdit.CheckInDate)
                {
                    // check if there is overlapping booking with the new checkout date
                    BookingController bookingController = new BookingController();
                    bool isOverlapping = bookingController.CheckIfOverlappingBooking(bookingToEdit.RoomId, bookingToEdit.BookingId, bookingToEdit.CheckInDate, newCheckoutDate);

                    if (isOverlapping)
                    {
                        MessageBox.Show("There is an overlapping booking with your selected check out date. Please choose other date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        bookingToEdit.CheckOutDate = newCheckoutDate;

                        // update the booking record
                        bool successEdit = bookingController.UpdateBookingRecord(bookingToEdit);

                        if (successEdit)
                        {
                            MessageBox.Show("Booking record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Failed to update the booking record.");
                        }
                    }
                }
                else
                {
                    throw new Exception("No changes have been made.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method to checkin and checkout date of the booking to edit
        private void DisplayCheckInAndCheckOutDate()
        {
            // assign the checkin and checkout date to the label and date picker
            checkInDateTxt.Text = bookingToEdit.CheckInDate.ToString();
            CheckOutDatePicker.Value = bookingToEdit.CheckOutDate;
        }

        private void ModifyGuest_Load(object sender, EventArgs e)
        {
            try
            {
                // display the data
                DisplayCheckInAndCheckOutDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            newCheckoutDate = CheckOutDatePicker.Value;
        }
    }
}