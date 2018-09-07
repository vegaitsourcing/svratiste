using System;

namespace Svratiste.Model
{
    public class DailyEntry
    {
        public Guid Id { get; set; }
        public Carton Carton { get; set; }
        public DateTime Date { get; set; }

        // Obezbedjenje boravka
        public bool Stay { get; set; }

        // Obezbeđenje obroka za korisnike
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }

        // Obezbeđenje uslova za održavanje lične higijene
        public bool Bath { get; set; }
        public bool LiecesRemoval { get; set; }

        // Nabavka obuće i odeće
        public bool Clothing { get; set; }

        // TODO: Add other fields
    }
}
