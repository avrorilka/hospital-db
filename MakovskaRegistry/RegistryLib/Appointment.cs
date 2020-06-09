using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace RegistryLib
{
	public class Appointment : Model
	{
		public int id { get; set; }
		public int patientId { get; set; }
		public int doctorId { get; set; }
		public string dataTime { get; set; }
		public List<Service> serviceList;

		public Appointment(int Id, int Doctor_id, int Patient_id, string Data_time, List<Service> ServiceList)
		{
			this.id = Id;
			this.doctorId = Doctor_id;
			this.patientId = Patient_id;
			this.dataTime = Data_time;
			this.serviceList = ServiceList;
		}
		public Appointment() { }
		public static DataTable CreateTable(SQLiteDataReader readerData)
		{
			DataTable table = new DataTable();

			table.Columns.Add("№ зустрічі");
			table.Columns.Add("Назва");
			table.Columns.Add("Ціна");
			table.Columns.Add("Дата");

			while (readerData.Read())
				table.Rows.Add(readerData[0], readerData[1], readerData[2], readerData[3]);

			return table;
		}
		public static DataTable AllMembersTable()
		{
			readerData = AllMembers("SELECT Appointment_Service.appointment, Service.name, " +
									"Service.price, Appointment.data_time " +
									"FROM Appointment_Service " +
									"LEFT OUTER JOIN " +
									"Appointment ON Appointment_Service.appointment = Appointment.id " +
									"LEFT OUTER JOIN " +
									"Service ON Appointment_Service.service_id = Service.id");
			DataTable table = CreateTable(readerData);
			return table;
		}
		public static Appointment DetailedAppointment(int id)
		{
			Appointment appointment;
			readerData = AllMembers($"SELECT Appointment_Service.appointment, Appointment.doctor_id, " +
									$"Appointment.patient_id, Appointment.data_time, Service.name, Service.price " +
									$"FROM Appointment_Service " +
									$"LEFT OUTER JOIN " +
									$"Appointment ON Appointment_Service.appointment = Appointment.id " +
									$"LEFT OUTER JOIN " +
									$"Service ON Appointment_Service.service_id = Service.id " +
									$"WHERE Appointment_Service.appointment = {id}");
			while (readerData.Read()) 
			{
				int appId = Convert.ToInt32(readerData[0]);
				int doctorId = Convert.ToInt32(readerData[1]);
				int patientId = Convert.ToInt32(readerData[2]);
				string dataTime = Convert.ToString(readerData[3]);

				Service.serviceLists = Service.DetailedAppointment(id);
				appointment = new Appointment(appId, doctorId, patientId, dataTime, Service.serviceLists);
				return appointment;
			}
			Appointment newApp = new Appointment();
			return newApp;
		}
	}
}
