using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Linq;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class PaymentController
    {
        private static readonly ExceptionHandling exception = new();

        public bool AddPayment(Payment payment)
        {
            try
            {
                // add the guest record to the database
                using (var context = new DataContext())
                {
                    context.Payments.Add(payment);
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
    }
}
