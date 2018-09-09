using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business.Contracts.Mappers
{
    public interface IDailyEntryMapper
    {
        DailyEntry ToEntity(DailyEntryDto dto, Carton carton);
    }
}
