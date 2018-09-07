using System;

namespace Svratiste.Model
{
    public class FirstEvaluation
    {
        public Guid Id { get; set; }
        public Carton Carton { get; set; }
        public String Nickname { get; set; }
        public String ParentsName { get; set; }
        public String OtherChildernName { get; set; }
        public String OtherMembersName { get; set; }
        public String AddressStreetName { get; set; }
        public String AddressStreetNumber { get; set; }

        // TODO: Add other fields
    }
}
