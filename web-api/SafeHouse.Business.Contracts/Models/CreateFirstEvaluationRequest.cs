using System;

namespace SafeHouse.Business.Contracts.Models
{
    public class CreateFirstEvaluationRequest
    {
        public Guid? Id { get; set; }

        public Guid CartonId { get; set; }

        public string OtherChildernName { get; set; }

        public string OtherMembersName { get; set; }

        public string GuardiansName { get; set; }

        public string LivingSpace { get; set; }

        public string SchoolAndGrade { get; set; }

        public string Languages { get; set; }

        public bool HealthCard { get; set; }

        public string CaseLeaderName { get; set; }

        public bool Capability { get; set; }

        public bool OnTheWaitingList { get; set; }

        public DateTime ServiceStart { get; set; }

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

        public DateTime StartedEvaluation { get; set; }

        public DateTime FinishedEvaluation { get; set; }

        public string EvaluationDoneBy { get; set; }

        public string EvaluationRevisedBy { get; set; }

        public SuitabilityDto Suitability { get; set; }
    }
}
