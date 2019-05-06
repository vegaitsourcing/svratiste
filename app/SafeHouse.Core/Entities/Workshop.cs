using SafeHouse.Core.Entities.Enums;

namespace SafeHouse.Core.Entities
{
    public class Workshop : BaseEntity
    {
        public WorkshopType Type { get; set; }

        public DailyEntry DailyEntry { get; set; }

        public int Number { get; set; }
    }
}