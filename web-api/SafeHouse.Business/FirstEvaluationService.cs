using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class FirstEvaluationService : IFirstEvaluationService
    {
        private readonly SafeHouseContext _dbContext;

        public FirstEvaluationService(SafeHouseContext context)
        {
            _dbContext = context;
        }

        public FirstEvaluation GetByCartonId(Guid id)
        {
            return _dbContext.FirstEvaluations
                .Include(x => x.Carton)
                .Include(x => x.Suitability)
                .ThenInclude(x => x.SuitabilityItems)
                .ThenInclude(x => x.SuitabilityCache)
                .FirstOrDefault(x => x.Carton.Id == id);
        }

        public void AddOrUpdate(CreateFirstEvaluationRequest evaluation)
        {
            if (evaluation.Id.HasValue)
            {
                UpdateFirstEvaluation(evaluation);
            }
            else
            {
                AddFirstEvaluation(evaluation);
            }
        }

        private void AddFirstEvaluation(CreateFirstEvaluationRequest evaluation)
        {
            var carton = _dbContext.Cartons.Find(evaluation.CartonId);
            var suitabilityItems = new List<SuitabilityItem>();

            foreach(var ev in evaluation.Suitability.SuitabilityItems)
            {
                suitabilityItems.Add(new SuitabilityItem
                {
                    Description = ev.Description,
                    SuitabilityCache = _dbContext.SuitabilityCaches.Find(ev.SuitabilityCache.Id)
                });
            }

            var newEvaluation = new FirstEvaluation
            {
                Attitude = evaluation.Attitude,
                Capability = evaluation.Capability,
                CaseLeaderName = evaluation.CaseLeaderName,
                DiagnosedDisease = evaluation.DiagnosedDisease,
                DirectedFromName = evaluation.DirectedFromName,
                DirectedToName = evaluation.DirectedToName,
                EvaluationDoneBy = evaluation.EvaluationDoneBy,
                EvaluationRevisedBy = evaluation.EvaluationRevisedBy,
                Expectations = evaluation.Expectations,
                FinishedEvaluation = evaluation.FinishedEvaluation,
                GuardiansName = evaluation.GuardiansName,
                HealthCard = evaluation.HealthCard,
                IndividualMovementAbility = evaluation.IndividualMovementAbility,
                Languages = evaluation.Languages,
                LivingSpace = evaluation.LivingSpace,
                OnTheWaitingList = evaluation.OnTheWaitingList,
                Other = evaluation.Other,
                OtherChildernName = evaluation.OtherChildernName,
                OtherMembersName = evaluation.OtherMembersName,
                PhysicalDescription = evaluation.PhysicalDescription,
                PriorityNeeds = evaluation.PriorityNeeds,
                SchoolAndGrade = evaluation.SchoolAndGrade,
                ServiceStart = evaluation.ServiceStart,
                StartedEvaluation = evaluation.StartedEvaluation,
                VerbalComunicationAbility = evaluation.VerbalComunicationAbility,
                Carton = carton,
                Suitability = new Suitability
                {
                    Description = evaluation.Suitability.Description,
                    SuitabilityItems = suitabilityItems
                }
            };

            _dbContext.FirstEvaluations.Add(newEvaluation);
            _dbContext.SaveChanges();
        }

        private void UpdateFirstEvaluation(CreateFirstEvaluationRequest evaluation)
        {
            var existingEvaluation = _dbContext.FirstEvaluations
                .Include(x => x.Suitability)
                .ThenInclude(x => x.SuitabilityItems)
                .FirstOrDefault(x => x.Id == evaluation.Id);

            if(existingEvaluation != null)
            {
                existingEvaluation.Attitude = evaluation.Attitude;
                existingEvaluation.Capability = evaluation.Capability;
                existingEvaluation.CaseLeaderName = evaluation.CaseLeaderName;
                existingEvaluation.DiagnosedDisease = evaluation.DiagnosedDisease;
                existingEvaluation.DirectedFromName = evaluation.DirectedFromName;
                existingEvaluation.DirectedToName = evaluation.DirectedToName;
                existingEvaluation.EvaluationDoneBy = evaluation.EvaluationDoneBy;
                existingEvaluation.EvaluationRevisedBy = evaluation.EvaluationRevisedBy;
                existingEvaluation.Expectations = evaluation.Expectations;
                existingEvaluation.FinishedEvaluation = evaluation.FinishedEvaluation;
                existingEvaluation.GuardiansName = evaluation.GuardiansName;
                existingEvaluation.HealthCard = evaluation.HealthCard;
                existingEvaluation.IndividualMovementAbility = evaluation.IndividualMovementAbility;
                existingEvaluation.Languages = evaluation.Languages;
                existingEvaluation.LivingSpace = evaluation.LivingSpace;
                existingEvaluation.OnTheWaitingList = evaluation.OnTheWaitingList;
                existingEvaluation.Other = evaluation.Other;
                existingEvaluation.OtherChildernName = evaluation.OtherChildernName;
                existingEvaluation.OtherMembersName = evaluation.OtherMembersName;
                existingEvaluation.PhysicalDescription = evaluation.PhysicalDescription;
                existingEvaluation.PriorityNeeds = evaluation.PriorityNeeds;
                existingEvaluation.SchoolAndGrade = evaluation.SchoolAndGrade;
                existingEvaluation.ServiceStart = evaluation.ServiceStart;
                existingEvaluation.StartedEvaluation = evaluation.StartedEvaluation;
                existingEvaluation.VerbalComunicationAbility = evaluation.VerbalComunicationAbility;

                var listToDelete = new List<SuitabilityItem>();
                foreach(var item in existingEvaluation.Suitability.SuitabilityItems)
                {
                    listToDelete.Add(item);
                }

                _dbContext.SuitabilityItems.RemoveRange(listToDelete);
                _dbContext.Suitabilities.Remove(existingEvaluation.Suitability);

                var suitabilityItems = new List<SuitabilityItem>();

                foreach (var ev in evaluation.Suitability.SuitabilityItems)
                {
                    suitabilityItems.Add(new SuitabilityItem
                    {
                        Description = ev.Description,
                        SuitabilityCache = _dbContext.SuitabilityCaches.Find(ev.SuitabilityCache.Id)
                    });
                }

                existingEvaluation.Suitability = new Suitability
                {
                    Description = evaluation.Suitability.Description,
                    SuitabilityItems = suitabilityItems
                };

                _dbContext.FirstEvaluations.Update(existingEvaluation);
                _dbContext.SaveChanges();
            }
        }
    }
}
