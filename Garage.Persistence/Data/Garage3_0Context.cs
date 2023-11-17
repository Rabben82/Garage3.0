using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage.Core.Entities;

namespace Garage3._0.Data
{
	public class Garage3_0Context : DbContext
	{
		public Garage3_0Context (DbContextOptions<Garage3_0Context> options)
			: base(options)
		{
		}

		public DbSet<Driver> Driver { get; set; } = default!;
		public DbSet<Vehicle> Vehicle { get; set; } = default!;
		public DbSet<VehicleTypes> VehicleTypes { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//makes this 2 primary key
			modelBuilder.Entity<Vehicle>().HasKey(v => new { v.DriverId, v.VehicleTypeId });
		}
	}
}
