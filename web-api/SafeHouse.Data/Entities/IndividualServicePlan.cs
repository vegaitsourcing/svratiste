using System;

namespace SafeHouse.Data.Entities 
{
    public class IndividualServicePlan: BaseEntity
    {
        public string Age { get; set; }
        public string DedicatedWorker { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeLimitForNextAppointment { get; set; }
    }
}
