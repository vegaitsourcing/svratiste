using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class CartonMapper : ICartonMapper
    {
        public void RemoveEntity(ref Carton carton)
        {
            carton.IsDeleted = true;
        }
        public void ApplyToEntity(ref Carton carton, CartonDto cartonDto)
        {
            carton.FirstName = cartonDto.FirstName;
            carton.LastName = cartonDto.LastName;
            carton.FathersName = cartonDto.FathersName;
            carton.FathersLastName = cartonDto.FathersLastName;
            carton.MothersName = cartonDto.MothersName;
            carton.MothersLastName = cartonDto.MothersLastName;
            carton.Nickname = cartonDto.Nickname;
            carton.GenderOptions = cartonDto.GenderOptions;
            carton.AddressStreetName = cartonDto.AddressStreetName;
            carton.AddressStreetNumber = cartonDto.AddressStreetNumber;
            carton.DateOfBirth = cartonDto.DateOfBirth;
            carton.InitialEvaluationDone = cartonDto.InitialEvaluationDone;
            carton.EvaluationDone = cartonDto.EvaluationDone;
            carton.IndividualPlanDone = cartonDto.IndividualPlanDone;
            carton.IsDeleted = cartonDto.IsDeleted;
        }

        public CartonDto ToDto(Carton entity)
        {
            return new CartonDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Nickname = entity.Nickname,
                GenderOptions = entity.GenderOptions,
                DateOfBirth = entity.DateOfBirth,
                AddressStreetName = entity.AddressStreetName,
                AddressStreetNumber = entity.AddressStreetNumber,
                FathersName = entity.FathersName,
                FathersLastName = entity.FathersLastName,
                MothersName = entity.MothersName,
                MothersLastName = entity.MothersLastName,
                InitialEvaluationDone = entity.InitialEvaluationDone,
                EvaluationDone = entity.EvaluationDone,
                IndividualPlanDone = entity.IndividualPlanDone,
                IsDeleted = entity.IsDeleted
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
                GenderOptions = dto.GenderOptions,
                DateOfBirth = dto.DateOfBirth,
                AddressStreetName = dto.AddressStreetName,
                AddressStreetNumber = dto.AddressStreetNumber,
                FathersName = dto.FathersName,
                FathersLastName = dto.FathersLastName,
                MothersName = dto.MothersName,
                MothersLastName = dto.MothersLastName,
                InitialEvaluationDone = dto.InitialEvaluationDone,
                EvaluationDone = dto.EvaluationDone,
                IndividualPlanDone = dto.IndividualPlanDone,
                IsDeleted = dto.IsDeleted
            };
        }
    }
}