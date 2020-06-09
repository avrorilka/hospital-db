using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
    public class Service
    {
		public int id { get; set; }
		public string name { get; set; }
		public double price { get; set; }
		public static List<Service> serviceLists = new List<Service>();

		public Service(int Id, string Name, double Price)
		{
			this.id = Id;
			this.name = Name;
			this.price = Price;
		}
		public Service(string Name, double Price)
		{
			this.name = Name;
			this.price = Price;
		}
		public Service(int Id)
		{
			this.id = Id;
		}
	}
}
