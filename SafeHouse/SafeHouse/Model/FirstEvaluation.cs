using System;

namespace SafeHouse.Model
{
    public class FirstEvaluation
    {
        public Guid Id { get; set; }
        public Carton Carton { get; set; }
        public String OtherChildernName { get; set; }
        public String OtherMembersName { get; set; }
        public String GuardiansName { get; set; }
        public String LivingSpace { get; set; }
        public String  SchoolAndGrade { get; set; }
        public String Languages { get; set; }
        public bool HealthCard { get; set; }
        public String CaseLeaderName { get; set; }
        public int MyProperty { get; set; }
        public Suitability SuitabilityId { get; set;}

        public bool Capability { get; set; }
        public bool OnTheWaitingList { get; set; }
        public DateTime ServiceStart { get; set; }
        public String DirectedToName { get; set; }

        //Procena Sposobnosti
        public String IndividualMovementAbility { get; set; }
        public String VerbalComunicationAbility { get; set; }
        public String PhysicalDescription { get; set; }
        public String DiagnosedDisease { get; set; }
        public String PriorityNeeds { get; set; }
        public String Attitude { get; set; }
        public String Expectations { get; set; }
        public String DirectedFromName { get; set; }
        public String Other { get; set; }

        public DateTime StartedEvaluation { get; set; }
        public DateTime FinishedEvaluation { get; set; }
        public String EvaluationDoneBy { get; set; }
        public String EvaluationRevisedBy { get; set; }
    }
}
