using System;
using System.Collections.Generic;
using System.Linq;
using SafeHouse.Business.Contracts;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class CartonService : ICartonService
    {
        private readonly SafeHouseContext _dbContex;

        public CartonService(SafeHouseContext context)
        {
            _dbContex = context;
        }

        public IEnumerable<Carton> Get(int? page)
        {
            return _dbContex.Cartons.ToList().Skip((page ?? 1) * 20).Take(20);
        }

        public Carton Get(Guid id)
        {
            return _dbContex.Cartons.Find(id);
        }

        public int GetPageNumber()
        {
            return _dbContex.Cartons.Count() / 20 + 1;
        }

        public void Add(Carton carton)
        {
            _dbContex.Cartons.Add(carton);
        }

        public void Update(Carton cartonNewValues)
        {
            _dbContex.Cartons.Update(cartonNewValues);
        }
    }
}
