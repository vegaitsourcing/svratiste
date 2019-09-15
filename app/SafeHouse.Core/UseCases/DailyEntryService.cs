using System;
using System.Collections.Generic;
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

        public IEnumerable<DailyEntryDto> GetAllByCartonId(Guid id)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == id && c.IsDeleted == false);
            var dailyEntry = _dailyEntryRepository.GetAll().Where(c => c.Carton == carton && c.IsDeleted == false).Select(c => _dailyEntryMapper.ToDto(c));
            if (dailyEntry != null) return dailyEntry;
            else return null;
        }

        public DailyEntryDto GetById(Guid id, Guid cartonId)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == cartonId);
            var dailyEntry = _dailyEntryRepository.GetSingleBy(c => c.Id == id);
            dailyEntry.Carton = carton;
            if (dailyEntry != null && dailyEntry.IsDeleted == false && carton.IsDeleted == false)
                return _dailyEntryMapper.ToDto(dailyEntry);
            else return null;
        }

        public DailyEntryDto GetByCartonIdForToday(Guid id)
        {
            DateTime today = DateTime.Now.Date;

            var carton = _cartonRepository.GetSingleBy(c => c.Id == id && c.IsDeleted == false);
            var dailyEntry = _dailyEntryRepository.GetAll().OrderByDescending(c => c.CreationDate).FirstOrDefault(c => c.Carton == carton && c.Date.Year == today.Year && c.Date.Month == today.Month && c.Date.Day == today.Day);
            if (dailyEntry != null && dailyEntry.IsDeleted == false) return _dailyEntryMapper.ToDto(dailyEntry);
            else return null;
        }

        public void Add(DailyEntryDto dailyEntryDto)
        {
            dailyEntryDto.Date = DateTime.Now.Date;
            var carton = _cartonRepository.GetSingleBy(c => c.Id == dailyEntryDto.CartonId);
            var dailyEntry = _dailyEntryMapper.ToEntity(dailyEntryDto, carton);
            _dailyEntryRepository.Add(dailyEntry);
            _unitOfWork.Commit();
        }

        public void Update(DailyEntryDto dailyEntryDto)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == dailyEntryDto.CartonId);
            var dailyEntry = _dailyEntryRepository.GetAll().OrderByDescending(e => e.CreationDate).FirstOrDefault(e => e.Id == dailyEntryDto.Id);

            if (dailyEntry != null && carton.IsDeleted == false && dailyEntry.IsDeleted == false)
            {
                _dailyEntryMapper.ApplyToEntity(ref dailyEntry, dailyEntryDto, carton);
                _dailyEntryRepository.Update(dailyEntry);
                _unitOfWork.Commit();
            }
        }

        public void Remove(Guid id)
        {
            var dailyEntry = _dailyEntryRepository.GetSingleBy(c => c.Id == id);

            if (dailyEntry != null)
            {
                _dailyEntryMapper.RemoveEntity(ref dailyEntry);
                _dailyEntryRepository.Update(dailyEntry);
                _unitOfWork.Commit();
            }
        }
    }
}