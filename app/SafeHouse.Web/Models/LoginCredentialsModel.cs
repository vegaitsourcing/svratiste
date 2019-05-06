using System.ComponentModel.DataAnnotations;
using SafeHouse.Core.Models;

namespace SafeHouse.Web.Models
{
    public class LoginCredentialsModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public CheckCredentialsRequest ToCheckCredentialsRequest()
            => new CheckCredentialsRequest
            {
                Password = Password,
                Username = Username
            };
    }
}
