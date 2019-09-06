using System;
using System.Collections.Generic;

namespace SafeHouse.Core.Models
{
    public class FirstEvaluationDto
    {
        public Guid Id { get; set; }

        public Guid CartonId { get; set; }

        public string GuardiansName { get; set; }

        public string OtherChildrenName { get; set; }

        public string OtherMembersName { get; set; }

        public int LivingSpace { get; set; }

        public string SchoolAndGrade { get; set; }

        public string Languages { get; set; }

        public string HealthCard { get; set; }

        public string CaseLeaderName { get; set; }

        public bool SleepOnStreet { get; set; }

        public bool DumpsterDiving { get; set; }

        public bool Begging { get; set; }

        public bool Prostituting { get; set; }

        public bool SellsOnStreet { get; set; }

        public bool HelpingFamilyOnStreet { get; set; }

        public bool ExtremelyPoor { get; set; }

        public string OtherSuitability { get; set; }

        public string Explanation { get; set; }

        public bool Capability { get; set; }

        public bool OnTheWaitingList { get; set; }

        public DateTime? ServiceStart { get; set; }

        public string DirectedToName { get; set; }

        public string IndividualMovementAbility { get; set; }

        public string VerbalComunicationAbility { get; set; }

        public string PhysicalDescription { get; set; }

        public string DiagnosedDisease { get; set; }

        public string PriorityNeeds { get; set; }

        public string Attitude { get; set; }

        public string Expectations { get; set; }

        public string DirectedFromName { get; set; }

        public string Other { get; set; }

        public DateTime? StartedEvaluation { get; set; }

        public DateTime? FinishedEvaluation { get; set; }

        public string EvaluationDoneBy { get; set; }

        public string EvaluationRevisedBy { get; set; }
    }
}