using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Entities.Enums;
using SafeHouse.Core.Models;
using System;

namespace SafeHouse.Infrastructure.Mappers
{
    public class DailyEntryMapper : IDailyEntryMapper
    {
        public DailyEntry ToEntity(DailyEntryDto dto, Carton carton)
        {
            var meal = dto.Breakfast ? Meal.Breakfast : 0;
            meal |= dto.Lunch ? Meal.Lunch : 0;
            meal |= dto.Diner ? Meal.Dinner : 0;

            return new DailyEntry
            {
                Carton = carton,
                Date = DateTime.Today,
                Meal = meal,
                Bath = dto.Bath,
                LiecesRemoval = dto.LiecesRemoval,
                Arrival = dto.Arrival,
                Clothing = dto.Clothes,
                Departure = dto.Departure,
                MediationSpeaking = dto.MediationSpeaking,
                MediationSpeakingDescription = dto.MediationSpeakingDescription,
                MediationWriting = dto.MediationWriting,
                MediationWritingDescription = dto.MediationWritingDescription,
                MedicalInterventions = dto.MedicalInterventions,
                ParentsContact = dto.ParentsContact,
                PsychosocialSupport = dto.PsychosocialSupport,
                Stay = dto.Stay
            };
        }
    }
}