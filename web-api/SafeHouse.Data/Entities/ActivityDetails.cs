namespace SafeHouse.Data.Entities 
{
    public class ActivityDetails: BaseEntity
    {
        public string Activity { get; set; }
        public string ResponiblePerson { get; set; }
        public string TimeLimit { get; set; }
        public IndividualServicePlan IndividualServicePlan { get; set; }
    }
}
