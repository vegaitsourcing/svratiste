using Microsoft.AspNetCore.Mvc;
using SafeHouse.Core.Entities.Enums;
using SafeHouse.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SafeHouse.Web.Controllers
{
    [Route("api/Enumerations")]
    [ApiController]
    public class EnumerationsController : BaseController
    {
        [HttpGet("LifeSkills")]
        public IEnumerable<NameValueModel> GetLifeSkills()
        {
            return GetEnumToNameValuePairs<LifeSkill>();
        }

        [HttpGet("MediationSpeakings")]
        public IEnumerable<NameValueModel> GetMediationSpeakings()
        {
            return GetEnumToNameValuePairs<MediationSpeaking>();
        }

        [HttpGet("MediationWritings")]
        public IEnumerable<NameValueModel> GetMediationWritings()
        {
            return GetEnumToNameValuePairs<MediationWriting>();
        }

        [HttpGet("MedicalInterventions")]
        public IEnumerable<NameValueModel> GetMedicalInterventions()
        {
            return GetEnumToNameValuePairs<MedicalInterventions>();
        }

        [HttpGet("SchoolActivities")]
        public IEnumerable<NameValueModel> GetSchoolActivities()
        {
            return GetEnumToNameValuePairs<SchoolActivity>();
        }

        [HttpGet("WorkshopTypes")]
        public IEnumerable<NameValueModel> GetWorkshopTypes()
        {
            return GetEnumToNameValuePairs<WorkshopType>();
        }

        [HttpGet("IndividualMovementAbilities")]
        public IEnumerable<NameValueModel> GetIndividualMovementAbilities()
        {
            return GetEnumToNameValuePairs<IndividualMovementAbility>();
        }

        [HttpGet("LivingSpaces")]
        public IEnumerable<NameValueModel> GetLivingSpaces()
        {
            return GetEnumToNameValuePairs<LivingSpace>();
        }

        private IEnumerable<NameValueModel> GetEnumToNameValuePairs<T>()
        {
            return Enum.GetNames(typeof(T))
                .Select(name => new NameValueModel
                {
                    Name = name,
                    Value = (int)Enum.Parse(typeof(T), name)
                });
        }
    }
}