using HeatCalc.Data.Models.Architect;

namespace HeatCalc.Data.Models.Building
{
    public class Section : ISection
    {
        public Guid Id { get; set; }
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
        public List<Corridor> Corridors { get; set; }
        public List<Staircase> Staircases { get; set; }
        public List<Elevator> Elevators { get; set; }
        public int BasementFireCompartmentNumber { get; set; }
        public bool HasPumpingStationInSectionFireComaprtment { get; set; }
    }
}
