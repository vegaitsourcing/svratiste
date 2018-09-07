using System;

namespace Svratiste.Model
{
    public class Carton
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        //public String CartonNumber { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int NumberOfVisits { get; set; }
        public String AddressStreetName { get; set; }
        public String AddressStreetNumber { get; set; }
        public String FathersFirstName {get; set;}
        public String FatherLastName {get; set;}
        public String MothersFirstName { get; set; }
        public String MothersLastName { get; set; }
        public bool InitialEvaluationDone {get; set;}
        public bool EvaluationDone {get; set;}
        public bool IndividualPlanDone {get; set;}
        public bool IndividualPlanRevised {get; set;}

    }
}
