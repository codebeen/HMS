using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Booking
    {
        [Key] // indication that this is primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto increment
        public int BookingId { get; set; }
        // foreign key room id
        public int RoomId { get; set; }
        // foreign key guest id
        public int GuestId { get; set; }
        // foreign key payment id
        public int? PaymentId { get; set; } // Nullable to handle cases where payment might not be done yet
        public string RoomType { get; set; }
        public string ModeOfPayment { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfGuest { get; set; }
        public bool IsCancelled { get; set; }

        // Navigation properties
        public virtual Room Room { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Payment Payment { get; set; }
    }
}