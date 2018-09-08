using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities 
{
    public class Suitability : BaseEntity
    {
        [MaxLength(1024)]
        public string Description { get; set; }
    }
}