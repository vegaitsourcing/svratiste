using SafeHouse.Core.Entities.Enums;
using System;

namespace SafeHouse.Core.Models
{
    public class EvaluationDto
    {
        public Guid Id { get; set; }

        public int Age { get; set; }

        public string FamilyMembers { get; set; }

        public string SchoolStatus { get; set; }

        public string CaseLeader { get; set; }

        public string DedicatedWorker { get; set; }

        public string OtherMembers { get; set; }

        public string BasicPhysicalNeeds { get; set; }

        public string PsyhoSocialNeeds { get; set; }

        public string EducationalNeeds { get; set; }

        public string OtherNeeds { get; set; }

        public string DominantEmotions { get; set; }

        public string DominantBehaviors { get; set; }

        public string SurroundStrenghts { get; set; }

        public string FamilyStrenghts { get; set; }

        public string PersonalStrenghts { get; set; }

        public string OtherStrenghts { get; set; }

        public string SurroundRisks { get; set; }

        public string FamilyRisks { get; set; }

        public string BehaviorRisks { get; set; }

        public string OtherRisks { get; set; }

        public string Capabilities { get; set; }

        public string CulturalSpecifics { get; set; }

        public string AdvicedLevelOfSupport { get; set; }

        public string EvaluationDoneBy { get; set; }
    }
}