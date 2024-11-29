using HeatCalc.Data.Enums;
using HeatCalc.Data.Models;
using HeatCalc.Data.Models.Architect;
using HeatCalc.Domain.Dto.Request;

namespace HeatCalc.Domain.Factories
{
    public class BuildingFactory
    {
        public Building CreateBuilding(BuildingRequest request)
        {
            return new Building()
            {
                BuildingType = (BuildingType)request.BuildingType,
                Name = request.Name,
                CreatedDateUtc = DateTime.UtcNow,
                VolumeIncludingFirstFloor = request.VolumeIncludingFirstFloor,
                Sections = request.Sections != null
                ? request.Sections.Select(section => CreateSection(section)).ToList()
                : new List<Section>(),
                HasParking = request.HasParking,
                CountOfExitGateInParking = request.CountOfExitGateInParking,
                CountFireCompartmentInParking = request.CountFireCompartmentInParking,
                IsRampIsolated = request.IsRampIsolated,
                NumberOfIsolatedRampInFireComaprtment = request.NumberOfIsolatedRampInFireComaprtment,
                Parkings = request.Parkings?.Select(CreateParking).ToList() ?? new List<Parking>(),
            };
        }

        public Building UpdateBuilding(BuildingRequest request, Building existingBuilding)
        {
            existingBuilding.BuildingType = (BuildingType)request.BuildingType;
            existingBuilding.Name = request.Name;
            existingBuilding.UpdatedDateUtc = DateTime.UtcNow;
            existingBuilding.VolumeIncludingFirstFloor = request.VolumeIncludingFirstFloor;
            existingBuilding.Sections = request.Sections.Select(section => CreateSection(section)).ToList();
            existingBuilding.HasParking = request.HasParking;
            existingBuilding.CountOfExitGateInParking = request.CountOfExitGateInParking;
            existingBuilding.CountFireCompartmentInParking = request.CountFireCompartmentInParking;
            existingBuilding.IsRampIsolated = request.IsRampIsolated;
            existingBuilding.NumberOfIsolatedRampInFireComaprtment = request.NumberOfIsolatedRampInFireComaprtment;
            existingBuilding.Parkings = request.Parkings?.Select(CreateParking).ToList() ?? new List<Parking>();

            return existingBuilding;
        }

        private Section CreateSection(SectionRequest sectionRequest)
        {
            return new Section
            {
                Number = sectionRequest.Number,
                TotalAreaOfApartmentsBelow = sectionRequest.TotalAreaOfApartmentsBelow,
                TotalAreaOfBasement = sectionRequest.TotalAreaOfBasement,
                TotalAreaOfTechnicalSpace = sectionRequest.TotalAreaOfTechnicalSpace,
                HasControlRoom = sectionRequest.HasControlRoom,
                TotalAreaOfControlRoom = sectionRequest.TotalAreaOfControlRoom,
                HasServiceCenter = sectionRequest.HasServiceCenter,
                TotalAreaOfServiceCenter = sectionRequest.TotalAreaOfServiceCenter,
                CountOfFloors = sectionRequest.CountOfFloors,
                LowerFireCompartmentNumber = sectionRequest.LowerFireCompartmentNumber,
                CountOfFloorsOfTheLowerFireComaprtment = sectionRequest.CountOfFloorsOfTheLowerFireComaprtment,
                CountOfCorridorsTypicalFloor = sectionRequest.CountOfCorridorsTypicalFloor,
                CountOfFireproofZone = sectionRequest.CountOfFireproofZone,
                Corridors = sectionRequest.Corridors.Select(CreateCorridor).ToList(),
                Elevators = sectionRequest.Elevators.Select(CreateElevator).ToList(),
                Staircases = sectionRequest.Staircases.Select(CreateStaircase).ToList(),
                //SectionCorridors = sectionRequest.Corridors?.Select(corridorRequest =>
                //new SectionCorridor
                //{
                //    Corridor = new Corridor
                //    {
                //        IsConnectTypicalFloorWithFireGateway = corridorRequest.IsConnectTypicalFloorWithFireGateway,
                //        IsConnectTypicalFloorWithFireProfZone = corridorRequest.IsConnectTypicalFloorWithFireProfZone,
                //    }
                //}).ToList() ?? new List<SectionCorridor>(),
                //SectionElevators = sectionRequest.Elevators?.Select(elevatorRequest =>
                //{
                //    var elevator = ElevatorData.Elevators.FirstOrDefault(f => f.TypeOfElevator == (TypeOfElevator)elevatorRequest.TypeOfElevator);
                //    if (elevator == null)
                //    {
                //        throw new InvalidOperationException($"Тип ЛИФТА не найден: {elevatorRequest.TypeOfElevator}");
                //    }
                //    return new SectionElevator { Elevator = elevator };
                //}).ToList() ?? new List<SectionElevator>(),
                //SectionStaircases = sectionRequest.Staircases?.Select(sectionStaircase => new SectionStaircase
                //{
                //    Staircase = new Staircase
                //    {
                //        IsConnectTypicalFloorWithFireProfZone = sectionStaircase.IsConnectTypicalFloorWithFireProfZone,
                //        IsConnectTypicalFloorWithIndividualFireGateway = sectionStaircase.IsConnectTypicalFloorWithIndividualFireGateway,
                //        IsStructuralDivisionOfTheStaircase = sectionStaircase.IsStructuralDivisionOfTheStaircase,
                //        TypeOfTheStaircase = (TypeOfStaircase)sectionStaircase.TypeOfTheStaircase,
                //    }
                //}).ToList() ?? new List<SectionStaircase>(),
                BasementFireCompartmentNumber = sectionRequest.BasementFireCompartmentNumber,
                HasPumpingStationInSectionFireComaprtment = sectionRequest.HasPumpingStationInSectionFireComaprtment,
                TotalAreaOfApartmentsAbove = sectionRequest.TotalAreaOfApartmentsAbove ?? 0.0,
                IntermediateTechnicalFloorNumber = sectionRequest.IntermediateTechnicalFloorNumber ?? 0,
                UpperFireCompartmentNumber = sectionRequest.UpperFireCompartmentNumber ?? 0,
                CountOfFloorsOfFireComaprtment = sectionRequest.CountOfFloorsOfFireComaprtment ?? 0
            };
        }

