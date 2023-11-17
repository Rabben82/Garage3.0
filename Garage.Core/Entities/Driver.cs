using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Core.Entities
{
	public class Driver
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string FullName => $"{FirstName} {LastName}";
		public DateTime DateOfBirth { get; set; } = new DateTime();
		public string Membership { get; set; } = string.Empty;
		ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
	}
}
