/*using System;
using System.Collections.Generic;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Exceptions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;
using Enums = SafeHouse.Core.Entities.Enums;
using LifeSkill = SafeHouse.Core.Entities.LifeSkill;
using SchoolActivity = SafeHouse.Core.Entities.SchoolActivity;

namespace SafeHouse.Core.UseCases
{
    public class DailyEntryService : IDailyEntryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<DailyEntry> _dailyEntryRepository;
        private readonly IRepository<Carton> _cartonRepository;
        private readonly IRepository<LifeSkillDailyEntry> _lifeSkillDailyEntryRepository;
        private readonly IRepository<LifeSkill> _lifeSkillRepository;
        private readonly IRepository<SchoolActivity> _schoolActivityRepository;
        private readonly IRepository<Workshop> _workshopRepository;
        private readonly IDailyEntryMapper _dailyEntryMapper;

        public DailyEntryService(IUnitOfWork unitOfWork, IDailyEntryMapper dailyEntryMapper,
            IRepository<DailyEntry> dailyEntryRepository, IRepository<Carton> cartonRepository,
            IRepository<LifeSkillDailyEntry> lifeSkillDailyEntryRepository, IRepository<LifeSkill> lifeSkillRepository,
            IRepository<SchoolActivity> schoolActivityRepository, IRepository<Workshop> workshopRepository)
        {
            _unitOfWork = unitOfWork;
            _dailyEntryRepository = dailyEntryRepository;
            _cartonRepository = cartonRepository;
            _lifeSkillDailyEntryRepository = lifeSkillDailyEntryRepository;
            _lifeSkillRepository = lifeSkillRepository;
            _schoolActivityRepository = schoolActivityRepository;
            _workshopRepository = workshopRepository;
            _dailyEntryMapper = dailyEntryMapper;
        }

        public void Add(DailyEntryDto dailyEntryDto)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == dailyEntryDto.CartonId);

            if (DailyEntryExists(dailyEntryDto.CartonId))
            {
                throw new DailyEntryExistsException(
                    $"Daily entry for day: {DateTime.Today} and Carton: {dailyEntryDto.CartonId} was created earlier.");
            }

            var dailyEntry = _dailyEntryMapper.ToEntity(dailyEntryDto, carton);

            AddWorkshopsToEntity(dailyEntryDto.Workshops, dailyEntry);
            AddSchoolActivitiesToEntity(dailyEntryDto.SchoolActivities, dailyEntry);
            AddLifeSkillsToEntity(dailyEntryDto.LifeSkills, dailyEntry);
            IncreaseVisitsNumberForCarton(carton);

            _unitOfWork.Commit();
        }

        private bool DailyEntryExists(Guid cartonId)
            => _dailyEntryRepository.GetAll().Any(de => de.Date == DateTime.Today && de.Carton.Id == cartonId);

        private void AddLifeSkillsToEntity(Enums.LifeSkill achievedLifeSkills, DailyEntry dailyEntry)
        {
            if (achievedLifeSkills == Enums.LifeSkill.None) return;

            foreach (Enums.LifeSkill lifeSkill in Enum.GetValues(typeof(Enums.LifeSkill)))
            {
                if (!achievedLifeSkills.HasFlag(lifeSkill)) continue;

                var lifeSkillDailyEntry = new LifeSkillDailyEntry
                {
                    LifeSkill = _lifeSkillRepository.GetSingleBy(ls => ls.LifeSkillType == lifeSkill),
                    DailyEntry = dailyEntry
                };

                _lifeSkillDailyEntryRepository.Add(lifeSkillDailyEntry);
            }
        }

        private void AddSchoolActivitiesToEntity(Enums.SchoolActivity schoolActivities, DailyEntry dailyEntry)
        {
            if (schoolActivities == Enums.SchoolActivity.None) return;

            foreach (Enums.SchoolActivity schoolActivity in Enum.GetValues(typeof(Enums.SchoolActivity)))
            {
                if (!schoolActivities.HasFlag(schoolActivity)) continue;

                _schoolActivityRepository.Add(new SchoolActivity { DailyEntry = dailyEntry, Type = schoolActivity });
            }
        }

        private void AddWorkshopsToEntity(IEnumerable<WorkshopDto> workshops, DailyEntry dailyEntry)
        {
            _dailyEntryRepository.Add(dailyEntry);

            foreach (var workshop in workshops)
            {
                _workshopRepository.Add(new Workshop
                {
                    DailyEntry = dailyEntry,
                    Number = workshop.Number,
                    Type = workshop.WorkshopType
                });
            }
        }

        private void IncreaseVisitsNumberForCarton(Carton carton)
        {
            carton.NumberOfVisits++;
            _cartonRepository.Update(carton);
        }
    }
}*/

using System;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.UseCases
{
    public class DailyEntryService : IDailyEntryService
    {
        private readonly IRepository<DailyEntry> _dailyEntryRepository;
        private readonly IRepository<Carton> _cartonRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDailyEntryMapper _dailyEntryMapper;

        public DailyEntryService(IUnitOfWork unitOfWork, IRepository<DailyEntry> dailyEntryRepository, IRepository<Carton> cartonRepository, IDailyEntryMapper dailyEntryMapper)
        {
            _unitOfWork = unitOfWork;
            _dailyEntryRepository = dailyEntryRepository;
            _cartonRepository = cartonRepository;
            _dailyEntryMapper = dailyEntryMapper;
        }

        public DailyEntryDto GetByCartonId(Guid id)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == id);
            var dailyEntry = _dailyEntryRepository.GetSingleBy(c => c.Carton == carton);
            if(dailyEntry != null) return _dailyEntryMapper.ToDto(dailyEntry);
            else return null;
        }

        public DailyEntryDto GetByCartonIdForToday(Guid id)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == id);
            var dailyEntry = _dailyEntryRepository.GetSingleBy(c => c.Carton == carton);
            if (dailyEntry != null) return _dailyEntryMapper.ToDto(dailyEntry);
            else return null;
        }

        public void Add(DailyEntryDto dailyEntryDto)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == dailyEntryDto.CartonId);
            var dailyEntry = _dailyEntryMapper.ToEntity(dailyEntryDto, carton);
            _dailyEntryRepository.Add(dailyEntry);
            _unitOfWork.Commit();
        }

        public void Update(DailyEntryDto dailyEntryDto)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == dailyEntryDto.CartonId);
            var dailyEntry = _dailyEntryRepository.GetSingleBy(e => e.Id == dailyEntryDto.Id);
            _dailyEntryMapper.ApplyToEntity(ref dailyEntry, dailyEntryDto, carton);

            _dailyEntryRepository.Update(dailyEntry);
            _unitOfWork.Commit();
        }

        public void Remove(Guid id)
        {
            var dailyEntry = _dailyEntryRepository.GetAll().FirstOrDefault(e => e.Id == id);
            _dailyEntryRepository.Remove(dailyEntry);
        }
    }
}