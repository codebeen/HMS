using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class SuiteRoomController
    {
        // Method to add a suite room
        public bool AddSuiteRoom(Suite suiteRoom)
        {
            try
            {
                // Add the suite room to the database
                using (var context = new DataContext())
                {
                    context.Rooms.Add(suiteRoom);
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


        // Method to read or display all the standard rooms
        public List<Suite> GetSuiteRooms()
        {
            try
            {
                // Create instance of DataContext
                using (var context = new DataContext())
                {
                    // Assign list of suite rooms where IsDeleted column is false to variable
                    var suiteRooms = context.Rooms
                        .OfType<Suite>()
                        .Where(sr => sr.IsDeleted == false)
                        .ToList();

                    // Return all suite rooms
                    return suiteRooms;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return null;
            }
        }

        // Method to edit suite room
        public bool EditSuiteRoom(Suite suiteRoom)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the room exists by room number
                    var existingSuiteRoom = context.Rooms
                        .OfType<Suite>()
                        .FirstOrDefault(sr => sr.RoomId == suiteRoom.RoomId);

                    if (existingSuiteRoom == null || existingSuiteRoom.IsDeleted == true)
                    {
                        return false;
                    }

                    existingSuiteRoom.RoomNumber = suiteRoom.RoomNumber;
                    existingSuiteRoom.RoomPrice = suiteRoom.RoomPrice;
                    existingSuiteRoom.OccupancyLimit = suiteRoom.OccupancyLimit;
                    existingSuiteRoom.RoomStatus = suiteRoom.RoomStatus;
                    existingSuiteRoom.NumberOfRooms = suiteRoom.NumberOfRooms;
                    existingSuiteRoom.SuiteType = suiteRoom.SuiteType;


                    // Update the suite room record in the database
                    context.Rooms.Update(existingSuiteRoom);
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

        // Method to delete suite room
        public bool DeleteSuiteRoom(Suite suiteRoom)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the room id exists
                    var suiteRoomToDelete = context.Rooms
                        .OfType<Suite>()
                        .FirstOrDefault(sr => sr.RoomId == suiteRoom.RoomId);

                    if (suiteRoomToDelete == null || suiteRoomToDelete.IsDeleted == true)
                    {
                        return false;
                    }

                    // Soft delete the room from the database
                    suiteRoomToDelete.IsDeleted = true;
                    context.Rooms.Update(suiteRoomToDelete); // Update the record
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
