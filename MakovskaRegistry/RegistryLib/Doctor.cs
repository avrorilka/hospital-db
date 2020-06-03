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

		public static DataTable AllMembersTable()
		{
			readerData = AllMembers("Select * From Doctor");
			DataTable table = CreateTable(readerData);
			return table;
		}
		public static DataTable CreateTable(SQLiteDataReader readerData)
		{
			DataTable table = new DataTable();

			table.Columns.Add("Ім'я");
			table.Columns.Add("Прізвище");
			table.Columns.Add("По Батькові");
			table.Columns.Add("Номер кабінету");

			while (readerData.Read())
			{
				table.Rows.Add(readerData[1], readerData[2], readerData[3], readerData[4]);
			}

			return table;
		}
	}
}
