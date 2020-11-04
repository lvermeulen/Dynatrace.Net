using System.Collections.Generic;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogJobRecordsTopValuesRestResult
	{
		public IEnumerable<ParsingFieldTopValue> ParsingFieldTopValues { get; set; }
		public int? ValuesCount { get; set; }
	}
}
