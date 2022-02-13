using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveCars.Data.Migrations
{
    public partial class NewConfigMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Vehicle_Price",
                table: "Vehicles",
                type: "numeric(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2)",
                oldMaxLength: 12,
                oldPrecision: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Vehicle_Price",
                table: "Vehicles",
                type: "numeric(2)",
                maxLength: 12,
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(12,2)",
                oldPrecision: 12,
                oldScale: 2);
        }
    }
}
