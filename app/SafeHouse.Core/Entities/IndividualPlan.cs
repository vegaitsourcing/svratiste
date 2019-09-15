using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class IndividualPlan : BaseEntity
    {
        public Carton Carton { get; set; }

        public string GoalsAndResults { get; set; }

        public string ActivitiesAndDue { get; set; }

        public string InvolvedPersons { get; set; }

        public DateTime Date { get; set; }

        public DateTime Due { get; set; }

        public bool IsDeleted { get; set; }
    }
}