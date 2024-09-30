using System.ComponentModel.DataAnnotations;

namespace HeatCalcServer.Enums
{
    public enum TypeOfElevator
    {
        [Display(Name = "Грузовой лифт")]
        Freight,
        [Display(Name = "Пассажирский лифт")]
        Passenger,
        [Display(Name = "Перевозка пожарных подразделений")]
        FireDepartment
    }
}
