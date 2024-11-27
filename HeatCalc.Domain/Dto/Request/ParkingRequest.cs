namespace HeatCalc.Domain.Dto.Request
{
    public class ParkingRequest
    {
        public int Number { get; set; }
        public double TotalAreaOfParking { get; set; }
        public double TotalParkingVolume { get; set; }
        public List<ElevatorRequest> Elevators { get; set; }
        public int CountOfFireproofZone { get; set; }
        public int CountOfFireGateway { get; set; }
        public bool HasFirePumpStation { get; set; }
        public bool HasPumpStation { get; set; }
        public bool HasHeatingPoint { get; set; }

        public bool HasShelter { get; set; }
        //public int NumberFireComaprtmentInParking { get; set; }
        public int PeopleCountInShelter { get; set; }
    }
}
