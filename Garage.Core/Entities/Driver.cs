using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Core.Entities
{
	internal class Driver
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int SSN { get; set; }
        public string Membership { get; set; }
		ICollection<Vehicle> Vehicles { get; set; }
	}
}
