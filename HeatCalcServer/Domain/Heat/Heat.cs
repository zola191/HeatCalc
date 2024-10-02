
namespace HeatCalcServer.Domain.Heat
{
    public class Heat
    {
        public static readonly int SpecificHeatLoadApartments; //в зависимости от площади АР может быть 67 или 77
        public static readonly int SpecificHeatLoadPremisesWithoutTech = 70;
        public static readonly int SpecificHeatLoadParking = 28;
        public static readonly double OutdoorTemp = 28;
        public static readonly double PremisesWithoutTechTemp = 18;
        public static readonly double AverageTemp = 20;
        public static readonly double ParkingTemp = 15;
        public static readonly double AreaPerPersonForPremisesWithoutTech = 20;
        public static readonly double SupplyAirFlowForPremisesWithoutTech = 60;
        public static readonly double SupplyAirFlowForControlRoom = 1500;
        public static readonly double SupplyAirFlowForServiceRoom = 1200;
        public static readonly bool ElectricHeating = false;
        public static readonly double SupplyAirFlowVForentilationChamber = 500;
        public static readonly double SupplyAirFlowFroPersonInShelter = 10;

        public const double CoefSafetyHeatApartments = 1.1;
        public const double CoefSafetyHeatPremisesWithoutTech = 1.1;
        public const double CoefSafetyHeatParking = 1.0;
        public const double CoefSafetyVentilationParking = 1.1;
        public const int HeatPerCurtain = 100;


        public double HeatApartments { get; set; }
        public double HeatPremisesWithoutTech { get; set; }
        public double HeatParking { get; set; }
        public double HeatForVentPremisesWithoutTech { get; set; }
        public double HeatForVentParking { get; set; }
        public int AirCurtains { get; set; }

    }
}
