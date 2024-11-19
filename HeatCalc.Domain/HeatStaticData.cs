namespace HeatCalc.Domain
{
    public static class HeatStaticData
    {
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

        public static readonly double SupplyAirFlowVForentilationChamber = 500;
        public static readonly double SupplyAirFlowFroPersonInShelter = 10;

        public const double CoefSafetyHeatApartments = 1.1;
        public const double CoefSafetyHeatPremisesWithoutTech = 1.1;
        public const double CoefSafetyHeatParking = 1.0;
        public const double CoefSafetyVentilationParking = 1.1;
        public const int HeatPerCurtain = 100;

    }
}
