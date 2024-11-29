namespace HeatCalc.Data.Models.Architect
{
    public class SectionStaircase
    {
        public Guid SectionId { get; set; }
        public Section Section { get; set; }

        public Guid StaircaseId { get; set; }
        public Staircase Staircase { get; set; }
    }
}
