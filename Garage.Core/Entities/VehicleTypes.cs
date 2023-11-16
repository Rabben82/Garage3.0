using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Core.Entities
{
	internal class VehicleTypes
	{
		public int Id { get; set; }
		public int Car { get; set; } 
		public int Bus { get; set; } 
		public int Truck { get; set; }
		//Foreign Key
		public int VehicleId { get; set; }
		//NAV Prop
		public ICollection<Vehicle> Vehicle { get; set; }
	}
}
