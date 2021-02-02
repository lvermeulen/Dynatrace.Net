using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class MonitorsObject
	{
		public IEnumerable<MonitorCollectionElement> Monitors { get; set; }
	}
}
