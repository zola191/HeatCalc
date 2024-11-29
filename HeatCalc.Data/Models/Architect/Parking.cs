using HeatCalc.Data.Enums;

namespace HeatCalc.Data.Models.Architect
{
    public class Parking
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Building Building { get; set; }
        public int Number { get; set; }
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
        /// количество пожаробезопасных зон
        /// </summary>
        public int CountOfFireproofZone { get; set; }
        /// <summary>
        /// Количество тамбур-шлюзов в пожарном отсеке стоянки
        /// </summary>
        public int CountOfFireGateway { get; set; }
        /// <summary>
        /// Насосная пожаротушения (в пож.отсеке секции)
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
        /// Наличие укрытия в автостоянке
        /// </summary>
        public bool HasShelter { get; set; }
        /// <summary>
        /// Количество людей в укрытии
        /// </summary>
        public int PeopleCountInShelter { get; set; }
        public List<Elevator> Elevators { get; set; }
    }
}
