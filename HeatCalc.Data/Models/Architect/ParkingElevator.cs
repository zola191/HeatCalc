
using HeatCalc.Data.Enums;

namespace HeatCalc.Data.Models.Architect
{
    public class ParkingElevator
    {
        public Guid ParkingId { get; set; }
        public Parking Parking { get; set; }

        public TypeOfElevator ElevatorType { get; set; }
        public Elevator Elevator { get; set; }
    }
}
