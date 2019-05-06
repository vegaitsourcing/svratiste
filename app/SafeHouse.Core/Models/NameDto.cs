using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Models
{
    public class NameDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MiddleName { get; set; }
    }
}
