﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using SafeHouse.Core.Contracts;
//using SafeHouse.Core.Entities;
//using SafeHouse.Core.Exceptions;
//using SafeHouse.Core.Models;

//namespace SafeHouse.Core
//{
//    public class FirstEvaluationService : IFirstEvaluationService
//    {
//        private readonly SafeHouseDbContext _dbContext;

//        public FirstEvaluationService(SafeHouseDbContext context)
//        {
//            _dbContext = context;
//        }

//        public FirstEvaluation GetByCartonId(Guid id)
//        {
//            return _dbContext.FirstEvaluations
//                .Include(x => x.Carton)
//                .Include(x => x.Suitability)
//                .ThenInclude(x => x.SuitabilityItems)
//                .ThenInclude(x => x.SuitabilityCache)
//                .FirstOrDefault(x => x.Carton.Id == id);
//        }

//        public void Add(CreateFirstEvaluationRequest evaluation)
//        {
//            if (evaluation.Id.HasValue)
//            {
//                UpdateFirstEvaluation(evaluation);
//            }
//            else
//            {
//                AddFirstEvaluationIfDoesntExist(evaluation);
//            }
//        }

//        private void AddFirstEvaluationIfDoesntExist(CreateFirstEvaluationRequest evaluation)
//        {
//            var carton = _dbContext.Cartons.Find(evaluation.CartonId);
//            if (!_dbContext.FirstEvaluations.Any(fe => fe.Carton.Id == evaluation.CartonId))
//            {
//                var suitabilityItems = PopulateSuitabilityItems(evaluation.Suitability).ToList();
//                var newEvaluation = CreateFirstEvaluation(evaluation, carton, suitabilityItems);

//                _dbContext.FirstEvaluations.Add(newEvaluation);
//                _dbContext.SaveChanges();
//            }
//            else
//            {
//                throw new FirstEvaluationExistsException($"First evaluation for carton with id {evaluation.CartonId} was created earlier.");
//            }
//        }

//        private IEnumerable<SuitabilityItem> PopulateSuitabilityItems(SuitabilityDto suitability)
//        {
//            var suitabilityItems = new List<SuitabilityItem>();

//            if (suitability != null)
//            {
//                foreach (var ev in suitability.SuitabilityItems)
//                {
//                    suitabilityItems.Add(new SuitabilityItem
//                    {
//                        Description = ev.Description,
//                        SuitabilityCache = _dbContext.SuitabilityCaches.Find(ev.SuitabilityCache.Id)
//                    });
//                }
//            }

//            return suitabilityItems;
//        }

//        private FirstEvaluation CreateFirstEvaluation(CreateFirstEvaluationRequest evaluation, Carton carton, List<SuitabilityItem> suitabilityItems)
//        {
//            return new FirstEvaluation
//            {
//                Attitude = evaluation.Attitude,
//                Capability = evaluation.Capability,
//                CaseLeaderName = evaluation.CaseLeaderName,
//                DiagnosedDisease = evaluation.DiagnosedDisease,
//                DirectedFromName = evaluation.DirectedFromName,
//                DirectedToName = evaluation.DirectedToName,
//                EvaluationDoneBy = evaluation.EvaluationDoneBy,
//                EvaluationRevisedBy = evaluation.EvaluationRevisedBy,
//                Expectations = evaluation.Expectations,
//                FinishedEvaluation = evaluation.FinishedEvaluation,
//                GuardiansName = evaluation.GuardiansName,
//                HealthCard = evaluation.HealthCard,
//                IndividualMovementAbility = evaluation.IndividualMovementAbility,
//                Languages = evaluation.Languages,
//                LivingSpace = evaluation.LivingSpace,
//                OnTheWaitingList = evaluation.OnTheWaitingList,
//                Other = evaluation.Other,
//                OtherChildrenName = evaluation.OtherChildrenName,
//                OtherMembersName = evaluation.OtherMembersName,
//                PhysicalDescription = evaluation.PhysicalDescription,
//                PriorityNeeds = evaluation.PriorityNeeds,
//                SchoolAndGrade = evaluation.SchoolAndGrade,
//                ServiceStart = evaluation.ServiceStart,
//                StartedEvaluation = evaluation.StartedEvaluation,
//                VerbalCommunicationAbility = evaluation.VerbalCommunicationAbility,
//                Carton = carton,
//                Suitability = suitabilityItems.Any() ? new Suitability
//                {
//                    Description = evaluation.Suitability.Description,
//                    SuitabilityItems = suitabilityItems
//                } : null
//            };
//        }

