using System;
using System.Collections.Generic;
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
		public int status_id { get; set; }

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
			this.status_id = Status_id;
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
		public Patient(int Card_number, string First_name, string Surname,
					   string Birth_date, string Phone_number, string Address, int Status_id)
		{
			this.card_number = Card_number;
			this.first_name = First_name;
			this.surname = Surname;
			this.birth_date = Birth_date;
			this.phone_number = Phone_number;
			this.address = Address;
			this.status_id = Status_id;
		}
		public Patient(int Card_number, string First_name, string Surname,
					   string Birth_date, string Phone_number, string Address)
		{
			this.card_number = Card_number;
			this.first_name = First_name;
			this.surname = Surname;
			this.birth_date = Birth_date;
			this.phone_number = Phone_number;
			this.address = Address;
		}
	}
}
