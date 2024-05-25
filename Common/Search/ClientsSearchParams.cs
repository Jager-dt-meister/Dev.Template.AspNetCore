using System;
using System.Collections.Generic;
using Common.Enums;

namespace Common.Search
{
	public class ClientsSearchParams : BaseSearchParams
	{
		public ClientsSearchParams(int startIndex = 0, int? objectsCount = null) : base(startIndex, objectsCount)
		{
		}
	}
}
