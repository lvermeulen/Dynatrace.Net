using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class SyntheticMetricFilter
	{
		[JsonConverter(typeof(SyntheticMetricActionTypesConverter))]
		public SyntheticMetricActionTypes? ActionType { get; set; }
		public bool? HasError { get; set; }
		public int? ErrorCode { get; set; }
		public string Event { get; set; }
		public string Location { get; set; }
	}
}
