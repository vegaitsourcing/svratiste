using SafeHouse.Core.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class FirstEvaluation : BaseEntity
    {
        public Carton Carton { get; set; }

        [MaxLength(512)]
        public string OtherChildrenName { get; set; }

        [MaxLength(512)]
        public string OtherMembersName { get; set; }

        [MaxLength(512)]
        public string GuardiansName { get; set; }

        public LivingSpace LivingSpace { get; set; }

        [MaxLength(512)]
        public string SchoolAndGrade { get; set; }

        [MaxLength(256)]
        public string Languages { get; set; }

        public bool HealthCard { get; set; }

        [MaxLength(256)]
        public string CaseLeaderName { get; set; }

        public Suitability Suitability { get; set; }

        public bool Capability { get; set; }

        public bool OnTheWaitingList { get; set; }

        public DateTime ServiceStart { get; set; }

        [MaxLength(512)]
        public string DirectedToName { get; set; }

        public IndividualMovementAbility IndividualMovementAbility { get; set; }

        [MaxLength(512)]
        public string VerbalCommunicationAbility { get; set; }

        [MaxLength(512)]
        public string PhysicalDescription { get; set; }

        [MaxLength(512)]
        public string DiagnosedDisease { get; set; }

        [MaxLength(512)]
        public string PriorityNeeds { get; set; }

        [MaxLength(512)]
        public string Attitude { get; set; }

        [MaxLength(512)]
        public string Expectations { get; set; }

        [MaxLength(512)]
        public string DirectedFromName { get; set; }

        [MaxLength(512)]
        public string Other { get; set; }

        public DateTime? StartedEvaluation { get; set; }

        public DateTime? FinishedEvaluation { get; set; }

        [MaxLength(256)]
        public string EvaluationDoneBy { get; set; }

        [MaxLength(256)]
        public string EvaluationRevisedBy { get; set; }
    }
}