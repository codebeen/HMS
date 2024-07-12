using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class GuestController
    {
        // method to add guest record
        public bool AddGuest(Guest guest)
        {
            try
            {
                // add the guest record to the database
                using (var context = new DataContext())
                {
                    context.Guests.Add(guest);
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

        public List<Guest> GetAllGuests()
        {
            using (var context = new DataContext())
            {
                return context.Guests.ToList();
            }
        }
    }
}
