using System.Collections.Immutable;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Entities.Enums;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.UseCases
{
    public class ReportService : IReportService
    {
        private readonly IRepository<DailyEntry> _dailyEntryRepository;

        public ReportService(IRepository<DailyEntry> dailyEntryRepository)
        {
            _dailyEntryRepository = dailyEntryRepository;
        }

        public ReportDataDto GetReport(ReportRequestDto request)
        {
            /*            var dailyEntriesInDatesRange = _dailyEntryRepository.Include(de => de.Carton)
                            .Where(d => d.Date >= request.From && d.Date <= request.To)
                            .Where(d => request.ChildName == null || d.Carton.FirstName == request.ChildName.FirstName)
                            .Where(d => request.ChildName == null || d.Carton.LastName == request.ChildName.LastName)
                            .Where(d => request.ChildName == null || string.IsNullOrEmpty(d.Carton.FathersName) || d.Carton.FathersName == request.ChildName.MiddleName)
                            .ToImmutableArray();

                        var reportDataDto = new ReportDataDto
                        {
                            VisitsCount = dailyEntriesInDatesRange.Count(),
                            GuestsCount = dailyEntriesInDatesRange.Count(d => d.Carton != null && d.Stay),
                            FemaleGuestsCount = dailyEntriesInDatesRange.Where(d => d.Carton != null && d.Stay)
                                .Count(d => d.Carton.Gender == Gender.Female),
                            MaleGuestsCount = dailyEntriesInDatesRange.Where(d => d.Carton != null && d.Stay)
                                .Count(d => d.Carton.Gender == Gender.Male),
                            MealCount = dailyEntriesInDatesRange.Sum(d => (int)d.Meal),
                            BathsCount = dailyEntriesInDatesRange.Count(d => d.Bath),
                            LiecesRemovedCount = dailyEntriesInDatesRange.Count(d => d.LiecesRemoval),
                            ClothingSumCount = dailyEntriesInDatesRange.Sum(d => d.Clothing),
                        };

                        return reportDataDto;*/
            return null;
        }
    }
}