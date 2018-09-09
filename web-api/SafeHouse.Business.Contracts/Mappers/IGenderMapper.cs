using System;
using System.Collections.Generic;
using System.Text;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Enums;

namespace SafeHouse.Business.Contracts.Mappers
{
    public interface IGenderMapper : IMapper<Gender, GenderDto> { }
}
