using System;

namespace SafeHouse.Data.Entities 
{
    public class Workshop : BaseEntity
    {
        public int Type { get; set; }
        public DailyEntry DailyEntry { get; set; }
        public int Number { get; set; }
    }
}