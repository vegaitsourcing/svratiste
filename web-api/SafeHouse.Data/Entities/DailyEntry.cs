using System;
using System.ComponentModel.DataAnnotations;
using SafeHouse.Data.Enums;

namespace SafeHouse.Data.Entities
{
    public class DailyEntry : BaseEntity
    {
        public Carton Carton { get; set; }

        public DateTime Date { get; set; }

        // Obezbedjenje boravka
        public bool Stay { get; set; }

        // Obezbeđenje obroka za korisnike
        public MealEnum Meal { get; set; }

        // Obezbeđenje uslova za održavanje lične higijene
        public bool Bath { get; set; }

        public bool LiecesRemoval { get; set; }

        // Nabavka obuće i odeće ide po broju komada
        public int Clothing { get; set; }

        // Posredovanje u obezbeđivanju dostupnosti usluga u zajednici
        public MediationWritingEnum MediationWriting { get; set; }

        [MaxLength(512)]
        public string MediationWritingDescription { get; set; }

        public MediationSpeakingEnum MediationSpeaking { get; set; }

        public string MediationSpeakingDescription { get; set; }

        // Pružanje psihosocijalne podrške
        public bool PsihosocialSupport { get; set; }

        // Kontakti sa roditeljima
        public string ParentsContact { get; set; }

        // Pružanje medicinskih intervencija i savetovanja
        public MedicalInterventionsEnum MedicalInterventions { get; set; }

        public DateTime Arrival { get; set; }

        public DateTime Departure { get; set; }
    }
}