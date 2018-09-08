using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities 
{
    public class IndividualServicePlan: BaseEntity
    {
        public Carton Carton { get; set; }
        [MaxLength(8)]
        public string Age { get; set; }
        [MaxLength(32)]
        public string DedicatedWorker { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeLimitForNextAppointment { get; set; }
    }
}
