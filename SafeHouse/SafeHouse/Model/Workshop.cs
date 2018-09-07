using System;

namespace SafeHouse.Model
{
    public class Workshop
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public DailyEntry DailyEntryId { get; set; }
        public int Number { get; set; }
    }
}