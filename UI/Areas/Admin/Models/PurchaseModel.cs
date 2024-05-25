using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class PurchaseModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "Id")]
		public int Id { get; set; }

		[Display(Name = "ClientId")]
		public int? ClientId { get; set; }

		[Display(Name = "Date")]
		public DateTime? Date { get; set; }

		public static PurchaseModel FromEntity(Purchase obj)
		{
			return obj == null ? null : new PurchaseModel
			{
				Id = obj.Id,
				ClientId = obj.ClientId,
				Date = obj.Date,
			};
		}

		public static Purchase ToEntity(PurchaseModel obj)
		{
			return obj == null ? null : new Purchase(obj.Id, obj.ClientId, obj.Date);
		}

		public static List<PurchaseModel> FromEntitiesList(IEnumerable<Purchase> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Purchase> ToEntitiesList(IEnumerable<PurchaseModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
