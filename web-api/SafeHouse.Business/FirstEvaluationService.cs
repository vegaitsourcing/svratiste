using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;

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
            return _dbContex.FirstEvaluations.Find(id);
        }

        public void Add(FirstEvaluation evaluation)
        {
            _dbContex.Add(evaluation);
        }
    }
}
