using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class VehicleWithCompositeKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_DriverId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Vehicle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                columns: new[] { "DriverId", "VehicleTypeId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_DriverId",
                table: "Vehicle",
                column: "DriverId");
        }
    }
}
