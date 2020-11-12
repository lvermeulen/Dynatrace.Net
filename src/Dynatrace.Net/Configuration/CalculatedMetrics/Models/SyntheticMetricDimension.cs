using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class SyntheticMetricDimension
	{
		public int? TopX { get; set; }
		[JsonConverter(typeof(SyntheticMetricDimensionsConverter))]
		public SyntheticMetricDimensions? Dimension { get; set; }
	}
}
