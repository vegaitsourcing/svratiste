using SafeHouse.Data.Enums;

namespace SafeHouse.Data.Entities
{
    public class Workshop : BaseEntity
    {
        public WorkshopType Type { get; set; }

        public DailyEntry DailyEntry { get; set; }

        public int Number { get; set; }
    }
}