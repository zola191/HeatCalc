using HeatCalc.Data.Enums;
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
                Sections = request.Sections?.Select(CreateSection).ToList() ?? new List<Section>(),
                IsHighRiseSection = request.IsHighRiseSection,
                HighRiseSections = request.HighRiseSections?.Select(CreateHighRiseSection).ToList() ?? new List<HighRiseSection>(),
                HasParking = request.HasParking,
                CountOfExitGateInParking = request.CountOfExitGateInParking,
                CountFireComaprtmentInParking = request.CountFireComaprtmentInParking,
                IsIsolatedRamp = request.IsIsolatedRamp,
                NumberOfIsolatedRampInFireComaprtment = request.NumberOfIsolatedRampInFireComaprtment,
                Parkings = request.Parkings?.Select(CreateParking).ToList() ?? new List<Parking>(),
                HasShelter = request.HasShelter,
                Shelters = request.Shelters?.Select(CreateShelter).ToList() ?? new List<Shelter>(),
            };
        }

        public Building UpdateBuilding(BuildingRequest request, Building existingBuilding)
        {
            existingBuilding.BuildingType = (BuildingType)request.BuildingType;
            existingBuilding.Name = request.Name;
            existingBuilding.UpdatedDateUtc = DateTime.UtcNow;
            existingBuilding.VolumeIncludingFirstFloor = request.VolumeIncludingFirstFloor;
            existingBuilding.Sections = request.Sections?.Select(CreateSection).ToList() ?? new List<Section>();
            existingBuilding.IsHighRiseSection = request.IsHighRiseSection;
            existingBuilding.HighRiseSections = request.HighRiseSections?.Select(CreateHighRiseSection).ToList() ?? new List<HighRiseSection>();
            existingBuilding.HasParking = request.HasParking;
            existingBuilding.CountOfExitGateInParking = request.CountOfExitGateInParking;
            existingBuilding.CountFireComaprtmentInParking = request.CountFireComaprtmentInParking;
            existingBuilding.IsIsolatedRamp = request.IsIsolatedRamp;
            existingBuilding.NumberOfIsolatedRampInFireComaprtment = request.NumberOfIsolatedRampInFireComaprtment;
            existingBuilding.Parkings = request.Parkings?.Select(CreateParking).ToList() ?? new List<Parking>();
            existingBuilding.HasShelter = request.HasShelter;
            existingBuilding.Shelters = request.Shelters?.Select(CreateShelter).ToList() ?? new List<Shelter>();

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
                Corridors = sectionRequest.Corridors?.Select(CreateCorridor).ToList() ?? new List<Corridor>(),
                Staircases = sectionRequest.Staircases.Select(CreateStaircase).ToList() ?? new List<Staircase>(),
                Elevators = sectionRequest.Elevators.Select(CreateElevator).ToList() ?? new List<Elevator>(),
                BasementFireCompartmentNumber = sectionRequest.BasementFireCompartmentNumber,
                HasPumpingStationInSectionFireComaprtment = sectionRequest.HasPumpingStationInSectionFireComaprtment
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

        private HighRiseSection CreateHighRiseSection(HighRiseSectionRequest highRiseSectionRequest)
        {
            return new HighRiseSection
            {
                TotalAreaOfApartments = highRiseSectionRequest.TotalAreaOfApartments,
                IntermediateTechnicalFloorNumber = highRiseSectionRequest.IntermediateTechnicalFloorNumber,
                UpperFireCompartmentNumber = highRiseSectionRequest.UpperFireCompartmentNumber,
                CountOfFloorsOfFireComaprtment = highRiseSectionRequest.CountOfFloorsOfFireComaprtment
            };
        }

        private Parking CreateParking(ParkingRequest parkingRequest)
        {
            return new Parking
            {
                TotalAreaOfParking = parkingRequest.TotalAreaOfParking,
                TotalParkingVoLume = parkingRequest.TotalParkingVolume,
                Elevators = parkingRequest.Elevators.Select(CreateElevator).ToList() ?? new List<Elevator>(),
                CountOfFireproofZone = parkingRequest.CountOfFireproofZone,
                CountOfFireGateway = parkingRequest.CountOfFireGateway,
                HasFirePumpStation = parkingRequest.HasFirePumpStation,
                HasPumpStation = parkingRequest.HasPumpStation,
                HasHeatingPoint = parkingRequest.HasHeatingPoint
            };
        }

        private Shelter CreateShelter(ShelterRequest shelterRequest)
        {
            return new Shelter
            {
                NumberFireComaprtmentInParking = shelterRequest.NumberFireComaprtmentInParking,
                PeopleCountInShelter = shelterRequest.PeopleCountInShelter
            };
        }

    }
}
