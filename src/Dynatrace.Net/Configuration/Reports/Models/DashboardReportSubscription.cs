using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace Dynatrace.Net.Configuration.Reports.Models
{
	public class DashboardReportSubscription
	{
		public IEnumerable<string> WEEK { get; set; }
		public IEnumerable<string> MONTH { get; set; }
	}
}
