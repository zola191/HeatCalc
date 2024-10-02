using System.ComponentModel.DataAnnotations;

namespace HeatCalcServer.Dto.Request
{
    public enum TypeOfElevatorRequest
    {
        [Display(Name = "Грузовой лифт")]
        Freight,
        [Display(Name = "Пассажирский лифт")]
        Passenger,
        [Display(Name = "Перевозка пожарных подразделений")]
        FireDepartment
    }
}
