﻿using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Exceptions;
using SafeHouse.Business.Contracts.Mappers;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;
using SafeHouse.Data.Entities;
using SafeHouse.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SafeHouse.Business
{
    public class DailyEntryService : IDailyEntryService
    {
        private readonly SafeHouseDbContext _dbContext;
        private readonly IDailyEntryMapper _mapper;

        public DailyEntryService(SafeHouseDbContext dbContext, IDailyEntryMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Add(DailyEntryDto dailyEntryDto)
        {
            var carton = _dbContext.Cartons.Find(dailyEntryDto.CartonId);
            if(!CheckIfDailyEntryExists(dailyEntryDto.CartonId))
            {
                var dailyEntry = _mapper.ToEntity(dailyEntryDto, carton);

                AddWorkshopsToEntity(dailyEntryDto.Workshops, dailyEntry);
                AddSchoolActivitiesToEntity(dailyEntryDto.SchoolAcivities, dailyEntry);
                AddLifeSkillsToEntity(dailyEntryDto.LifeSkills, dailyEntry);
                PerformPostDailyEntryAdditionActions(carton);

                _dbContext.SaveChanges();
            }
            else
            {
                throw new DailyEntryExistsException($"Daily entry for day: {DateTime.Today} and Carton: {dailyEntryDto.CartonId} was created earlier.");
            }
        }

        private bool CheckIfDailyEntryExists(Guid cartonId)
        {
            return _dbContext.DailyEntries.Any(de => de.Date == DateTime.Today && de.Carton.Id == cartonId);
        }

        private void AddLifeSkillsToEntity(LifeSkillEnum lifeSkills, DailyEntry dailyEntry)
        {
            if (lifeSkills != 0)
            {
                foreach (LifeSkillEnum lifeSkill in (LifeSkillEnum[])Enum.GetValues(typeof(LifeSkillEnum)))
                {
                    if ((lifeSkills & lifeSkill) != 0)
                    {
                        _dbContext.LifeSkillDailyEntries
                            .Add(new LifeSkillDailyEntry
                            {
                                DailyEntry = dailyEntry,
                                LifeSkill = _dbContext.LifeSkills
                                .Where(ls => ls.LifeSkillType == lifeSkill)
                                .Single()
                            });
                    }
                }
            }
        }

        private void AddSchoolActivitiesToEntity(SchoolActivityEnum schoolAcivities, DailyEntry dailyEntry)
        {
            if (schoolAcivities != 0)
            {
                foreach (SchoolActivityEnum schoolActivity in (SchoolActivityEnum[])Enum.GetValues(typeof(SchoolActivityEnum)))
                {
                    if ((schoolAcivities & schoolActivity) != 0)
                    {
                        _dbContext.SchoolActivities.Add(new SchoolActivity { DailyEntry = dailyEntry, Type = schoolActivity });
                    }
                }
            }
        }

        private void AddWorkshopsToEntity(ICollection<WorkshopDto> workshops, DailyEntry dailyEntry)
        {
            _dbContext.DailyEntries.Add(dailyEntry);

            foreach (var workshop in workshops)
            {
                _dbContext.Workshops.Add(new Workshop
                {
                    DailyEntry = dailyEntry,
                    Number = workshop.Number,
                    Type = workshop.WorkshopType
                });
            }
        }

        private void PerformPostDailyEntryAdditionActions(Carton carton)
        {
            IncreaseVisitsNumberForCarton(carton);
        }

        private void IncreaseVisitsNumberForCarton(Carton carton)
        {
            carton.NumberOfVisits++;
        }
    }
}
