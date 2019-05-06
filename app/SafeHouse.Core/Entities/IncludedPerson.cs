using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class IncludedPerson : BaseEntity
    {
        [MaxLength(32)]
        public string FirstName { get; set; }

        [MaxLength(32)]
        public string LastName { get; set; }

        [MaxLength(32)]
        public string Function { get; set; }
        public IndividualServicePlan IndividualServicePlan { get; set; }
    }
}
