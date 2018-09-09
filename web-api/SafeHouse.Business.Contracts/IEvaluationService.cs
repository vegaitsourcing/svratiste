using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IEvaluationService
    {
        Evaluation GetByCartonId(Guid id);

        void AddOrUpdate(CreateEvaluationRequest evaluation);
    }
}
