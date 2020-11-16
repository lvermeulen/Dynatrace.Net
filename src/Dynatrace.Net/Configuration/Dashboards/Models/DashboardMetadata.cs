using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Dashboards.Models
{
	public class DashboardMetadata
	{
		public string Name { get; set; }
		public bool? Shared { get; set; }
		public string Owner { get; set; }
		public SharingInfo SharingDetails { get; set; }
		public DashboardFilter DashboardFilter { get; set; }
		public IEnumerable<string> Tags { get; set; }
		public bool? Preset { get; set; }
		public IEnumerable<string> ValidFilterKeys { get; set; }
	}
}
