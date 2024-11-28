
namespace HeatCalc.Domain.Dto.Response
{
    public class ParkingModel
    {
        public int Number { get; set; }
        public double TotalAreaOfParking { get; set; }
        public double TotalParkingVoLume { get; set; }
        public List<ElevatorModel> Elevators { get; set; }
        public int CountOfFireproofZone { get; set; }
        public int CountOfFireGateway { get; set; }
        public bool HasFirePumpStation { get; set; }
        public bool HasPumpStation { get; set; }
        public bool HasHeatingPoint { get; set; }

        public bool HasShelter { get; set; }
        public int PeopleCountInShelter { get; set; }
    }
}
