using SafeHouse.Business.Contracts.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Api.Models
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
