using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
   public class Cabinet : Model
   {
		public int id { get; set; }
		public int cabinetNumber { get; set; }
		public Type type;

		public Cabinet(int id, int Type_id, int Cabinet_number)
		{
			this.id = id;
			this.type = new Type(Type_id);
			this.cabinetNumber = Cabinet_number;
		}
		public Cabinet(int Type_id, int Cabinet_number)
		{
			this.type = new Type(Type_id);
			this.cabinetNumber = Cabinet_number;
		}
		public Cabinet(int Cabinet_number)
		{
			this.cabinetNumber = Cabinet_number;
		}
	}
}
