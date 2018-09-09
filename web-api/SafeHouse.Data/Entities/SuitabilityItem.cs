using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities 
{
    public class SuitabilityItem : BaseEntity
    {

        public SuitabilityCache SuitabilityCache { get; set; }

        [MaxLength(1024)]
        public string Description {get; set;}
    }
}