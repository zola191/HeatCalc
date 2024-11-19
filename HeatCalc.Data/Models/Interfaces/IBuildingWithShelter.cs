using HeatCalc.Data.Models.Building;

namespace HeatCalc.Data.Models.Interfaces
{
    public interface IBuildingWithShelter
    {
        List<Shelter> Shelters { get; set; }
    }
}
