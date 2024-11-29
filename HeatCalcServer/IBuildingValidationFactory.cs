using FluentValidation;
using HeatCalc.Domain.Dto.Enums;
using HeatCalc.Domain.Dto.Request;

namespace HeatCalcServer
{
    public interface IBuildingValidationFactory
    {
        IValidator<BuildingRequest> GetValidator(BuildingTypeModel buildingType);
    }
}
