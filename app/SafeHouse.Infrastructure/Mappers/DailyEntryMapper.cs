using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class DailyEntryMapper : IDailyEntryMapper
    {
/*        public void RemoveEntity(ref DailyEntry dailyEntry)
        {
            dailyEntry.IsDeleted = true;
        }*/

        public void ApplyToEntity(ref DailyEntry dailyEntry, DailyEntryDto dailyEntryDto, Carton carton)
        {
            dailyEntry.Id = dailyEntryDto.Id;
            dailyEntry.Carton = carton;
            dailyEntry.Gender = dailyEntryDto.Gender;
            dailyEntry.Stay = dailyEntryDto.Stay;
            dailyEntry.Breakfast = dailyEntryDto.Breakfast;
            dailyEntry.Lunch = dailyEntryDto.Lunch;
            dailyEntry.Bath = dailyEntryDto.Bath;
            dailyEntry.LiecesRemoval = dailyEntryDto.LiecesRemoval;
            dailyEntry.Clothes = dailyEntryDto.Clothes;
            dailyEntry.MediationWriting = dailyEntryDto.MediationWriting;
            dailyEntry.MediationWritingDescription = dailyEntryDto.MediationWritingDescription;
            dailyEntry.MediationSpeaking = dailyEntryDto.MediationSpeaking;
            dailyEntry.MediationSpeakingDescription = dailyEntryDto.MediationSpeakingDescription;
            dailyEntry.LifeSkills = dailyEntryDto.LifeSkills;
            dailyEntry.SchoolAcivities = dailyEntryDto.SchoolAcivities;
            dailyEntry.PsihosocialSupport = dailyEntryDto.PsihosocialSupport;
            dailyEntry.ParentsContact = dailyEntryDto.ParentsContact;
            dailyEntry.MedicalInterventions = dailyEntryDto.MedicalInterventions;
            dailyEntry.Arrival = dailyEntryDto.Arrival;
            dailyEntry.EducationWorkshop = dailyEntryDto.EducationWorkshop;
            dailyEntry.CreativeWorkshop = dailyEntryDto.CreativeWorkshop;
            dailyEntry.StartTime = dailyEntryDto.StartTime;
            dailyEntry.EndTIme = dailyEntryDto.EndTIme;
        }
        public DailyEntryDto ToDto(DailyEntry entity)
        {
            return new DailyEntryDto
            {
                Id = entity.Id,
                CartonId = entity.Carton.Id,
                Gender = entity.Gender,
                Stay = entity.Stay,
                Breakfast = entity.Breakfast,
                Lunch = entity.Lunch,
                Bath = entity.Bath,
                LiecesRemoval = entity.LiecesRemoval,
                Clothes = entity.Clothes,
                MediationWriting = entity.MediationWriting,
                MediationWritingDescription = entity.MediationWritingDescription,
                MediationSpeaking = entity.MediationSpeaking,
                MediationSpeakingDescription = entity.MediationSpeakingDescription,
                LifeSkills = entity.LifeSkills,
                SchoolAcivities = entity.SchoolAcivities,
                PsihosocialSupport = entity.PsihosocialSupport,
                ParentsContact = entity.ParentsContact,
                MedicalInterventions = entity.MedicalInterventions,
                Arrival = entity.Arrival,
                EducationWorkshop = entity.EducationWorkshop,
                CreativeWorkshop = entity.CreativeWorkshop,
                StartTime = entity.StartTime,
                EndTIme = entity.EndTIme
            };
        }

        public DailyEntry ToEntity(DailyEntryDto dto, Carton carton)
        {
            return new DailyEntry
            {
                Id = dto.Id,
                Carton = carton,
                Gender = dto.Gender,
                Stay = dto.Stay,
                Breakfast = dto.Breakfast,
                Lunch = dto.Lunch,
                Bath = dto.Bath,
                LiecesRemoval = dto.LiecesRemoval,
                Clothes = dto.Clothes,
                MediationWriting = dto.MediationWriting,
                MediationWritingDescription = dto.MediationWritingDescription,
                MediationSpeaking = dto.MediationSpeaking,
                MediationSpeakingDescription = dto.MediationSpeakingDescription,
                LifeSkills = dto.LifeSkills,
                SchoolAcivities = dto.SchoolAcivities,
                PsihosocialSupport = dto.PsihosocialSupport,
                ParentsContact = dto.ParentsContact,
                MedicalInterventions = dto.MedicalInterventions,
                Arrival = dto.Arrival,
                EducationWorkshop = dto.EducationWorkshop,
                CreativeWorkshop = dto.CreativeWorkshop,
                StartTime = dto.StartTime,
                EndTIme = dto.EndTIme
            };
        }
    }
}