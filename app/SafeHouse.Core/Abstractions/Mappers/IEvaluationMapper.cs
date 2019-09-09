using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions.Mappers
{
    public interface IEvaluationMapper
    {
        EvaluationDto ToDto(Evaluation entity);

        Evaluation ToEntity(EvaluationDto dto, Carton carton);

        void ApplyToEntity(ref Evaluation evaluation, EvaluationDto evaluationDto, Carton carton);
    }
}