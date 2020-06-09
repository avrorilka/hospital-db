using System;
using System.Collections.Generic;
using System.Text;

namespace RegistryLib
{
    public class Service : Model
    {
		public int id { get; set; }
		public string name { get; set; }
		public double price { get; set; }
		public static List<Service> serviceLists = new List<Service>();

		public Service(int Id, string Name, double Price)
		{
			this.id = Id;
			this.name = Name;
			this.price = Price;
		}
		public Service(string Name, double Price)
		{
			this.name = Name;
			this.price = Price;
		}
		public Service(int Id)
		{
			this.id = Id;
		}

		public static List<Service> DetailedAppointment(int id)
		{
			readerData = AllMembers($"SELECT Appointment_Service.appointment, Appointment.doctor_id, " +
									$"Appointment.patient_id, Appointment.data_time, Service.name, Service.price " +
									$"FROM Appointment_Service " +
									$"LEFT OUTER JOIN " +
									$"Appointment ON Appointment_Service.appointment = Appointment.id " +
									$"LEFT OUTER JOIN " +
									$"Service ON Appointment_Service.service_id = Service.id " +
									$"WHERE Appointment_Service.appointment = {id}");

			serviceLists = new List<Service>();
			while (readerData.Read())
			{
				Service service = new Service(Convert.ToString(readerData[4]), Convert.ToInt32(readerData[5]));
				serviceLists.Add(service);
			}
			return serviceLists;
		}
	}
}
