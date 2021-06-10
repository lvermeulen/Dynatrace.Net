using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogJobStatusResult
	{
		[JsonConverter(typeof(LogAnalysisStatusesConverter))]
		public LogAnalysisStatuses LogAnalysisStatus { get; set; }
		public long? StatusChangeTimestamp { get; set; }
		[JsonConverter(typeof(LogHandlingErrorsConverter))]
		public LogHandlingErrors LogHandlingError { get; set; }
		public int? RecordsTotal { get; set; }
		public IEnumerable<string> SortableFields { get; set; }
		public IEnumerable<string> FilterableFields { get; set; }
	}
}
