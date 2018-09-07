using System;

namespace SafeHouse.Model
{
    public class SafeHouseUser
    {
        public Guid Id { get; set; }
        public String CommonName { get; set; }
        public String Email { get; set; }
        public String PasswordSalt { get; set; }
        public String Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
