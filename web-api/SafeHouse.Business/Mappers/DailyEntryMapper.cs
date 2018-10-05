﻿using SafeHouse.Business.Contracts.Mappers;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;
using SafeHouse.Data.Enums;
using System;

namespace SafeHouse.Business.Mappers
{
    public class DailyEntryMapper : IDailyEntryMapper
    {
        public DailyEntry ToEntity(DailyEntryDto dto, Carton carton)
        {
            var meal = dto.Breakfast ? Meal.Breakfast : 0;
                meal |= dto.Lunch ? Meal.Lunch : 0;
                meal |= dto.Diner ? Meal.Dinner : 0;

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
                Stay = dto.Stay
            };
        }

    }
}
