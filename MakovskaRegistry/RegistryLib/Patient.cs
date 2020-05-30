using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace RegistryLib
{
    public class Patient : Model 
    {
		public int card_number { get; set; }
		public string first_name { get; set; }
		public string surname { get; set; }
		public string midlle_name { get; set; }
		public string birth_date { get; set; }
		public string phone_number { get; set; }
		public string address { get; set; }
		public Status status;
		public List<Privileged_group> groupList;


		public Patient() { }
		public Patient(int Card_number, string First_name, string Surname, string Midlle_name,
					   string Birth_date, string Phone_number, string Address, int Status_id, 
					   List<Privileged_group> GroupList)
		{
			this.card_number = Card_number;
			this.first_name = First_name;
			this.surname = Surname;
			this.midlle_name = Midlle_name;
			this.birth_date = Birth_date;
			this.phone_number = Phone_number;
			this.address = Address;
			status = new Status(Status_id);
			groupList = GroupList;
		}
		public Patient(int Card_number, string First_name, string Surname, string Midlle_name,
					   string Birth_date, string Phone_number, string Address, int Status_id)
		{
			this.card_number = Card_number;
			this.first_name = First_name;
			this.surname = Surname;
			this.midlle_name = Midlle_name;
			this.birth_date = Birth_date;
			this.phone_number = Phone_number;
			this.address = Address;
			status = new Status(Status_id);
		}
		public Patient(int Card_number, string First_name, string Surname, string Midlle_name,
					   string Birth_date, string Phone_number, string Address, 
					   List<Privileged_group> GroupList)
		{
			this.card_number = Card_number;
			this.first_name = First_name;
			this.surname = Surname;
			this.midlle_name = Midlle_name;
			this.birth_date = Birth_date;
			this.phone_number = Phone_number;
			this.address = Address;
			groupList = GroupList;
		}
		public Patient(int Card_number, string First_name, string Surname, string Midlle_name,
					   string Birth_date, string Phone_number, string Address)
		{
			this.card_number = Card_number;
			this.first_name = First_name;
			this.surname = Surname;
			this.midlle_name = Midlle_name;
			this.birth_date = Birth_date;
			this.phone_number = Phone_number;
			this.address = Address;
		}


		public static DataTable CreateTable(SQLiteDataReader readerData)
		{
			DataTable table = new DataTable();

			table.Columns.Add("№ картки");
			table.Columns.Add("Ім'я");
			table.Columns.Add("Прізвище");
			table.Columns.Add("Дата народження");

			while (readerData.Read())
			{
				table.Rows.Add(readerData[0], readerData[1], readerData[2], readerData[4]);
			}

			return table;
		}

		public static DataTable AllMembersTable()
		{
			readerData = AllMembers("Select * From Patient");
			DataTable table = CreateTable(readerData);
			return table;
		}
		
		public void InsertNewPatient(Patient patient)
		{
			SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Patient(first_name, surname, midlle_name, birth_date, phone_number, address) " +
														"VALUES(?,?,?,?,?,?)");
			insertSQL.Parameters.Add(patient.first_name);
			insertSQL.Parameters.Add(patient.surname);
			insertSQL.Parameters.Add(patient.midlle_name);
			insertSQL.Parameters.Add(patient.birth_date);
			insertSQL.Parameters.Add(patient.phone_number);
			insertSQL.Parameters.Add(patient.address);
	
			insertSQL.ExecuteNonQuery();
		
		}
		public static void DeletePatient(int card_number)
		{
			EditMember($"DELETE FROM Patient " +
					   $"WHERE card_number = {card_number};");
		}

		public static Patient ConvertPatient(int card_number)
		{
			Patient patient;
			readerData = AllMembers($"SELECT * From Patient WHERE card_number = {card_number}");
			while (readerData.Read())
			{
				patient = new Patient(Convert.ToInt32(readerData[0]), Convert.ToString(readerData[1]),
									  Convert.ToString(readerData[2]), Convert.ToString(readerData[3]),
									  Convert.ToString(readerData[4]), Convert.ToString(readerData[5]),
									  Convert.ToString(readerData[6]), Convert.ToInt32(readerData[7]));
				return patient;
			}
			Patient NEW = new Patient();
			return NEW;
		}
		public static void EditPatient(Patient patient)
		{
			EditMember($"UPDATE Patient SET first_name = \"{patient.first_name}\", surname = \"{patient.surname}\", " +
							$"midlle_name = \"{patient.midlle_name}\", birth_date = \"{patient.birth_date}\", " +
							$"phone_number = \"{patient.phone_number}\", address = \"{patient.address}\", " +
							$"status_id = {patient.status.id} " +
						$"WHERE card_number = {patient.card_number}"); 
		}

		public static DataTable SearchPatient(int index, string text)
		{
			text = text.Trim();
			DataTable table = new DataTable();
			switch (index)
			{
				case 0: 
					{
						readerData = AllMembers("Select * From Patient " +
							  $"WHERE card_number = \"{text}\"");
						table = CreateTable(readerData);

						break;
					}
				case 1: 
					{
						readerData = AllMembers("Select * From Patient " +
							  $"WHERE first_name = \"{text}\"");
						table = CreateTable(readerData);

						break;
					}
				case 2: 
					{
						readerData = AllMembers("Select * From Patient " +
								$"WHERE surname = \"{text}\"");
						table = CreateTable(readerData);

						break;
					}
				case 3: 
					{
						readerData = AllMembers("Select * From Patient " +
									$"WHERE birth_date = \"{text}\"");
						table = CreateTable(readerData);

						break;
					}
			}
			return table;
		}
	}
}
