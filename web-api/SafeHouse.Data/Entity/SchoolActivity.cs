using System;

namespace SafeHouse.Model
{
    public class SchoolActivity : BaseEntity
    {
        public int Type { get; set; }
        public DailyEntry DailyEntry { get; set; }
    }
}