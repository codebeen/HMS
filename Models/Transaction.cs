using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }

        // Separate properties for date and time
        public DateTime TransactionDate { get; set; }
        public TimeSpan TransactionTime { get; set; }
        // Reference to User who created this transaction
        public string? EmployeeName { get; set; }

        // Additional properties as needed
    }
}
