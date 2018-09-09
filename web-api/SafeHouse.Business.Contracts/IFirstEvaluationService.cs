using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IFirstEvaluationService
    {
        FirstEvaluation Get(Guid id);

        void AddOrUpdate(CreateFirstEvaluationRequest evaluation);
    }
}
