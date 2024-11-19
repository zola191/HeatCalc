namespace HeatCalc.Domain.Dto.Request.Archive

{
    public class StaircaseRequest
    {
        public TypeOfStaircaseRequest TypeOfTheStaircase { get; set; }
        public bool IsConnectTypicalFloorWithIndividualFireGateway { get; set; }
        public bool IsConnectTypicalFloorWithFireProfZone { get; set; }
        public bool IsStructuralDivisionOfTheStaircase { get; set; }
    }
}
