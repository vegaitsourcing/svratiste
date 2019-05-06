using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Api.Models;
using SafeHouse.Data.Enums;

namespace SafeHouse.Api.Controllers
{
    [Route("api/Enumerations")]
    [ApiController]
    public class EnumerationsController : BaseController
    {
        [HttpGet("LifeSkills")]
        public ICollection<NameValueModel> GetLifeSkills()
        {
            return EnumToNameValueList<LifeSkillEnum>();
        }

        [HttpGet("MediationSpeakings")]
        public ICollection<NameValueModel> GetMediationSpeakings()
        {
            return EnumToNameValueList<MediationSpeakingEnum>();
        }

        [HttpGet("MediationWritings")]
        public ICollection<NameValueModel> GetMediationWritings()
        {
            return EnumToNameValueList<MediationWritingEnum>();
        }

        [HttpGet("MedicalInterventions")]
        public ICollection<NameValueModel> GetMedicalInterventions()
        {
            return EnumToNameValueList<MedicalInterventionsEnum>();
        }

        [HttpGet("SchoolActivities")]
        public ICollection<NameValueModel> GetSchoolActivities()
        {
            return EnumToNameValueList<SchoolActivityEnum>();
        }

        [HttpGet("WorkshopTypes")]
        public ICollection<NameValueModel> GetWorkshopTypes()
        {
            return EnumToNameValueList<WorkshopType>();
        }

        [HttpGet("IndividualMovementAbilities")]
        public ICollection<NameValueModel> GetIndividualMovementAbilities()
        {
            return EnumToNameValueList<IndividualMovementAbilityEnum>();
        }

        [HttpGet("LivingSpaces")]
        public ICollection<NameValueModel> GetLivingSpaces()
        {
            return EnumToNameValueList<LivingSpaceEnum>();
        }

        private ICollection<NameValueModel> EnumToNameValueList<T>()
        {
            var result = new List<NameValueModel> { };

            foreach (var type in Enum.GetValues(typeof(T)))
            {
                result.Add(new NameValueModel { Value = (int)type, Name = ((T)type).ToString() });
            }

            return result;
        }
    }
}