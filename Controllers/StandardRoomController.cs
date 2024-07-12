using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class StandardRoomController
    {
        // Method to add a standard room
        public bool AddStandardRoom(StandardRoom standardRoom)
        {
            try
            {
                // Add the standard room to the database
                using (var context = new DataContext())
                {
                    context.Rooms.Add(standardRoom);
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
        public List<StandardRoom> GetStandardRooms()
        {
            try
            {
                // Create instance of DataContext
                using (var context = new DataContext())
                {
                    // Assign list of standard rooms where IsDeleted column is false to variable
                    var standardRooms = context.Rooms
                        .OfType<StandardRoom>()
                        .Where(sr => sr.IsDeleted == false)
                        .ToList();

                    // Return all standard rooms
                    return standardRooms;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return null;
            }
        }

        // Method to edit standard room
        public bool EditStandardRoom(StandardRoom standardRoom)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the room exists by room number
                    var existingStandardRoom = context.Rooms
                        .OfType<StandardRoom>()
                        .FirstOrDefault(sr => sr.RoomId == standardRoom.RoomId);

                    if (existingStandardRoom == null || existingStandardRoom.IsDeleted == true)
                    {
                        return false;
                    }

                    existingStandardRoom.RoomNumber = standardRoom.RoomNumber;
                    existingStandardRoom.RoomPrice = standardRoom.RoomPrice;
                    existingStandardRoom.OccupancyLimit = standardRoom.OccupancyLimit;
                    existingStandardRoom.RoomStatus = standardRoom.RoomStatus;
                    existingStandardRoom.BedType = standardRoom.BedType;
                    existingStandardRoom.BathroomInclusion = standardRoom.BathroomInclusion;


                    // Update the standard room record in the database
                    context.Rooms.Update(existingStandardRoom);
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

        // Method to delete standard room
        public bool DeleteStandardRoom(StandardRoom room)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the room id exists
                    var standardRoom = context.Rooms
                        .OfType<StandardRoom>()
                        .FirstOrDefault(sr => sr.RoomId == room.RoomId);

                    if (standardRoom == null || standardRoom.IsDeleted == true)
                    {
                        return false;
                    }

                    // Soft delete the room from the database
                    standardRoom.IsDeleted = true;
                    context.Rooms.Update(standardRoom); // Update the record
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
