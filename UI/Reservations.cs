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
    public partial class Reservations : UserControl
    {
        private DateTime filterDate;
        private Booking selectedBooking = new Booking();


        public Reservations()
        {
            InitializeComponent();

        }


        private void SearchBar_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void Reservations_Load(object sender, EventArgs e)
        {
            try
            {
                // assign the value of calendard as date today
                ReservationCalendar.Value = DateTime.Now;

                LoadUpcomingBookings(); // load bookings
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // load all upcoming booking records
        private void LoadUpcomingBookings()
        {
            // reset the selected booking
            selectedBooking = null;

            // access the method to load the bookings
            BookingController upcomingBookings = new BookingController();
            var listOfBookings = upcomingBookings.LoadUpcomingBookingRecords();

            // load the data to datagridview
            AddBookingRecords(listOfBookings);
        }


        // method to add booking records in datagridview
        private void AddBookingRecords(List<Booking> bookingRecords)
        {
            try
            {
                var bookings = bookingRecords;

                // clear the gridview
                ReservationGridView.Rows.Clear();

                // display the booking records
                foreach (var booking in bookings)
                {
                    ReservationGridView.Rows.Add(
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

        // Load booking data from the database
        private void FilterBookings(DateTime dateToFilter)
        {
            try
            {
                // reset the selected booking
                selectedBooking = null;

                // load filtered booking records based on date to filter
                BookingController bookingController = new BookingController();
                var filteredBookings = bookingController.FilterBookingRecords(dateToFilter);

                // load the data to datagridview
                AddBookingRecords(filteredBookings);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // method to search for booking records
        private void SearchBookingRecords(string searchText)
        {
            try
            {
                // reset the selected booking
                selectedBooking = null;

                // Check if the search text is empty or whitespace
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    // Load all bookings
                    LoadUpcomingBookings();
                }
                else
                {
                    // load filtered booking records based on date to filter
                    BookingController bookingController = new BookingController();
                    var searchedBookings = bookingController.SearchBookingRecord(searchText);

                    // check if searchedBookings is not null
                    if (searchedBookings != null)
                    {
                        // load the data to datagridview
                        AddBookingRecords(searchedBookings);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReservationEditBttn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if there is a selected booking
                if (selectedBooking != null)
                {
                    ModifyPage callModifyPage = new ModifyPage(selectedBooking);
                    callModifyPage.ShowDialog();

                    // load the data grid view after editing
                    LoadUpcomingBookings();
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

        private void ReservationCancelBttn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if there is a selected booking
                if (selectedBooking != null)
                {
                    TermsandCondition callTermsandCondition = new TermsandCondition(selectedBooking);
                    callTermsandCondition.ShowDialog();

                    // load the data grid view after cancelation
                    LoadUpcomingBookings();
                }
                else
                {
                    throw new Exception("Please select a booking to cancel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ReservationCalendar_ValueChanged(object sender, EventArgs e)
        {
            // assign the value to filterDate
            filterDate = ReservationCalendar.Value;

            // load the data
            FilterBookings(filterDate);
        }

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the data of the selected row
                var selectedRow = ReservationGridView.Rows[e.RowIndex];

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

        // method to check the roomType and return the room instance
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

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            SearchBookingRecords(SearchBar.Text);

            /*
            // needs to press enter key
            if (e.KeyCode == Keys.Enter)
            {
                SearchBookingRecords(SearchBar.Text);
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevents the ding sound on Enter key press
            }
            */
        }
    }
}