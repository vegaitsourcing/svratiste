using System;
using System.Collections.Generic;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface ICartonService
    {
        IEnumerable<CartonDto> Get(int page);

        CartonDto Get(Guid id);

        void Add(CartonDto carton);

        void Update(CartonDto cartonNewValues);
    }
}