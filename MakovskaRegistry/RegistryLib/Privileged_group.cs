using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Text.RegularExpressions;

namespace RegistryLib
{
	public class Privileged_group
	{
		public int id { get; set; }
		public string name { get; set; }
		public double discountPercent { get; set; }
		public static List<Privileged_group> patientLists = new List<Privileged_group>();

		public Privileged_group(int Id, string Name, double Discount_percent)
		{
			this.id = Id;
			this.name = Name;
			this.discountPercent = Discount_percent;
		}
		public Privileged_group(int Id, double Discount_percent)
		{
			this.id = Id;
			this.discountPercent = Discount_percent;
		}
		public Privileged_group()
		{

		}

		public static Privileged_group NewGroup(int index)
		{
			Privileged_group group;
			Model.readerData = Model.AllMembers("SELECT * FROM Privileged_group " +
												$"WHERE id = {index}");
			while (Model.readerData.Read())
			{
				group = new Privileged_group(Convert.ToInt32(Model.readerData[0]),
											 Convert.ToString(Model.readerData[1]),
											 Convert.ToDouble(Model.readerData[2]));
				return group;
			}
			Privileged_group newGroup = new Privileged_group();
			return newGroup;

		}

		public static void AddGroup(int card_numb, int group_id) 
		{
			int patient_id = card_numb;
			Model.EditMember("INSERT INTO Patient_Group(patient_id, group_id) " +
							$"VALUES({patient_id},{group_id})");

		}
		public static void RemoveGroup(int card_numb, int group_id)
		{
			int patient_id = card_numb;
			Model.EditMember($"DELETE FROM Patient_Group " +
							$"WHERE patient_id = {patient_id} AND group_id = {group_id}");
		}

		public static List<string> FillGroupBox()
		{
			Model.readerData = Model.AllMembers("SELECT name FROM Privileged_group " +
												"ORDER BY id");
			List<string> groupList = new List<string>();
			groupList.Add("");
			while (Model.readerData.Read())
			{
				groupList.Add(Convert.ToString(Model.readerData[0]));
			}
			Model.Closer(Model.readerData);

			return groupList;
		}
	}
}
