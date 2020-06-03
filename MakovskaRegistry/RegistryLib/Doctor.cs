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

		public Doctor(int Id, string First_name, string Surname, string Middle_name, int Cabinet_id)
		{
			this.id = Id;
			this.FirstName = First_name;
			this.Surname = Surname;
			this.MiddleName = Middle_name;
			this.cabinet = new Cabinet(Cabinet_id);
		}
		public Doctor(int Id)
		{
			this.id = Id;
		}


		public static string DoctorString()
		{
			return "Select Doctor.id, Doctor.first_name, Doctor.surname, Doctor.middle_name, " +
					"Cabinet.cabinet_number, Type.name " +
					"From Doctor " +
					"LEFT OUTER JOIN " +
					"Cabinet ON Doctor.cabinet_id = Cabinet.type_id " +
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

			table.Columns.Add("Ім'я");
			table.Columns.Add("Прізвище");
			table.Columns.Add("Номер кабінету");
			table.Columns.Add("Спеціальність");

			while (readerData.Read())
			{
				table.Rows.Add(readerData[1], readerData[2], readerData[4], readerData[5]);
			}

			return table;
		}

		public static void DeleteDoctor(int id)
		{
			EditMember($"DELETE FROM Doctor " +
					   $"WHERE id = {id};");
		}

		public static void DetailedDoctor(int id)
		{
			Patient patient;
			readerData = AllMembers($"Select Doctor.id, Doctor.first_name, Doctor.surname, Doctor.middle_name, " +
									$"Cabinet.cabinet_number, Type.name, Schedule.time_start, Schedule.time_end " +
									$"From Doctor " +
									$"LEFT OUTER JOIN " +
									$"Cabinet ON Doctor.cabinet_id = Cabinet.type_id " +
									$"LEFT OUTER JOIN " +
									$"Type ON Cabinet.type_id = Type.id " +
									$"LEFT OUTER JOIN " +
									$"Schedule ON Schedule.doctor_id = Doctor.id " +
									$"WHERE Doctor.id = {id}");
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



	}
}
