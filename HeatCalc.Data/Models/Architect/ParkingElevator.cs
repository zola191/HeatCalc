
namespace HeatCalc.Data.Models.Architect
{
    public class ParkingElevator
    {
        public Guid ParkingId { get; set; }
        public Parking Parking { get; set; }

        public Guid ElevatorId { get; set; }
        public Elevator Elevator { get; set; }
    }
}
