using System.Collections.Generic;

namespace Dynatrace.Net.Environment.ServiceLevelObjectives.Models
{
	public class SloList
	{
		public object NextPageKeys { get; set; }
		// ReSharper disable once InconsistentNaming
		public IEnumerable<Slo> SLOs { get; set; }
		public string NextPageKey { get; set; }
		public int? PageSize { get; set; }
		public int? TotalCount { get; set; }
	}
}
