using System;

namespace SafeHouse.Data.Entities 
{
    public class SuitabilityItem : BaseEntity
    {
        public Suitability Suitability { get; set; }
        public string Name {get; set;}
        public string Description {get; set;}
    }
}