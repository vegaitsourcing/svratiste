using System;

namespace SafeHouse.Model
{
    public class DailyEntry
    {
        public Guid Id { get; set; }
        public Carton Carton { get; set; }
        public DateTime Date { get; set; }

        // Obezbedjenje boravka
        public bool Stay { get; set; }

        // Obezbeđenje obroka za korisnike
        public int Meal { get; set; }

        // Obezbeđenje uslova za održavanje lične higijene
        public bool Bath { get; set; }
        public bool LiecesRemoval { get; set; }

        // Nabavka obuće i odeće ide po broju komada
        public int Clothing { get; set; }

        // Posredovanje u obezbeđivanju dostupnosti usluga u zajednici
        public int MediationWriting { get; set; }
        public int MediationSpeaking { get; set; }

        // Pružanje psihosocijalne podrške
        public bool PsihosocialSupport { get; set; }

        // Kontakti sa roditeljima
        public int ParentsContact { get; set; }

        // Pružanje medicinskih intervencija i savetovanja
        public int MedicalInterventions { get; set; }

        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
    }
}
