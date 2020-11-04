using System.Collections.Generic;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogListForCustomDeviceResult
	{
		public IEnumerable<LogForCustomDevice> Logs { get; set; }
	}
}
