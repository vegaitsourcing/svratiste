namespace SafeHouse.Model
{
    public class LifeSkillDailyEntry : BaseEntity
    {
        public LifeSkill LifeSkill { get; set; }
        public DailyEntry DailyEntry { get; set; }
    }
}