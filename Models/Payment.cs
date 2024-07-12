using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Payment
    {
        [Key] // Indicate that this is the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto increment
        public int PaymentId { get; set; }

        public int BookingId { get; set; }

        // Indicates the payment method, e.g., "Cash", "Credit Card", "PayMongo"
        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; }

        // Amount of the payment
        [Required]
        public double Amount { get; set; }

        // Currency of the payment, e.g., "PHP"
        [Required]
        [MaxLength(10)]
        public string Currency { get; set; }

        // Status of the payment, e.g., "Pending", "Completed", "Failed"
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }

        // Date and time of the payment
        [Required]
        public DateTime PaymentDate { get; set; }

        // PayMongo-specific fields (nullable for cash payments)
        public string? PayMongoTransactionId { get; set; }
        public string? PayMongoPaymentIntentId { get; set; }
        public string? PayMongoPaymentMethodId { get; set; }

        public virtual Booking Booking { get; set; }

    }
}
