using SafeHouse.Core.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class DailyEntry : BaseEntity
    {
        public string CartonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public bool Stay { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Bath { get; set; }
        public bool LiecesRemoval { get; set; }
        public int Clothes { get; set; }
        public int MediationWriting { get; set; }
        public string MediationWritingDescription { get; set; }
        public int MediationSpeaking { get; set; }
        public string MediationSpeakingDescription { get; set; }
        public int LifeSkills { get; set; }
        public int SchoolAcivities { get; set; }
        public bool PsihosocialSupport { get; set; }
        public int ParentsContact { get; set; }
        public int MedicalInterventions { get; set; }
        public string Arrival { get; set; }
        public int EducationWorkshop { get; set; }
        public int CreativeWorkshop { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTIme { get; set; }
    }
}