using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class EvaluationMapper : IEvaluationMapper
    {
        public void ApplyToEntity(ref Evaluation evaluation, EvaluationDto evaluationDto, Carton carton)
        {
            evaluation.Id = evaluationDto.Id;
            evaluation.Carton = carton;
            evaluation.Age = evaluationDto.Age;
            evaluation.DedicatedWorker = evaluationDto.DedicatedWorker;
            evaluation.FamilyMembers = evaluationDto.FamilyMembers;
            evaluation.OtherMembers = evaluationDto.OtherMembers;
            evaluation.BasicPhysicalNeeds = evaluationDto.BasicPhysicalNeeds;
            evaluation.PsyhoSocialNeeds = evaluationDto.PsyhoSocialNeeds;
            evaluation.SchoolStatus = evaluationDto.SchoolStatus;
            evaluation.EducationalNeeds = evaluationDto.EducationalNeeds;
            evaluation.OtherNeeds = evaluationDto.OtherNeeds;
            evaluation.DominantEmotions = evaluationDto.DominantEmotions;
            evaluation.DominantBehaviors = evaluationDto.DominantBehaviors;
            evaluation.SurroundStrenghts = evaluationDto.SurroundStrenghts;
            evaluation.FamilyStrenghts = evaluationDto.FamilyStrenghts;
            evaluation.PersonalStrenghts = evaluationDto.PersonalStrenghts;
            evaluation.OtherStrenghts = evaluationDto.OtherStrenghts;
            evaluation.SurroundRisks = evaluationDto.SurroundRisks;
            evaluation.FamilyRisks = evaluationDto.FamilyRisks;
            evaluation.BehaviorRisks = evaluationDto.BehaviorRisks;
            evaluation.OtherRisks = evaluationDto.OtherRisks;
            evaluation.Capabilities = evaluationDto.Capabilities;
            evaluation.CulturalSpecifics = evaluationDto.CulturalSpecifics;
            evaluation.AdvicedLevelOfSupport = evaluationDto.AdvicedLevelOfSupport;
            evaluation.EvaluationDoneBy = evaluationDto.EvaluationDoneBy;
            evaluation.Date = evaluationDto.Date;
        }
        public EvaluationDto ToDto(Evaluation entity)
        {
            return new EvaluationDto
            {
                Id = entity.Id,
                CartonId = entity.Carton.Id,
                Age = entity.Age,
                DedicatedWorker = entity.DedicatedWorker,
                FamilyMembers = entity.FamilyMembers,
                OtherMembers = entity.OtherMembers,
                BasicPhysicalNeeds = entity.BasicPhysicalNeeds,
                PsyhoSocialNeeds = entity.PsyhoSocialNeeds,
                SchoolStatus = entity.SchoolStatus,
                EducationalNeeds = entity.EducationalNeeds,
                OtherNeeds = entity.OtherNeeds,
                DominantEmotions = entity.DominantEmotions,
                DominantBehaviors = entity.DominantBehaviors,
                SurroundStrenghts = entity.SurroundStrenghts,
                FamilyStrenghts = entity.FamilyStrenghts,
                PersonalStrenghts = entity.PersonalStrenghts,
                OtherStrenghts = entity.OtherStrenghts,
                SurroundRisks = entity.SurroundRisks,
                FamilyRisks = entity.FamilyRisks,
                BehaviorRisks = entity.BehaviorRisks,
                OtherRisks = entity.OtherRisks,
                Capabilities = entity.Capabilities,
                CulturalSpecifics = entity.CulturalSpecifics,
                AdvicedLevelOfSupport = entity.AdvicedLevelOfSupport,
                EvaluationDoneBy = entity.EvaluationDoneBy,
                Date = entity.Date
            };
        }

        public Evaluation ToEntity(EvaluationDto dto, Carton carton)
        {
            return new Evaluation
            {
                Id = dto.Id,
                Carton = carton,
                Age = dto.Age,
                DedicatedWorker = dto.DedicatedWorker,
                FamilyMembers = dto.FamilyMembers,
                OtherMembers = dto.OtherMembers,
                BasicPhysicalNeeds = dto.BasicPhysicalNeeds,
                PsyhoSocialNeeds = dto.PsyhoSocialNeeds,
                SchoolStatus = dto.SchoolStatus,
                EducationalNeeds = dto.EducationalNeeds,
                OtherNeeds = dto.OtherNeeds,
                DominantEmotions = dto.DominantEmotions,
                DominantBehaviors = dto.DominantBehaviors,
                SurroundStrenghts = dto.SurroundStrenghts,
                FamilyStrenghts = dto.FamilyStrenghts,
                PersonalStrenghts = dto.PersonalStrenghts,
                OtherStrenghts = dto.OtherStrenghts,
                SurroundRisks = dto.SurroundRisks,
                FamilyRisks = dto.FamilyRisks,
                BehaviorRisks = dto.BehaviorRisks,
                OtherRisks = dto.OtherRisks,
                Capabilities = dto.Capabilities,
                CulturalSpecifics = dto.CulturalSpecifics,
                AdvicedLevelOfSupport = dto.AdvicedLevelOfSupport,
                EvaluationDoneBy = dto.EvaluationDoneBy,
                Date = dto.Date
            };
        }
    }
}