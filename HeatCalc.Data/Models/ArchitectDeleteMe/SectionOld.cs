using HeatCalc.Data.Models.Building;

namespace HeatCalc.Data.Models.Architect
{
    public class SectionOld
    {
        public Guid Id { get; set; }
        /// <summary>
        /// номер секции в пределах дома
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Общая площадь квартир секции 2-24 этажа
        /// </summary>
        public double TotalAreaOfApartmentsBelow { get; set; }
        /// <summary>
        /// Общая площадь квартир секции с 25 этажа и выше
        /// </summary>
        public double TotalAreaOfApartmentsAbove { get; set; }
        /// <summary>
        /// площадь подвала
        /// </summary>
        public double TotalAreaOfBasement { get; set; }
        /// <summary>
        /// площадь технического пространства над подвалом секции в пожарном отсеке жилья
        /// </summary>
        public double TotalAreaOfTechnicalSpace { get; set; }
        /// <summary>
        /// Наличие ОДС/ЦПУ в секции
        /// </summary>
        public bool HasControlRoom { get; set; }
        /// <summary>
        /// Общая площадь ОДС/ЦПУ
        /// </summary>
        public double TotalAreaOfControlRoom { get; set; }
        /// <summary>
        /// центр обслуживания населения
        /// </summary>
        public bool HasServiceCenter { get; set; }
        public double TotalAreaOfServiceCenter { get; set; }
        /// <summary>
        /// количество этажей
        /// </summary>
        public int CountOfFloors { get; set; }
        /// <summary>
        /// номер нижнего пожарного отсека
        /// </summary>
        public int LowerFireCompartmentNumber { get; set; }
        /// <summary>
        /// количество этажей нижнего пожарного отсека
        /// </summary>
        public int CountOfFloorsOfTheLowerFireComaprtment { get; set; }
        /// <summary>
        /// промежуточный технический этаж
        /// </summary>
        public int IntermediateTechnicalFloorNumber { get; set; }
        /// <summary>
        /// номер верхнего пожарного отсека
        /// </summary>
        public int UpperFireCompartmentNumber { get; set; }
        /// <summary>
        /// количество этажей верхнего пожарного отсека
        /// </summary>
        public int CountOfFloorsOfTheUpperFireComaprtment { get; set; }
        /// <summary>
        /// количество коридоров типового этажа
        /// </summary>
        public int CountOfCorridorsTypicalFloor { get; set; }
        /// <summary>
        /// количество пожаробезопасных зон
        /// </summary>
        public int CountOfFireproofZone { get; set; }
        public List<Corridor> Corridors { get; set; } = new List<Corridor>();
        public List<Staircase> Staircases { get; set; } = new List<Staircase>();
        public List<Elevator> Elevators { get; set; } = new List<Elevator>();

        /// <summary>
        /// номер пож.отсека, в котором расположен подвал секции
        /// </summary>
        public int BasementFireCompartmentNumber { get; set; }
        /// <summary>
        /// Насосная(в пож.отсеке секции)
        /// </summary>
        public bool HasPumpingStationInSectionFireComaprtment { get; set; }
        /// <summary>
        /// количество людей в подвале при отсутствии стоянки
        /// </summary>
        public int CountOfPeopleInShelter { get; set; }

    }
}
