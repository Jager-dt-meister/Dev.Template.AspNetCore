using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Common.Enums;
using Common.Search;
using Dal.DbModels;

namespace Dal
{
	public class PurchasesDal : BaseDal<DefaultDbContext, Purchase, Entities.Purchase, int, PurchasesSearchParams, object>
	{
		protected override bool RequiresUpdatesAfterObjectSaving => false;

		public PurchasesDal()
		{
		}

		protected internal PurchasesDal(DefaultDbContext context) : base(context)
		{
		}

		protected override Task UpdateBeforeSavingAsync(DefaultDbContext context, Entities.Purchase entity, Purchase dbObject, bool exists)
		{
			dbObject.ClientId = entity.ClientId;
			dbObject.Date = entity.Date;
			return Task.CompletedTask;
		}
	
		protected override Task<IQueryable<Purchase>> BuildDbQueryAsync(DefaultDbContext context, IQueryable<Purchase> dbObjects, PurchasesSearchParams searchParams)
		{
			return Task.FromResult(dbObjects);
		}

		protected override async Task<IList<Entities.Purchase>> BuildEntitiesListAsync(DefaultDbContext context, IQueryable<Purchase> dbObjects, object convertParams, bool isFull)
		{
			return (await dbObjects.ToListAsync()).Select(ConvertDbObjectToEntity).ToList();
		}

		protected override Expression<Func<Purchase, int>> GetIdByDbObjectExpression()
		{
			return item => item.Id;
		}

		protected override Expression<Func<Entities.Purchase, int>> GetIdByEntityExpression()
		{
			return item => item.Id;
		}

		internal static Entities.Purchase ConvertDbObjectToEntity(Purchase dbObject)
		{
			return dbObject == null ? null : new Entities.Purchase(dbObject.Id, dbObject.ClientId, dbObject.Date);
		}
	}
}
