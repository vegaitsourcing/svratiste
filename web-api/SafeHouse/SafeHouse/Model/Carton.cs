using System;

namespace Svratiste.Model
{
    public class Carton
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String CartonNumber { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public int NumberOfVisits { get; set; }
    }
}
