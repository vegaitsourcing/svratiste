using SafeHouse.Core.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class DailyEntry : BaseEntity
    {
        public Carton Carton { get; set; }

        public DateTime Date { get; set; }

        public bool Stay { get; set; }

        public Meal Meal { get; set; }

        public bool Bath { get; set; }

        public bool LiecesRemoval { get; set; }

        public int Clothing { get; set; }

        public MediationWriting MediationWriting { get; set; }

        [MaxLength(512)]
        public string MediationWritingDescription { get; set; }

        public MediationSpeaking MediationSpeaking { get; set; }

        public string MediationSpeakingDescription { get; set; }

        public bool PsychosocialSupport { get; set; }

        public string ParentsContact { get; set; }

        public MedicalInterventions MedicalInterventions { get; set; }

        public DateTime Arrival { get; set; }

        public DateTime Departure { get; set; }
    }
}