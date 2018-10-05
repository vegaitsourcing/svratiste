using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;
using SafeHouse.Data.Entities;
using SafeHouse.Data.Enums;

namespace SafeHouse.Business
{
    public class ReportService : IReportService
    {
        private readonly SafeHouseContext _dbContext;

        public ReportService(SafeHouseContext context)
        {
            _dbContext = context;
        }

        public ReportDataDto GetReportData(ReportRequestDto request)
        {
            var dailyEntriesInDatesRange = _dbContext.DailyEntries
                .Include(d => d.Carton)
                .Where(d => d.Date.CompareTo(request.From) >= 0 && d.Date.CompareTo(request.To) <= 0);

            if (request.ChildName != null)
            {
                dailyEntriesInDatesRange = FilterByChild(request.ChildName, dailyEntriesInDatesRange);
            }

            var reportDataDto = new ReportDataDto
            {
                VisitsCount = dailyEntriesInDatesRange.Count(),
                GuestsCount = dailyEntriesInDatesRange.Where(d => d.Carton != null && d.Stay).Count(),
                FemaleGuestsCount = dailyEntriesInDatesRange.Where(d => d.Carton != null && d.Stay)
                    .Count(d => d.Carton.Gender == Gender.Female),
                MaleGuestsCount = dailyEntriesInDatesRange.Where(d => d.Carton != null && d.Stay)
                    .Count(d => d.Carton.Gender == Gender.Male),
                //MealCount = dailyEntriesInDatesRange.Sum(d => d.Meal),
                BathsCount = dailyEntriesInDatesRange.Count(d => d.Bath),
                LiecesRemovedCount = dailyEntriesInDatesRange.Count(d => d.LiecesRemoval),
                ClothingSumCount = dailyEntriesInDatesRange.Sum(d => d.Clothing),
            };

            return reportDataDto;
        }

        private IQueryable<DailyEntry> FilterByChild(NameDto childName, IQueryable<DailyEntry> entries)
        {
            return entries
                .Where(d => d.Carton.FirstName == childName.FirstName)
                .Where(d => d.Carton.LastName == childName.LastName)
                .Where(d => string.IsNullOrEmpty(d.Carton.FathersName) || (d.Carton.FathersName == childName.MiddleName));
        }
    }
}
