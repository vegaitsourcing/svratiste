using SafeHouse.Data.Entities;
using System;
using System.Collections.Generic;

namespace SafeHouse.Business.Contracts
{
    public interface ICartonService
    {
        IEnumerable<Carton> Get(int? page);
        Carton Get(Guid id);
        int GetPageNumber();
        void Add(Carton carton);
        void Update(Carton cartonNewValues);
    }
}
