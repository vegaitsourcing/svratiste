using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions.Mappers
{
    public interface IDailyEntryMapper
    {
        DailyEntryDto ToDto(DailyEntry entity);

        DailyEntry ToEntity(DailyEntryDto dto, Carton carton);

        void ApplyToEntity(ref DailyEntry dailyEntry, DailyEntryDto dailyEntryDto, Carton carton);
       /* void RemoveEntity(ref DailyEntry dailyEntry);*/
    }
}