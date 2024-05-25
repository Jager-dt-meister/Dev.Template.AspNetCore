using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Client
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime? Birth { get; set; }
		public DateTime? RegDate { get; set; }

		public Client(int id, string name, DateTime? birth, DateTime? regDate)
		{
			Id = id;
			Name = name;
			Birth = birth;
			RegDate = regDate;
		}
	}
}
