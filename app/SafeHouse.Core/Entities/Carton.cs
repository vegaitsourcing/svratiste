using SafeHouse.Core.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class Carton : BaseEntity
    {
        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(32)]
        public string LastName { get; set; }

        [MaxLength(32)]
        public string Nickname { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int NumberOfVisits { get; set; }

        [MaxLength(100)]
        public string AddressStreetName { get; set; }

        [MaxLength(32)]
        public string AddressStreetNumber { get; set; }

        [MaxLength(32)]
        public string FathersName { get; set; }

        [MaxLength(32)]
        public string FathersLastName { get; set; }

        [MaxLength(32)]
        public string MothersName { get; set; }

        [MaxLength(32)]
        public string MothersLastName { get; set; }

        public bool NotificationsEnabled { get; set; }

        public bool InitialEvaluationDone { get; set; }

        public bool EvaluationDone { get; set; }

        public bool IndividualPlanDone { get; set; }

        public bool IndividualPlanRevised { get; set; }
    }
}