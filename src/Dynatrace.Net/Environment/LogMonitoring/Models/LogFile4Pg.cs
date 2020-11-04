using System.Collections.Generic;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogFile4Pg
	{
		public string Path { get; set; }
		public int? Size { get; set; }
		public IEnumerable<Host4Pg> Hosts { get; set; }
	}
}
