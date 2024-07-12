using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Threading.Timer;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public class RoomStatusUpdater
    {
        private Timer _timer;

        public void Start()
        {
            // Run the method immediately and then every hour
            _timer = new Timer(UpdateRoomStatuses, null, TimeSpan.Zero, TimeSpan.FromHours(1));
        }

        private void UpdateRoomStatuses(object state)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var currentDateTime = DateTime.Now;

                    // Find bookings with past checkout dates
                    var pastBookings = context.Bookings
                        .Where(b => b.CheckOutDate < currentDateTime && !b.IsCancelled)
                        .ToList();

                    foreach (var booking in pastBookings)
                    {
                        // Find the room associated with the booking
                        var room = context.Rooms.Find(booking.RoomId);
                        if (room != null && room.RoomStatus == "occupied")
                        {
                            // Update the room status to available
                            room.RoomStatus = "available";
                        }
                    }

                    // Save changes to the database
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                MessageBox.Show("Error updating room statuses: " + ex.Message);
            }
        }

        public void Stop()
        {
            _timer?.Dispose();
        }
    }
}
