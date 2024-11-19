using System.ComponentModel.DataAnnotations;

namespace HeatCalc.Domain.Dto.Request.Archive
{
    public enum TypeOfStaircaseRequest
    {
        [Display(Name = "Лестничная клетка типа Л1")]
        L1,
        [Display(Name = "Лестничная клетка типа Н2")]
        N2,
        [Display(Name = "Лестничная клетка типа Н3")]
        N3,
    }
}
