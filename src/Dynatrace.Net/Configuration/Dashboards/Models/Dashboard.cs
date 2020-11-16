using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Dashboards.Models
{
	public class Dashboard
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public DashboardMetadata DashboardMetadata { get; set; }
		public IEnumerable<Tile> Tiles { get; set; }
	}
}
