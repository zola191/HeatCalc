﻿using HeatCalc.Domain.Dto.Enums;

namespace HeatCalc.Domain.Dto.Response
{
    public class BuildingModel
    {
        public Guid Id { get; set; }
        public BuildingTypeModel BuildingTypeModel { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public List<SectionModel> Sections { get; set; }
        //public bool IsHighRiseSection { get; set; }
        //public List<HighRiseSectionModel>? HighRiseSections { get; set; }
        public bool HasParking { get; set; }
        public int? CountOfExitGateInParking { get; set; }
        public int? CountFireComaprtmentInParking { get; set; }
        public bool? IsIsolatedRamp { get; set; }
        public int? NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<ParkingModel>? Parkings { get; set; }
        //public bool HasShelter { get; set; }
        //public List<ShelterModel>? Shelters { get; set; }
    }
}
