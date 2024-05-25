using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Purchase
	{
		public int Id { get; set; }
		public int? ClientId { get; set; }
		public DateTime? Date { get; set; }

		public Purchase(int id, int? clientId, DateTime? date)
		{
			Id = id;
			ClientId = clientId;
			Date = date;
		}
	}
}
