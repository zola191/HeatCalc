using HeatCalc.Data.Models.Architect;
using HeatCalc.Domain.Dto.Enums;
using HeatCalc.Domain.Dto.Response;

namespace HeatCalc.Domain.Factories
{
    public class BuildingResponseFactory
    {
        public BuildingModel CreateBuildingModel(Building building)
        {
            return new BuildingModel()
            {
                Id = building.Id,
                BuildingTypeModel = (BuildingTypeModel)building.BuildingType,
                Name = building.Name,
                CreatedDateUtc = building.CreatedDateUtc,
                VolumeIncludingFirstFloor = building.VolumeIncludingFirstFloor,
                Sections = building.Sections?.Select(CreateSectionModel).ToList() ?? new List<SectionModel>(),
                HasParking = building.HasParking,
                CountOfExitGateInParking = building.CountOfExitGateInParking,
                CountFireCompartmentInParking = building.CountFireCompartmentInParking,
                IsRampIsolated = building.IsRampIsolated,
                NumberOfIsolatedRampInFireComaprtment = building.NumberOfIsolatedRampInFireComaprtment,
                Parkings = building.Parkings?.Select(CreateParkingModel).ToList() ?? new List<ParkingModel>(),
            };
        }


        public BuildingModel UpdateBuildingModel(Building building)
        {
            return new BuildingModel()
            {
                Id = building.Id,
                BuildingTypeModel = (BuildingTypeModel)building.BuildingType,
                Name = building.Name,
                CreatedDateUtc = building.CreatedDateUtc,
                UpdatedDateUtc = building.UpdatedDateUtc,
                VolumeIncludingFirstFloor = building.VolumeIncludingFirstFloor,
                Sections = building.Sections?.Select(CreateSectionModel).ToList() ?? new List<SectionModel>(),
                HasParking = building.HasParking,
                CountOfExitGateInParking = building.CountOfExitGateInParking,
                CountFireCompartmentInParking = building.CountFireCompartmentInParking,
                IsRampIsolated = building.IsRampIsolated,
                NumberOfIsolatedRampInFireComaprtment = building.NumberOfIsolatedRampInFireComaprtment,
                Parkings = building.Parkings?.Select(CreateParkingModel).ToList() ?? new List<ParkingModel>(),
            };
        }

        private SectionModel CreateSectionModel(Section section)
        {
            return new SectionModel
            {
                Number = section.Number,
                TotalAreaOfApartmentsBelow = section.TotalAreaOfApartmentsBelow,
                TotalAreaOfBasement = section.TotalAreaOfBasement,
                TotalAreaOfTechnicalSpace = section.TotalAreaOfTechnicalSpace,
                HasControlRoom = section.HasControlRoom,
                TotalAreaOfControlRoom = section.TotalAreaOfControlRoom,
                HasServiceCenter = section.HasServiceCenter,
                TotalAreaOfServiceCenter = section.TotalAreaOfServiceCenter,
                CountOfFloors = section.CountOfFloors,
                LowerFireCompartmentNumber = section.LowerFireCompartmentNumber,
                CountOfFloorsOfTheLowerFireComaprtment = section.CountOfFloorsOfTheLowerFireComaprtment,
                CountOfCorridorsTypicalFloor = section.CountOfCorridorsTypicalFloor,
                CountOfFireproofZone = section.CountOfFireproofZone,
                Corridors = section.SectionCorridors.Select(sectionCorridor =>
                {
                    var corridor = sectionCorridor.Corridor;
                    return new CorridorModel
                    {
                        IsConnectTypicalFloorWithFireGateway = corridor.IsConnectTypicalFloorWithFireGateway,
                        IsConnectTypicalFloorWithFireProfZone = corridor.IsConnectTypicalFloorWithFireGateway
                    };
                }).ToList() ?? new List<CorridorModel>(),
                Staircases = section.SectionStaircases.Select(sectionStaircase =>
                {
                    var staircase = sectionStaircase.Staircase;
                    return new StaircaseModel
                    {
                        IsConnectTypicalFloorWithFireProfZone = staircase.IsConnectTypicalFloorWithFireProfZone,
                        IsConnectTypicalFloorWithIndividualFireGateway = staircase.IsConnectTypicalFloorWithIndividualFireGateway,
                        IsStructuralDivisionOfTheStaircase = staircase.IsStructuralDivisionOfTheStaircase,
                        TypeOfTheStaircase = (TypeOfStaircaseModel)staircase.TypeOfTheStaircase
                    };
                }).ToList() ?? new List<StaircaseModel>(),
                Elevators = section.SectionElevators.Select(sectionElevator =>
                {
                    var elevator = sectionElevator.Elevator;
                    return new ElevatorModel
                    {
                        TypeOfElevator = (TypeOfElevatorModel) elevator.TypeOfElevator,
                    };
                }).ToList() ?? new List<ElevatorModel>(),
                BasementFireCompartmentNumber = section.BasementFireCompartmentNumber,
                HasPumpingStationInSectionFireComaprtment = section.HasPumpingStationInSectionFireComaprtment,

                TotalAreaOfApartmentsAbove = section.TotalAreaOfApartmentsAbove,
                IntermediateTechnicalFloorNumber = section.IntermediateTechnicalFloorNumber,
                UpperFireCompartmentNumber = section.UpperFireCompartmentNumber,
                CountOfFloorsOfFireComaprtment = section.CountOfFloorsOfFireComaprtment
            };
        }

        private CorridorModel CreateCorridorModel(Corridor corridor)
        {
            return new CorridorModel
            {
                IsConnectTypicalFloorWithFireGateway = corridor.IsConnectTypicalFloorWithFireGateway,
                IsConnectTypicalFloorWithFireProfZone = corridor.IsConnectTypicalFloorWithFireProfZone,
            };
        }

        private StaircaseModel CreateStaircaseModel(Staircase staircase)
        {
            return new StaircaseModel
            {
                TypeOfTheStaircase = (TypeOfStaircaseModel)staircase.TypeOfTheStaircase,
                IsConnectTypicalFloorWithIndividualFireGateway = staircase.IsConnectTypicalFloorWithIndividualFireGateway,
                IsConnectTypicalFloorWithFireProfZone = staircase.IsConnectTypicalFloorWithFireProfZone,
                IsStructuralDivisionOfTheStaircase = staircase.IsStructuralDivisionOfTheStaircase,
            };
        }

        private ElevatorModel CreateElevatorModel(Elevator elevator)
        {
            return new ElevatorModel
            {
                TypeOfElevator = (TypeOfElevatorModel)elevator.TypeOfElevator
            };
        }

        private ParkingModel CreateParkingModel(Parking parking)
        {
            return new ParkingModel
            {
                Number = parking.Number,
                TotalAreaOfParking = parking.TotalAreaOfParking,
                TotalParkingVoLume = parking.TotalParkingVoLume,
                Elevators = parking.ParkingElevators.Select(parkingElevator =>
                {
                    var elevator = parkingElevator.Elevator;
                    return new ElevatorModel
                    {
                        TypeOfElevator = (TypeOfElevatorModel) elevator.TypeOfElevator,
                    };
                }).ToList() ?? new List<ElevatorModel>(),
                CountOfFireproofZone = parking.CountOfFireproofZone,
                CountOfFireGateway = parking.CountOfFireGateway,
                HasFirePumpStation = parking.HasFirePumpStation,
                HasPumpStation = parking.HasPumpStation,
                HasHeatingPoint = parking.HasHeatingPoint,
                HasShelter = parking.HasShelter,
                PeopleCountInShelter = parking.PeopleCountInShelter
            };
        }
    }
}
