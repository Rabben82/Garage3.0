using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Core.Entities
{
	public class VehicleTypes
	{
		public int Id { get; set; }
		public string TypeName { get; set; } 
		//Foreign Key
		public int VehicleId { get; set; }
		//NAV Prop
		public ICollection<Vehicle> Vehicle { get; set; } = new List<Vehicle>();
	}
}
