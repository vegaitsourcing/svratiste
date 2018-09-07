using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Model
{
    public class FirstEvaluation : BaseEntity
    {
        public Carton Carton { get; set; }

        [MaxLength(512)]
        public String OtherChildernName { get; set; }

        [MaxLength(512)]
        public String OtherMembersName { get; set; }

        [MaxLength(512)]
        public String GuardiansName { get; set; }

        [MaxLength(128)]
        public String LivingSpace { get; set; }

        [MaxLength(512)]
        public String  SchoolAndGrade { get; set; }

        [MaxLength(256)]
        public String Languages { get; set; }
        public bool HealthCard { get; set; }

        [MaxLength(256)]
        public String CaseLeaderName { get; set; }
        public int MyProperty { get; set; }
        public Suitability SuitabilityId { get; set;}

        public bool Capability { get; set; }
        public bool OnTheWaitingList { get; set; }
        public DateTime ServiceStart { get; set; }

        [MaxLength(512)]
        public String DirectedToName { get; set; }

        //Procena Sposobnosti
        [MaxLength(512)]
        public String IndividualMovementAbility { get; set; }

        [MaxLength(512)]
        public String VerbalComunicationAbility { get; set; }

        [MaxLength(512)]
        public String PhysicalDescription { get; set; }

        [MaxLength(512)]
        public String DiagnosedDisease { get; set; }

        [MaxLength(512)]
        public String PriorityNeeds { get; set; }

        [MaxLength(512)]
        public String Attitude { get; set; }

        [MaxLength(512)]
        public String Expectations { get; set; }

        [MaxLength(512)]
        public String DirectedFromName { get; set; }

        [MaxLength(512)]
        public String Other { get; set; }

        public DateTime StartedEvaluation { get; set; }
        public DateTime FinishedEvaluation { get; set; }

        [MaxLength(256)]
        public String EvaluationDoneBy { get; set; }

        [MaxLength(256)]
        public String EvaluationRevisedBy { get; set; }
    }
}
