using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Text.RegularExpressions;

namespace RegistryLib
{
	public class Appointment : Model
	{
		string pattern;

		public int id { get; set; }
		public Patient patientId { get; set; }
		public Doctor doctorId { get; set; }

		private string dataTime;
		public string DataTime
		{
			get => dataTime;
			set
			{
				pattern = @"(((0[1-9]|[1-2][0-9]|3[0-1]).(0[1-9]|1[0-2]).(19[0-9]{2}|20[0-2][0-9]|201[0-7])) ([0-1]*[0-9]|2[0-3]):([0-5][0-9]))";
				if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase) || value == "")
					dataTime = value;
				else
					throw new ArgumentException();
			}
		}
		public List<Service> serviceList;

		public Appointment(int Id, int Doctor_id, int Patient_id, string Data_time, List<Service> ServiceList)
		{
			this.id = Id;
			this.doctorId = new Doctor(Doctor_id);
			this.patientId = new Patient(Patient_id);
			this.DataTime = Data_time;
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
			readerData = AllMembers(AppointmentString());
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

		public static string AppointmentString()
		{
			return "SELECT Appointment_Service.appointment, Service.name, Service.price, Appointment.data_time, " +
					"Appointment.doctor_id, Appointment.patient_id, Doctor.surname " +
					"FROM Appointment_Service " +
					"LEFT OUTER JOIN " +
					"Appointment ON Appointment_Service.appointment = Appointment.id " +
					"LEFT OUTER JOIN " +
					"Service ON Appointment_Service.service_id = Service.id " +
					"LEFT OUTER JOIN " +
					"Doctor ON Appointment.doctor_id = Doctor.id ";
		}

		public static DataTable SearchAppointment(int index, string text)
		{
			text = text.Trim();
			DataTable table = new DataTable();
			switch (index)
			{
				case 0:
					{
						readerData = AllMembers(AppointmentString() +
									$"WHERE Appointment.data_time " +
									$"LIKE '%{text}%'");
						table = CreateTable(readerData);

						break;
					}
				case 1:
					{
						readerData = AllMembers(AppointmentString() +
									$"WHERE Appointment.patient_id = {text}");
						table = CreateTable(readerData);

						break;
					}
				case 2:
					{
						readerData = AllMembers(AppointmentString() +
									$"WHERE Doctor.surname " +
									$"LIKE '%{text}%'");
						table = CreateTable(readerData);

						break;
					}
				case 3:
					{
						readerData = AllMembers(AppointmentString() +
												"WHERE Service.name " +
												$"LIKE '%{text}%'");
						table = CreateTable(readerData);

						break;
					}
			}
			return table;
		}

		public static void DeleteAppointment(int id)
		{
			EditMember($"DELETE FROM Appointment_Service " +
						$"WHERE appointment = {id};");

			EditMember($"DELETE FROM Appointment " +
						$"WHERE id = {id};");
		}
	}
}
