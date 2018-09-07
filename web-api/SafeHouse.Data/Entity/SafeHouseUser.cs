using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Model
{
    public class SafeHouseUser : BaseEntity
    {
        [Required]
        public string CommonName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordSalt { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
