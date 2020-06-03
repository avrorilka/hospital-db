using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
	public class Schedule
	{
		public int id { get; set; }
		public int doctor_id { get; set; }
		public string time_start { get; set; }
		public string time_end { get; set; }

		public Schedule(int Id, int doctor_id_, string time_start_, string time_end_)
		{
			this.id = Id;
			this.doctor_id = doctor_id_;
			this.time_start = time_start_;
			this.time_end = time_end_;
		}
	}
}
