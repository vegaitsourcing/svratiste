﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class Evaluation : BaseEntity
    {
        public Carton Carton { get; set; }

        [MaxLength(256)]
        public string DedicatedWorker { get; set; }

        [MaxLength(256)]
        public string OtherMembers { get; set; }
    
        [MaxLength(512)]
        public string BasicPhysicalNeeds { get; set; }

        [MaxLength(512)]
        public string PsyhoSocialNeeds { get; set; }

        [MaxLength(512)]
        public string EducationalNeeds { get; set; }

        [MaxLength(512)]
        public string OtherNeeds { get; set; }

        [MaxLength(512)]
        public string DominantEmotions { get; set; }

        [MaxLength(512)]
        public string DominantBehaviors { get; set; }

        [MaxLength(256)]
        public string SurroundStrenghts { get; set; }

        [MaxLength(256)]
        public string FamilyStrenghts { get; set; }

        [MaxLength(256)]
        public string PersonalStrenghts { get; set; }

        [MaxLength(256)]
        public string OtherStrenghts { get; set; }

        [MaxLength(256)]
        public string SurroundRisks { get; set; }

        [MaxLength(256)]
        public string FamilyRisks { get; set; }

        [MaxLength(256)]
        public string BehaviorRisks { get; set; }

        [MaxLength(256)]
        public string OtherRisks { get; set; }

        [MaxLength(512)]
        public string Capabilities { get; set; }

        [MaxLength(512)]
        public string CulturalSpecifics { get; set; }

        [MaxLength(256)]
        public string AdvicedLevelOfSupport { get; set; }

        [MaxLength(256)]
        public string EvaluationDoneBy { get; set; }

        public DateTime Date { get; set; }

        public bool IsDeleted { get; set; }
    }
}
