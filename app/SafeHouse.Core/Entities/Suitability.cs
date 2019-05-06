using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class Suitability : BaseEntity
    {
        [MaxLength(1024)]
        public string Description { get; set; }

        public ICollection<SuitabilityItem> SuitabilityItems { get; set; }
    }
}