using SafeHouse.Business.Contracts.Models;

namespace SafeHouse.Business.Contracts
{
    public interface IDailyEntryService
    {
        void Add(DailyEntryDto dailyEntry);
    }
}
