﻿using HeatCalcServer.Dto.Response;

namespace HeatCalcServer.Dto.Request
{
    public class ArchitectRequest
    {
        public string Name { get; set; }
        public int SectionsCount { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public bool HasParking { get; set; }
        public bool HasShelter { get; set; }
        public List<SectionModel> Sections { get; set; }
        public int CountFireComaprtmentInParking { get; set; }
        public int CountOfExitGateInParking { get; set; }
        public bool IsIsolatedRamp { get; set; }
        public int NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<ParkingModel> Parkings { get; set; }
    }
}
