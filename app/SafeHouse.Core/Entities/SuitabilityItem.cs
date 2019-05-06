using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class SuitabilityItem : BaseEntity
    {
        public SuitabilityCache SuitabilityCache { get; set; }

        [MaxLength(1024)]
        public string Description { get; set; }
    }
}