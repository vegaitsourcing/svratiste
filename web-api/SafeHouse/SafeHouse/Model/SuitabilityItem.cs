using System;

namespace SafeHouse.Model
{
    public class SuitabilityItem
    {
        public Guid Id { get; set; }
        public Suitability SuitabilityId { get; set; }
        public String Name {get; set;}
        public String Description {get; set;}
    }
}