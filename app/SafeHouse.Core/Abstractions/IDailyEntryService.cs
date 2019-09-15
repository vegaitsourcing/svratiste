using System;
using SafeHouse.Core.Models;
using System.Collections.Generic;

namespace SafeHouse.Core.Abstractions
{
    public interface IDailyEntryService
    {
        IEnumerable<DailyEntryDto> GetAllByCartonId(Guid id);

        DailyEntryDto GetById(Guid id, Guid cartonId);

        DailyEntryDto GetByCartonIdForToday(Guid id);

        void Add(DailyEntryDto dailyEntry);

        void Update(DailyEntryDto dailyEntry);

        void Remove(Guid id);
    }
}
