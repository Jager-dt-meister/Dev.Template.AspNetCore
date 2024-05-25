using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Purchase = Entities.Purchase;

namespace BL
{
	public class PurchasesBL
	{
		public async Task<int> AddOrUpdateAsync(Purchase entity)
		{
			entity.Id = await new PurchasesDal().AddOrUpdateAsync(entity);
			return entity.Id;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new PurchasesDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(PurchasesSearchParams searchParams)
		{
			return new PurchasesDal().ExistsAsync(searchParams);
		}

		public Task<Purchase> GetAsync(int id)
		{
			return new PurchasesDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new PurchasesDal().DeleteAsync(id);
		}

		public Task<SearchResult<Purchase>> GetAsync(PurchasesSearchParams searchParams)
		{
			return new PurchasesDal().GetAsync(searchParams);
		}
	}
}

