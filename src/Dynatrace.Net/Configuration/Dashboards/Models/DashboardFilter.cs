using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Dashboards.Models
{
	public class DashboardFilter
	{
		public string Timeframe { get; set; }
		public EntityShortRepresentation ManagementZone { get; set; }
	}
}
