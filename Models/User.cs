using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class User
    {
        // Necessary for Login
        [Key] [Required]
        public string EmployeeNumber { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Birthdate { get; set; }
        [Required]
        public string Salt { get; set; }
        [Required]
        public string SaltedPassword { get; set; }
        public DateTime? CreatedAt { get; set; }

        // For profile purposes
        [Required]
        public string JobPosition { get; set; }
        public string? Schedule { get; set; }
        [Required]
        public byte[] ProfilePicture { get; set; }
    }
}