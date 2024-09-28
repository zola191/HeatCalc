
namespace HeatCalcServer.Domain
{
    public class Architect
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        //сумма площадей всех секций жилого дома
        //public decimal TotalAreaOfApartments { get; set; }
        public int SectionsCount { get; set; }
        public decimal VolumeIncludingFirstFloor { get; set; }
        public bool HasParking { get; set; }
        public bool HasShelter {  get; set; }
        public List<Section> Sections { get; set; }
    }
}
