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
    public partial class Guest_recep : UserControl
    {
        private Booking selectedBooking = new Booking();

        public Guest_recep()
        {
            InitializeComponent();
        }
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                // check if there is a selected booking
                if (selectedBooking != null)
                {
                    ModifyGuest modifyGuest = new ModifyGuest(selectedBooking);
                    modifyGuest.ShowDialog();
                    // this.Hide();

                    // load the data grid view after editing
                    LoadStayingGuests();
                }
                else
                {
                    throw new Exception("Please select a booking to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void guestGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the data of the selected row
                var selectedRow = guestGridView.Rows[e.RowIndex];

                // check if the selected row is not null
                if (selectedRow != null)
                {
                    // assign the data to selected booking
                    int bookingId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    int roomId = Convert.ToInt32(selectedRow.Cells[1].Value);
                    int guestId = Convert.ToInt32(selectedRow.Cells[2].Value);
                    int roomNumber = Convert.ToInt32(selectedRow.Cells[3].Value);
                    string fullName = selectedRow.Cells[4].Value.ToString();
                    string roomType = selectedRow.Cells[5].Value.ToString();
                    int numberOfGuest = Convert.ToInt32(selectedRow.Cells[6].Value);
                    string modeOfPayment = selectedRow.Cells[7].Value.ToString();
                    var checkInDate = Convert.ToDateTime(selectedRow.Cells[8].Value);
                    var checkOutDate = Convert.ToDateTime(selectedRow.Cells[9].Value);
                    var bookingDate = Convert.ToDateTime(selectedRow.Cells[10].Value);
                    string status = selectedRow.Cells[11].Value.ToString();

                    // check the roomType to assign room number
                    Room room = CheckRoomType(roomType, roomNumber);


                    // assign to instance of booking
                    selectedBooking = new Booking
                    {
                        BookingId = bookingId,
                        RoomId = roomId,
                        GuestId = guestId,
                        Room = room,
                        Guest = new Guest { FirstName = fullName },
                        RoomType = roomType,
                        NumberOfGuest = numberOfGuest,
                        ModeOfPayment = modeOfPayment,
                        CheckInDate = checkInDate,
                        CheckOutDate = checkOutDate,
                        BookingDate = bookingDate,
                        Status = status
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Room CheckRoomType(string roomType, int roomNumber)
        {
            // Determine the specific room type
            Room room;

            switch (roomType.ToLower())
            {
                case "standard room":
                    room = new StandardRoom { RoomNumber = roomNumber };
                    break;
                case "deluxe room":
                    room = new DeluxeRoom { RoomNumber = roomNumber };
                    break;
                case "suite":
                    room = new Suite { RoomNumber = roomNumber };
                    break;
                default:
                    throw new InvalidOperationException("Unknown room type");
            }

            return room;
        }

        private void Guest_recep_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStayingGuests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStayingGuests()
        {
            // reset selectedBooking
            selectedBooking = null;

            // load the satying guest data from database
            BookingController bookingController = new BookingController();
            // access the method
            var stayingGuests = bookingController.GetGuestStayingNow();

            if (stayingGuests != null)
            {
                AddBookingToDataGridView(stayingGuests);
            }
        }

        private void AddBookingToDataGridView(List<Booking> stayingGuests)
        {
            try
            {
                var bookings = stayingGuests;

                // clear the gridview
                guestGridView.Rows.Clear();

                // display the booking records
                foreach (var booking in bookings)
                {
                    guestGridView.Rows.Add(
                        booking.BookingId
                        , booking.RoomId
                        , booking.GuestId
                        , booking.Room.RoomNumber
                        , booking.Guest.FirstName + " " + booking.Guest.LastName
                        , booking.RoomType
                        , booking.NumberOfGuest
                        , booking.ModeOfPayment
                        , booking.CheckInDate
                        , booking.CheckOutDate
                        , booking.BookingDate
                        , booking.Status
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}