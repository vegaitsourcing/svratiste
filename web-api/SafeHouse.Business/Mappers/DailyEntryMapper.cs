using SafeHouse.Business.Contracts.Mappers;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Mappers
{
    public class DailyEntryMapper : IDailyEntryMapper
    {
        public DailyEntry ToEntity(DailyEntryDto dto, Carton carton)
        {
            var meal = dto.Breakfast ? 1 : 0;
            meal |= dto.Lunch ? 2 : 1;
            meal |= dto.Diner ? 4 : 1;

            return new DailyEntry()
            {
                Carton = carton,
                Date = DateTime.Now,
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
                PsihosocialSupport = dto.PsihosocialSupport,
                Stay = dto.Stay,
            };
        }

    }
}
