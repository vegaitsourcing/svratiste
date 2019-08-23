using SafeHouse.Core.Entities.Enums;
using System;

namespace SafeHouse.Core.Models
{
    public class CartonDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int NumberOfVisits { get; set; }

        public string AddressStreetName { get; set; }

        public string AddressStreetNumber { get; set; }

        public string FathersName { get; set; }

        public string FathersLastName { get; set; }

        public string MothersName { get; set; }

        public string MothersLastName { get; set; }

        public bool NotificationsEnabled { get; set; }

        public bool InitialEvaluationDone { get; set; }

        public bool EvaluationDone { get; set; }

        public bool IndividualPlanDone { get; set; }

        public bool IndividualPlanRevised { get; set; }

        public int Notifications { get; set; }
    }
}