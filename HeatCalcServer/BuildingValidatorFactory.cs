using FluentValidation;
using HeatCalc.Domain.Dto.Enums;
using HeatCalc.Domain.Dto.Request;
using HeatCalcServer.Validators;

namespace HeatCalcServer
{
    public class BuildingValidatorFactory : IBuildingValidatorFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public BuildingValidatorFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IValidator<BuildingRequest> GetValidator(BuildingTypeModel buildingType)
        {
            var validator = buildingType switch
            {
                BuildingTypeModel.Building => _serviceProvider.GetService<CreateBuildingRequestValidator>() as IValidator<BuildingRequest>,
                BuildingTypeModel.BuildingWithParking => _serviceProvider.GetService<CreateBuildingWithParkingRequestValidator>() as IValidator<BuildingRequest>,
                _ => null
            };

            if (validator == null)
            {
                throw new InvalidOperationException($"Валидаор {buildingType} не найден.");
            }

            return validator;
        }
    }
}
