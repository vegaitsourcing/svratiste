using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Model
{
    public class Carton : BaseEntity
    {
        [Required]
        [MaxLength(32)]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(32)]
        public String LastName { get; set; }

        [MaxLength(32)]
        public String Nickname { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int NumberOfVisits { get; set; }

        [MaxLength(100)]
        public String AddressStreetName { get; set; }

        [MaxLength(32)]
        public String AddressStreetNumber { get; set; }

        [MaxLength(32)]
        public String FathersName {get; set;}

        [MaxLength(32)]
        public String MothersName { get; set; }
        public bool InitialEvaluationDone {get; set;}
        public bool EvaluationDone {get; set;}
        public bool IndividualPlanDone {get; set;}
        public bool IndividualPlanRevised {get; set;}

    }
}
