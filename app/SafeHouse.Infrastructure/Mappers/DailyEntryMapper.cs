using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class DailyEntryMapper : IDailyEntryMapper
    {
        public DailyEntryDto ToDto(DailyEntry entity)
        {
            return new DailyEntryDto
            {
                Id = entity.Id,
                CartonId = entity.Carton.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
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
                FirstName = dto.FirstName,
                LastName = dto.LastName,
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