using System;

namespace SafeHouse.Model
{
    public class Carton
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Nickname { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int NumberOfVisits { get; set; }
        public String AddressStreetName { get; set; }
        public String AddressStreetNumber { get; set; }
        public String FathersName {get; set;}
        public String MothersName { get; set; }
        public bool InitialEvaluationDone {get; set;}
        public bool EvaluationDone {get; set;}
        public bool IndividualPlanDone {get; set;}
        public bool IndividualPlanRevised {get; set;}

    }
}
