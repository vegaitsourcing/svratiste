using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class GoalAndResult : BaseEntity
    {
        [MaxLength(100)]
        public string Goal { get; set; }

        [MaxLength(100)]
        public string Result { get; set; }

        // public IndividualServicePlan IndividualServicePlan { get; set; }
    }
}