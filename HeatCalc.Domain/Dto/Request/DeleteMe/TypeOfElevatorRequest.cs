﻿using System.ComponentModel.DataAnnotations;

namespace HeatCalc.Domain.Dto.Request.Archive
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