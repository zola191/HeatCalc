
using HeatCalc.Data.Models.Building;

namespace HeatCalc.Data.Models.Interfaces
{
    public interface IHighRiseBuilding
    {
        /// <summary>
        /// пожарные отсеки высотного здания
        /// </summary>
        List<HighRiseSection> HighRiseSections { get; set; }
    }
}
