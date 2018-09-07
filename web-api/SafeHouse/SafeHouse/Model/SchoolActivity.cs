using System;

namespace SafeHouse.Model
{
    public class SchoolActivity
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public DailyEntry DailyEntryId { get; set; }
    }
}