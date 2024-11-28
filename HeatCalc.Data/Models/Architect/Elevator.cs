using HeatCalc.Data.Enums;

namespace HeatCalc.Data.Models.Architect
{
    public class Elevator
    {
        public TypeOfElevator TypeOfElevator { get; set; }
        public List<SectionElevator> SectionElevators { get; set; }
        public List<ParkingElevator> ParkingElevators { get; set; }

    }
}
