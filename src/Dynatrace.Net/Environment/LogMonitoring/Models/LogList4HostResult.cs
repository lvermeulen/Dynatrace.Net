using System.Collections.Generic;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogList4HostResult
	{
		public bool? ContentAccess { get; set; }
		public IEnumerable<Log4Host> Logs { get; set; }
	}
}
