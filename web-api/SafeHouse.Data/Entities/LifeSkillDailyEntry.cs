namespace SafeHouse.Data.Entities
{
    public class LifeSkillDailyEntry : BaseEntity
    {
        public LifeSkill LifeSkill { get; set; }

        public DailyEntry DailyEntry { get; set; }
    }
}