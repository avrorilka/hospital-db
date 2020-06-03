using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
	public class Appointment
	{
		public int id { get; set; }
		public Patient patient_id { get; set; }
		public Doctor doctor_id { get; set; }
		public string data_time { get; set; }

		public Appointment(int Id, int Patient_id, int Doctor_id, string Data_time)
		{
			this.id = Id;
			this.patient_id = new Patient(Patient_id);
			this.doctor_id = new Doctor (Doctor_id);
			this.data_time = Data_time;
		}
	}
}
