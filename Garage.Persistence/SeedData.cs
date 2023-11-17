using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Garage.Core.Entities;
using Garage3._0.Data;
using Microsoft.EntityFrameworkCore;

namespace Garage.Persistence
{
	public static class SeedData
	{
		private static Faker faker;
		private static Random rnd = new Random();
		public static async Task InitAsync(Garage3_0Context db)
		{
			if (await db.Driver.AnyAsync()) return;

			faker = new Faker("sv");

			var drivers = GenerateDrivers(10);
			await db.AddRangeAsync(drivers);

			var vehicles = GenerateVehicles(20);

			var vehicleTypes = GenerateVehicleTypes(3);
		}

		private static object GenerateVehicleTypes(int numberOfVehicleTypes)
		{
			var vehicleTypes = new List<VehicleTypes>();

			var vehicleType = new VehicleTypes()
			{
				TypeName = GenerateRandomVehicleType()
			};
			vehicleTypes.Add(vehicleType);

			return vehicleTypes;
		}

		private static string GenerateRandomVehicleType()
		{
			string[] vehicleTypeNames = new[] { "Car", "Bus", "Truck" };

		    var typeName = vehicleTypeNames[rnd.Next(vehicleTypeNames.Length)];

		    return typeName;
		}

		private static object GenerateVehicles(int numberOfVehicles)
		{
			var vehicles = new List<Vehicle>();
			var startDate = new DateTime(2022, 1, 1);
			var endDate = new DateTime(2022, 12, 31);

			for (int j = 0; j < numberOfVehicles; j++)
			{
				var model = faker.Vehicle.Model();
				var regNr = faker.Vehicle.Vin();
				var color = faker.Commerce.Color();
				var arrivalTime = faker.Date.Between(startDate, endDate);

				var vehicle = new Vehicle()
				{
					ModelName = model,
					RegNumber = regNr,
					Color = color,
					ArrivalTime = arrivalTime
				};

				vehicles.Add(vehicle);
			}
			return vehicles;
		}

		private static object GenerateDrivers(int numberOfDrivers)
		{
			var drivers = new List<Driver>();

			for (int i = 0; i < numberOfDrivers; i++)
			{
				var fName = faker.Name.FirstName();
				var lName = faker.Name.LastName();
				var membership = "free";
				var dateOfBirth = faker.Person.DateOfBirth;

				var driver = new Driver()
				{
					FirstName = fName,
					LastName = lName,
					DateOfBirth = dateOfBirth,
					Membership = membership
				};

				drivers.Add(driver);
			}
			return drivers;
		}
	}
}
