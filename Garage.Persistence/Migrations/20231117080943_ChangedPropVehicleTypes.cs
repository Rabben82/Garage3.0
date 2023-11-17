using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPropVehicleTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bus",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "Car",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "Truck",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "Ssn",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "ModleName",
                table: "Vehicle",
                newName: "ModelName");

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "VehicleTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Vehicle",
                newName: "ModleName");

            migrationBuilder.AddColumn<int>(
                name: "Bus",
                table: "VehicleTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Car",
                table: "VehicleTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Truck",
                table: "VehicleTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssn",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
