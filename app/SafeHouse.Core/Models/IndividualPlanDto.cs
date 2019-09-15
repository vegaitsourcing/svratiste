using SafeHouse.Core.Entities.Enums;
using System;

namespace SafeHouse.Core.Models
{
    public class IndividualPlanDto
    {
        public Guid Id { get; set; }

        public Guid CartonId { get; set; }
        
        public string GoalsAndResults { get; set; }

        public string ActivitiesAndDue { get; set; }

        public string InvolvedPersons { get; set; }

        public DateTime Date { get; set; }

        public DateTime Due { get; set; }

        public bool IsDeleted { get; set; }
    }
}