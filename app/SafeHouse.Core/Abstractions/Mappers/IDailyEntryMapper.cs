using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions.Mappers
{
    public interface IDailyEntryMapper
    {
        DailyEntry ToEntity(DailyEntryDto dto, Carton carton);
    }
}