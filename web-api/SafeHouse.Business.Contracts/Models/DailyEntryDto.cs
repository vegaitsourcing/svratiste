using SafeHouse.Data.Enums;
using System;

namespace SafeHouse.Business.Contracts.Models
{
    public class DailyEntryDto
    {
        public Guid CartonGuid { get; set; }
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
        //Workshops
        //School

        public bool PsihosocialSupport { get; set; }
        public string ParentsContact { get; set; }

        public MediacalInterventionsEnum MedicalInterventions { get; set; }

        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
    }
}
