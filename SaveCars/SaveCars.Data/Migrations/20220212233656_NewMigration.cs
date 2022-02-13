using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveCars.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fabricator_Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Vehicle_Model = table.Column<string>(type: "varchar(50)", nullable: false),
                    Vehicle_Information = table.Column<string>(type: "varchar(200)", nullable: false),
                    Vehicle_Plate = table.Column<string>(type: "varchar(8)", nullable: false),
                    Vehicle_Year = table.Column<string>(type: "varchar(9)", nullable: false),
                    Vehicle_Price = table.Column<decimal>(type: "numeric(2)", precision: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Vehicle", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Vehicle_Model",
                table: "Vehicles",
                column: "Vehicle_Model",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Vehicle_Plate",
                table: "Vehicles",
                column: "Vehicle_Plate",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
