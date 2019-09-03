using System;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IFirstEvaluationService
    {
        FirstEvaluationDto GetByCartonId(Guid id);

        void Add(FirstEvaluationDto firstEvaluation);

        void Update(FirstEvaluationDto firstEvaluation);

        void Remove(FirstEvaluationDto firstEvaluation);
    }
}
