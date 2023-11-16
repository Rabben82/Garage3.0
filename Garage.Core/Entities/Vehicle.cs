using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Core.Entities
{
	internal class Vehicle
	{
		public int Id { get; set; }
		public string ModleName { get; set; }
		public string RegNumber { get; set; }
		public string Color { get; set; }
		public DateTime ArrivalTime { get; set; }
		//Foreign Key
		public int DriverId { get; set; }
		public int VehicleTypeId { get; set; }
		//NAV Property
		public Driver Driver { get; set; }
		public VehicleTypes VehicleTypes { get; set; }	
	}
}
