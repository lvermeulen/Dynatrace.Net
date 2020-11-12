using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class CalculatedMobileMetricDimension
	{
		public int? TopX { get; set; }
		[JsonConverter(typeof(CalculatedMobileMetricDimensionTypesConverter))]
		public CalculatedMobileMetricDimensionTypes? Dimension { get; set; }
	}
}
