using SafeHouse.Core.Entities.Enums;
using System;
using System.Collections.Generic;

namespace SafeHouse.Core.Models
{
    public class DailyEntryDto
    {
        public Guid Id { get; set; }
        public Guid CartonId { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Diner { get; set; }
        public bool Bath { get; set; }
        public bool LiecesRemoval { get; set; }
        public bool Clothes { get; set; }
        public bool VerballySocialCenter { get; set; }
        public bool VerballyEducation { get; set; }
        public bool VerballyCitizensAssociations { get; set; }
        public bool VerballyHealthInstitutions { get; set; }
        public bool VerballyPolice { get; set; }
        public bool VerballyOther { get; set; }
        public bool WrittenSocialCenter { get; set; }
        public bool WrittenEducation { get; set; }
        public bool WrittenCitizensAssociations { get; set; }
        public bool WrittenHealthInstitutions { get; set; }
        public bool WrittenPolice { get; set; }
        public bool WrittenOther { get; set; }
        public bool CbDecisionMakingSkills { get; set; }
        public bool CbProblemSolvingSkills { get; set; }
        public bool CbAssertiveCommunication { get; set; }
        public bool CbHowToSayNo { get; set; }
        public bool CbAwarenessOfYourself { get; set; }
        public bool CbRecognizingAndManagingEmotions { get; set; }
        public bool CbEmpathy { get; set; }
        public bool CbConfrontationWithStress { get; set; }
        public bool CbMaintainingPersonalHygiene { get; set; }
        public bool CbMaintainingHygieneOfClothingAndFootwear { get; set; }
        public bool CbHealth { get; set; }
        public bool CbPersonalSecurityAndCrisisManagementSituations { get; set; }
        public bool CbTakingCareOfPersonalFinances { get; set; }
        public bool CbMaintainingHygieneOfThePlaceOfResidence { get; set; }
        public bool CbUseOfHomeAppliances { get; set; }
        public bool CbMealPreparationAndServing { get; set; }
        public bool CbBehaviorAtTheTable { get; set; }
        public bool CbProcurementOfGroceries { get; set; }
        public bool CbHealthCareDuringPregnancy { get; set; }
        public bool CbPhysicalCareOfNewbornAndInfant { get; set; }
        public bool CbExpressingLoveForYourChild { get; set; }
        public bool CbChildProtection { get; set; }
        public bool CbStimulatingTheChild { get; set; }
        public bool CbIssuingCersonalDocuments { get; set; }
        public bool CbUseOfTheClock { get; set; }
        public bool CbTrafficRegulationsAndSigns { get; set; }
        public bool CbUtilizingCommunityResources { get; set; }
        public bool CbNavigatingTheSpace { get; set; }
        public bool CbUseOfMedia { get; set; }
        public bool CbActiveJobSearch { get; set; }
        public string TxtDecisionMakingSkills { get; set; }
        public string TxtProblemSolvingSkills { get; set; }
        public string TxtAssertiveCommunication { get; set; }
        public string TxtHowToSayNo { get; set; }
        public string TxtAwarenessOfYourself { get; set; }
        public string TxtRecognizingAndManagingEmotions { get; set; }
        public string TxtEmpathy { get; set; }
        public string TxtConfrontationWithStress { get; set; }
        public string TxtMaintainingPersonalHygiene { get; set; }
        public string TxtMaintainingHygieneOfClothingAndFootwear { get; set; }
        public string TxtHealth { get; set; }
        public string TxtPersonalSecurityAndCrisisManagementSituations { get; set; }
        public string TxtTakingCareOfPersonalFinances { get; set; }
        public string TxtMaintainingHygieneOfThePlaceOfResidence { get; set; }
        public string TxtUseOfHomeAppliances { get; set; }
        public string TxtMealPreparationAndServing { get; set; }
        public string TxtBehaviorAtTheTable { get; set; }
        public string TxtProcurementOfGroceries { get; set; }
        public string TxtHealthCareDuringPregnancy { get; set; }
        public string TxtPhysicalCareOfNewbornAndInfant { get; set; }
        public string TxtExpressingLoveForYourChild { get; set; }
        public string TxtChildProtection { get; set; }
        public string TxtStimulatingTheChild { get; set; }
        public string TxtIssuingCersonalDocuments { get; set; }
        public string TxtUseOfTheClock { get; set; }
        public string TxtTrafficRegulationsAndSigns { get; set; }
        public string TxtUtilizingCommunityResources { get; set; }
        public string TxtNavigatingTheSpace { get; set; }
        public string TxtUseOfMedia { get; set; }
        public string TxtActiveJobSearch { get; set; }
        public string EdictiveWorkshops { get; set; }
        public string CreativeWorkshops { get; set; }
        public string Homework { get; set; }
        public string Training { get; set; }
        public string LearningSchoolMaterials { get; set; }
        public string InterventionsForTheDevelopmentOfCognitiveFunctions { get; set; }
        public string TelephoneContact { get; set; }
        public string PersonalContact { get; set; }
        public string InterventionAtTheSafeHouse { get; set; }
        public string Counseling { get; set; }
        public string Medication { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
    }
}