namespace HeatCalcServer.Domain
{
    public class Parking
    {
        /// <summary>
        /// Площадь всех помещений автостоянки и рампы (если есть) 
        /// в пределах пожарного отсека в том числе технических кроме ИТП, м2
        /// </summary>
        public double TotalAreaOfParking { get; set; }
        /// <summary>
        /// Объем автостоянки без учета технических помещений автостоянки, м3
        /// </summary>
        public double TotalParkingVoLume { get; set; }
        /// <summary>
        /// Количество лифтов с режимом "Перевозка пожарных подразделений" с опуском в пожарный отсек стоянки
        /// </summary>
        public List<Elevator> Elevators { get; set; }
        /// <summary>
        /// количество пожаробезопасных зон
        /// </summary>
        public int CountOfFireproofZone { get; set; }
        /// <summary>
        /// Количество тамбур-шлюзов в пожарном отсеке стоянки
        /// </summary>
        public int CountOfFireGateway { get; set; }
        /// <summary>
        /// Насосная (в пож.отсеке секции)
        /// </summary>
        public bool HasFirePumpStation { get; set; }
        /// <summary>
        /// Насосная (в пож.отсеке секции)
        /// </summary>
        public bool HasPumpStation { get; set; }
        /// <summary>
        /// Помещение ИТП (в пож.отсеке секции)
        /// </summary>
        public bool HasHeatingPoint { get; set; }

        /// <summary>
        /// количество людей в укрытии
        /// </summary>
        public int CountOfPeopleInShelter { get; set; }
    }
}
