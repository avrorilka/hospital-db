using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
	public class Appointment
	{
		public int id { get; set; }
		public Patient patientId { get; set; }
		public Doctor doctorId { get; set; }
		public string dataTime { get; set; }

		public Appointment(int Id, int Patient_id, int Doctor_id, string Data_time)
		{
			this.id = Id;
			this.patientId = new Patient(Patient_id);
			this.doctorId = new Doctor (Doctor_id);
			this.dataTime = Data_time;
		}
	}
}
