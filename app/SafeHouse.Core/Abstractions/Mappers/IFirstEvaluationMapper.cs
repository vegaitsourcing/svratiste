using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions.Mappers
{
    public interface IFirstEvaluationMapper
    {
        FirstEvaluationDto ToDto(FirstEvaluation entity);
        FirstEvaluation ToEntity(FirstEvaluationDto dto);
    }
}