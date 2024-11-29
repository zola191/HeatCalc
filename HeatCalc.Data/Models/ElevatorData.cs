
using HeatCalc.Data.Enums;
using HeatCalc.Data.Models.Architect;

namespace HeatCalc.Data.Models
{
    public static class ElevatorData
    {
        public static List<Elevator> Elevators { get; } = new List<Elevator>
        {
            new Elevator { TypeOfElevator = TypeOfElevator.FireDepartment},
            new Elevator { TypeOfElevator = TypeOfElevator.Freight }
        };
    }
}
