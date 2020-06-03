using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
	public class Doctor
	{
		public int id { get; set; }
		public string first_name { get; set; }
		public string surname { get; set; }
		public string middle_name { get; set; }
		public Cabinet cabinet;

		public Doctor(int Id, string First_name, string Surname, string Middle_name, int Cabinet_id)
		{
			this.id = Id;
			this.first_name = First_name;
			this.surname = Surname;
			this.middle_name = Middle_name;
			this.cabinet = new Cabinet(Cabinet_id);
		}
	}
}
