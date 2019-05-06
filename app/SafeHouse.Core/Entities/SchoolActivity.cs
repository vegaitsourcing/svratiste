namespace SafeHouse.Core.Entities
{
    public class SchoolActivity : BaseEntity
    {
        public Enums.SchoolActivity Type { get; set; }

        public DailyEntry DailyEntry { get; set; }
    }
}