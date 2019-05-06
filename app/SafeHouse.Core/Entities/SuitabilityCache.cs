using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class SuitabilityCache : BaseEntity
    {
        [MaxLength(80)]
        public string Name { get; set; }
    }
}
