using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities
{
    public class SuitabilityCache : BaseEntity
    {
        [MaxLength(32)]
        public string Name { get; set; }
    }
}
