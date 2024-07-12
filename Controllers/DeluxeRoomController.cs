using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class DeluxeRoomController
    {
        // Method to add a deluxe room
        public bool AddDeluxeRoom(DeluxeRoom deluxeRoom)
        {
            try
            {
                // Add the deluxe room to the database
                using (var context = new DataContext())
                {
                    context.Rooms.Add(deluxeRoom);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }

        // Method to read or display all the deluxe rooms
        public List<DeluxeRoom> GetDeluxeRooms()
        {
            try
            {
                // Create instance of DataContext
                using (var context = new DataContext())
                {
                    // Assign list of deluxe rooms where IsDeleted column is false to variable
                    var deluxeRooms = context.Rooms
                        .OfType<DeluxeRoom>()
                        .Where(sr => sr.IsDeleted == false)
                        .ToList();

                    // Return all deluxe rooms
                    return deluxeRooms;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return null;
            }
        }

        // Method to edit deluxe room
        public bool EditDeluxeRoom(DeluxeRoom deluxeRoom)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the room exists by room id
                    var existingDeluxeRoom = context.Rooms
                        .OfType<DeluxeRoom>()
                        .FirstOrDefault(sr => sr.RoomId == deluxeRoom.RoomId);

                    if (existingDeluxeRoom == null || existingDeluxeRoom.IsDeleted == true)
                    {
                        return false;
                    }

                    existingDeluxeRoom.RoomNumber = deluxeRoom.RoomNumber;
                    existingDeluxeRoom.RoomPrice = deluxeRoom.RoomPrice;
                    existingDeluxeRoom.OccupancyLimit = deluxeRoom.OccupancyLimit;
                    existingDeluxeRoom.RoomStatus = deluxeRoom.RoomStatus;
                    existingDeluxeRoom.TypeOfView = deluxeRoom.TypeOfView;

                    // Update the deluxe room record in the database
                    context.Rooms.Update(existingDeluxeRoom);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }

        // Method to delete deluxe room
        public bool DeleteDeluxeRoom(DeluxeRoom deluxeRoom)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the room id exists
                    var deluxeRoomToDelete = context.Rooms
                        .OfType<DeluxeRoom>()
                        .FirstOrDefault(sr => sr.RoomId == deluxeRoom.RoomId);

                    if (deluxeRoomToDelete == null || deluxeRoomToDelete.IsDeleted == true)
                    {
                        return false;
                    }

                    // Soft delete the room from the database
                    deluxeRoomToDelete.IsDeleted = true;
                    context.Rooms.Update(deluxeRoomToDelete); // Update the record
                    context.SaveChanges(); // Save changes
                    return true;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }


        // Handle exceptions with error message
        private void HandleException(Exception ex)
        {
            var errorMessage = new StringBuilder();
            errorMessage.AppendLine($"Message: {ex.Message}");
            errorMessage.AppendLine($"Source: {ex.Source}");
            errorMessage.AppendLine($"Stack Trace: {ex.StackTrace}");

            var inner = ex.InnerException;
            while (inner != null)
            {
                errorMessage.AppendLine("---- Inner Exception ----");
                errorMessage.AppendLine($"Message: {inner.Message}");
                errorMessage.AppendLine($"Source: {inner.Source}");
                errorMessage.AppendLine($"Stack Trace: {inner.StackTrace}");
                inner = inner.InnerException;
            }

            MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
