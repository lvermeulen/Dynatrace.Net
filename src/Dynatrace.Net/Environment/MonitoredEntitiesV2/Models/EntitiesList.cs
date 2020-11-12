using System.Collections.Generic;

namespace Dynatrace.Net.Environment.MonitoredEntitiesV2.Models
{
	public class EntitiesList
	{
		public int? TotalCount { get; set; }
		public int? PageSize { get; set; }
		public string NextPageKey { get; set; }
		public IEnumerable<Entity> Entities { get; set; }
	}
}
