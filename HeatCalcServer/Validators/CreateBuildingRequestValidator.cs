using FluentValidation;
using HeatCalc.Domain.Dto.Request;

namespace HeatCalcServer.Validators
{
    public class CreateBuildingRequestValidator : AbstractValidator<BuildingRequest>
    {
        public CreateBuildingRequestValidator()
        {
            RuleFor(f => f.Name).NotEmpty();
            RuleFor(f => f.VolumeIncludingFirstFloor).NotEmpty();
            RuleForEach(f => f.Sections)
                .ChildRules(section =>
                {
                    section.RuleFor(g => g.Number).NotEmpty().WithMessage("Номер секции должен быть задан");
                    section.RuleFor(g => g.TotalAreaOfApartmentsBelow).NotEmpty().WithMessage("Общая площадь квартир должна быть задана");

                    section.RuleFor(x => x.TotalAreaOfControlRoom)
                    .NotEmpty()
                    .When(x => x.HasControlRoom)
                    .WithMessage("Не указана площадь ОДС");

                    section.RuleFor(x => x.TotalAreaOfServiceCenter)
                    .NotEmpty()
                    .When(x => x.HasServiceCenter)
                    .WithMessage("Не указана площадь ЦИН");

                    section.RuleFor(g => g.CountOfFloors).NotEmpty().WithMessage("Количество этажей должно быть задано");
                    section.RuleFor(g => g.CountOfCorridorsTypicalFloor).NotEmpty().WithMessage("Необходимо указать количество выделенных коридоров типового этажа");
                    section.RuleFor(g => g.CountOfFireproofZone).NotEmpty().WithMessage("Необходимо указать количество пожаробезопасных зон");

                    section.RuleForEach(g => g.Corridors)
                    .ChildRules(corridor =>
                    {
                        corridor.RuleFor(h => h)
                            .Must(c => !(c.IsConnectTypicalFloorWithFireProfZone && c.IsConnectTypicalFloorWithFireGateway))
                            .WithMessage("Коридор не может одновременно сообщаться с пожаробезопасной зоной и тамбур-шлюзом.");

                        corridor.RuleFor(h => h)
                            .Must(c => c.IsConnectTypicalFloorWithFireProfZone || c.IsConnectTypicalFloorWithFireGateway)
                            .WithMessage("Коридор должен сообщаться либо с пожаробезопасной зоной, либо с тамбур-шлюзом.");
                    });

                    section.RuleForEach(g => g.Staircases)
                    .ChildRules(staircase =>
                    {
                        staircase.RuleFor(h => h.TypeOfTheStaircase)
                            .IsInEnum()
                            .WithMessage("Указан недопустимый тип лестницы.");

                        staircase.RuleFor(h => h)
                        .Must(c => !(c.IsStructuralDivisionOfTheStaircase && c.IsConnectTypicalFloorWithIndividualFireGateway))
                        .WithMessage("Лестница не может одновременно сообщаться с пожаробезопасной зоной и тамбур-шлюзом.");

                        staircase.RuleFor(h => h)
                        .Must(c => !(c.IsStructuralDivisionOfTheStaircase || c.IsConnectTypicalFloorWithIndividualFireGateway))
                        .WithMessage("Как правило лестница сообщается либо с пожаробезопасной зоной, либо с тамбур-шлюзом.");
                    });

                    section.RuleForEach(g => g.Elevators)
                    .ChildRules(elevator =>
                    {
                        elevator.RuleFor(h => h.TypeOfElevator)
                        .IsInEnum()
                        .WithMessage("Указан недопустимый тип лифта.");
                    });

                    section.RuleForEach(h => new[]
                    {
                        h.LowerFireCompartmentNumber,
                        h.UpperFireCompartmentNumber,
                        h.TotalAreaOfApartmentsAbove,
                        h.CountOfFloorsOfFireComaprtment
                    }).NotEmpty()
                        .When(c => c.IsHighRiseSection)
                        .WithMessage("Для высотной секции необходимо задать номера пожарных отсеков верхнего/нижнего," +
                        " площадь квартир каждого пож отсека, количество этажей пожарного отсека");
                });

            RuleForEach(f => new[] { f.CountOfExitGateInParking, f.CountFireCompartmentInParking, f.NumberOfIsolatedRampInFireComaprtment })
                .NotEmpty()
                .When(f => f.HasParking)
                .WithMessage("Когда паркинг указан, все поля должны быть заполнены.");

            RuleFor(f => f.IsRampIsolated)
                .NotNull()
                .WithMessage("IsIsolatedRamp должно быть указано.")
                .Must(value => value == true || value == false)
                .WithMessage("IsIsolatedRamp должно быть равно true или false.");

            RuleForEach(f => f.Parkings)
                .ChildRules(parking =>
                {
                    parking.RuleFor(g => g.Number).NotEmpty().WithMessage("Номер пожарного отсека обязательно должен быть указан");
                    parking.RuleFor(g => g.TotalAreaOfParking).NotEmpty().WithMessage("Необходимо указать площадь паркинга");
                    parking.RuleFor(g => g.TotalParkingVolume).NotEmpty().WithMessage("Необходимо указать объем паркинга");
                    parking.RuleFor(g => g.CountOfFireproofZone).NotEmpty().WithMessage("Необходимо указать количество пожаробезопасных зон");
                    parking.RuleFor(g => g.CountOfFireGateway).NotEmpty().WithMessage("Необходимо указать количество тамбур-шлюзов");
                    parking.RuleFor(g => g.HasFirePumpStation).NotEmpty().WithMessage("Необходимо указать есть ли насосная пожаротушения");
                    parking.RuleFor(g => g.HasPumpStation).NotEmpty().WithMessage("Необходимо указать есть ли насосная");
                    parking.RuleFor(g => g.HasHeatingPoint).NotEmpty().WithMessage("Необходимо указать есть ли ИТП");
                    parking.RuleFor(g => g.PeopleCountInShelter).NotEmpty()
                           .When(h => h.HasShelter)
                           .WithMessage("Необходимо указать количество людей при наличии укрытия");

                    parking.RuleForEach(g => g.Elevators)
                    .ChildRules(elevator =>
                    {
                        elevator.RuleFor(h => h.TypeOfElevator).IsInEnum()
                        .WithMessage("Указан недопустимый тип лифта.");
                    });
                }).When(g => g.HasParking);


        }
    }
}
