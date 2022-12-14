using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

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
			Closer(readerData);

			return serviceLists;
		}

		public static DataTable CreateTable(SQLiteDataReader readerData)
		{
			DataTable table = new DataTable();

			table.Columns.Add("id");
			table.Columns.Add("Назва");
			table.Columns.Add("Ціна");

			while (readerData.Read())
				table.Rows.Add(readerData[0], readerData[1], readerData[2]);

			return table;
		}
		public static DataTable AllMembersTable()
		{
			readerData = AllMembers("SELECT * From Service");
			DataTable table = CreateTable(readerData);
			Closer(readerData);

			return table;
		}

		public static void AddService(int id, int serviceId)
		{
			Closer(readerData);

			EditMember("INSERT INTO Appointment_Service(appointment, service_id) " +
						$"VALUES ({id},{serviceId})");
		}
		public static void RemoveService(int id, int serviceId)
		{
			Closer(readerData);

			EditMember($"DELETE FROM Appointment_Service " +
						$"WHERE appointment = {id} AND service_id = {serviceId}");
		}

		public static DataTable SearchAppointment(string text)
		{
			Closer(readerData);

			text = text.Trim();
			DataTable table = new DataTable();

			readerData = AllMembers("SELECT * From Service " +
						$"WHERE name " +
						$"LIKE '%{text}%'");
			table = CreateTable(readerData);
			Closer(readerData);

			return table;
		}


	}
}
