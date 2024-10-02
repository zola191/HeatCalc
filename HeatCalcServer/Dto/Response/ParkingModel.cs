namespace HeatCalcServer.Dto.Response
{
    public class ParkingModel
    {
        public double TotalAreaOfParking { get; set; }
        public double TotalParkingVoLume { get; set; }
        public List<ElevatorModel> Elevators { get; set; }
        public int CountOfFireproofZone { get; set; }
        public int CountOfFireGateway { get; set; }
        public bool HasFirePumpStation { get; set; }
        public bool HasPumpStation { get; set; }
        public bool HasHeatingPoint { get; set; }
        public int CountOfPeopleInShelter { get; set; }
    }
}
