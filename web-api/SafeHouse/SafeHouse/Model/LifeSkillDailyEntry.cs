namespace SafeHouse.Model
{
    public class LifeSkillDailyEntry : BaseEntity
    {
        public LifeSkills LifeSkillId { get; set; }
        public DailyEntry DailyEntryId { get; set; }
    }
}