using SafeHouse.Data.Enums;
using System;
using System.Collections.Generic;

namespace SafeHouse.Business.Contracts.Models
{
    public class DailyEntryDto
    {
        public Guid Id { get; set; }
        public Guid CartonId { get; set; }
        public bool Stay { get; set; }

        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Diner { get; set; }

        public bool Bath { get; set; }
        public bool LiecesRemoval { get; set; }

        public int Clothes { get; set; }
        public MediationWritingEnum MediationWriting { get; set; }
        public string MediationWritingDescription { get; set; }

        public MediationSpeakingEnum MediationSpeaking { get; set; }
        public string MediationSpeakingDescription { get; set; }

        //LifeSkill
        public LifeSkillEnum LifeSkills { get; set; }
        //Workshops
        public ICollection<WorkshopDto> Workshops { get; set; }
        //School
        public SchoolActivityEnum SchoolAcivities { get; set; }

        public bool PsihosocialSupport { get; set; }
        public string ParentsContact { get; set; }

        public MedicalInterventionsEnum MedicalInterventions { get; set; }

        public DateTime Arrival { get; set; }

        public DateTime Departure { get; set; }
    }
}
