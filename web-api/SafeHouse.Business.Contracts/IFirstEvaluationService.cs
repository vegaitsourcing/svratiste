using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IFirstEvaluationService
    {
        FirstEvaluation Get(Guid id);
        void Add(FirstEvaluation evaluation);
    }
}
