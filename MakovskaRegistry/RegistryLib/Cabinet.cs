using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
   public class Cabinet
   {
		public int id { get; set; }
		public int cabinet_number { get; set; }
		public Type type;

		public Cabinet(int id, int Type_id, int Cabinet_number)
		{
			this.id = id;
			this.type = new Type(Type_id);
			this.cabinet_number = Cabinet_number;
		}
		public Cabinet(int Type_id, int Cabinet_number)
		{
			this.type = new Type(Type_id);
			this.cabinet_number = Cabinet_number;
		}
		public Cabinet(int id)
		{
			this.id = id;
		}
	}
}
