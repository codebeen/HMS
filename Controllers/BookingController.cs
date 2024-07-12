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
                    .Where(b => b.Status != "Cancelled" && b.Status != "Done" && b.CheckInDate.Date == filterDate.Date) // filter by date, excludes time
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
                    .Where(b => b.Status == "Upcoming") //&& b.CheckInDate > DateTime.Now)
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


        // method to get guest that are staying on the hotel
        public List<Booking> GetGuestStayingNow()
        {
            try
            {
                using (var context = new DataContext())
                {
                    // get bookings which checkin date is less than current time and checkout date is greater than or equal to current time
                    var stayingGuest = context.Bookings
                        .Include(b => b.Room)
                        .Include(b => b.Guest)
                        .Where(b => b.Status == "Staying") // && b.CheckInDate <= DateTime.Now && b.CheckOutDate >= DateTime.Now)
                        .ToList();

                    return stayingGuest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // method to count the staying guests
        public int CountStayingGuests()
        {
            try
            {
                using (var context = new DataContext())
                {
                    // get bookings which checkin date is less than current time and checkout date is greater than or equal to current time
                    var totalStayingGuest = context.Bookings
                        .Include(b => b.Room)
                        .Include(b => b.Guest)
                        .Where(b => b.Status == "Staying") // && b.CheckInDate <= DateTime.Now && b.CheckOutDate >= DateTime.Now)
                        .Count();

                    return totalStayingGuest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }


        // method to count upcoming bookings
        public int CountUpcomingBookings()
        {
            try
            {
                using (var context = new DataContext())
                {
                    // get bookings which checkin date is less than current time and checkout date is greater than or equal to current time
                    var totalUpcomingBookings = context.Bookings
                        .Include(b => b.Room)
                        .Include(b => b.Guest)
                        .Where(b => b.Status == "Upcoming") // && b.CheckInDate > DateTime.Now)
                        .Count();

                    return totalUpcomingBookings;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }


        // check if there is an overlapping booking given the new checkout date
        public bool CheckIfOverlappingBooking(int roomId, int bookingId, DateTime checkInDate, DateTime checkOutDate)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // get the booking records that has the same room id
                    var bookings = context.Bookings
                        .Where(b => b.RoomId == roomId && b.BookingId != bookingId && b.Status != "Cancelled" && b.Status != "Done")
                        .ToList();

                    // check if there is overlapping booking
                    foreach (var booking in bookings)
                    {
                        if (checkInDate < booking.CheckOutDate && checkOutDate > booking.CheckInDate)
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // method to update status if the booking is done
        public void UpdateBookingStatus()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var allBookings = context.Bookings.Where(b => b.Status != "Cancelled").ToList();

                    foreach (var booking in allBookings)
                    {
                        if (booking.CheckInDate <= DateTime.Now && booking.CheckOutDate >= DateTime.Now)
                        {
                            booking.Status = "Staying";
                        }
                        else if (booking.CheckOutDate < DateTime.Now)
                        {
                            booking.Status = "Done";
                            booking.Room.RoomStatus = "Available"; // reset the room status to available
                        }
                        else if (booking.CheckInDate > DateTime.Now)
                        {
                            booking.Status = "Upcoming";
                        }

                        context.Bookings.Update(booking);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // method to edit staying bookings or bookings that already checkin
        public bool EditStayNowBookings(Booking booking)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Retrieve the booking record by id
                    var bookingToUpdate = context.Bookings.Find(booking.BookingId);

                    if (bookingToUpdate == null || bookingToUpdate.Status.ToLower() == "cancelled" || bookingToUpdate.Status.ToLower() == "done")
                    {
                        return false;
                    }
                    else
                    {
                        // assign the new checkout date
                        bookingToUpdate.CheckOutDate = booking.CheckOutDate;

                        // update the record
                        context.Bookings.Update(bookingToUpdate);
                        // save changes
                        context.SaveChanges();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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

                    if (bookingToEdit == null || bookingToEdit.Status.ToLower() == "cancelled" || bookingToEdit.Status.ToLower() == "done")
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
                    if (bookingToDelete == null || bookingToDelete.Status == "cancelled" || bookingToDelete.Status.ToLower() == "done")
                    {
                        return false;
                    }

                    // soft delete the record
                    bookingToDelete.Status = "Cancelled";
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