        private Corridor CreateCorridor(CorridorRequest corridorRequest)
        {
            return new Corridor
            {
                IsConnectTypicalFloorWithFireGateway = corridorRequest.IsConnectTypicalFloorWithFireGateway,
                IsConnectTypicalFloorWithFireProfZone = corridorRequest.IsConnectTypicalFloorWithFireProfZone,
            };
        }

        private Staircase CreateStaircase(StaircaseRequest staircaseRequest)
        {
            return new Staircase
            {
                TypeOfTheStaircase = (TypeOfStaircase)staircaseRequest.TypeOfTheStaircase,
                IsConnectTypicalFloorWithIndividualFireGateway = staircaseRequest.IsConnectTypicalFloorWithIndividualFireGateway,
                IsConnectTypicalFloorWithFireProfZone = staircaseRequest.IsConnectTypicalFloorWithFireProfZone,
                IsStructuralDivisionOfTheStaircase = staircaseRequest.IsStructuralDivisionOfTheStaircase,
            };
        }

        private Elevator CreateElevator(ElevatorRequest elevatorRequest)
        {
            return new Elevator
            {
                TypeOfElevator = (TypeOfElevator)elevatorRequest.TypeOfElevator
            };
        }

        private Parking CreateParking(ParkingRequest parkingRequest)
        {
            return new Parking
            {
                Number = parkingRequest.Number,
                TotalAreaOfParking = parkingRequest.TotalAreaOfParking,
                TotalParkingVoLume = parkingRequest.TotalParkingVolume,
                Elevators = parkingRequest.Elevators.Select(CreateElevator).ToList(),
                //ParkingElevators = parkingRequest.Elevators.Select(elevatorRequest => new ParkingElevator
                //{
                //    Elevator = CreateElevator(elevatorRequest)
                //}).ToList() ?? new List<ParkingElevator>(),
                CountOfFireproofZone = parkingRequest.CountOfFireproofZone,
                CountOfFireGateway = parkingRequest.CountOfFireGateway,
                HasFirePumpStation = parkingRequest.HasFirePumpStation,
                HasPumpStation = parkingRequest.HasPumpStation,
                HasHeatingPoint = parkingRequest.HasHeatingPoint,
                HasShelter = parkingRequest.HasShelter,
                PeopleCountInShelter = parkingRequest.PeopleCountInShelter
            };
        }
    }
}
