using SafeHouse.Core.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class FirstEvaluation : BaseEntity
    {
        public Carton Carton { get; set; }

        [MaxLength(512)]
        public string GuardiansName { get; set; }

        [MaxLength(512)]
        public string OtherChildrenName { get; set; }

        [MaxLength(512)]
        public string OtherMembersName { get; set; }

        public int LivingSpace { get; set; }

        [MaxLength(512)]
        public string SchoolAndGrade { get; set; }

        [MaxLength(512)]
        public string Languages { get; set; }

        [MaxLength(512)]
        public string HealthCard { get; set; }

        [MaxLength(512)]
        public string CaseLeaderName { get; set; }

        public bool SleepOnStreet { get; set; }

        public bool DumpsterDiving { get; set; }

        public bool Begging { get; set; }

        public bool Prostituting { get; set; }

        public bool SellsOnStreet { get; set; }

        public bool HelpingFamilyOnStreet { get; set; }

        public bool ExtremelyPoor { get; set; }

        [MaxLength(512)]
        public string OtherSuitability { get; set; }

        [MaxLength(512)]
        public string Explanation { get; set; }

        public bool Capability { get; set; }

        public bool OnTheWaitingList { get; set; }

        public DateTime? ServiceStart { get; set; }

        [MaxLength(512)]
        public string DirectedToName { get; set; }

        [MaxLength(512)]
        public string IndividualMovementAbility { get; set; }

        [MaxLength(512)]
        public string VerbalComunicationAbility { get; set; }

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

        [MaxLength(512)]
        public string EvaluationDoneBy { get; set; }

        [MaxLength(512)]
        public string EvaluationRevisedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}