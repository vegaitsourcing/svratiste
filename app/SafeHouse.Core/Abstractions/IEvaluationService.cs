using System;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IEvaluationService
    {
        EvaluationDto GetByCartonId(Guid id);

        void Add(EvaluationDto evaluation);

        void Update(EvaluationDto evaluation);

        void Remove(Guid id);
    }
}