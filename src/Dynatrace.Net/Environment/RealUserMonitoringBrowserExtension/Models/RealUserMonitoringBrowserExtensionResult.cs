using System.Collections.Generic;

namespace Dynatrace.Net.Environment.RealUserMonitoringBrowserExtension.Models
{
	public class RealUserMonitoringBrowserExtensionResult
	{
		public int? Revision { get; set; }
		public IEnumerable<BrowserExtension> Applications { get; set; }
	}
}
