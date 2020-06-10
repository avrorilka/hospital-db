using System;
using System.Collections.Generic;

namespace RegistryLib
{
	public class Privileged_group : Model
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

		public static List<Privileged_group> DetailedPatient(int card_number)
		{
			readerData = AllMembers($"SELECT Patient.card_number, Patient.first_name, Patient.surname, Patient.midlle_name, " +
											$"Patient.birth_date, Patient.phone_number, Patient.address, Patient.status_id, " +
											$"Privileged_group.id, Privileged_group.name, Privileged_group.discount_percent " +
									$"FROM Patient " +
									$"LEFT OUTER JOIN " +
										$"Patient_Group ON Patient.card_number = Patient_Group.patient_id " +
									$"LEFT OUTER JOIN " +
										$"Privileged_group ON Patient_Group.group_id = Privileged_group.id " +
									$"WHERE card_number = {card_number}");

			patientLists = new List<Privileged_group>();

			while (readerData.Read())
			{
				Privileged_group group = new Privileged_group(Convert.ToInt32(readerData[8]), Convert.ToString(readerData[9]), 
																Convert.ToDouble(readerData[10]));
				patientLists.Add(group);
			}
			return patientLists;
		}
	}
}
