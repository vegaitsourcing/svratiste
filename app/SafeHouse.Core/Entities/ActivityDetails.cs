using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class ActivityDetails : BaseEntity
    {
        [MaxLength(512)]
        public string Activity { get; set; }

        [MaxLength(32)]
        public string ResponsiblePerson { get; set; }

        [MaxLength(32)]
        public string TimeLimit { get; set; }

        // public IndividualServicePlan IndividualServicePlan { get; set; }
    }
}