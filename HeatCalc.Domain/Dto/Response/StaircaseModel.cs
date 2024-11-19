namespace HeatCalc.Domain.Dto.Response
{
    public class StaircaseModel
    {
        public TypeOfStaircaseModel TypeOfTheStaircase { get; set; }
        public bool IsConnectTypicalFloorWithIndividualFireGateway { get; set; }
        public bool IsConnectTypicalFloorWithFireProfZone { get; set; }
        public bool IsStructuralDivisionOfTheStaircase { get; set; }
    }
}
