using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;
using System.Linq;

namespace SafeHouse.Business
{
    public class FirstEvaluationService : IFirstEvaluationService
    {
        private readonly SafeHouseContext _dbContex;

        public FirstEvaluationService(SafeHouseContext context)
        {
            _dbContex = context;
        }

        public FirstEvaluation Get(Guid id)
        {
            return _dbContex.FirstEvaluations.Include("Carton").First(x => x.Carton.Id == id);
        }

        public void Add(FirstEvaluation evaluation)
        {
            _dbContex.FirstEvaluations.Add(evaluation);
        }
    }
}
