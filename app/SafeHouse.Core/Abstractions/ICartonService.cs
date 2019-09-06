using SafeHouse.Core.Models;
using System;
using System.Collections.Generic;

namespace SafeHouse.Core.Abstractions
{
    public interface ICartonService
    {
        IEnumerable<CartonDto> Get(int page);

        IEnumerable<CartonDto> GetOverEighteen();

        CartonDto Get(Guid id);

        void Add(CartonDto carton);

        void Update(CartonDto cartonNewValues);

        void Remove(CartonDto cartonNewValues);

        int GetPageNumber();
    }
}