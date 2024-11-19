
namespace HeatCalc.Domain.Dto.Response
{
    public class SectionModel
    {
        public int Number { get; set; }
        public double TotalAreaOfApartmentsBelow { get; set; }
        public double TotalAreaOfApartmentsAbove { get; set; }
        public double TotalAreaOfBasement { get; set; }
        public double TotalAreaOfTechnicalSpace { get; set; }
        public bool HasControlRoom { get; set; }
        public double TotalAreaOfControlRoom { get; set; }
        public bool HasServiceCenter { get; set; }
        public double TotalAreaOfServiceCenter { get; set; }
        public int CountOfFloors { get; set; }
        public int LowerFireCompartmentNumber { get; set; }
        public int CountOfFloorsOfTheLowerFireComaprtment { get; set; }
        public int IntermediateTechnicalFloorNumber { get; set; }
        public int UpperFireCompartmentNumber { get; set; }
        public int CountOfFloorsOfTheUpperFireComaprtment { get; set; }
        public int CountOfCorridorsTypicalFloor { get; set; }
        public int CountOfFireproofZone { get; set; }
        public List<CorridorModel> Corridors { get; set; }
        public List<StaircaseModel> Staircases { get; set; }
        public List<ElevatorModel> Elevators { get; set; }
        public int BasementFireCompartmentNumber { get; set; }
        public bool HasPumpingStationInSectionFireComaprtment { get; set; }
        public int CountOfPeopleInShelter { get; set; }
    }
}
