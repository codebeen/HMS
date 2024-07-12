using HOTEL_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class BookingController
    {
        // method to add booking record
        public bool AddBooking(Booking booking)
        {
            try
            {
                // add the booking record to the database
                using (var context = new DataContext())
                {
                    context.Bookings.Add(booking);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // method to read or display all the booking records
        public List<Booking> FilterBookingRecords(DateTime filterDate)
        {
            // create instance of DataContext
            using (var context = new DataContext())
            {
                // assign list of bookings that is not cancelled to variables
                var bookingRecords = context.Bookings
                    .Include(b => b.Room)
                    .Include(b => b.Guest)
                    .Where(b => !b.IsCancelled && b.CheckInDate.Date == filterDate.Date) // filter by date, excludes time
                    .ToList();

                // return all booking records
                return bookingRecords;

            }
        }

        // method to load all upcoming booking records
        public List<Booking> LoadUpcomingBookingRecords()
        {
            // create instance of DataContext
            using (var context = new DataContext())
            {
                // assign list of bookings that is not cancelled to variables
                var bookingRecords = context.Bookings
                    .Include(b => b.Room)
                    .Include(b => b.Guest)
                    .Where(b => !b.IsCancelled && b.CheckInDate > DateTime.Now)
                    .ToList();

                // return all booking records
                return bookingRecords;

            }
        }


        // method to search booking records
        public List<Booking> SearchBookingRecord(string searchText)
        {
            try
            {
                // get the all the upcoming bookings
                var bookings = LoadUpcomingBookingRecords();

                // filter the bookings if textToSearch is not empty
                if (!string.IsNullOrEmpty(searchText))
                {
                    bookings = bookings.Where(b => b.Guest.FirstName.ToLower().Contains(searchText.ToLower())
                                                || b.Guest.LastName.ToLower().Contains(searchText.ToLower())
                                                || b.Room.RoomNumber.ToString().Contains(searchText))
                                        .ToList();
                    return bookings;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        // method to update booking record
        public bool UpdateBookingRecord(Booking booking)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Retrieve the booking record by ID
                    var bookingToEdit = context.Bookings.FirstOrDefault(b => b.BookingId == booking.BookingId);

                    if (bookingToEdit == null || bookingToEdit.IsCancelled == true)
                    {
                        return false;
                    }

                    bookingToEdit.CheckInDate = booking.CheckInDate;
                    bookingToEdit.CheckOutDate = booking.CheckOutDate;
                    // bookingToEdit.NumberOfGuest = booking.NumberOfGuest;

                    // update the booking record
                    context.Bookings.Update(bookingToEdit);
                    // Save changes to the database
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        // method to delete booking record
        public bool DeleteBookingRecord(Booking booking)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Retrieve the booking record by ID
                    var bookingToDelete = context.Bookings.FirstOrDefault(b => b.BookingId == booking.BookingId);
                    if (bookingToDelete == null || bookingToDelete.IsCancelled == true)
                    {
                        return false;
                    }

                    // soft delete the record
                    bookingToDelete.IsCancelled = true;

                    // update the booking record
                    context.Bookings.Update(bookingToDelete);
                    // Save changes to the database
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}