using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
	public class Schedule
	{
		public int id { get; set; }
		public int doctor_id { get; set; }
		public string timeStart { get; set; }
		public string timeEnd { get; set; }

		public Schedule(int Id, int doctor_id, string time_start, string time_end)
		{
			this.id = Id;
			this.doctor_id = doctor_id;
			this.timeStart = time_start;
			this.timeEnd = time_end;
		}
		public Schedule(string time_start, string time_end)
		{
			this.timeStart = time_start;
			this.timeEnd = time_end;
		}

	}
}
