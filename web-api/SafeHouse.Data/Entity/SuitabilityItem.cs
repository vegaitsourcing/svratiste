using System;

namespace SafeHouse.Model
{
    public class SuitabilityItem : BaseEntity
    {
        public Suitability Suitability { get; set; }
        public string Name {get; set;}
        public string Description {get; set;}
    }
}