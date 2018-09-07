namespace SafeHouse.Model
{
    public class GoalAndResult: BaseEntity
    {
        public string Goal { get; set; }
        public string Result { get; set; }
        public IndividualServicePlan IndividualServicePlan { get; set; }
    }
}
