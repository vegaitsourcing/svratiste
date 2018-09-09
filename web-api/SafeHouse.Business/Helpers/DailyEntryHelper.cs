using SafeHouse.Data.Entities;
using SafeHouse.Data.Enums;

namespace sadfdf
{
    public class DailyEntryHelper
    {
        public int CountGivenServices(DailyEntry entry)
        {
            int sum = 0;
            if (entry.Meal > 0) { sum++; }
            if (entry.Stay) { sum++; }
            if (entry.Bath || entry.LiecesRemoval) { sum++; }
            if (entry.Clothing > 0) { sum++; }

            return sum;
        }
    }
}
