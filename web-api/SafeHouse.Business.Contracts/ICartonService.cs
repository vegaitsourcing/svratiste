using SafeHouse.Business.Contracts.Models;
using System;
using System.Collections.Generic;

namespace SafeHouse.Business.Contracts
{
    public interface ICartonService
    {
        IEnumerable<CartonDto> Get(int? page);

        CartonDto Get(Guid id);

        int GetPageNumber();

        void Add(CartonDto carton);

        void Update(CartonDto cartonNewValues);
    }
}
