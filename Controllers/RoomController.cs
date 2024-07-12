using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class RoomController
    {
        // method to update room status if booked
        public void UpdateRoomStatus(int roomId)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var roomToUpdate = context.Rooms.Find(roomId);

                    roomToUpdate.RoomStatus = "Occupied";

                    // update the record
                    context.Rooms.Update(roomToUpdate);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
