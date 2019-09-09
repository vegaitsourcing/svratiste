using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class FirstEvaluationMapper : IFirstEvaluationMapper
    {
        public void ApplyToEntity(ref FirstEvaluation firstEvaluation, FirstEvaluationDto firstEvaluationDto, Carton carton)
        {
            firstEvaluation.Id = firstEvaluationDto.Id;
            firstEvaluation.Carton = carton;
            firstEvaluation.GuardiansName = firstEvaluationDto.GuardiansName;
            firstEvaluation.OtherChildrenName = firstEvaluationDto.OtherChildrenName;
            firstEvaluation.OtherMembersName = firstEvaluationDto.OtherMembersName;
            firstEvaluation.LivingSpace = firstEvaluationDto.LivingSpace;
            firstEvaluation.SchoolAndGrade = firstEvaluationDto.SchoolAndGrade;
            firstEvaluation.Languages = firstEvaluationDto.Languages;
            firstEvaluation.HealthCard = firstEvaluationDto.HealthCard;
            firstEvaluation.CaseLeaderName = firstEvaluationDto.CaseLeaderName;
            firstEvaluation.SleepOnStreet = firstEvaluationDto.SleepOnStreet;
            firstEvaluation.DumpsterDiving = firstEvaluationDto.DumpsterDiving;
            firstEvaluation.Begging = firstEvaluationDto.Begging;
            firstEvaluation.Prostituting = firstEvaluationDto.Prostituting;
            firstEvaluation.SellsOnStreet = firstEvaluationDto.SellsOnStreet;
            firstEvaluation.HelpingFamilyOnStreet = firstEvaluationDto.HelpingFamilyOnStreet;
            firstEvaluation.ExtremelyPoor = firstEvaluationDto.ExtremelyPoor;
            firstEvaluation.OtherSuitability = firstEvaluationDto.OtherSuitability;
            firstEvaluation.Explanation = firstEvaluationDto.Explanation;
            firstEvaluation.Capability = firstEvaluationDto.Capability;
            firstEvaluation.OnTheWaitingList = firstEvaluationDto.OnTheWaitingList;
            firstEvaluation.ServiceStart = firstEvaluationDto.ServiceStart;
            firstEvaluation.DirectedToName = firstEvaluationDto.DirectedToName;
            firstEvaluation.IndividualMovementAbility = firstEvaluationDto.IndividualMovementAbility;
            firstEvaluation.VerbalComunicationAbility = firstEvaluationDto.VerbalComunicationAbility;
            firstEvaluation.PhysicalDescription = firstEvaluationDto.PhysicalDescription;
            firstEvaluation.DiagnosedDisease = firstEvaluationDto.DiagnosedDisease;
            firstEvaluation.PriorityNeeds = firstEvaluationDto.PriorityNeeds;
            firstEvaluation.Attitude = firstEvaluationDto.Attitude;
            firstEvaluation.Expectations = firstEvaluationDto.Expectations;
            firstEvaluation.DirectedFromName = firstEvaluationDto.DirectedFromName;
            firstEvaluation.Other = firstEvaluationDto.Other;
            firstEvaluation.StartedEvaluation = firstEvaluationDto.StartedEvaluation;
            firstEvaluation.FinishedEvaluation = firstEvaluationDto.FinishedEvaluation;
            firstEvaluation.EvaluationDoneBy = firstEvaluationDto.EvaluationDoneBy;
            firstEvaluation.EvaluationRevisedBy = firstEvaluationDto.EvaluationRevisedBy;
        }

        public FirstEvaluationDto ToDto(FirstEvaluation entity)
        {
            return new FirstEvaluationDto
            {
                Id = entity.Id,
                CartonId = entity.Carton.Id,
                GuardiansName = entity.GuardiansName,
                OtherChildrenName = entity.OtherChildrenName,
                OtherMembersName = entity.OtherMembersName,
                LivingSpace = entity.LivingSpace,
                SchoolAndGrade = entity.SchoolAndGrade,
                Languages = entity.Languages,
                HealthCard = entity.HealthCard,
                CaseLeaderName = entity.CaseLeaderName,
                SleepOnStreet = entity.SleepOnStreet,
                DumpsterDiving = entity.DumpsterDiving,
                Begging = entity.Begging,
                Prostituting = entity.Prostituting,
                SellsOnStreet = entity.SellsOnStreet,
                HelpingFamilyOnStreet = entity.HelpingFamilyOnStreet,
                ExtremelyPoor = entity.ExtremelyPoor,
                OtherSuitability = entity.OtherSuitability,
                Explanation = entity.Explanation,
                Capability = entity.Capability,
                OnTheWaitingList = entity.OnTheWaitingList,
                ServiceStart = entity.ServiceStart,
                DirectedToName = entity.DirectedToName,
                IndividualMovementAbility = entity.IndividualMovementAbility,
                VerbalComunicationAbility = entity.VerbalComunicationAbility,
                PhysicalDescription = entity.PhysicalDescription,
                DiagnosedDisease = entity.DiagnosedDisease,
                PriorityNeeds = entity.PriorityNeeds,
                Attitude = entity.Attitude,
                Expectations = entity.Expectations,
                DirectedFromName = entity.DirectedFromName,
                Other = entity.Other,
                StartedEvaluation = entity.StartedEvaluation,
                FinishedEvaluation = entity.FinishedEvaluation,
                EvaluationDoneBy = entity.EvaluationDoneBy,
                EvaluationRevisedBy = entity.EvaluationRevisedBy
            };
        }

        public FirstEvaluation ToEntity(FirstEvaluationDto dto, Carton carton)
        {
            return new FirstEvaluation
            {
                Id = dto.Id,
                Carton = carton,
                GuardiansName = dto.GuardiansName,
                OtherChildrenName = dto.OtherChildrenName,
                OtherMembersName = dto.OtherMembersName,
                LivingSpace = dto.LivingSpace,
                SchoolAndGrade = dto.SchoolAndGrade,
                Languages = dto.Languages,
                HealthCard = dto.HealthCard,
                CaseLeaderName = dto.CaseLeaderName,
                SleepOnStreet = dto.SleepOnStreet,
                DumpsterDiving = dto.DumpsterDiving,
                Begging = dto.Begging,
                Prostituting = dto.Prostituting,
                SellsOnStreet = dto.SellsOnStreet,
                HelpingFamilyOnStreet = dto.HelpingFamilyOnStreet,
                ExtremelyPoor = dto.ExtremelyPoor,
                OtherSuitability = dto.OtherSuitability,
                Explanation = dto.Explanation,
                Capability = dto.Capability,
                OnTheWaitingList = dto.OnTheWaitingList,
                ServiceStart = dto.ServiceStart,
                DirectedToName = dto.DirectedToName,
                IndividualMovementAbility = dto.IndividualMovementAbility,
                VerbalComunicationAbility = dto.VerbalComunicationAbility,
                PhysicalDescription = dto.PhysicalDescription,
                DiagnosedDisease = dto.DiagnosedDisease,
                PriorityNeeds = dto.PriorityNeeds,
                Attitude = dto.Attitude,
                Expectations = dto.Expectations,
                DirectedFromName = dto.DirectedFromName,
                Other = dto.Other,
                StartedEvaluation = dto.StartedEvaluation,
                FinishedEvaluation = dto.FinishedEvaluation,
                EvaluationDoneBy = dto.EvaluationDoneBy,
                EvaluationRevisedBy = dto.EvaluationRevisedBy
            };
        }
    }
}