using System.Collections.Generic;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogJobRecordsResult
	{
		public IEnumerable<LogRecord> Records { get; set; }
		public string ScrollToken { get; set; }
	}
}
