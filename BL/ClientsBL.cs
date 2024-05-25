using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Common.Enums;
using Common.Search;
using Client = Entities.Client;

namespace BL
{
	public class ClientsBL
	{
		public async Task<int> AddOrUpdateAsync(Client entity)
		{
			entity.Id = await new ClientsDal().AddOrUpdateAsync(entity);
			return entity.Id;
		}

		public Task<bool> ExistsAsync(int id)
		{
			return new ClientsDal().ExistsAsync(id);
		}

		public Task<bool> ExistsAsync(ClientsSearchParams searchParams)
		{
			return new ClientsDal().ExistsAsync(searchParams);
		}

		public Task<Client> GetAsync(int id)
		{
			return new ClientsDal().GetAsync(id);
		}

		public Task<bool> DeleteAsync(int id)
		{
			return new ClientsDal().DeleteAsync(id);
		}

		public Task<SearchResult<Client>> GetAsync(ClientsSearchParams searchParams)
		{
			return new ClientsDal().GetAsync(searchParams);
		}
	}
}

