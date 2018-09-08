using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class EvaluationService : IEvaluationService
    {
        private readonly SafeHouseContext _dbContex;

        public EvaluationService(SafeHouseContext context)
        {
            _dbContex = context;
        }

        public Evaluation Get(Guid id)
        {
            return _dbContex.Evaluations.Include("Carton").First(x => x.Carton.Id == id);
        }

        public void Add(Evaluation evaluation)
        {
            _dbContex.Evaluations.Add(evaluation);
        }
    }
}
