using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeatCalc.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Corridors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsConnectTypicalFloorWithFireGateway = table.Column<bool>(type: "bit", nullable: false),
                    IsConnectTypicalFloorWithFireProfZone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corridors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elevators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfElevator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elevators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeatApartments = table.Column<double>(type: "float", nullable: false),
                    HeatPremisesWithoutTech = table.Column<double>(type: "float", nullable: false),
                    HeatParking = table.Column<double>(type: "float", nullable: false),
                    HeatForVentPremisesWithoutTech = table.Column<double>(type: "float", nullable: false),
                    HeatForVentParking = table.Column<double>(type: "float", nullable: false),
                    AirCurtains = table.Column<int>(type: "int", nullable: false),
                    SpecificHeatLoadApartments = table.Column<int>(type: "int", nullable: false),
                    ElectricHeating = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staircases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeOfTheStaircase = table.Column<int>(type: "int", nullable: false),
                    IsConnectTypicalFloorWithIndividualFireGateway = table.Column<bool>(type: "bit", nullable: false),
                    IsConnectTypicalFloorWithFireProfZone = table.Column<bool>(type: "bit", nullable: false),
                    IsStructuralDivisionOfTheStaircase = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staircases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VolumeIncludingFirstFloor = table.Column<double>(type: "float", nullable: false),
                    HasParking = table.Column<bool>(type: "bit", nullable: false),
                    CountOfExitGateInParking = table.Column<int>(type: "int", nullable: true),
                    CountFireCompartmentInParking = table.Column<int>(type: "int", nullable: true),
                    IsRampIsolated = table.Column<bool>(type: "bit", nullable: true),
                    NumberOfIsolatedRampInFireComaprtment = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Heats_HeatId",
                        column: x => x.HeatId,
                        principalTable: "Heats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    TotalAreaOfParking = table.Column<double>(type: "float", nullable: false),
                    TotalParkingVoLume = table.Column<double>(type: "float", nullable: false),
                    CountOfFireproofZone = table.Column<int>(type: "int", nullable: false),
                    CountOfFireGateway = table.Column<int>(type: "int", nullable: false),
                    HasFirePumpStation = table.Column<bool>(type: "bit", nullable: false),
                    HasPumpStation = table.Column<bool>(type: "bit", nullable: false),
                    HasHeatingPoint = table.Column<bool>(type: "bit", nullable: false),
                    HasShelter = table.Column<bool>(type: "bit", nullable: false),
                    PeopleCountInShelter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parking_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    TotalAreaOfApartmentsBelow = table.Column<double>(type: "float", nullable: false),
                    TotalAreaOfBasement = table.Column<double>(type: "float", nullable: false),
                    TotalAreaOfTechnicalSpace = table.Column<double>(type: "float", nullable: false),
                    HasControlRoom = table.Column<bool>(type: "bit", nullable: false),
                    TotalAreaOfControlRoom = table.Column<double>(type: "float", nullable: false),
                    HasServiceCenter = table.Column<bool>(type: "bit", nullable: false),
                    TotalAreaOfServiceCenter = table.Column<double>(type: "float", nullable: false),
                    CountOfFloors = table.Column<int>(type: "int", nullable: false),
                    LowerFireCompartmentNumber = table.Column<int>(type: "int", nullable: false),
                    CountOfFloorsOfTheLowerFireComaprtment = table.Column<int>(type: "int", nullable: false),
                    CountOfCorridorsTypicalFloor = table.Column<int>(type: "int", nullable: false),
                    CountOfFireproofZone = table.Column<int>(type: "int", nullable: false),
                    BasementFireCompartmentNumber = table.Column<int>(type: "int", nullable: false),
                    HasPumpingStationInSectionFireComaprtment = table.Column<bool>(type: "bit", nullable: false),
                    IsHighRiseSection = table.Column<bool>(type: "bit", nullable: false),
                    TotalAreaOfApartmentsAbove = table.Column<double>(type: "float", nullable: false),
                    IntermediateTechnicalFloorNumber = table.Column<int>(type: "int", nullable: false),
                    UpperFireCompartmentNumber = table.Column<int>(type: "int", nullable: false),
                    CountOfFloorsOfFireComaprtment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElevatorParking",
                columns: table => new
                {
                    ElevatorsId = table.Column<int>(type: "int", nullable: false),
                    ParkingsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElevatorParking", x => new { x.ElevatorsId, x.ParkingsId });
                    table.ForeignKey(
                        name: "FK_ElevatorParking_Elevators_ElevatorsId",
                        column: x => x.ElevatorsId,
                        principalTable: "Elevators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElevatorParking_Parking_ParkingsId",
                        column: x => x.ParkingsId,
                        principalTable: "Parking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorridorSection",
                columns: table => new
                {
                    CorridorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorridorSection", x => new { x.CorridorsId, x.SectionsId });
                    table.ForeignKey(
                        name: "FK_CorridorSection_Corridors_CorridorsId",
                        column: x => x.CorridorsId,
                        principalTable: "Corridors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorridorSection_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElevatorSection",
                columns: table => new
                {
                    ElevatorsId = table.Column<int>(type: "int", nullable: false),
                    SectionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElevatorSection", x => new { x.ElevatorsId, x.SectionsId });
                    table.ForeignKey(
                        name: "FK_ElevatorSection_Elevators_ElevatorsId",
                        column: x => x.ElevatorsId,
                        principalTable: "Elevators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElevatorSection_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionStaircase",
                columns: table => new
                {
                    SectionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaircasesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionStaircase", x => new { x.SectionsId, x.StaircasesId });
                    table.ForeignKey(
                        name: "FK_SectionStaircase_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionStaircase_Staircases_StaircasesId",
                        column: x => x.StaircasesId,
                        principalTable: "Staircases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_HeatId",
                table: "Buildings",
                column: "HeatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CorridorSection_SectionsId",
                table: "CorridorSection",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ElevatorParking_ParkingsId",
                table: "ElevatorParking",
                column: "ParkingsId");

            migrationBuilder.CreateIndex(
                name: "IX_ElevatorSection_SectionsId",
                table: "ElevatorSection",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Parking_BuildingId",
                table: "Parking",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_BuildingId",
                table: "Sections",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionStaircase_StaircasesId",
                table: "SectionStaircase",
                column: "StaircasesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorridorSection");

            migrationBuilder.DropTable(
                name: "ElevatorParking");

            migrationBuilder.DropTable(
                name: "ElevatorSection");

            migrationBuilder.DropTable(
                name: "SectionStaircase");

            migrationBuilder.DropTable(
                name: "Corridors");

            migrationBuilder.DropTable(
                name: "Parking");

            migrationBuilder.DropTable(
                name: "Elevators");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Staircases");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Heats");
        }
    }
}
