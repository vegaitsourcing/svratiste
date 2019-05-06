using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IDailyEntryService
    {
        void Add(DailyEntryDto dailyEntry);
    }
}
