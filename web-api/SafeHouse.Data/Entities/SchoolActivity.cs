using System;

namespace SafeHouse.Data.Entities 
{
    public class SchoolActivity : BaseEntity
    {
        public int Type { get; set; }
        public DailyEntry DailyEntry { get; set; }
    }
}