using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Dashboards.Models
{
	public class TileFilter
	{
		public string Timeframe { get; set; }
		public EntityShortRepresentation ManagementZone { get; set; }
	}
}
