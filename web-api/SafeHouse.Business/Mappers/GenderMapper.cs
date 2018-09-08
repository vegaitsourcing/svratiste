using System;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Enums;

namespace SafeHouse.Business.Mappers
{
    public class GenderMapper : IGenderMapper
    {
        public GenderDto ToDto(Gender entity)
        {
            switch (entity)
            {
                case Gender.Female:
                    return GenderDto.Female;
                case Gender.Male:
                    return GenderDto.Male;
                default:
                    throw new InvalidOperationException("Enum value doesn't exist.");
            }
        }

        public Gender ToEntity(GenderDto dto)
        {
            switch (dto)
            {
                case GenderDto.Female:
                    return Gender.Female;
                case GenderDto.Male:
                    return Gender.Male;
                default:
                    throw new InvalidOperationException("Enum value doesn't exist.");
            }
        }
    }
}
