using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Text.RegularExpressions;

namespace RegistryLib
{
	public class Doctor : Model
	{
		string pattern;

		public int id { get; set; }

		private string firstName;
		public string FirstName
		{
			get => firstName;
			set
			{
				pattern = @"([А-ЯІЇЄҐ][а-яіїєґ\-’]+)";
				if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase))
					firstName = value;
				else
					throw new ArgumentException();
			}
		}

		private string surname;
		public string Surname
		{
			get => surname;
			set
			{
				pattern = @"([А-ЯІЇЄҐ][а-яіїєґ\-’]+)";
				if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase))
					surname = value;
				else
					throw new ArgumentException();
			}
		}

		private string middleName;
		public string MiddleName
		{
			get => middleName;
			set
			{
				pattern = @"([А-ЯІЇЄҐ][а-яіїєґ\-’]+)";
				if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase) || String.IsNullOrWhiteSpace(value))
					middleName = value;
				else
					throw new ArgumentException();
			}
		}

		public Cabinet cabinet;
		public Type type;
		public Schedule schedule;

		public Doctor(int Id, string First_name, string Surname, string Middle_name, int Cabinet_id)
		{
			this.id = Id;
			this.FirstName = First_name;
			this.Surname = Surname;
			this.MiddleName = Middle_name;
			this.cabinet = new Cabinet(Cabinet_id);
		}
		public Doctor(int Id, string First_name, string Surname, string Middle_name, 
					  int CabinetNumb, string TypeName, string TimeStart, string TimeEnd)
		{
			this.id = Id;
			this.FirstName = First_name;
			this.Surname = Surname;
			this.MiddleName = Middle_name;
			this.cabinet = new Cabinet(CabinetNumb);
			this.type = new Type(TypeName);
			this.schedule = new Schedule(TimeStart, TimeEnd);
		}
		public Doctor(string First_name, string Surname, string Middle_name,
					  int CabinetNumb, string TypeName, string TimeStart, string TimeEnd)
		{
			this.FirstName = First_name;
			this.Surname = Surname;
			this.MiddleName = Middle_name;
			this.cabinet = new Cabinet(CabinetNumb);
			this.type = new Type(TypeName);
			this.schedule = new Schedule(TimeStart, TimeEnd);
		}
		public Doctor(int Id)
		{
			this.id = Id;
		}
		public Doctor() { }


		public static string DoctorString()
		{
			return "Select Doctor.id, Doctor.first_name, Doctor.surname, Doctor.middle_name, " +
					"Cabinet.cabinet_number, Type.name " +
					"From Doctor " +
					"LEFT OUTER JOIN " +
					"Cabinet ON Doctor.cabinet_id = Cabinet.id " +
					"LEFT OUTER JOIN " +
					"Type ON Cabinet.type_id = Type.id ";
		}
		public static DataTable AllMembersTable()
		{
			readerData = AllMembers(DoctorString());
			DataTable table = CreateTable(readerData);
			return table;
		}
		public static DataTable CreateTable(SQLiteDataReader readerData)
		{
			DataTable table = new DataTable();

			table.Columns.Add("id");
			table.Columns.Add("Ім'я");
			table.Columns.Add("Прізвище");
			table.Columns.Add("Номер кабінету");
			table.Columns.Add("Спеціальність");

			while (readerData.Read())
			{
				table.Rows.Add(readerData[0], readerData[1], readerData[2], readerData[4], readerData[5]);
			}

			return table;
		}

		public static void DeleteDoctor(int id)
		{
			EditMember($"DELETE FROM Schedule " +
					   $"WHERE doctor_id = {id}");

			EditMember($"DELETE FROM Doctor " +
					   $"WHERE id = {id}");
		}

		public static Doctor DetailedDoctor(int id)
		{
			Doctor doctor;
			readerData = AllMembers($"Select Doctor.id, Doctor.first_name, Doctor.surname, Doctor.middle_name, " +
									$"Cabinet.cabinet_number, Type.name, Schedule.time_start, Schedule.time_end " +
									$"From Doctor " +
									$"LEFT OUTER JOIN " +
									$"Cabinet ON Doctor.cabinet_id = Cabinet.id " +
									$"LEFT OUTER JOIN " +
									$"Type ON Cabinet.type_id = Type.id " +
									$"LEFT OUTER JOIN " +
									$"Schedule ON Schedule.doctor_id = Doctor.id " +
									$"WHERE Doctor.id = {id}");
			while (readerData.Read())
			{

				int doctor_id = Convert.ToInt32(readerData[0]);
				string name = Convert.ToString(readerData[1]), surname = Convert.ToString(readerData[2]),
					  middleName = Convert.ToString(readerData[3]);
				int cabinetNumber = Convert.ToInt32(readerData[4]);
				string typeName = Convert.ToString(readerData[5]), 
					timeStart = Convert.ToString(readerData[6]), timeEnd = Convert.ToString(readerData[7]);

				doctor = new Doctor(doctor_id, name, surname, middleName, cabinetNumber, typeName, timeStart, timeEnd);

				return doctor;
			}

			Doctor NEW = new Doctor();
			return NEW;
		}

		public static DataTable SearchDoctor(int index, string text)
		{
			text = text.Trim();
			DataTable table = new DataTable();
			switch (index)
			{
				case 0:
					{
						readerData = AllMembers(DoctorString() +
									$"WHERE Doctor.first_name " +
									$"LIKE '%{text}%'");
						table = CreateTable(readerData);

						break;
					}
				case 1:
					{
						readerData = AllMembers(DoctorString() +
									$"WHERE Doctor.surname " +
									$"LIKE '%{text}%'");
						table = CreateTable(readerData);

						break;
					}
				case 2:
					{
						readerData = AllMembers(DoctorString() +
												"WHERE Cabinet.cabinet_number " +
												$"LIKE '%{text}%'");
						table = CreateTable(readerData);

						break;
					}
				case 3:
					{
						readerData = AllMembers(DoctorString() +
												"WHERE Type.name " +
												$"LIKE '%{text}%'");
						table = CreateTable(readerData);

						break;
					}
			}
			return table;
		}

		public static void EditDoctor(Doctor doctor, int oldCab)
		{
			EditMember($"UPDATE Doctor SET first_name = \"{doctor.firstName}\", surname = \"{doctor.surname}\", " +
						$"middle_name = \"{doctor.middleName}\" " +
						$"WHERE id = {doctor.id}");

			EditMember($"UPDATE Schedule SET time_start = \"{doctor.schedule.TimeStart}\", time_end  = \"{doctor.schedule.TimeEnd}\"" +
						$"WHERE doctor_id = {doctor.id}");

			readerData = AllMembers($"SELECT id FROM Type " +
									$"WHERE name = \"{doctor.type}\"");
			int typeId = 1;
			while (readerData.Read())
			{
				typeId = Convert.ToInt32(readerData[0]);
			}
			
			EditMember($"UPDATE Cabinet SET type_id = \"{typeId}\", cabinet_number = \"{doctor.cabinet.cabinetNumber}\" " +
						$"WHERE cabinet_number = \"{oldCab}\"");
		}

		public static void InsertNewDoctor(Doctor doctor, int typeId)
		{

			EditMember($"INSERT INTO Cabinet (type_id, cabinet_number) " +
						$"VALUES (\"{typeId}\", \"{doctor.cabinet.cabinetNumber}\")");
			int doctorCabId = GetLastMemberId("SELECT max(id) FROM Cabinet");

			EditMember($"INSERT INTO Doctor(first_name, surname, middle_name, cabinet_id) " +
						$"VALUES (\"{doctor.FirstName}\", \"{doctor.Surname}\", \"{doctor.MiddleName}\", \"{doctorCabId}\")");
			int doctorId = GetLastMemberId("SELECT max(id) FROM Doctor");

			EditMember($"INSERT INTO Schedule(doctor_id, time_start, time_end)" +
						$"VALUES (\"{doctorId}\", \"{doctor.schedule.TimeStart}\", \"{doctor.schedule.TimeEnd}\")");
		}

	}
}
