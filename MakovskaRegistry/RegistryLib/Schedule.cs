using System;
using System.Text.RegularExpressions;

namespace RegistryLib
{
	public class Schedule : Model
	{
		string pattern;

		public int id { get; set; }
		public int doctor_id { get; set; }

		private string timeStart;
		public string TimeStart 
		{
			get => timeStart;
			set
			{
				pattern = @"([0-1]*[0-9]|2[0-3]):([0-5][0-9])";
				if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase))
					timeStart = value;
				else
					throw new ArgumentException();
			}
		}

		private string timeEnd;
		public string TimeEnd
		{
			get => timeEnd;
			set
			{
				pattern = @"([0-1]*[0-9]|2[0-3]):([0-5][0-9])";
				if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase))
					timeEnd = value;
				else
					throw new ArgumentException();
			}
		}

		public Schedule(int Id, int doctor_id, string time_start, string time_end)
		{
			this.id = Id;
			this.doctor_id = doctor_id;
			this.TimeStart = time_start;
			this.TimeEnd = time_end;
		}
		public Schedule(string time_start, string time_end)
		{
			this.TimeStart = time_start;
			this.TimeEnd = time_end;
		}

	}
}
