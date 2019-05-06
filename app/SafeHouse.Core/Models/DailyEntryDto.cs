using SafeHouse.Core.Entities.Enums;
using System;
using System.Collections.Generic;

namespace SafeHouse.Core.Models
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

        public MediationWriting MediationWriting { get; set; }

        public string MediationWritingDescription { get; set; }

        public MediationSpeaking MediationSpeaking { get; set; }

        public string MediationSpeakingDescription { get; set; }

        public LifeSkill LifeSkills { get; set; }

        public ICollection<WorkshopDto> Workshops { get; set; }

        public SchoolActivity SchoolActivities { get; set; }

        public bool PsychosocialSupport { get; set; }

        public string ParentsContact { get; set; }

        public MedicalInterventions MedicalInterventions { get; set; }

        public DateTime Arrival { get; set; }

        public DateTime Departure { get; set; }
    }
}