using SafeHouse.Business.Contracts.Mappers;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business.Mappers
{
    public class CartonMapper : ICartonMapper
    {
        private readonly IGenderMapper _genderMapper;

        public CartonMapper(IGenderMapper genderMapper)
        {
            _genderMapper = genderMapper;
        }

        public CartonDto ToDto(Carton entity)
        {
            return new CartonDto
            {
                Id = entity.Id,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Nickname = entity.Nickname,
                    Gender = _genderMapper.ToDto(entity.Gender),
                    DateOfBirth = entity.DateOfBirth,
                    NumberOfVisits = entity.NumberOfVisits,
                    AddressStreetName = entity.AddressStreetName,
                    AddressStreetNumber = entity.AddressStreetNumber,
                    FathersName = entity.FathersName,
                    MothersName = entity.MothersName,
                    InitialEvaluationDone = entity.InitialEvaluationDone,
                    EvaluationDone = entity.EvaluationDone,
                    IndividualPlanDone = entity.IndividualPlanDone,
                    IndividualPlanRevised = entity.IndividualPlanRevised,
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
                    Gender = _genderMapper.ToEntity(dto.Gender),
                    DateOfBirth = dto.DateOfBirth,
                    NumberOfVisits = dto.NumberOfVisits,
                    AddressStreetName = dto.AddressStreetName,
                    AddressStreetNumber = dto.AddressStreetNumber,
                    FathersName = dto.FathersName,
                    MothersName = dto.MothersName,
                    InitialEvaluationDone = dto.InitialEvaluationDone,
                    EvaluationDone = dto.EvaluationDone,
                    IndividualPlanDone = dto.IndividualPlanDone,
                    IndividualPlanRevised = dto.IndividualPlanRevised
            };
        }
    }
}
