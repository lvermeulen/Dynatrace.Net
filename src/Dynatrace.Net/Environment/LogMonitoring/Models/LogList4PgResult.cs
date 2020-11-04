using System.Collections.Generic;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogList4PgResult
	{
		public IEnumerable<LogFile4Pg> Logs { get; set; }
	}
}
