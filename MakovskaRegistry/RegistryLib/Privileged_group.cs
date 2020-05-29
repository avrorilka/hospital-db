using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
	public class Privileged_group
	{
		public int id { get; set; }
		public string name { get; set; }
		public double discount_percent { get; set; }

		public Privileged_group(int Id, string Name, double Discount_percent)
		{
			this.id = Id;
			this.name = Name;
			this.discount_percent = Discount_percent;
		}
		public Privileged_group(int Id)
		{
			this.id = Id;
		}
	}
}
