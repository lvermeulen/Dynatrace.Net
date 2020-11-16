using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Dashboards.Models
{
	public class DashboardList
	{
		public IEnumerable<DashboardStub> Dashboards { get; set; }
	}
}
