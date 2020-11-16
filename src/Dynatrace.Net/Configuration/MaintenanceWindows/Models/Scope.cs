using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.MaintenanceWindows.Models
{
	public class Scope
	{
		public IEnumerable<string> Entities { get; set; }
		public IEnumerable<MonitoredEntityFilter> Matches { get; set; }
	}
}
