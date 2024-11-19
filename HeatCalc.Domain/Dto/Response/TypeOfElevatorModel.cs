using System.ComponentModel.DataAnnotations;

namespace HeatCalc.Domain.Dto.Response
{
    public enum TypeOfElevatorModel
    {
        [Display(Name = "Грузовой лифт")]
        Freight,
        [Display(Name = "Пассажирский лифт")]
        Passenger,
        [Display(Name = "Перевозка пожарных подразделений")]
        FireDepartment
    }
}
