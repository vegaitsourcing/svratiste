using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions.Mappers
{
    public interface ICartonMapper
    {
        CartonDto ToDto(Carton entity);
        Carton ToEntity(CartonDto dto);
    }
}