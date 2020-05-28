using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
    public class Status : Model
    {
		public int id { get; set; }
		public string name { get; set; }

		public Status(int Id, string Name)
		{
			this.id = Id;
			this.name = Name;
		}
	}
}
