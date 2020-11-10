using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TimeSeriesV1.Models
{
	public class TimeSeriesRegistrationMessage
	{
		public string DisplayName { get; set; }
		[JsonConverter(typeof(MetricDescriptorUnitsConverter))]
		public MetricDescriptorUnits? Unit { get; set; }
		public IEnumerable<string> Dimensions { get; set; }
		public IEnumerable<string> Types { get; set; }
	}
}
