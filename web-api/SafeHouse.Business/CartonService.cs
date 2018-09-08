using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Add(Carton carton)
        {
            _dbContex.Add(carton);
        }

        public void Update(Carton cartonNewValues)
        {
            _dbContex.Cartons.Update(cartonNewValues);
        }
    }
}