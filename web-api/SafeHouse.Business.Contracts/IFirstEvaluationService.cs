using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IFirstEvaluationService
    {
        FirstEvaluation GetByCartonId(Guid id);
        void AddOrUpdate(CreateFirstEvaluationRequest evaluation);
    }
}
