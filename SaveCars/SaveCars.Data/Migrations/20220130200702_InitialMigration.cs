using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveCars.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document_Number = table.Column<string>(type: "varchar(12)", nullable: false),
                    Vehicle_Plate = table.Column<string>(type: "varchar(8)", nullable: false),
                    Document_Tax = table.Column<decimal>(type: "numeric(2)", precision: 2, nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Document", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fabricators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fabricator_Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Fabricator_Nationality = table.Column<string>(type: "varchar(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Fabricator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vehicle_Model = table.Column<string>(type: "varchar(50)", nullable: false),
                    Vehicle_Information = table.Column<string>(type: "varchar(200)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Price = table.Column<decimal>(type: "numeric(2)", precision: 2, nullable: false),
                    FabricatorId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Fabricators_FabricatorId",
                        column: x => x.FabricatorId,
                        principalTable: "Fabricators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_Document_Number",
                table: "Documents",
                column: "Document_Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Documents_Vehicle_Plate",
                table: "Documents",
                column: "Vehicle_Plate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DocumentId",
                table: "Vehicles",
                column: "DocumentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FabricatorId",
                table: "Vehicles",
                column: "FabricatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Vehicle_Model",
                table: "Vehicles",
                column: "Vehicle_Model",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Fabricators");
        }
    }
}
