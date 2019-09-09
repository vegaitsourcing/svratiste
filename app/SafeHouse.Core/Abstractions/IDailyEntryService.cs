using System;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IDailyEntryService
    {
        DailyEntryDto GetByCartonId(Guid id);

        void Add(DailyEntryDto dailyEntry);

        void Update(DailyEntryDto dailyEntry);

        void Remove(Guid id);
    }
}
