using System.Collections.Generic;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class EntityBaselineData
	{
		public string EntityId { get; set; }
		public string DisplayName { get; set; }
		public decimal? ErrorRate { get; set; }
		public bool? HasLoadBaseline { get; set; }
		public decimal? MicrosMedian { get; set; }
		public decimal? Micros90ThPercentile { get; set; }
		public IEnumerable<EntityBaselineData> ChildBaselines { get; set; }
	}
}
