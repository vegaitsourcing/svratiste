using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities 
{
    public class SuitabilityItem : BaseEntity
    {
        public Suitability Suitability { get; set; }
        [MaxLength(32)]
        public string Name {get; set;}
        [MaxLength(1024)]
        public string Description {get; set;}
    }
}