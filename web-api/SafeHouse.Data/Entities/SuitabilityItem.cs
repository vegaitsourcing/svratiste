using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities 
{
    public class SuitabilityItem : BaseEntity
    {
        public Suitability Suitability { get; set; }

        public SuitabilityCache SuitabilityCache { get; set; }

        [MaxLength(1024)]
        public string Description {get; set;}
    }
}