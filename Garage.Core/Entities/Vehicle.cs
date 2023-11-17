using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Core.Entities
{
	public class Vehicle
	{
		//public int Id { get; set; }
		public string ModelName { get; set; } = string.Empty;
		public string RegNumber { get; set; } = string.Empty;
		public string Color { get; set; } = string.Empty;
		public DateTime ArrivalTime { get; set; }
		//Foreign Key
		public int DriverId { get; set; }
		public int VehicleTypeId { get; set; }
		//NAV Property
		public Driver Driver { get; set; } = new Driver();
		public VehicleTypes VehicleTypes { get; set; } = new VehicleTypes();
	}
}
