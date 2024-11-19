namespace HeatCalc.Data.Models.Heat
{
    public class Heat
    {
        public Guid Id { get; set; }
        public double HeatApartments { get; set; }
        public double HeatPremisesWithoutTech { get; set; }
        public double HeatParking { get; set; }
        public double HeatForVentPremisesWithoutTech { get; set; }
        public double HeatForVentParking { get; set; }
        public int AirCurtains { get; set; }
        public int SpecificHeatLoadApartments { get; set; }
        //в зависимости от площади АР может быть 67 или 77
        public bool ElectricHeating { get; set; }


    }
}