//        private void UpdateFirstEvaluation(CreateFirstEvaluationRequest evaluation)
//        {
//            var existingEvaluation = _dbContext.FirstEvaluations
//                .Include(x => x.Suitability)
//                .ThenInclude(x => x.SuitabilityItems)
//                .FirstOrDefault(x => x.Id == evaluation.Id);

//            if (existingEvaluation != null)
//            {
//                existingEvaluation.Attitude = evaluation.Attitude;
//                existingEvaluation.Capability = evaluation.Capability;
//                existingEvaluation.CaseLeaderName = evaluation.CaseLeaderName;
//                existingEvaluation.DiagnosedDisease = evaluation.DiagnosedDisease;
//                existingEvaluation.DirectedFromName = evaluation.DirectedFromName;
//                existingEvaluation.DirectedToName = evaluation.DirectedToName;
//                existingEvaluation.EvaluationDoneBy = evaluation.EvaluationDoneBy;
//                existingEvaluation.EvaluationRevisedBy = evaluation.EvaluationRevisedBy;
//                existingEvaluation.Expectations = evaluation.Expectations;
//                existingEvaluation.FinishedEvaluation = evaluation.FinishedEvaluation;
//                existingEvaluation.GuardiansName = evaluation.GuardiansName;
//                existingEvaluation.HealthCard = evaluation.HealthCard;
//                existingEvaluation.IndividualMovementAbility = evaluation.IndividualMovementAbility;
//                existingEvaluation.Languages = evaluation.Languages;
//                existingEvaluation.LivingSpace = evaluation.LivingSpace;
//                existingEvaluation.OnTheWaitingList = evaluation.OnTheWaitingList;
//                existingEvaluation.Other = evaluation.Other;
//                existingEvaluation.OtherChildrenName = evaluation.OtherChildrenName;
//                existingEvaluation.OtherMembersName = evaluation.OtherMembersName;
//                existingEvaluation.PhysicalDescription = evaluation.PhysicalDescription;
//                existingEvaluation.PriorityNeeds = evaluation.PriorityNeeds;
//                existingEvaluation.SchoolAndGrade = evaluation.SchoolAndGrade;
//                existingEvaluation.ServiceStart = evaluation.ServiceStart;
//                existingEvaluation.StartedEvaluation = evaluation.StartedEvaluation;
//                existingEvaluation.VerbalCommunicationAbility = evaluation.VerbalCommunicationAbility;

//                var listToDelete = new List<SuitabilityItem>();
//                if (existingEvaluation.Suitability != null && existingEvaluation.Suitability.SuitabilityItems.Any())
//                {
//                    foreach (var item in existingEvaluation.Suitability.SuitabilityItems)
//                    {
//                        listToDelete.Add(item);
//                    }

//                    _dbContext.SuitabilityItems.RemoveRange(listToDelete);
//                    _dbContext.Suitabilities.Remove(existingEvaluation.Suitability);
//                }

//                var suitabilityItems = new List<SuitabilityItem>();

//                if (evaluation.Suitability != null)
//                {
//                    foreach (var ev in evaluation.Suitability.SuitabilityItems)
//                    {
//                        suitabilityItems.Add(new SuitabilityItem
//                        {
//                            Description = ev.Description,
//                            SuitabilityCache = _dbContext.SuitabilityCaches.Find(ev.SuitabilityCache.Id)
//                        });
//                    }

//                    existingEvaluation.Suitability = new Suitability
//                    {
//                        Description = evaluation.Suitability.Description,
//                        SuitabilityItems = suitabilityItems.Any() ? suitabilityItems : null
//                    };
//                }

//                _dbContext.FirstEvaluations.Update(existingEvaluation);
//                _dbContext.SaveChanges();
//            }
//        }
//    }
//}
