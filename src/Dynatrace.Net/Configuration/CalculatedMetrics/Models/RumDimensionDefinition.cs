using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class RumDimensionDefinition
	{
		public int? TopX { get; set; }
		[JsonConverter(typeof(RumDimensionsConverter))]
		public RumDimensions? Dimension { get; set; }
		public string PropertyKey { get; set; }
	}
}
