using System.Collections.Generic;

namespace Dynatrace.Net.Environment.MonitoredEntitiesV2.Models
{
	public class EntityTypeList
	{
		public int? TotalCount { get; set; }
		public int? PageSize { get; set; }
		public string NextPageKey { get; set; }
		public IEnumerable<EntityType> Types { get; set; }
	}
}
