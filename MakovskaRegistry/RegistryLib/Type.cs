using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
    public class Type
    {
		public int id { get; set; }
		public string name { get; set; }

		public Type(int Id, string Name)
		{
			this.id = Id;
			this.name = Name;
		}
		public Type(string Name)
		{
			this.name = Name;
		}
		public Type(int Id)
		{
			this.id = Id;
		}
	}
}
