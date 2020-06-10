using System;
using System.Collections.Generic;

namespace RegistryLib
{
    public class Type : Model
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

		public static List<string> FillTypeBox()
		{
			Model.readerData = Model.AllMembers("SELECT name FROM Type");
			List<string> typeList = new List<string>();
			while (Model.readerData.Read())
			{
				typeList.Add(Convert.ToString(Model.readerData[0]));
			}
			Model.Closer(Model.readerData);

			return typeList;
		}
	}
}
