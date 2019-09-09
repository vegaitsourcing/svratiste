using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class CartonMapper : ICartonMapper
    {
        public void ApplyToEntity(ref Carton carton, CartonDto cartonDto)
        {
            carton.FirstName = cartonDto.FirstName;
            carton.LastName = cartonDto.LastName;
            carton.Nickname = cartonDto.Nickname;
            carton.Gender = cartonDto.Gender;
            carton.DateOfBirth = cartonDto.DateOfBirth;
            carton.NumberOfVisits = cartonDto.NumberOfVisits;
            carton.AddressStreetName = cartonDto.AddressStreetName;
            carton.AddressStreetNumber = cartonDto.AddressStreetNumber;
            carton.FathersName = cartonDto.FathersName;
            carton.FathersLastName = cartonDto.FathersLastName;
            carton.MothersName = cartonDto.MothersName;
            carton.MothersLastName = cartonDto.MothersLastName;
            carton.NotificationsEnabled = cartonDto.NotificationsEnabled;
            carton.InitialEvaluationDone = cartonDto.InitialEvaluationDone;
            carton.EvaluationDone = cartonDto.EvaluationDone;
            carton.IndividualPlanDone = cartonDto.IndividualPlanDone;
            carton.IndividualPlanRevised = cartonDto.IndividualPlanRevised;
        }

        public CartonDto ToDto(Carton entity)
        {
            return new CartonDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Nickname = entity.Nickname,
                Gender = entity.Gender,
                DateOfBirth = entity.DateOfBirth,
                NumberOfVisits = entity.NumberOfVisits,
                AddressStreetName = entity.AddressStreetName,
                AddressStreetNumber = entity.AddressStreetNumber,
                FathersName = entity.FathersName,
                FathersLastName = entity.FathersLastName,
                MothersName = entity.MothersName,
                MothersLastName = entity.MothersLastName,
                NotificationsEnabled = entity.NotificationsEnabled,
                InitialEvaluationDone = entity.InitialEvaluationDone,
                EvaluationDone = entity.EvaluationDone,
                IndividualPlanDone = entity.IndividualPlanDone,
                IndividualPlanRevised = entity.IndividualPlanRevised
            };
        }

        public Carton ToEntity(CartonDto dto)
        {
            return new Carton
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Nickname = dto.Nickname,
                Gender = dto.Gender,
                DateOfBirth = dto.DateOfBirth,
                NumberOfVisits = dto.NumberOfVisits,
                AddressStreetName = dto.AddressStreetName,
                AddressStreetNumber = dto.AddressStreetNumber,
                FathersName = dto.FathersName,
                FathersLastName = dto.FathersLastName,
                MothersName = dto.MothersName,
                MothersLastName = dto.MothersLastName,
                NotificationsEnabled = dto.NotificationsEnabled,
                InitialEvaluationDone = dto.InitialEvaluationDone,
                EvaluationDone = dto.EvaluationDone,
                IndividualPlanDone = dto.IndividualPlanDone,
                IndividualPlanRevised = dto.IndividualPlanRevised
            };
        }
    }
}