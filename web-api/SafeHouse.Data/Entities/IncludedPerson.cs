namespace SafeHouse.Data.Entities 
{
    public class IncludedPerson: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Function { get; set; }
        public IndividualServicePlan IndividualServicePlan { get; set; }
    }
}
