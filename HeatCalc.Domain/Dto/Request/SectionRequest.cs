namespace HeatCalc.Domain.Dto.Request
{
    public class SectionRequest
    {
        public int Number { get; set; }
        public double TotalAreaOfApartmentsBelow { get; set; }
        public double TotalAreaOfBasement { get; set; }
        public double TotalAreaOfTechnicalSpace { get; set; }
        public bool HasControlRoom { get; set; }
        public double TotalAreaOfControlRoom { get; set; }
        public bool HasServiceCenter { get; set; }
        public double TotalAreaOfServiceCenter { get; set; }
        public int CountOfFloors { get; set; }
        public int LowerFireCompartmentNumber { get; set; }
        public int CountOfFloorsOfTheLowerFireComaprtment { get; set; }
        public int CountOfCorridorsTypicalFloor { get; set; }
        public int CountOfFireproofZone { get; set; }
        public List<CorridorRequest> Corridors { get; set; }
        public List<StaircaseRequest> Staircases { get; set; }
        public List<ElevatorRequest> Elevators { get; set; }
        public int BasementFireCompartmentNumber { get; set; }
        public bool HasPumpingStationInSectionFireComaprtment { get; set; }

        public bool IsHighRiseSection { get; set; }
        public double? TotalAreaOfApartmentsAbove { get; set; }
        public int? IntermediateTechnicalFloorNumber { get; set; }
        public int? UpperFireCompartmentNumber { get; set; }
        public int? CountOfFloorsOfFireComaprtment { get; set; }
    }
}
