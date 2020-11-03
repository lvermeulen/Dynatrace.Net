using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class MetricEventAlertingScope
	{
		[JsonConverter(typeof(MetricEventAlertingScopeFilterTypesConverter))]
		public MetricEventAlertingScopeFilterTypes? FilterType { get; set; }
	}
}
