using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities
{
    public class SafeHouseUser : BaseEntity
    {
        [Required]
        public string CommonName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
