using SafeHouse.Data.Enums;

namespace SafeHouse.Data.Entities
{
    public class SchoolActivity : BaseEntity
    {
        public SchoolActivityEnum Type { get; set; }

        public DailyEntry DailyEntry { get; set; }
    }
}