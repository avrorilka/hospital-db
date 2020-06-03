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
		public Status(int Id)
		{
			this.id = Id;
		}

		public static List<string> FillStatusBox()
		{
			Model.readerData = Model.AllMembers("SELECT name FROM Status");
			List<string> statusList = new List<string>();
			statusList.Add("");
			while (Model.readerData.Read())
			{
				statusList.Add(Convert.ToString(Model.readerData[0]));
			}
			Model.Closer(Model.readerData);

			return statusList;
		}

	}
}
