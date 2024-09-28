using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HeatCalcServer.Domain
{
    public class Section
    {
        public Guid Id { get; set; }
        //номер секции в пределах дома
        public int Number { get; set; }
        //Общая площадь квартир секции 2-24 этажа
        public decimal TotalAreaOfApartmentsBelow { get; set; }
        //Общая площадь квартир секции с 25 этажа и выше
        public decimal TotalAreaOfApartmentsAbove { get; set; }
        //площадь подвала
        public decimal TotalAreaOfBasement { get; set; }
        //площадь технического пространства
        public decimal TotalAreaOfTechnicalSpace { get; set; }
        //Наличие ОДС/ЦПУ в секции
        public bool HasControlRoom { get; set; }
        public decimal TotalAreaOfControlRoom { get; set; }
        //центр обслуживания населения
        public bool HasServiceCenter { get; set; }
        public decimal TotalAreaOfServiceCenter { get; set; }
        //количество этажей
        public int NumberOfFloors { get; set; }
        //

    }
}
